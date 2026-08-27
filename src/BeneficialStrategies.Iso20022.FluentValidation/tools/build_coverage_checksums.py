#!/usr/bin/env python3
"""
Builds/refreshes coverage-checksums.json — a manifest mapping every model type this project
has a FluentValidation validator for to its current ISO 20022 spec content checksum.

Why: the MCP snapshot server added a per-artifact content checksum (2026-08-26 deployment).
Any change to a message/component/choice/codeset's own spec content changes its checksum.
Diffing this manifest against a freshly-regenerated one after a snapshot sync tells you exactly
which of our *validators* — not just which model types — need review.

Coverage policy (validators only ever accumulate — see this package's own CLAUDE.md): a type's
lifecycle in the ISO registry has three states, and this manifest's "status" field distinguishes
all three:
  1. Registered (or any non-Obsolete status) — normal, "status": null in the manifest.
  2. "Obsolete" but still present in get_spec_snapshot output — "status": "Obsolete". The
     underlying model type AND its validator both get [Obsolete(...)] mirrored onto them (matching
     the ~40+ existing examples, e.g. Components/Quantity3.cs) — both files stay, both compile.
  3. Absent from get_spec_snapshot entirely — "status": "NOT_FOUND_IN_CURRENT_SNAPSHOT". This IS
     the deletion trigger, for both the model type and its validator, in the same commit — subject
     to the same reference-safety check snapshot-sync-components/-choices/-messages already do
     (grep for external references; a referencing type that's itself also gone must be removed
     first). The first real hit this tool found (2026-08-26): InvestmentFundTransactionsByFund3 —
     Obsolete since 2018, fully purged from the snapshot by the 2026-06-26 sync, but blocked from
     immediate deletion by two live references (StatementOfInvestmentFundTransactions3,
     StatementOfInvestmentFundTransactionsV03) that are themselves also gone — a dependency-chain
     removal, not a single-file one.

Two-step process, since checksums can only come from a live MCP call (this script has no network
access) and the Common model files can only be read from a checked-out repo (the MCP session
can't see them):
  1. In a Claude session with MCP access: call get_spec_snapshot for every artifactType per the
     existing snapshot-sync-plan skill's own convention (append each page to one
     snapshot-sync/{date}/spec-snapshot.tsv). This is the exact same file that skill family
     already produces — no new download step is introduced.
  2. Run this script against that file:
       python3 build_coverage_checksums.py snapshot-sync/{date}/spec-snapshot.tsv
     It scans the Common project for every model type's own [IsoId("...")] attribute, joins that
     against every validator's AbstractValidator<T>/ExternalCodesetAbstractValidator<T>
     declaration, looks up each resulting id's checksum in the spec-snapshot TSV, and writes
     coverage-checksums.json (git-diffable — see below).

Usage:
    python3 build_coverage_checksums.py <spec-snapshot.tsv> [<more.tsv> ...] [--out PATH] [--snapshot-date YYYY-MM-DD]

    --snapshot-date: the MCP snapshot date this data came from (from get_repository_statistics —
    not embedded in the TSV itself), recorded in the manifest's _meta for future readers. Optional
    but strongly recommended.

    Accepts one or more TSV files/globs — either the single concatenated spec-snapshot.tsv the
    snapshot-sync skill produces, or several separate get_spec_snapshot dumps (e.g. one per page)
    if that's more convenient for the calling session. Content is identical either way.

After regenerating, `git diff coverage-checksums.json` IS the validator-maintenance diff:
  - A type's "checksum" value changed          -> spec content changed -> review/EDIT that validator.
  - A new top-level key appeared                -> a validator was added since the last manifest
                                                    (not itself actionable here — just bookkeeping).
  - "status" newly became "Obsolete"            -> mirror [Obsolete(...)] onto the model type (if
                                                    not already) and the validator. Neither is deleted.
  - "status" newly became "NOT_FOUND_IN_CURRENT_SNAPSHOT" -> deletion candidate for both the model
                                                    type and its validator (see policy above).
This does NOT detect brand-new spec messages/components we have no validator for yet (that's a
"what should we add coverage for" question, not a "what do we already have that might be stale"
question) — that stays a job for snapshot-sync-plan's own added/removed diff.
"""
import re
import os
import sys
import csv
import json
import glob

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
FV_ROOT = os.path.abspath(os.path.join(SCRIPT_DIR, ".."))
COMMON_ROOT = os.path.abspath(os.path.join(FV_ROOT, "..", "BeneficialStrategies.Iso20022.Common"))
DEFAULT_OUT = os.path.join(FV_ROOT, "coverage-checksums.json")

