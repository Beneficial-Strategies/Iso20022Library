---
name: snapshot-sync
description: Orchestrate the ISO 20022 snapshot sync process. Auto-detects current state from the plan document and executes the next batch of work. Re-invoke repeatedly to make progress. Handles all libraries in dependency order (iso20022 first, then dependents).
argument-hint: (none — state is read from snapshot-sync/DATE/LIBRARY/PLAN.md)
---

# Snapshot Sync — Orchestrator

This is the top-level entry point for the snapshot sync process. Run `/snapshot-sync` repeatedly — each invocation reads the current state and executes the next batch of work automatically.

**Library dependency order**: `iso20022` → `fluentvalidation` (future). A dependent library's plan is not created or started until the preceding library reaches Completion.

## Steps

### 1. Determine the current snapshot date

Load the MCP tool schema:
```
ToolSearch: select:mcp__iso20022__get_repository_statistics
```

Call `mcp__iso20022__get_repository_statistics` to retrieve the current snapshot date from the MCP server. Format it as `YYYY-MM-DD`. This becomes the **date key** used in all folder paths.

### 2. Locate the active plan

Work through the library list in dependency order: `["iso20022", "fluentvalidation"]`.

For each library, check whether `snapshot-sync/{date}/{library}/PLAN.md` exists and whether its `## Completion` section has all items checked.

- **First library with no plan file** → this is the library to plan next (go to Step 3).
- **First library with an incomplete plan** → this is the active library (go to Step 4).
- **All libraries complete** → report full completion and stop.

For now, only create the `fluentvalidation` plan after `iso20022` is fully complete. Do not start FluentValidation sync automatically; report that it is ready and wait for the user to confirm.

### 3. No plan exists — run planning

The active library has no plan file. Follow all steps from `.claude/skills/snapshot-sync-plan/SKILL.md` (read that file with the Read tool and execute its instructions), passing the active library name as context.

After the plan is created, re-read it and fall through to Step 4.

### 4. Plan exists — determine current phase

Read `snapshot-sync/{date}/{library}/PLAN.md`. Scan the sections in order:

- Find the **first Phase section** that has any unchecked `- [ ]` items → this is the active phase.
- If all Phase items above a **Milestone section** are checked but the milestone itself is unchecked → the active work is the milestone.
- If all phases and milestones are checked but `## Completion` is not → report that and ask the user to run `/snapshot-sync-verify` for final sign-off.

### 5. Execute the active phase

**If active = Phase 1 (Codesets):**
Read `.claude/skills/snapshot-sync-codesets/SKILL.md` and follow its instructions for the `{date}/{library}` plan.

**If active = Phase 2 (Components):**
Read `.claude/skills/snapshot-sync-components/SKILL.md` and follow its instructions.

**If active = Phase 3 (Choices):**
Read `.claude/skills/snapshot-sync-choices/SKILL.md` and follow its instructions.

**If active = Phase 4 (Messages):**
Read `.claude/skills/snapshot-sync-messages/SKILL.md` and follow its instructions.

**If active = a Milestone:**
Read `.claude/skills/snapshot-sync-verify/SKILL.md` and follow its instructions for the current milestone.

### 6. Report status

After executing the batch, report:
- Library and date being synced
- Phase just worked on and how many items were processed
- How many items remain in that phase
- What will happen on the next `/snapshot-sync` invocation
