---
name: snapshot-sync-plan
description: Query the ISO 20022 MCP server to discover what changed since the last snapshot, then create snapshot-sync/DATE/LIBRARY/PLAN.md with a phased checklist. Safe to re-run — it warns before overwriting an in-progress plan.
argument-hint: [library] (default: iso20022)
---

# Snapshot Sync — Plan

Create `snapshot-sync/{date}/{library}/PLAN.md` — the master checklist that drives the sync for one library. The library defaults to `iso20022` if no argument is given.

## Before You Begin

1. Determine the **library**: `$ARGUMENTS` if provided, otherwise `iso20022`.
2. Load MCP tool schemas:
   ```
   ToolSearch: select:mcp__iso20022__get_repository_statistics,mcp__iso20022__get_migration_diff,mcp__iso20022__get_migration_path
   ```
3. Call `mcp__iso20022__get_repository_statistics` to get the current snapshot **date** (format as `YYYY-MM-DD`).
4. Set **plan path** = `snapshot-sync/{date}/{library}/PLAN.md`.
5. If the plan file already exists, warn the user that regenerating it **resets all checkbox state** and ask for explicit confirmation before proceeding. Stop if they decline.

## Steps

### 1. Download the spec snapshot

Load the MCP tool schema:
```
ToolSearch: select:mcp__iso20022__get_spec_snapshot
```

Call `mcp__iso20022__get_spec_snapshot` for each `artifactType`, writing each result to disk
before calling the next. Large sections (`components`, `codesets`) require multiple pages —
each response includes `# Page X of Y`; keep calling with `page+1` until `X == Y`.

**WRITE EACH RESULT TO DISK BEFORE CALLING THE NEXT. Do not read or process in-context.**

Call sequence (append all to `snapshot-sync/{date}/spec-snapshot.tsv`):

```
messages         (page 1 of 1)
components, 1    (check # Page X of Y in response)
components, 2
... repeat until page X == Y
choices          (page 1 of 1)
codesets, 1      (check # Page X of Y)
codesets, 2
... repeat until page X == Y
business         (page 1 of 1)
types            (page 1 of 1)
```

**COMPLETENESS IS MANDATORY — DO NOT PROCEED WITH A PARTIAL SNAPSHOT.**

After all calls, verify the assembled file:
1. Contains a `# Section: ... | Page X of X` line for every section and every page.
2. All `# Page X of Y` lines have X == Y (no pages skipped).
3. Counts are non-zero and plausible vs `get_repository_statistics` totals.
4. If any page or section is missing, stop and log to `MCP-FEEDBACK.md` — do not proceed.

### 2. Diff against the previous snapshot

Check for a previous snapshot:

```bash
ls snapshot-sync/*/spec-snapshot.tsv 2>/dev/null | sort | tail -2
```

**First run (no previous snapshot):** Compare the spec snapshot against the library's source files to find what's new, changed, or removed. Use `grep` to extract names from the TSV, then compare against directory listings:

```bash
# Messages in spec vs. files in MessageDefinitions/
grep '^MSGDEF' snapshot-sync/{date}/spec-snapshot.tsv | cut -f2 > /tmp/spec-messages.txt
find src/BeneficialStrategies.Iso20022.Common/MessageDefinitions -name "*.cs" \
  | xargs -I{} basename {} .cs > /tmp/lib-messages.txt
comm -23 <(sort /tmp/spec-messages.txt) <(sort /tmp/lib-messages.txt)  # in spec, not in lib = NEW
comm -13 <(sort /tmp/spec-messages.txt) <(sort /tmp/lib-messages.txt)  # in lib, not in spec = REMOVED

# Repeat for: MSGCOMP → Components/, CHOICE → Choices/, CODESET → Codesets/
```

**Subsequent runs (previous snapshot exists):** Diff the two TSV files directly:

```bash
PREV=$(ls snapshot-sync/*/spec-snapshot.tsv | sort | tail -2 | head -1)
CURR=snapshot-sync/{date}/spec-snapshot.tsv

# New lines (in current, not in previous):
comm -13 <(sort "$PREV") <(sort "$CURR") | grep -v '^#' > /tmp/snapshot-added.tsv

# Removed lines (in previous, not in current):
comm -23 <(sort "$PREV") <(sort "$CURR") | grep -v '^#' > /tmp/snapshot-removed.tsv
```

