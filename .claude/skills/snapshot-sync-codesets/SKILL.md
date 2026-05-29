---
name: snapshot-sync-codesets
description: Phase 1 of the iso20022 snapshot sync. Reads Phase 1 from the active PLAN.md and processes up to 20 codeset (enum) additions, changes, and removals per invocation. Fully reentrant.
argument-hint: (none — reads state from active snapshot-sync/DATE/iso20022/PLAN.md)
---

# Snapshot Sync — Codesets (Phase 1)

Process Phase 1 (Codesets) of the active iso20022 snapshot sync plan. Each invocation handles up to **20 items**, then commits progress and stops. Re-invoke to continue.

## Setup

### 1. Locate the active plan

Load the MCP tool schema:
```
ToolSearch: select:mcp__iso20022__get_repository_statistics
```

Call `mcp__iso20022__get_repository_statistics` to get the current snapshot date. Find the active plan at:
```
snapshot-sync/{date}/iso20022/PLAN.md
```

Read that file. If there are no unchecked items in Phase 1, report that Phase 1 is already complete.

### 1b. Order items to avoid dependency errors

**CRITICAL**: Derived codeset files reference parent enum members with `= ParentCode.MemberName` syntax. If a New derived codeset references a member that hasn't been added yet to a Changed base codeset, the file will compile with errors.

Before selecting the batch of 20, apply this ordering rule:

1. Collect **all** unchecked items from Phase 1 (both New and Changed sections).
2. For each unchecked New codeset that is `DerivedFrom` a base codeset, check whether that base codeset has an unchecked Changed item.
3. Any such Changed base codeset item must be processed **before** any New derived codeset that references it.
4. Build the ordered batch (up to 20 items):
   - First: Changed items for base codesets that are prerequisites for New items in this batch
   - Then: New items (up to fill the remaining slots)
   - Then: remaining Changed items (if slots remain)
   - Then: Removed items

This ordering ensures that when a derived file is written, all its parent members already exist in the compiled base type.

### 2. Load the lookup tool

```
ToolSearch: select:mcp__iso20022__universal_lookup
```

## Processing Each Item

For each unchecked codeset item (up to 20), determine the action from its label (New / Changed / Removed) and execute:

---

### New Codeset

1. Call `mcp__iso20022__universal_lookup` with the codeset name to retrieve its full spec: IsoId, description, parent/DerivedFrom type, and all enum member codes with their values and descriptions.

   **COMPLETENESS CHECK — REQUIRED BEFORE WRITING THE FILE.**
   After receiving the lookup result, verify the member list is complete:
   - If the response includes a `total_members`, `member_count`, or equivalent field: confirm the number of members returned matches. If not, fetch remaining pages before continuing.
   - If the response offers pagination: exhaust all pages.
   - If you have no completeness signal and the list seems suspiciously short (e.g., exactly 25, 50, or 100 items on a codeset that likely has more based on its name/description): treat this as a potential truncation. Do **not** write the file. Instead:
     1. Add a `BLOCKED` entry to PLAN.md below the item:
        ```
          - [ ] BLOCKED: {CodesetName} — lookup returned {N} members but completeness cannot be verified. Resolve before continuing.
        ```
     2. Append a friction entry to `snapshot-sync/{date}/MCP-FEEDBACK.md`.
     3. Skip to the next item in the batch.

   A codeset file with missing enum members will compile but produce silent runtime errors (unmapped codes). This is not acceptable.

