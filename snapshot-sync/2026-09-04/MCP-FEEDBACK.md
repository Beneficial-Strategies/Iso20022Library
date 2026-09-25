# MCP Feedback — 2026-09-04 snapshot sync

## `get_snapshot_diff` result size can exceed the tool-call token cap for busy sections — 2026-09-25 (snapshot-sync-plan)

**Operation**: Retrieving `changedContent` (242 items, unfiltered) and `changedContent`
xsiType-filtered to `MessageComponent` (52 items) for the `2026-06-26/2026-09-04` pair.

**What MCP provided**: Both calls returned successfully but were flagged by the client harness as
exceeding its own per-tool-call token cap (108,270 and 599,810 characters respectively) and were
redirected to a saved file instead of being returned inline.

**Gap**: Nothing wrong with the data itself — it was complete and well-formed JSON — but a
`pageSize` of 500 (the value used successfully for smaller filtered pulls like `CodeSet`/
`ChoiceComponent`) was too large for `changedContent` once `xsiType` was omitted or set to a
type with per-item verbose attribute payloads (`MessageComponent` records carry a `changes`
object whose values can themselves be long space-separated ID lists, e.g. `messageBuildingBlock`
churn).

**Workaround**: Parsed the saved file directly with `python3 -c "json.loads(...)"` and `grep`/
`collections.Counter` instead of re-requesting with a smaller page size — cheaper than a second
round trip once the file was already on disk, but a smaller default `pageSize` (or the tool
proactively suggesting a smaller page size in its own size-exceeded error) would avoid producing
an oversized single-page response in the first place for callers who don't know in advance how
verbose the changed section's `changes` payloads will be for a given `xsiType`.

**Enterprise Impact**: A CI pipeline calling `get_snapshot_diff` generically (without prior
knowledge of which `xsiType`s produce verbose payloads) would hit this same size ceiling on any
future sync where a similar-shaped bulk reference-list change lands, and would need the same
file-based fallback logic built in from the start rather than discovering it interactively.

**Suggested Enhancement**: Document a recommended `pageSize` ceiling per `xsiType` (or auto-clamp
`pageSize` server-side when an unfiltered/verbose type is requested) so callers don't need to
discover the safe page size by trial and error.

**Commented-out candidate**: None identified.