Then filter by record type to get per-artifact-type diffs:
```bash
grep '^MSGDEF'    /tmp/snapshot-added.tsv    # New message definitions
grep '^MSGCOMP'   /tmp/snapshot-added.tsv    # New message components
grep '^CHOICE'    /tmp/snapshot-added.tsv    # New choice types
grep '^CODESET'   /tmp/snapshot-added.tsv    # New code sets
grep '^CODE'      /tmp/snapshot-added.tsv    # New codes within existing code sets
grep '^MSGELEMENT' /tmp/snapshot-added.tsv   # New elements within existing components
# etc. — and same for snapshot-removed.tsv
```

### 3. Categorize changes (iso20022 library)

Sort every changed artifact into one of four phases. For each item record whether it is **new**, **changed**, or **removed**, and note enough detail to act on it without re-querying MCP (though re-querying for details is always fine):

- **Phase 1 — Codesets**: enum types under `src/BeneficialStrategies.Iso20022.Common/Codesets/`
  - New: full name + file path. **Important — before adding a "New" entry, check whether the codeset has any enumerated codes in the spec.** A codeset with no codes is one of two things:
    1. **External with members**: `IsExternal` flag is set AND the MCP returns members sourced from the external codeset JSON (`*externalcodesets*.json`). Still a New entry — the codeset skill creates a **hybrid `IIsoExternalCode` struct** (open struct + named constants per known member), not a closed enum.
    2. **Everything else with no codes** — pattern-validated (`pattern` attribute present), length/table-validated (`ValidationByTable` constraint, minLength/maxLength/exact-length facet), or genuinely no facet at all: still a New entry, and still real work — the codeset skill creates a **plain open `IIsoExternalCode` struct**, Pattern-validated (or permissively `^.+$` with a documented "MCP checked, no facet found" note when MCP gives nothing at all).
    > **2026-08-16 correction**: this section previously had a third branch — "String alias: ...
    > Do NOT add to the New section... check `GlobalUsings.cs`... no action needed" — which
    > produced a 60-type defect (every memberless codeset silently became an unvalidated
    > `System.String` alias instead of a real struct), discovered and fixed 2026-08-16. See
    > `project_external_codeset_shadowing_defect.md` and commit `4db243b1e1`. **A memberless
    > codeset is never "no action needed" — it always needs a real struct in `Codesets/`.**
    > `GlobalUsings.cs`'s `// External Codesets` section is legacy; do not add new entries there.
    > A codeset landing here with genuinely no MCP data of any kind (not even a `pattern`) is not
    > "unexpected" — it happens (e.g. `LanguageCode`, `NationalityCode`, `BusinessFilePriorityCode`
    > all had only an unresolved `ValidationByTable` constraint) — still create the struct, just
    > with a permissive pattern and a documented note, per CLAUDE.md's external-standard-exception
    > guidance. Only flag for manual investigation if the codeset is missing from MCP entirely
    > (not found by any name/spelling — a genuinely stale/removed type, see the 16-name precedent
    > in the same commit).
  - Changed: added/removed enum member codes
  - Obsolete: call `get_snapshot_diff` with `section: changedContent` and `xsiType: CodeSet`, then filter for records where `changes.registrationStatus[1] === "Obsolete"`. For each match, check if the file exists in `Codesets/`; if so, add an `### Obsolete` subsection entry noting the removalDate from `changes.removalDate[1]` (if present). These files stay in the library — they get `[Obsolete("Marked obsolete in the ISO 20022 {date} snapshot. Removal date: {removalDate}.")]` (or `"No removal date recorded."` if absent). Do NOT put them in `### Removed`.
  - Removed: file path to delete — only for codesets that appear in `get_snapshot_diff` `section: removed` with `xsi:type: CodeSet` AND whose file exists in `Codesets/`. Items that are merely Obsolete are NOT removals.
- **Phase 2 — Components**: record types under `src/BeneficialStrategies.Iso20022.Common/Components/`
  - Changed: field-level description (type change, added field, removed field)
  - Obsolete/Removed: **same three-state distinction as Phase 1** (below), substituting
    `xsiType: MessageComponent` and `Components/` for `CodeSet`/`Codesets/`. This is not
    optional — `InvestmentFundTransactionsByFund3` was found 2026-08-26 sitting in `Components/`
    with no `[Obsolete]` attribute despite the ISO spec having marked it Obsolete since 2018 and
    fully purged it from the queryable snapshot by 2026-06-26, specifically because an earlier
    version of this section had no Obsolete/Removed step for Components at all — see
    `project_validator_checksum_manifest` in project memory.