2. Create `src/BeneficialStrategies.Iso20022.Common/Codesets/{CodesetName}.cs` using this pattern:

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// {ISO description from spec}
/// </summary>
[DataContract]
[Serializable]
[IsoId("{IsoId from spec}")]
[Description(@"{ISO description from spec}")]
[DerivedFrom(typeof({ParentCode}))]   // omit this line if there is no parent type
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<{CodesetName}>))]
#endif
public enum {CodesetName}
{
    /// <summary>
    /// {member description}
    /// Encoded/decoded by serializers as "{EnumMember value}".
    /// </summary>
    [EnumMember(Value = "{code}")]
    [IsoId("{member IsoId}")]
    [Description(@"{member description}")]
    {MemberName} = {ParentCode}.{MemberName},  // use this form if DerivedFrom; otherwise use a unique int
}
```

Omit `[DerivedFrom]` and the `= {ParentCode}.{MemberName}` ordinal assignment if the codeset has no parent type. In that case assign sequential integers starting at 0.

3. Mark the item `[x]` in PLAN.md.

---

### Changed Codeset

1. Call `mcp__iso20022__universal_lookup` with the codeset name to get the authoritative current member list.

2. Read the existing file at `src/BeneficialStrategies.Iso20022.Common/Codesets/{CodesetName}.cs`.

3. Apply the changes:
   - **Added members**: append new `[EnumMember]` entries at the end of the enum body following the existing pattern.
   - **Removed members**: delete the member's doc comment + attributes + declaration. Then search for any references to that member across the solution (`grep -r "{CodesetName}.{MemberName}" src/`) and list them in the progress report as broken references to fix.

4. Mark the item `[x]` in PLAN.md.

---

### Obsolete Codeset

1. Read the existing file at `src/BeneficialStrategies.Iso20022.Common/Codesets/{CodesetName}.cs`.

2. Add the `[Obsolete]` attribute immediately before `public enum {CodesetName}`, after all other attributes:
   - If a removalDate is recorded in PLAN.md: `[Obsolete("Marked obsolete in the ISO 20022 {snapshot-date} snapshot. Removal date: {removalDate}.")]`
   - If no removalDate: `[Obsolete("Marked obsolete in the ISO 20022 {snapshot-date} snapshot. No removal date recorded.")]`
   - Place it after the last `[...]` attribute block and before `#if NET8_0_OR_GREATER` (if present), or directly before `public enum` if there is no `#if` block.

3. Do NOT delete the file or remove any enum members.

4. Mark the item `[x]` in PLAN.md.

---

### Removed Codeset

1. Search for all references to the type: `grep -r "{CodesetName}" src/ --include="*.cs" -l`

2. If references exist outside `Codesets/{CodesetName}.cs` itself, **do not delete** the file. Instead, add a follow-up note to PLAN.md directly below the checked item:
   ```
     - [ ] FOLLOW-UP: {CodesetName} has references in {file1}, {file2} — resolve before deletion
   ```

3. If there are no external references, delete the file.

4. Mark the original item `[x]` in PLAN.md.

---

## After the Batch

### Update PLAN.md metadata

Update the `**Last updated**` date in the Metadata section.

### Commit progress

```bash
git add -A
git commit -m "Snapshot sync {date} (iso20022): codesets — {N} done, {R} remaining"
```

### Report

- How many items were processed
- How many items remain in Phase 1
- Any broken references or follow-up items added
- If Phase 1 is now fully checked: remind the user that Milestone 1 (build verification) is next — run `/snapshot-sync` or `/snapshot-sync-verify` to continue

---

## MCP Friction Log

After each batch, append an entry to `snapshot-sync/{date}/MCP-FEEDBACK.md` for **each friction point actually observed**. Only log real issues encountered during this batch — skip if the MCP tools worked cleanly.

### Entry format

```markdown
## [Short descriptive title] — {date} (snapshot-sync-codesets)

**Operation**: [One-line description]
**What MCP provided**: [What the tool returned]
**Gap**: [What was missing or required extra calls]
**Workaround**: [What was done instead — include N extra API calls]
**Enterprise Impact**: [Why this matters to an enterprise team automating sync across
hundreds of codeset changes per release cycle]
**Suggested Enhancement**: [Specific new tool, parameter, or batch mode]
**Commented-out candidate**: [Name of a commented-out MCP tool that might address this, or "None identified"]
```

### Known friction categories to watch for

- **No batch lookup**: Each codeset required a separate `universal_lookup` call. For a batch of 20 items this means 20 serial round-trips. At enterprise scale (hundreds of codesets changed per release), this is a significant throughput bottleneck. A `batch_lookup` accepting a list of identifiers and returning all results in one response would eliminate this.
- **Incomplete single-call data**: Did `universal_lookup` return all enum members with their `[EnumMember]` values, `[IsoId]`, and descriptions in one call? Or were follow-up calls needed to get complete member data?
- **No codeset-only filter**: Was there a way to query "all changed codesets for this snapshot" directly, or did the diff have to be pre-filtered manually from a mixed result set?
- **Parent type resolution**: When a codeset is `DerivedFrom` a parent type, was the parent type clearly identified in the lookup result, or did it require a separate call?
- **Ordinal/value conflicts**: Did the MCP server provide enough information to correctly assign enum ordinals without ambiguity, or was manual inference required?
