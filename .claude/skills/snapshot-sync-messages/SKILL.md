---
name: snapshot-sync-messages
description: Phase 4 of the iso20022 snapshot sync. Reads Phase 4 from the active PLAN.md and processes up to 20 message definition additions, changes, obsoletions, and removals per invocation. Optionally filter to a single business area. Fully reentrant.
argument-hint: [area] (optional — filter to one business area, e.g. "pain", "pacs", "camt")
---

# Snapshot Sync — Messages (Phase 4)

Process Phase 4 (Messages) of the active iso20022 snapshot sync plan. Each invocation handles up to **20 items**, then commits progress and stops. Re-invoke to continue.

If `$ARGUMENTS` is provided, only process items in the matching business area section (e.g., `### pain`). This is useful for targeted work on a specific area.

## Setup

### 1. Locate the active plan

Load the MCP tool schema:
```
ToolSearch: select:mcp__plugin_iso20022-staging_iso20022-staging__get_repository_statistics
```

Call `mcp__plugin_iso20022-staging_iso20022-staging__get_repository_statistics` to get the current snapshot date. Read:
```
snapshot-sync/{date}/iso20022/PLAN.md
```

Navigate to `## Phase 4: Messages`. If `$ARGUMENTS` is provided, find the `### {area}` subsection and collect only those unchecked items. Otherwise collect all unchecked items across all areas, in document order. Take the first 20.

If there are no unchecked items (filtered by area if applicable), report Phase 4 is complete (or complete for that area).

### 2. Download the message spec snapshot (required underlayment)

Load the tool schema and download the full message snapshot **once at the start of Phase 4**:

```
ToolSearch: select:mcp__plugin_iso20022-staging_iso20022-staging__get_spec_snapshot
```

Call `mcp__plugin_iso20022-staging_iso20022-staging__get_spec_snapshot` with `artifactType: 'messages'`. Write the result to disk — it is the authoritative, grep-friendly source for all Phase 4 work. The snapshot contains two record types:

**MSGDEF** (one per message):
```
MSGDEF  name  isoId  businessArea  status  definition
```
The `definition` field is the full Scope/Usage text for the message class — used verbatim in `[Description(@"...")]` and `/// <summary>`.

**MSGBLOCK** (one per message building block):
```
MSGBLOCK  messageName  blockName  xmlTag  componentName  minOccurs  maxOccurs  status  memberIsoId  definition
```
- `memberIsoId`: the xmi:id of the messageBuildingBlock element — the stable identity key for a field across versions
- `definition`: the field's verbatim ISO description — used in property `/// <summary>`

With both columns, the snapshot is fully self-contained: no per-message MCP round trips are needed during normal processing.

> **Server version note**: If `definition` or `memberIsoId` are absent from MSGBLOCK (older server), fall back to `universal_lookup` per message (step 3).

### 3. Load the lookup tool (fallback and supplemental)

```
ToolSearch: select:mcp__plugin_iso20022-staging_iso20022-staging__universal_lookup
```

`universal_lookup` renders the full definition in a dedicated `### Definition` section (untruncated). Use it when:
- The spec snapshot is missing definition/memberIsoId columns (older server)
- Navigating individual member details with `showChildDescriptions: true`
- Verifying a specific field when the snapshot data is ambiguous

### 4. Sourcing descriptions

**The new snapshot is always authoritative.** Never copy descriptions from predecessor files as a substitute for the snapshot — a field's description can be updated between versions for any reason (repurposing, added clarity, corrected wording) without any structural change. Always write what the current snapshot says.

**When the snapshot has `definition` columns** (current server):
- Class `/// <summary>` and `[Description(@"...")]`: use MSGDEF `definition`
- Each property `/// <summary>`: use MSGBLOCK `definition` for that building block
- No predecessor file lookup needed

