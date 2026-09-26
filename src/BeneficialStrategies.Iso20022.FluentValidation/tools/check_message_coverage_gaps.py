#!/usr/bin/env python3
"""
Detects a class of coverage gap that build_coverage_checksums.py explicitly does NOT cover (see
its own docstring: "This does NOT detect brand-new spec messages/components we have no validator
for yet ... that stays a job for snapshot-sync-plan's own added/removed diff") — and that
snapshot-sync-plan's SKILL.md, in turn, never actually implements either. Neither tool owned this
question, so it could go stale silently. This one does own it.

The question: "CoverageCompletenessTests.FullySupportedMessages claims certain business areas
(pain, pacs, ...) are 100% covered at the top-level-message granularity described in this
project's own CLAUDE.md Coverage Scoping Policy ('the newest Registered version, plus a newer
Provisionally Registered version if one exists'). Did a snapshot sync just make that claim stale —
either by superseding an already-covered message with a newer version, or by introducing a
brand-new message family into a business area we already call complete?"

Neither case fails any existing test: CoverageCompletenessTests only walks the exact class names
already listed in FullySupportedMessages — a message that was never added to that array is
invisible to it, whether it's a harmless unrelated message or a new V14 that just obsoleted the
V13 this project spent a week building full-spec validators for.

How it works:
  1. Parse every class name out of CoverageCompletenessTests.cs's FullySupportedMessages array.
  2. Look each one up by name in a spec-snapshot.tsv's MSGDEF rows to get its businessArea and
     registrationStatus. (If a fully-supported message can't be found in the current snapshot at
     all, that's the "NOT_FOUND_IN_CURRENT_SNAPSHOT" deletion-lifecycle case build_coverage_checksums.py
     already tracks — reported here as a separate warning, not a coverage gap.)
  3. Split each resolved name into (family, version) via the trailing "V<digits>" suffix that
     every message class in this codebase uses (e.g. "CustomerCreditTransferInitiationV13" ->
     ("CustomerCreditTransferInitiation", 13)). Build covered[area][family] = max version claimed.
  4. Business areas with at least one FullySupportedMessages entry are "in-scope areas" — the ones
     this project has made a completeness claim about.
  5. Walk every MSGDEF row in the current spec-snapshot.tsv whose businessArea is an in-scope area,
     split it the same way, and compare against `covered`:
       - family not in covered[area] at all -> NEW_FAMILY: a message family this project has never
         built a validator for just appeared in an area already claimed complete.
       - version > covered[area][family]    -> SUPERSEDED: a newer version of an already-covered
         family exists; the covered version is no longer "the newest Registered version" per this
         project's own policy.
     Both are reported regardless of the new row's own registrationStatus, with status included in
     the output — a Provisionally Registered newer version is still worth a human look even though
     the policy treats it more leniently than a newly Registered one.

This script only detects and reports. It never edits FullySupportedMessages, never writes a
validator, and never touches the model library — closing a reported gap is real validator-authoring
work, exactly like every other message added to FullySupportedMessages historically (see
project_fluentvalidation_coverage_progress in project memory).

Usage:
    python3 check_message_coverage_gaps.py <spec-snapshot.tsv> [<more.tsv> ...] [--json PATH]

    Reads FullySupportedMessages from
    ../BeneficialStrategies.Iso20022.FluentValidation.Tests/CoverageCompletenessTests.cs
    (relative to this script) by default — override with --coverage-tests-file if the layout ever
    changes. Prints a human-readable report to stdout; --json also writes the same findings as
    structured JSON for a calling skill/session to act on programmatically. Exit code is 1 if any
    gap was found (so a skill or CI step can key off it), 0 if the check ran clean.
"""
import argparse
import csv
import glob
import json
import os
import re
import sys

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
FV_ROOT = os.path.abspath(os.path.join(SCRIPT_DIR, ".."))
DEFAULT_COVERAGE_TESTS_FILE = os.path.abspath(
    os.path.join(FV_ROOT, "..", "BeneficialStrategies.Iso20022.FluentValidation.Tests", "CoverageCompletenessTests.cs")
)

TYPEOF_RE = re.compile(r"typeof\((\w+)\)")
FAMILY_VERSION_RE = re.compile(r"^(.*)V(\d+)$")

