# MCP Server Feedback — Snapshot Sync 2026-05-11

Feedback collected during snapshot sync execution against the ISO 20022 MCP server.
Entries reflect actual friction encountered, written from the perspective of an enterprise
consumer automating ISO 20022 library maintenance.

---

## ~~GetSpecSnapshot Returns Internal Error (-32603)~~ — RESOLVED — 2026-05-28 (snapshot-sync-plan)

> **Resolution**: Root cause diagnosed via Cloud Run structured logs. `GetSpecSnapshot` completed
> successfully server-side (1043ms), but `System.OutOfMemoryException` in `GC.AllocateNewArray`
> occurred when the MCP C# SDK tried to JSON-serialize and SSE-send the ~20MB result string.
> Fix: added required `artifactType` parameter to `GetSpecSnapshot` (`messages`, `components`,
> `choices`, `codesets`, `business`, `types`). Each section is ~2–5MB, well within transport limits.
> Callers assemble the full snapshot by calling six times and appending to disk.
> Fixed in `SnapshotTools.cs` and deployed to staging 2026-05-28.
> Planning skill updated to call once per artifactType.
> Original report preserved below for reference.

**Operation**: Call `GetSpecSnapshot` to download the complete ISO 20022 spec as a TSV for local diffing.

**What MCP provided**: JSON-RPC error `-32603: An error occurred.` — no data returned.

**Root cause (confirmed via Cloud Run logs)**: Tool completed in 1043ms, but the MCP C# SDK's
JSON serialization of the 20MB result string triggered `System.OutOfMemoryException` in
`GC.AllocateNewArray`. Memory limit is 2Gi, but peak allocation during SSE serialization of a
20MB string (source string + JSON encoder buffers + intermediate arrays) exceeded available heap.

**Fix applied**: `GetSpecSnapshot` now requires an `artifactType` parameter (`messages`, `components`,
`choices`, `codesets`, `business`, `types`). Each filtered response is ~2–5MB, well within the
transport budget. The planning skill calls it six times and assembles on disk.

**Enterprise Impact**: A bulk-export tool that reliably fails at 20MB is not usable for enterprise
automation. The per-type filter maps directly to the sync phases, enabling parallel phase planning
and significantly reducing per-call memory pressure.

**Commented-out candidate**: None — `GetSpecSnapshot` was itself the commented-out candidate, now
restored and fixed.

---

## ~~No Repository-Wide Snapshot Diff Tool~~ — RESOLVED — 2026-05-11 (snapshot-sync-plan)

> **Resolution**: `GetSpecSnapshot` and `GetDataTypeMembersSnapshot` were restored in
> `SnapshotTools.cs` (commit `99b7f36` in Iso20022MasterControl). Access restricted to
> `Feature.BulkOperations` (Enterprise/Support only). Staging deploy triggered 2026-05-28.
> The planning skill now uses a write-to-disk + local grep/diff workflow.
> Original report preserved below for reference.

---

## No Repository-Wide Snapshot Diff Tool — 2026-05-11 (snapshot-sync-plan)

**Operation**: Retrieve all artifact changes (codesets, components, choices, messages) between
snapshot 2025-04-24 and snapshot 2026-05-11, to build a complete, exhaustive sync plan.

**What MCP provided**:
- `get_migration_diff(fromName, toName)` — compares two **specific named message versions**
  (e.g., `pain.001.001.10` to `pain.001.001.12`). Requires knowing both endpoints in advance.
  Cannot be called without already knowing which messages changed.
- `get_migration_path(name)` — returns the version chain for a **single named element**.
  Useful for tracing one message forward, but requires knowing the element name first.
- `get_repository_statistics` — returns aggregate counts only (total messages by business area,
  total components by type). No information about what changed between snapshots.
- No tool accepts a snapshot date or snapshot identifier as input and returns all changed artifacts.

**Gap**: There is no tool to answer the question: *"What changed in the repository between
snapshot A and snapshot B?"* This is the foundational query that every snapshot sync begins with.
Without it, the sync process cannot start — there is no way to construct a complete list of what
needs to be updated, and proceeding without that list would produce a silently incomplete sync.

**Workaround attempted**: None. Per the planning skill's completeness rules, a plan built on
partial data is actively harmful. The planning phase was halted. `PLAN.md` was not written.

**Alternative workaround (rejected — requires explicit user approval before use)**:
Reconstruct the diff by brute force:
1. Use `universal_search` to enumerate all artifacts by type.
2. For each artifact, call `get_migration_path` to check if it has a successor version added
   after 2025-04-24.
3. For changed messages, call `get_migration_diff` per message pair to get field-level changes.

This approach would require **thousands of serial MCP calls** (one per artifact for step 2, one
per changed message pair for step 3). For a repository of 3,312 messages + 24,174 supporting
structures, this is not viable in a single session and would produce extreme API load. It is also
not guaranteed to detect new artifacts (additions not derived from an older version) or removals.

**Enterprise Impact**: This is a **show-stopper for enterprise automation**. Any team running
automated ISO 20022 library maintenance on each new specification release needs a single,
authoritative "what changed" query as the entry point. Without it:
- The sync cannot be automated — it requires manual investigation of every artifact.
- CI pipelines cannot trigger a sync in response to a new snapshot.
- There is no way to verify the sync is complete without exhaustively inspecting every artifact.
- The cost of the brute-force workaround (thousands of API calls) makes automated syncs
  impractical and would likely hit rate limits or timeout in CI environments.

**Suggested Enhancement**: Add a **snapshot diff endpoint** — the highest-priority capability
gap in the MCP server for enterprise consumers:

```
get_snapshot_diff(fromDate: string, toDate: string, artifactType?: string) → {
  added: ArtifactSummary[],
  changed: ArtifactSummary[],
  removed: ArtifactSummary[],
  total_count: number,         // for completeness verification
  next_page?: string           // pagination token if result is large
}
```

Where `ArtifactSummary` includes the artifact's ISO ID, name, type (codeset/component/choice/
message), and enough detail to populate a PLAN.md entry without requiring a follow-up lookup.

A `artifactType` filter parameter would allow callers to retrieve only codesets, only messages,
etc. — important for phased processing workflows.

**Commented-out candidate**: Unknown — cannot inspect MCP server source. However, a
`get_snapshot_diff` or `list_changes_since` tool would be the expected implementation. If such
a tool exists in commented-out form, restoring it would unblock the entire planning phase.