**When the snapshot lacks `definition` columns** (older server — fallback only):
- Use `universal_lookup` per message to get the class definition from the `### Definition` section
- Use `showChildDescriptions: true` to get building block definitions from the children table
- Predecessor file text may be used as a last resort for fields not returned by the lookup, but mark any such property with `// TODO: verify description against current spec`

## Processing Each Item

For each item, extract the business area from the ISO message identifier (e.g., `pain.001.001.12` → area is `pain`).

---

### New Message

1. Call `mcp__plugin_iso20022-staging_iso20022-staging__universal_lookup` with the message identifier (e.g., `pain.001.001.12`) to retrieve: IsoId, display name, description, XmlTag, DocumentNamespace, DocumentElementName, and all fields with their IsoId, display name, XML tag, type, and multiplicity.

   **COMPLETENESS CHECK — REQUIRED BEFORE WRITING THE FILE.**
   Verify the field list is complete:
   - If the response includes a field count or `total_fields`: confirm it matches what was returned. Fetch additional pages if paginated.
   - If there is no completeness signal and the field count seems suspiciously low or round: treat this as a potential truncation. Do **not** write the file. Instead:
     1. Add a `BLOCKED` entry in PLAN.md below the item.
     2. Append a friction entry to `snapshot-sync/{date}/MCP-FEEDBACK.md`.
     3. Skip to the next item in the batch.

   A message record with missing fields will parse XML silently discarding data, and will fail schema validation against ISO XSD. This is not acceptable.

2. Determine the class name from the display name + version number (e.g., `CustomerCreditTransferInitiationV12`).

3. Create `src/BeneficialStrategies.Iso20022.Common/MessageDefinitions/{area}/{ClassName}.cs`:

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.{area};

/// <summary>
/// This record is an implementation of the {IsoIdentifier} ISO standard message type.
/// {ISO description from spec}
/// </summary>
[Description(@"{ISO description}")]
[IsoId("{IsoId}")]
[DisplayName("{Display Name}")]
public record {ClassName} : IOuterRecord
{
    public const string IsoIdentifier = "{area}.NNN.001.VV";
    public const string XmlTag = "{XmlTag}";
    public const string DocumentNamespace = "{DocumentNamespace}";
    public const string DocumentElementName = "{DocumentElementName}";

    /// <summary>
    /// {field description}
    /// </summary>
    [IsoId("{field IsoId}")]
    [DisplayName("{Field Display Name}")]
    [IsoXmlTag("{XmlTag}")]
    {multiplicity-attribute}
    public {FieldType} {PropertyName} { get; init; }

