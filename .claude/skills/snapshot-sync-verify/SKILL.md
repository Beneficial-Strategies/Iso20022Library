---
name: snapshot-sync-verify
description: Run the build (and tests at Milestone 4) for the current snapshot sync milestone. Updates milestone checkboxes in PLAN.md on success. Safe to re-run after fixing errors.
argument-hint: (none — detects active plan and current milestone automatically)
---

# Snapshot Sync — Verify (Milestone)

Run the build and optionally tests for the current snapshot sync milestone. Updates `PLAN.md` checkboxes only on success.

## Setup

### 1. Locate the active plan

Load the MCP tool schema:
```
ToolSearch: select:mcp__iso20022__get_repository_statistics
```

Call `mcp__iso20022__get_repository_statistics` to get the current snapshot date.

Work through the library dependency order (`iso20022` → `fluentvalidation`) and find the first library whose plan is not yet at Completion. Read its plan at `snapshot-sync/{date}/{library}/PLAN.md`.

### 2. Identify the current milestone

Scan the plan for the first **Milestone section** that has unchecked items and whose preceding Phase section has all items checked. That is the milestone to verify.

- **Milestone 1** (after Phase 1 Codesets): build only
- **Milestone 2** (after Phase 2 Components): build only
- **Milestone 3** (after Phase 3 Choices): build only
- **Milestone 4** (after Phase 4 Messages): build + tests

If no milestone is ready (preceding phase still has unchecked items), report which phase items remain and stop.

## Steps

### 3. Run the build

```bash
cd src && dotnet build iso20022.sln
```

**If the build FAILS:**
- Print the full error output.
- Do **not** update any checkboxes in PLAN.md.
- Identify which phase introduced the failures (look at the file paths in the error messages).
- Suggest targeted fixes:
  - Missing type reference → check if a removed codeset/component/choice still has a usage that wasn't cleaned up; add a FOLLOW-UP item to the relevant phase in PLAN.md.
  - Namespace not found → check the file's namespace declaration matches the directory name.
  - Ambiguous member → check for duplicate enum member ordinal assignments.
- Stop. Do not proceed to tests.

**If the build PASSES:**
- Report build success.
- Continue to Step 4 only if this is Milestone 4.
- Otherwise skip to Step 5.

### 4. Run the tests (Milestone 4 only)

```bash
cd src && dotnet test iso20022.sln --logger "console;verbosity=normal"
```

**If tests FAIL:**
- Print the failing test names and error output.
- Do **not** check the `All tests pass` checkbox.
- Investigate whether the failures are pre-existing (unrelated to the sync) or introduced by it.
- Report findings and suggest next steps.

**If tests PASS:**
- Report test pass count.

### 5. Update PLAN.md

On success, mark the milestone checkbox(es) `[x]` in PLAN.md. Update `**Last updated**` in the Metadata section.

For Milestone 4 with passing tests, also check the `## Completion` item:
```
- [x] All phases and milestones verified
```

Then commit:

```bash
git add snapshot-sync/{date}/{library}/PLAN.md
git commit -m "Snapshot sync {date} ({library}): Milestone {N} passed — build {and tests} green"
```

### 6. Report

- Which milestone was verified
- Build status (pass/fail, error count if fail)
- Test status if applicable (pass count / fail count)
- What comes next: the next phase to work on, or if all milestones are done, instructions for the Completion step (review, final commit, PR)