# Business areas this project currently claims *100% complete* per project_fluentvalidation_
# coverage_progress (project memory) and README.md's own coverage table intro. This is
# deliberately NOT "every area that happens to have >=1 FullySupportedMessages entry" — camt has
# several dozen entries (investigation/limit/reservation/mandate-adjacent messages built early)
# but is explicitly paused at 22/100 (22%), not claimed complete, so hundreds of uncovered camt
# families are expected pre-existing backlog, not a sync-introduced regression. The NEW_FAMILY
# check below only makes sense against an area with a "we call this done" claim to protect.
# Update this set (and the README/memory) together whenever a new area reaches 100%.
FULLY_COVERED_AREAS = {"pain", "pacs"}

# Message names permanently excluded from FullySupportedMessages by deliberate policy decision,
# not because they're unbuilt — see README.md's coverage-table footnote. Both are pre-ISO20022-
# rename legacy IDs whose lineage moved to a different name (and, for one, a different business
# area) decades ago; they will never be built under these names. Excluded here so they don't show
# up as false-positive NEW_FAMILY findings forever.
KNOWN_EXCLUDED_LEGACY_NAMES = {"PaymentCancellationRequestV01", "PaymentStatusReportV02"}


def load_fully_supported_names(coverage_tests_file):
    with open(coverage_tests_file, "r", encoding="utf-8") as f:
        content = f.read()
    m = re.search(r"FullySupportedMessages\s*=\s*\[(.*?)\];", content, re.DOTALL)
    if not m:
        print(f"ERROR: could not find FullySupportedMessages array in {coverage_tests_file}", file=sys.stderr)
        sys.exit(2)
    return TYPEOF_RE.findall(m.group(1))


def load_msgdef_rows(tsv_paths):
    """name -> (businessArea, registrationStatus). Last-seen wins (there should be no dupes)."""
    rows = {}
    for path in tsv_paths:
        with open(path, "r", encoding="utf-8") as f:
            reader = csv.reader(f, delimiter="\t")
            for row in reader:
                if not row or row[0] != "MSGDEF":
                    continue
                # MSGDEF: name  isoId  businessArea  status  removalDate  checksum  definition
                if len(row) < 5:
                    continue
                name, area, status = row[1], row[3], row[4]
                rows[name] = (area, status)
    return rows


def split_family_version(name):
    m = FAMILY_VERSION_RE.match(name)
    if not m:
        return None, None
    return m.group(1), int(m.group(2))