- **Phase 3 — Choices**: abstract choice records under `src/BeneficialStrategies.Iso20022.Common/Choices/`
  - Changed: variant added/removed
  - Obsolete/Removed: same three-state distinction, `xsiType: ChoiceComponent` and `Choices/`.
- **Phase 4 — Messages**: outer record types under `src/BeneficialStrategies.Iso20022.Common/MessageDefinitions/{area}/`
  - Group by 4-letter business area prefix (pain, pacs, camt, seev, sese, semt, acmt, admi, auth, etc.)
  - Obsolete/Removed: same three-state distinction. Messages have no `xsiType` value in
    `get_snapshot_diff` (`MessageDefinition` returns zero results — confirmed 2026-08-26); scan the
    unfiltered `added`/`removed`/`changedContent` sections instead (tractable at this artifact's
    scale — see `project_mcp_checksum_field` in project memory) and identify message-shaped records
    by their attribute shape (`xmlTag`+`rootElement`+`messageSet`, no `xsi:type` field) rather than
    by filter.

**The three-state distinction, spelled out once (applies to all four phases above):**
1. **Registered** (no `registrationStatus` change, or unchanged) — ordinary New/Changed handling.
2. **Obsolete, still present in the snapshot** — `registrationStatus` becomes `"Obsolete"` in a
   `changedContent` record (`changes.registrationStatus[1] === "Obsolete"`), and the entity still
   appears in `get_spec_snapshot`. The file **stays** in the library, gets
   `[Obsolete("Marked obsolete in the ISO 20022 {date} snapshot. Removal date: {removalDate}."`
   (or `"No removal date recorded."` if `changes.removalDate` is absent) — matching the ~40+
   existing examples across `Components`/`Codesets` (e.g. `Components/Quantity3.cs`). Do **not**
   put these in the Removed bucket.
3. **Genuinely absent** — the entity appears in `get_snapshot_diff`'s `removed` section (filtered
   by the phase's `xsiType`, where one exists) AND its file still exists in the library. This is
   the actual deletion trigger — but delete only after the same reference-safety check the
   "Removed Component/Choice/Message" processing steps already do (`grep` for external references;
   if any exist, add a `FOLLOW-UP` instead of deleting, since the referencing type may itself need
   to go first — chains of retired types, like the semt `InvestmentFundTransactionsByFund3` →
   `StatementOfInvestmentFundTransactions3` → `StatementOfInvestmentFundTransactionsV03` cluster
   found 2026-08-26, must be removed in dependency order, not all at once).

A type merely flipping to Obsolete is never a Removed entry, and a type already absent from the
snapshot should never linger as a bare `[Obsolete]` marker forever — eventually it disappears from
the snapshot's queryable output entirely, at which point it belongs in state 3, not state 2.

### 3. Write the plan file

Create `snapshot-sync/{date}/{library}/` directory if needed, then write `PLAN.md`:

```markdown
# Snapshot Sync — {library} — {date}
<!-- Generated by /snapshot-sync-plan on YYYY-MM-DD. Edit checklist items only, not headers. -->

## Metadata
- **Library**: {library}
- **MCP snapshot date**: {date}
- **Previous snapshot**: 2025-04-24
- **Branch**: snapshot/2026
- **Plan created**: YYYY-MM-DD
- **Last updated**: YYYY-MM-DD

## Phase 1: Codesets (N new · M changed · O obsolete · P removed)
<!-- /snapshot-sync-codesets works this section -->
### New
- [ ] `CodesetName` — `Codesets/CodesetName.cs`
### Changed
- [ ] `CodesetName` — add: CODE1, CODE2; remove: OLDCODE
### Obsolete
- [ ] `CodesetName` — add `[Obsolete("Marked obsolete in the ISO 20022 {date} snapshot. Removal date: {removalDate}.")]`, file stays
### Removed
- [ ] `CodesetName` — delete `Codesets/CodesetName.cs`

## Milestone 1: Build
- [ ] Build passes after codesets

## Phase 2: Components (N new · M changed · O obsolete · P removed)
<!-- /snapshot-sync-components works this section -->
### New
- [ ] `ComponentName##` — `Components/ComponentName##.cs`
### Changed
- [ ] `ComponentName##` — [field-level description]
### Obsolete
- [ ] `ComponentName##` — add `[Obsolete("Marked obsolete in the ISO 20022 {date} snapshot. Removal date: {removalDate}.")]`, file stays
### Removed
- [ ] `ComponentName##` — delete `Components/ComponentName##.cs`