ISOID_RE = re.compile(r'\[IsoId\("([^"]+)"\)\]')
VALIDATOR_DECL_RE = re.compile(
    r'public\s+(?:sealed\s+)?class\s+(\w+)\s*:\s*(?:AbstractValidator|ExternalCodesetAbstractValidator)<([\w\.]+)>'
)

# Record types the MCP snapshot carries a checksum for: (statusColIdx, checksumColIdx), 0-based.
# Confirmed empirically 2026-08-26: MSGDEF has an extra businessArea column MSGCOMP/CHOICE/CODESET
# don't, shifting both columns one later.
CHECKSUM_RECORD_TYPES = {
    "MSGDEF": (4, 5),
    "MSGCOMP": (3, 4),
    "CHOICE": (3, 4),
    "CODESET": (3, 4),
    "SIMPLETYPE": (3, 4),
    "AMOUNT": (3, 4),
    "EXTSCHEMA": (3, 4),
    "USERDEF": (3, 4),
}


def build_type_to_isoid():
    """Scan Common for every model type's own IsoId, keyed by simple type name.

    First IsoId occurrence in a file = that type's own id (true for Components/MessageDefinitions/
    single-type files, and for Codesets since the enum-level attribute always precedes every
    per-member one). Choice VARIANT files (Choices/{ChoiceName}/{Variant}.cs) are deliberately
    excluded — only Choices/*.cs itself (the {ChoiceName}_.cs base-type files) is scanned, since no
    validator ever targets a bare variant type directly (only the base type, via
    SetInheritanceValidator), and variant filenames collide constantly (Code.cs, Proprietary.cs,
    Value.cs, ...) both across different choices and against genuine top-level Components.
    """
    type_to_isoid = {}
    dupes = []
    for scan_dir in ["Components", "Choices", "Codesets", "MessageDefinitions", "Amounts", "ExternalSchema"]:
        root = os.path.join(COMMON_ROOT, scan_dir)
        if not os.path.isdir(root):
            continue
        for dirpath, _, filenames in os.walk(root):
            if scan_dir == "Choices" and os.path.abspath(dirpath) != os.path.abspath(root):
                continue
            for fn in filenames:
                if not fn.endswith(".cs"):
                    continue
                path = os.path.join(dirpath, fn)
                with open(path, "r", encoding="utf-8") as f:
                    content = f.read()
                m = ISOID_RE.search(content)
                if not m:
                    continue
                type_name = fn[:-3]
                isoid = m.group(1)
                if type_name in type_to_isoid and type_to_isoid[type_name] != isoid:
                    dupes.append((type_name, type_to_isoid[type_name], isoid, path))
                type_to_isoid[type_name] = isoid
    return type_to_isoid, dupes


def scan_validators():
    """Every validator file's (relpath, validatorClassName, validatedTypeSimpleName)."""
    results = []
    for dirpath, _, filenames in os.walk(os.path.join(FV_ROOT, "Validators")):
        for fn in filenames:
            if not fn.endswith(".cs"):
                continue
            path = os.path.join(dirpath, fn)
            relpath = os.path.relpath(path, FV_ROOT)
            with open(path, "r", encoding="utf-8") as f:
                content = f.read()
            m = VALIDATOR_DECL_RE.search(content)
            if not m:
                results.append((relpath, None, None))
                continue
            validator_name, validated_type = m.group(1), m.group(2)
            results.append((relpath, validator_name, validated_type.split(".")[-1]))
    return results


def load_checksums(tsv_paths):
    """id -> (recordType, registrationStatus, checksum), from one or more spec-snapshot TSV files."""
    id_to_checksum = {}
    for path in tsv_paths:
        with open(path, "r", encoding="utf-8") as f:
            reader = csv.reader(f, delimiter="\t")
            for row in reader:
                if not row or not row[0] or row[0].startswith("#"):
                    continue
                cols = CHECKSUM_RECORD_TYPES.get(row[0])
                if cols is None:
                    continue
                status_idx, checksum_idx = cols
                if len(row) <= checksum_idx:
                    continue
                id_to_checksum[row[2]] = (row[0], row[status_idx], row[checksum_idx])
    return id_to_checksum


