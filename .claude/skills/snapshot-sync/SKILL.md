---
name: snapshot-sync
description: Orchestrate the ISO 20022 snapshot sync process. Auto-detects current state from the plan document and executes the next batch of work. Re-invoke repeatedly to make progress. Handles all libraries in dependency order (iso20022 first, then dependents).
argument-hint: (none — state is read from snapshot-sync/DATE/LIBRARY/PLAN.md)
---

# Snapshot Sync — Orchestrator

This is the top-level entry point for the snapshot sync process. Run `/snapshot-sync` repeatedly — each invocation reads the current state and executes the next batch of work automatically.

**Library dependency order**: `iso20022` → `fluentvalidation` (future). A dependent library's plan is not created or started until the preceding library reaches Completion. The first concrete piece of the `fluentvalidation` phase already exists: once `iso20022`'s sync reaches Completion for a given date, run `.claude/skills/snapshot-sync-validator-checksums/SKILL.md` to find which *existing* FluentValidation validators need editing or obsoleting (it does not find new coverage candidates — that stays part of the normal per-message-family build process).

## Steps

### 1. Determine the current snapshot date

Load the MCP tool schema:
```
ToolSearch: select:mcp__plugin_iso20022-staging_iso20022-staging__get_repository_statistics
```

Call `mcp__plugin_iso20022-staging_iso20022-staging__get_repository_statistics` to retrieve the current snapshot date from the MCP server. Format it as `YYYY-MM-DD`. This becomes the **date key** used in all folder paths.

### 1a. Download the spec snapshot (required underlayment — do this once per sync)

Check whether `snapshot-sync/{date}/spec-snapshot.tsv` already exists. If not, download it now before any phase work begins.

Load the tool schema:
```
ToolSearch: select:mcp__plugin_iso20022-staging_iso20022-staging__get_spec_snapshot
```

Call `get_spec_snapshot` once for each artifact type and **append** each response to `snapshot-sync/{date}/spec-snapshot.tsv`:

```
get_spec_snapshot('messages')        → write   spec-snapshot.tsv
get_spec_snapshot('components', 1)   → append  (repeat until Page X of X)
get_spec_snapshot('choices')         → append
get_spec_snapshot('codesets', 1)     → append  (repeat until Page X of X)
get_spec_snapshot('business')        → append
get_spec_snapshot('types')           → append
```

This file is the **single source of truth for all ISO descriptions** used throughout all four phases. Every entity and every child property in the spec has an `id` and a `definition` field in this file — descriptions are read from here by grepping for the entity's IsoId, with `universal_lookup` used only as a fallback when a specific entry is missing or ambiguous.

> **Note on server maturity**: The `definition` field is fully populated on MSGDEF records. As
> the server evolves, `definition` will be added to MSGBLOCK, MSGELEMENT, CODE, EXTCODE,
> VARIANT, and other child record types (tracked in `MCP-FEEDBACK.md`). Until those fields land,
> `universal_lookup` remains the fallback for child-level descriptions. The workflow is the same
> either way — prefer the snapshot, fall back to lookup.

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
