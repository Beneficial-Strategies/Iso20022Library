---
name: snapshot-sync-validator-checksums
description: Refresh coverage-checksums.json (FluentValidation package) from the current MCP spec snapshot and flag which existing validators need review — edit (spec content changed), mirror [Obsolete] from the model type (spec entity flagged obsolete but still present), or delete in lockstep with its model type (spec entity genuinely absent, subject to reference-safety check). Does NOT find new coverage candidates — that's snapshot-sync-plan's job.
argument-hint: (none — reads snapshot-sync/{date}/spec-snapshot.tsv, writes src/BeneficialStrategies.Iso20022.FluentValidation/coverage-checksums.json)
---

# Snapshot Sync — Validator Checksums

Answers a narrower question than the rest of the `snapshot-sync-*` family: not "what's new in the
spec" but **"of the 1,296+ model types we already have a FluentValidation validator for, did any
of their own spec content change since we last checked — and does any of it no longer exist at
all?"** Cross-field constraint logic (`WithName(constraintName)` blocks) is exactly the kind of
thing a checksum change can silently invalidate without changing the reachable-graph shape the
other skills already track.

Background: the MCP server added a per-artifact content checksum (16-hex-char hash) on 2026-08-26,
present on `MSGDEF`/`MSGCOMP`/`CHOICE`/`CODESET`/`SIMPLETYPE`/`AMOUNT`/`EXTSCHEMA`/`USERDEF`
records in `get_spec_snapshot` output — one value per uniquely-identified artifact, confirmed
unique with zero collisions across the full message/component/choice sets. See
`project_mcp_checksum_field` in project memory for the original discovery notes.

## Before You Begin

This skill is part of the `fluentvalidation` library phase referenced (but not yet built out) in
`snapshot-sync/SKILL.md`'s library dependency order (`iso20022` → `fluentvalidation`). Run it
**after** the `iso20022` library's own sync (`snapshot-sync-codesets`/`-components`/`-choices`/
`-messages`) has reached Completion for the snapshot date in question — the FluentValidation
package's validators target the `iso20022` library's model types, so checking validator staleness
against a spec snapshot the model itself hasn't been synced to yet would conflate two different
kinds of drift.

## Steps

### 1. Ensure the spec snapshot exists

Check for `snapshot-sync/{date}/spec-snapshot.tsv`. This skill does **not** introduce a new
download step — it's the exact same file `snapshot-sync-plan`'s Step 1 already produces. If it
doesn't exist for the date you're working, run `snapshot-sync-plan` first (or its Step 1 alone).

### 2. Regenerate the manifest

```bash
cd src/BeneficialStrategies.Iso20022.FluentValidation
python3 tools/build_coverage_checksums.py \
  --snapshot-date {date} \
  ../../snapshot-sync/{date}/spec-snapshot.tsv
```

The script (see its own docstring for full detail) does two things no MCP call can do alone:
scans `Common` for every model type's own `[IsoId("...")]` (join key), and scans this package's
`Validators/` tree for every validator's `AbstractValidator<T>`/`ExternalCodesetAbstractValidator<T>`
declaration — then joins the two against the snapshot's checksums. It reports (to stderr) any
validator whose validated type has no resolvable `IsoId` at all — that should always be zero; if
it isn't, stop and investigate before proceeding, since it means the join itself is broken, not
that a spec entity changed.

### 3. Diff against the last committed manifest

```bash
git diff --stat src/BeneficialStrategies.Iso20022.FluentValidation/coverage-checksums.json
```

Then inspect the actual entries that changed:

```bash
git diff src/BeneficialStrategies.Iso20022.FluentValidation/coverage-checksums.json
```

Categorize every changed entry:

- **`"checksum"` value changed** (both old and new non-null) — the underlying spec content
  changed. **EDIT candidate.** Re-run `universal_lookup` on that type's ISO ID to see what
  actually changed (field added/removed, constraint text changed, definition reworded), then
  update the validator and its test file accordingly. A checksum change alone doesn't say *what*
  changed — always re-fetch and read the current spec text before editing.