    // ... additional fields
}
```

**Multiplicity rules**: same as components — `required` for 1..1, `T?` for 0..1, `ValueList<T>` for 0..∞ and 1..∞.

4. Mark the item `[x]` in PLAN.md.

---

### Updated Message

1. Call `mcp__plugin_iso20022-staging_iso20022-staging__universal_lookup` to get the current authoritative field list.

2. Read the existing file at `MessageDefinitions/{area}/{ClassName}.cs`.

3. Apply only the changes described in the PLAN.md item description (field added, field removed, field type changed). Do not rewrite the whole file.

4. If a field type change could break callers, note it in the progress report.

5. Mark the item `[x]` in PLAN.md.

---

### Obsolete Message

A message whose `registrationStatus` flipped to `Obsolete` but which **still appears** in
`get_spec_snapshot` output. Not a removal. Messages have no `xsiType` filter value in
`get_snapshot_diff` (`MessageDefinition` returns zero results) — identify these by scanning the
unfiltered `changedContent` section for message-shaped records (`xmlTag`+`rootElement`+
`messageSet` attributes, no `xsi:type` field) with `changes.registrationStatus[1] === "Obsolete"`.

1. Read the existing file at `MessageDefinitions/{area}/{ClassName}.cs`.

2. Add the `[Obsolete]` attribute immediately before `public record {ClassName} : IOuterRecord`,
   after all other attributes:
   - If a removalDate is recorded in PLAN.md: `[Obsolete("Marked obsolete in the ISO 20022 {snapshot-date} snapshot. Removal date: {removalDate}.")]`
   - If no removalDate: `[Obsolete("Marked obsolete in the ISO 20022 {snapshot-date} snapshot. No removal date recorded.")]`

3. Do NOT delete the file or remove any fields.

4. Mark the item `[x]` in PLAN.md.

---

### Removed Message

A message that no longer appears in `get_spec_snapshot` output at all — genuinely absent, not
merely `Obsolete`-flagged (see the Obsolete step above). Same unfiltered-scan caveat applies:
identify these from the raw `removed` section by record shape, since there's no `xsiType` filter
for messages.

1. Search for references: `grep -r "{ClassName}" src/ --include="*.cs" -l`

2. If external references exist (outside the file itself), add a follow-up item and do not delete.
   A referencing type that is *itself* also Removed in this same sync should be processed first.

3. If no external references, delete the file, **and its FluentValidation validator in the same
   commit** if one exists (`src/BeneficialStrategies.Iso20022.FluentValidation/Validators/{area}/{ClassName}Validator.cs`).
   See `snapshot-sync-validator-checksums` for the FluentValidation-side manifest this should also
   update.

4. Mark the item `[x]` in PLAN.md.

---

## After the Batch

Update `**Last updated**` in PLAN.md metadata, then commit:

```bash
git add -A
git commit -m "Snapshot sync {date} (iso20022): messages [{area or 'all'}] — {N} done, {R} remaining"
```

Report: items processed, items remaining (total and by area if filtered), follow-up items added. If Phase 4 is fully checked, remind the user that Milestone 4 (full build + tests) is next.

---

## MCP Friction Log

After each batch, append an entry to `snapshot-sync/{date}/MCP-FEEDBACK.md` for **each friction point actually observed**. Only log real issues — skip if the MCP tools worked cleanly.

### Entry format

```markdown
## [Short descriptive title] — {date} (snapshot-sync-messages)

**Operation**: [One-line description]
**What MCP provided**: [What the tool returned]
**Gap**: [What was missing or required extra calls]
**Workaround**: [What was done instead — include N extra API calls]
**Enterprise Impact**: [Why this matters — message definitions are the largest phase,
with potentially thousands of items across 37 business areas]
**Suggested Enhancement**: [Specific new tool, parameter, or batch mode]
**Commented-out candidate**: [Name of a commented-out MCP tool that might address this, or "None identified"]
```

### Known friction categories to watch for

- **No batch lookup**: Each message required a separate `universal_lookup` call. With potentially hundreds of changed messages across 37 business areas, this is the highest-volume friction point in the entire sync. A `batch_lookup` that accepts a list of ISO identifiers (e.g., `["pain.001.001.12", "pacs.008.001.14"]`) and returns all specs in one response would dramatically reduce round-trip cost.
- **No business-area query**: Was there a way to ask "give me all changed messages in the `pain` business area" directly? Or did you have to filter a full mixed diff? Enterprise users frequently need to delegate business-area work to different team members — area-scoped queries are essential.
- **Message identifier vs. class name**: Did the MCP response clearly provide both the ISO message identifier (e.g., `pain.001.001.12`) and the C# class name (e.g., `CustomerCreditTransferInitiationV12`)? Or did the class name have to be derived from the display name with manual version-suffix construction?
- **Field-level diff not pre-computed**: For *updated* messages, did the MCP server return a structured field diff, or did you have to retrieve the full field list and diff it against the existing file yourself? At scale, pre-computed field diffs would be the difference between a fast sync and an expensive one.
- **Namespace derivation**: Was the `DocumentNamespace` (e.g., `urn:iso:std:iso:20022:tech:xsd:pain.001.001.12`) and `XmlTag` clearly provided in the lookup result, or did they need to be constructed from convention?
- **Completeness verification**: Was there any way to confirm that all messages for a given business area had been retrieved (i.e., a count or a "list all IDs in area X" endpoint)? Without it, there's no way to verify the plan is exhaustive.