## Milestone 2: Build
- [ ] Build passes after components

## Phase 3: Choices (N new · M changed · O obsolete · P removed)
<!-- /snapshot-sync-choices works this section -->
### New
- [ ] `ChoiceName` — `Choices/ChoiceName_.cs` + `Choices/ChoiceName/` directory
### Changed
- [ ] `ChoiceName` — [variant added/removed]
### Obsolete
- [ ] `ChoiceName` — add `[Obsolete("Marked obsolete in the ISO 20022 {date} snapshot. Removal date: {removalDate}.")]` on the base type, files stay
### Removed
- [ ] `ChoiceName` — delete `Choices/ChoiceName_.cs` and `Choices/ChoiceName/`

## Milestone 3: Build
- [ ] Build passes after choices

## Phase 4: Messages (N new · M changed · O obsolete · P removed)
<!-- /snapshot-sync-messages [area] works this section -->
### {area} (N)
- [ ] `{area}.NNN.001.VV` — [new | updated | obsolete | removed]: [description]

## Milestone 4: Full Build + Tests
- [ ] Build passes
- [ ] All tests pass

## Completion
- [ ] All phases and milestones verified
- [ ] Changes committed and branch ready for review
```

Fill every checklist entry with the actual artifacts from the diff. Omit empty subsections (e.g., skip `### Removed` if there are no removals).

### 4. Commit the plan

```bash
git add snapshot-sync/{date}/{library}/PLAN.md
git commit -m "Snapshot sync {date} ({library}): create plan document (N total changes)"
```

### 5. Print summary

| Phase | New | Changed | Obsolete | Removed | Total |
|-------|-----|---------|----------|---------|-------|
| Codesets | | | | | |
| Components | | | | | |
| Choices | | | | | |
| Messages | | | | | |
| **Total** | | | | | |

Remind the user to run `/snapshot-sync` to begin execution.

---

## MCP Friction Log

After completing the plan, review what happened and append an entry to `snapshot-sync/{date}/MCP-FEEDBACK.md` for **each friction point actually encountered**. Do not invent hypothetical issues — only log what you observed. If everything worked cleanly, skip this section.

### MCP-FEEDBACK.md entry format

```markdown
## [Short descriptive title] — {date} (snapshot-sync-plan)

**Operation**: [One-line description of what was being attempted]
**What MCP provided**: [What the tool actually returned]
**Gap**: [What was missing, ambiguous, or required extra calls to compensate]
**Workaround**: [What was done instead — include number of extra API calls if applicable]
**Enterprise Impact**: [Why this matters at scale: CI pipelines, large diffs, developer productivity,
automation reliability. Write from the perspective of an enterprise team running this on every
ISO 20022 release, not a one-time manual run.]
**Suggested Enhancement**: [Specific new tool, new parameter, or mode that would close the gap]
**Commented-out candidate**: [Name of any currently commented-out MCP tool that might address this,
or "None identified"]
```

### Known friction categories to watch for during planning

- **Snapshot date**: Is the current snapshot date clearly returned by `get_repository_statistics`, or did you have to derive it from another call or infer it?
- **Diff completeness**: Did `get_migration_diff` return enough detail (added/removed member codes for codesets, field-level changes for components) to write the PLAN.md without per-item follow-up calls? Or did you have to call `universal_lookup` on individual items just to populate the plan?
- **Diff categorization**: Did the diff pre-sort results by artifact type (codeset / component / choice / message), or did you have to categorize them manually?
- **Diff pagination**: Was the full diff returned in one response, or did it require multiple calls to retrieve all changes?
- **Filtering**: Was there any way to request "only codeset changes" or "only message changes" to avoid processing irrelevant artifact types?

Append the `MCP-FEEDBACK.md` file to the same git commit as the plan, or in a follow-up commit immediately after.