def main():
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("tsv_paths", nargs="+", help="spec-snapshot.tsv file(s)/glob(s)")
    parser.add_argument("--coverage-tests-file", default=DEFAULT_COVERAGE_TESTS_FILE)
    parser.add_argument("--json", default=None, help="also write findings as JSON to this path")
    parser.add_argument(
        "--fully-covered-areas",
        default=None,
        help=(
            "Comma-separated business area codes to run the NEW_FAMILY check against (default: "
            + ",".join(sorted(FULLY_COVERED_AREAS))
            + " — areas with a documented 100%%-complete claim; override only if that claim's "
            "scope has changed since this script was last updated)."
        ),
    )
    args = parser.parse_args()
    fully_covered_areas = (
        set(a.strip() for a in args.fully_covered_areas.split(",") if a.strip())
        if args.fully_covered_areas
        else FULLY_COVERED_AREAS
    )

    tsv_paths = []
    for pattern in args.tsv_paths:
        matched = glob.glob(pattern)
        tsv_paths.extend(matched if matched else [pattern])

    fully_supported_names = load_fully_supported_names(args.coverage_tests_file)
    msgdef = load_msgdef_rows(tsv_paths)

    covered = {}  # area -> family -> version
    unresolved = []  # fully-supported names not found in current snapshot at all
    unparseable_covered = []
    for name in fully_supported_names:
        if name not in msgdef:
            unresolved.append(name)
            continue
        area, _status = msgdef[name]
        family, version = split_family_version(name)
        if family is None:
            unparseable_covered.append(name)
            continue
        covered.setdefault(area, {})
        if family not in covered[area] or version > covered[area][family]:
            covered[area][family] = version

    in_scope_areas = set(covered.keys())  # scope for the SUPERSEDED check (broad — any covered area)
    new_family_check_areas = in_scope_areas & fully_covered_areas  # narrower scope, see constant's comment

    new_families = []
    superseded = []
    unparseable_snapshot = []
    for name, (area, status) in msgdef.items():
        if area not in in_scope_areas or name in KNOWN_EXCLUDED_LEGACY_NAMES:
            continue
        family, version = split_family_version(name)
        if family is None:
            if area in new_family_check_areas:
                unparseable_snapshot.append((name, area))
            continue
        family_map = covered[area]
        if family not in family_map:
            if area in new_family_check_areas:
                new_families.append(
                    {"area": area, "family": family, "name": name, "version": version, "status": status}
                )
        elif version > family_map[family]:
            superseded.append(
                {
                    "area": area,
                    "family": family,
                    "coveredVersion": family_map[family],
                    "newName": name,
                    "newVersion": version,
                    "status": status,
                }
            )

    findings = {
        "inScopeAreas": sorted(in_scope_areas),
        "fullyCoveredAreasChecked": sorted(new_family_check_areas),
        "newFamiliesInScopedAreas": sorted(new_families, key=lambda x: (x["area"], x["family"])),
        "supersededCoveredMessages": sorted(superseded, key=lambda x: (x["area"], x["family"])),
        "unresolvedFullySupportedNames": sorted(unresolved),
        "unparseableFullySupportedNames": sorted(unparseable_covered),
        "unparseableSnapshotNamesInScopedAreas": sorted(unparseable_snapshot),
    }

    print(f"Areas with >=1 FullySupportedMessages entry (checked for SUPERSEDED): {', '.join(findings['inScopeAreas'])}")
    print(f"Areas with a documented 100%-complete claim (checked for NEW_FAMILY): {', '.join(findings['fullyCoveredAreasChecked']) or '(none)'}")
    print()
    if findings["supersededCoveredMessages"]:
        print(f"SUPERSEDED — {len(findings['supersededCoveredMessages'])} covered message(s) have a newer version in the current snapshot:")
        for f in findings["supersededCoveredMessages"]:
            print(
                f"  [{f['area']}] {f['family']}: covered V{f['coveredVersion']:02d} -> "
                f"spec has {f['newName']} (status: {f['status']})"
            )
        print()
    if findings["newFamiliesInScopedAreas"]:
        print(f"NEW FAMILY — {len(findings['newFamiliesInScopedAreas'])} message family(ies) not in FullySupportedMessages appeared in a 100%-complete area:")
        for f in findings["newFamiliesInScopedAreas"]:
            print(f"  [{f['area']}] {f['name']} (family: {f['family']}, status: {f['status']})")
        print()
    if findings["unresolvedFullySupportedNames"]:
        print(
            f"WARNING — {len(findings['unresolvedFullySupportedNames'])} FullySupportedMessages "
            f"name(s) not found in the current snapshot at all (check for the NOT_FOUND_IN_CURRENT_SNAPSHOT "
            f"deletion-lifecycle case in coverage-checksums.json):"
        )
        for n in findings["unresolvedFullySupportedNames"]:
            print(f"  {n}")
        print()
    if findings["unparseableFullySupportedNames"] or findings["unparseableSnapshotNamesInScopedAreas"]:
        print(
            f"NOTE — {len(findings['unparseableFullySupportedNames'])} FullySupportedMessages name(s) and "
            f"{len(findings['unparseableSnapshotNamesInScopedAreas'])} in-scope-area snapshot name(s) didn't "
            f"match the 'NameV<digits>' convention and were skipped rather than guessed at — check manually."
        )
        print()

    gap_found = bool(findings["newFamiliesInScopedAreas"] or findings["supersededCoveredMessages"])
    if not gap_found:
        print("No coverage gaps found — every in-scope business area's completeness claim still matches the current snapshot.")

    if args.json:
        with open(args.json, "w", encoding="utf-8") as f:
            json.dump(findings, f, indent=2)
        print(f"\nFindings written to {args.json}", file=sys.stderr)

    sys.exit(1 if gap_found else 0)


if __name__ == "__main__":
    main()