- **`"status"` newly became `"Obsolete"`** (the type still appears in `get_spec_snapshot`, just
  flagged) — state 2 of 3 in the ISO registry lifecycle. Not a removal.
  - Check whether `Common/{...}/{TypeName}.cs` already carries `[Obsolete(...)]`. If not, add it —
    an `iso20022`-library change (via `snapshot-sync-components`/`-choices`/`-codesets`/
    `-messages`, matching the marker shape already used in existing model types, e.g.
    `Components/Quantity3.cs`: `"Marked obsolete in the ISO 20022 {date} snapshot. {removal date,
    or 'No removal date recorded.'}"`). **Use this entry's own `"removalDate"` field directly** —
    it's sourced from the bulk `get_spec_snapshot` TSV (a real column since the 2026-08-27
    deployment); no separate `universal_lookup` call needed. `null` genuinely means no date is
    recorded (or, for external codesets specifically, that the column isn't present on that row
    shape at all — see `build_coverage_checksums.py`'s docstring) — not a signal to go look harder.
  - Once the model type carries `[Obsolete(...)]`, mirror the same attribute onto its validator.
    Both files stay in the repository, both still compile, both are marked.
- **`"status": "NOT_FOUND_IN_CURRENT_SNAPSHOT"` newly appeared** — the spec entity no longer
  appears in `get_spec_snapshot` at all, genuinely purged from the registry (not merely
  `Obsolete`-flagged — see above). State 3 of 3, and **this is the deletion trigger** for both the
  model type and its validator, together, in the same commit — subject to the same
  reference-safety check `snapshot-sync-components`/`-choices`/`-messages` already perform before
  deleting a model type (grep for external references; a referencing type that's itself also gone
  must be removed first, in dependency order). This skill doesn't perform that deletion itself —
  it's the `iso20022`-library sync skill's job to delete the model type (per its own Removed
  section), and the validator's removal follows as a compile-forced consequence in the same
  commit. First real hit found 2026-08-26: `InvestmentFundTransactionsByFund3` — blocked from
  immediate deletion by two live references (`StatementOfInvestmentFundTransactions3`,
  `StatementOfInvestmentFundTransactionsV03`), which are themselves also confirmed-absent — a
  dependency-chain removal, not a single-file one.
- **A key present in the old manifest is entirely absent from the new one** — the validator file
  itself was deleted since the last manifest was committed (which only happens in unison with its
  model type being deleted from `Common`, per the policy above — this key vanishing is confirming
  that already happened, not proposing it). Bookkeeping only, not actionable here.
- **A new key appeared with a normal checksum** — a validator was added since the last manifest.
  Bookkeeping only — confirms `build_coverage_checksums.py` is tracking it now, nothing to do.

### 4. Act on findings, then re-run to confirm clean

After mirroring `[Obsolete(...)]` markers / editing validators per the above (never deleting one
except in lockstep with its model type), re-run Step 2. The diff should now be empty except for
entries you deliberately changed (their checksums will match the new spec content you just built
against). Commit the refreshed `coverage-checksums.json` alongside the validator changes it
justified — not as a separate commit — so `git blame` on the manifest always lands on the commit
that explains *why* a checksum moved.

### 5. What this skill deliberately does NOT do

It never proposes **new** validators for spec entities that have no validator at all yet — a
checksum-based join can only ever cover types already in the manifest. Finding new coverage
candidates (new messages, or existing messages whose reachable graph grew) stays
`snapshot-sync-plan`'s and the individual message-scoping workflow's job (see
`project_fluentvalidation_coverage_progress` in project memory for that ongoing effort).

## Known tool friction (log new instances to `snapshot-sync/{date}/MCP-FEEDBACK.md`)

- `get_spec_snapshot('components', N)` intermittently returned a **duplicate of a previously
  fetched page** instead of the requested page N, observed under concurrent/rapid sequential
  calls (2026-08-26) — silent, no error, same byte-identical content returned twice for two
  different requested page numbers, leaving one real page's ~2,000 records completely
  unretrieved. Detected only by noticing first/last record names repeating across "different"
  pages. Workaround: request the missing range again with a **different `pageSize`** (shifts
  page boundaries, sidesteps whatever cache key collided) rather than retrying the same
  `(page, pageSize)` pair. Verify every fetched page's first/last record name against its
  neighbors before trusting a "complete" download — matching `snapshot-sync-plan`'s existing
  "COMPLETENESS IS MANDATORY" verification step, just extended to catch silent duplicates, not
  only missing pages.
