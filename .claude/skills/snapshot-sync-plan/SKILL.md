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
  - New: full name + file path
  - Changed: added/removed enum member codes
  - Removed: file path to delete
- **Phase 2 — Components**: record types under `src/BeneficialStrategies.Iso20022.Common/Components/`
  - Changed: field-level description (type change, added field, removed field)
- **Phase 3 — Choices**: abstract choice records under `src/BeneficialStrategies.Iso20022.Common/Choices/`
  - Changed: variant added/removed
- **Phase 4 — Messages**: outer record types under `src/BeneficialStrategies.Iso20022.Common/MessageDefinitions/{area}/`
  - Group by 4-letter business area prefix (pain, pacs, camt, seev, sese, semt, acmt, admi, auth, etc.)

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

## Phase 1: Codesets (N new · M changed · P removed)
<!-- /snapshot-sync-codesets works this section -->
### New
- [ ] `CodesetName` — `Codesets/CodesetName.cs`
### Changed
- [ ] `CodesetName` — add: CODE1, CODE2; remove: OLDCODE
### Removed
- [ ] `CodesetName` — delete `Codesets/CodesetName.cs`

## Milestone 1: Build
- [ ] Build passes after codesets

## Phase 2: Components (N new · M changed · P removed)
<!-- /snapshot-sync-components works this section -->
### New
- [ ] `ComponentName##` — `Components/ComponentName##.cs`
### Changed
- [ ] `ComponentName##` — [field-level description]
### Removed
- [ ] `ComponentName##` — delete `Components/ComponentName##.cs`

## Milestone 2: Build
- [ ] Build passes after components

## Phase 3: Choices (N new · M changed · P removed)
<!-- /snapshot-sync-choices works this section -->
### New
- [ ] `ChoiceName` — `Choices/ChoiceName_.cs` + `Choices/ChoiceName/` directory
### Changed
- [ ] `ChoiceName` — [variant added/removed]
### Removed
- [ ] `ChoiceName` — delete `Choices/ChoiceName_.cs` and `Choices/ChoiceName/`

## Milestone 3: Build
- [ ] Build passes after choices

## Phase 4: Messages (N new · M changed · P removed)
<!-- /snapshot-sync-messages [area] works this section -->
### {area} (N)
- [ ] `{area}.NNN.001.VV` — [new | updated | removed]: [description]

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

| Phase | New | Changed | Removed | Total |
|-------|-----|---------|---------|-------|
| Codesets | | | | |
| Components | | | | |
| Choices | | | | |
| Messages | | | | |
| **Total** | | | | |

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
