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

### 3. Run the build and check documentation warnings

```bash
cd src && dotnet build iso20022.sln --no-incremental 2>&1 | tee /tmp/build-output.txt
```

Use `--no-incremental` to force a full rebuild so warning counts are accurate.

**Check for errors (CS, MSB):**

**If the build FAILS (errors > 0):**
- Print the full error output.
- Do **not** update any checkboxes in PLAN.md.
- Identify which phase introduced the failures (look at the file paths in the error messages).
- Suggest targeted fixes:
  - Missing type reference → check if a removed codeset/component/choice still has a usage that wasn't cleaned up; add a FOLLOW-UP item to the relevant phase in PLAN.md.
  - Namespace not found → check the file's namespace declaration matches the directory name.
  - Ambiguous member → check for duplicate enum member ordinal assignments.
- Stop. Do not proceed to warning checks or tests.

**Check for CS1591 warnings (missing XML documentation):**

```bash
grep -c "warning CS1591" /tmp/build-output.txt || echo "0"
```

**CS1591 is a hard gate.** Every public type and every public member in this library must carry its verbatim ISO description as an XML doc comment — this is a non-negotiable requirement (see CLAUDE.md). A CS1591 warning means a public member has no `/// <summary>` at all.

**If CS1591 count > 0:**
- Do **not** update any milestone checkboxes in PLAN.md.
- Print the first 20 CS1591 occurrences to identify the files involved.
- Report which phase owns those files (codesets → Phase 1, components → Phase 2, choices → Phase 3, messages → Phase 4).
- Add FOLLOW-UP items in PLAN.md for each affected phase.
- Stop. The milestone is not complete until CS1591 count is zero.

**Zero-warning gate:** The normal build must produce **0 warnings** of any kind. CS0618/CS0612 (obsolete member usage) are suppressed in normal builds via `<NoWarn>` in the project file — that suppression is intentional and not a gate failure. All other warnings are failures.

**If build passes and CS1591 = 0 and total warnings = 0:**
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

### 6. Annual obsolete-warning audit (Milestone 4 only, once per year)

At Milestone 4 of each sync, run the build with obsolete warnings re-enabled to audit the tangle:

```bash
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release --no-incremental \
  -p:EnableObsoleteWarnings=true 2>&1 | grep "CS0618\|CS0612" | wc -l
```

For each type flagged:
- If it was marked obsolete in the **current snapshot** → keep (one-snapshot grace period for consumers).
- If it was marked obsolete in an **earlier snapshot** AND all its references are also obsolete → it is safe to delete now.
- If it was marked obsolete in an **earlier snapshot** but has non-obsolete references → blocked; leave for a future sync when the referencing types are also retired.

Document any safe deletions as FOLLOW-UP items in PLAN.md. This audit does not block the milestone; it is informational only unless safe deletions are found.

### 7. Report

- Which milestone was verified
- Build status (pass/fail, warning count)
- Test status if applicable (pass count / fail count)
- Obsolete-warning audit results (Milestone 4 only): count of CS0618/CS0612 with `-p:EnableObsoleteWarnings=true`, and any safe-to-delete types found
- What comes next: the next phase to work on, or if all milestones are done, instructions for the Completion step (review, final commit, PR)