def main():
    args = sys.argv[1:]
    out_path = DEFAULT_OUT
    if "--out" in args:
        i = args.index("--out")
        out_path = args[i + 1]
        del args[i : i + 2]
    snapshot_date = None
    if "--snapshot-date" in args:
        i = args.index("--snapshot-date")
        snapshot_date = args[i + 1]
        del args[i : i + 2]

    tsv_paths = []
    for pattern in args:
        matched = glob.glob(pattern)
        tsv_paths.extend(matched if matched else [pattern])
    if not tsv_paths:
        print(__doc__)
        sys.exit(1)

    type_to_isoid, dupes = build_type_to_isoid()
    print(f"Model types with an IsoId found: {len(type_to_isoid)}", file=sys.stderr)
    if dupes:
        print(
            f"NOTE: {len(dupes)} type-name collisions (harmless unless one of them is a "
            f"validated type below — check the 'Unresolved' report if so):",
            file=sys.stderr,
        )
        for d in dupes:
            print(f"  {d[0]}: {d[1]} -> {d[2]} (last seen at {d[3]})", file=sys.stderr)

    validators = scan_validators()
    print(f"Validator files scanned: {len(validators)}", file=sys.stderr)

    id_to_checksum = load_checksums(tsv_paths)
    print(f"Checksum records loaded from {len(tsv_paths)} file(s): {len(id_to_checksum)}", file=sys.stderr)

    manifest = {}
    unresolved_type = []
    for relpath, validator_name, validated_type in validators:
        if validated_type is None:
            unresolved_type.append((relpath, "validator class declaration did not parse"))
            continue
        isoid = type_to_isoid.get(validated_type)
        if isoid is None:
            unresolved_type.append((relpath, f"validated type '{validated_type}' has no IsoId in Common"))
            continue

        hit = id_to_checksum.get(isoid)
        if hit is None:
            manifest[validated_type] = {
                "isoId": isoid,
                "checksum": None,
                "recordType": None,
                "status": "NOT_FOUND_IN_CURRENT_SNAPSHOT",
                "validatorFile": relpath,
            }
        else:
            record_type, registration_status, checksum = hit
            manifest[validated_type] = {
                "isoId": isoid,
                "checksum": checksum,
                "recordType": record_type,
                # null for the common case (Registered/whatever non-Obsolete status the spec
                # uses) so an ordinary entry's JSON stays uncluttered; "Obsolete" is the one
                # value worth surfacing directly here rather than needing a separate lookup.
                "status": registration_status if registration_status == "Obsolete" else None,
                "validatorFile": relpath,
            }

    if unresolved_type:
        print(f"UNRESOLVED (could not determine an isoId at all — investigate): {len(unresolved_type)}", file=sys.stderr)
        for u in unresolved_type:
            print(f"  {u}", file=sys.stderr)

    not_found = sum(1 for e in manifest.values() if e.get("status") == "NOT_FOUND_IN_CURRENT_SNAPSHOT")
    obsolete_but_present = sum(1 for e in manifest.values() if e.get("status") == "Obsolete")
    print(
        f"Resolved with a current checksum: {len(manifest) - not_found} "
        f"({obsolete_but_present} of those are Obsolete-but-present)",
        file=sys.stderr,
    )
    print(f"ABSENT from the current snapshot entirely (deletion candidates): {not_found}", file=sys.stderr)
    for name, e in manifest.items():
        if e.get("status") == "NOT_FOUND_IN_CURRENT_SNAPSHOT":
            print(f"  {name} ({e['isoId']}) -> {e['validatorFile']}", file=sys.stderr)

    payload = {
        "_meta": {
            "snapshotDate": snapshot_date,
            "generatedFrom": os.path.basename(tsv_paths[0]) if len(tsv_paths) == 1 else f"{len(tsv_paths)} snapshot files",
            "entryCount": len(manifest),
        },
        "entries": manifest,
    }
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(payload, f, indent=2, sort_keys=True)
        f.write("\n")
    print(f"Wrote {out_path}", file=sys.stderr)


if __name__ == "__main__":
    main()
