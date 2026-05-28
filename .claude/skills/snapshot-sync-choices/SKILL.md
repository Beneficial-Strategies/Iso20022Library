---
name: snapshot-sync-choices
description: Phase 3 of the iso20022 snapshot sync. Reads Phase 3 from the active PLAN.md and processes up to 20 choice type additions, changes, and removals per invocation. Fully reentrant.
argument-hint: (none — reads state from active snapshot-sync/DATE/iso20022/PLAN.md)
---

# Snapshot Sync — Choices (Phase 3)

Process Phase 3 (Choices) of the active iso20022 snapshot sync plan. Each invocation handles up to **20 items**, then commits progress and stops. Re-invoke to continue.

## Setup

### 1. Locate the active plan

Load the MCP tool schema:
```
ToolSearch: select:mcp__iso20022__get_repository_statistics
```

Call `mcp__iso20022__get_repository_statistics` to get the current snapshot date. Read:
```
snapshot-sync/{date}/iso20022/PLAN.md
```

Collect all unchecked items (`- [ ]`) from `## Phase 3: Choices`, in document order. Take the first 20.

If there are no unchecked items in Phase 3, report that Phase 3 is already complete.

### 2. Load the lookup tool

```
ToolSearch: select:mcp__iso20022__universal_lookup
```

## Choice Type File Structure

Each choice type occupies:
- `src/BeneficialStrategies.Iso20022.Common/Choices/{ChoiceName}_.cs` — abstract base record
- `src/BeneficialStrategies.Iso20022.Common/Choices/{ChoiceName}/` — directory containing one `.cs` file per variant

The abstract base uses `[KnownType]` and `[JsonDerivedType]` attributes for each variant. Variant files contain concrete records that extend the base.

## Processing Each Item

---

### New Choice

1. Call `mcp__iso20022__universal_lookup` with the choice name to get: IsoId, description, and all variants (each with its XML tag, element type, and description).

2. Create the abstract base file `Choices/{ChoiceName}_.cs`:

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// {ISO description}
    /// </summary>
    [KnownType(typeof({ChoiceName}.{Variant1}))]
    [KnownType(typeof({ChoiceName}.{Variant2}))]
    [JsonDerivedType(typeof({ChoiceName}.{Variant1}), nameof({ChoiceName}.{Variant1}))]
    [JsonDerivedType(typeof({ChoiceName}.{Variant2}), nameof({ChoiceName}.{Variant2}))]
    [IsoId("{IsoId}")]
    [DisplayName("{Display Name}")]
    public abstract record {ChoiceName}_ { }
}
```

3. Create the directory `Choices/{ChoiceName}/` and one `.cs` file per variant:

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices
{
    public partial record {ChoiceName}_ 
    {
        /// <summary>
        /// {variant description}
        /// </summary>
        [IsoId("{variant IsoId}")]
        [DisplayName("{Variant Display Name}")]
        [IsoXmlTag("{XmlTag}")]
        public record {VariantName} : {ChoiceName}_
        {
            /// <summary>{element description}</summary>
            [IsoId("{element IsoId}")]
            [DisplayName("{Element Display Name}")]
            [IsoXmlTag("{XmlTag}")]
            public required {ElementType} {PropertyName} { get; init; }
        }
    }
}
```

4. Mark the item `[x]` in PLAN.md.

---

### Changed Choice

1. Call `mcp__iso20022__universal_lookup` to get the current authoritative variant list.

2. Read the existing `Choices/{ChoiceName}_.cs` base file.

3. Apply changes:
   - **Variant added**: add `[KnownType]` and `[JsonDerivedType]` entries to the base file; create a new variant `.cs` file in the directory.
   - **Variant removed**: remove its `[KnownType]` and `[JsonDerivedType]` lines from the base; delete the variant file. Search for references (`grep -r "{ChoiceName}.{VariantName}" src/ --include="*.cs"`) and add follow-up notes for any callers.
   - **Variant element type changed**: update the property type in the variant file; note if it's breaking.

4. Mark the item `[x]` in PLAN.md.

---

### Removed Choice

1. Search for references: `grep -r "{ChoiceName}" src/ --include="*.cs" -l`

2. If external references exist, do not delete. Add follow-up:
   ```
     - [ ] FOLLOW-UP: {ChoiceName} referenced in {files} — resolve before deletion
   ```

3. If no external references, delete `Choices/{ChoiceName}_.cs` and the entire `Choices/{ChoiceName}/` directory.

4. Mark the item `[x]` in PLAN.md.

---

## After the Batch

Update `**Last updated**` in PLAN.md metadata, then commit:

```bash
git add -A
git commit -m "Snapshot sync {date} (iso20022): choices — {N} done, {R} remaining"
```

Report: items processed, items remaining, follow-up items added. If Phase 3 is fully checked, remind the user that Milestone 3 (build) is next.

---

## MCP Friction Log

After each batch, append an entry to `snapshot-sync/{date}/MCP-FEEDBACK.md` for **each friction point actually observed**. Only log real issues — skip if the MCP tools worked cleanly.

### Entry format

```markdown
## [Short descriptive title] — {date} (snapshot-sync-choices)

**Operation**: [One-line description]
**What MCP provided**: [What the tool returned]
**Gap**: [What was missing or required extra calls]
**Workaround**: [What was done instead — include N extra API calls]
**Enterprise Impact**: [Why this matters to an enterprise team running automated sync]
**Suggested Enhancement**: [Specific new tool, parameter, or batch mode]
**Commented-out candidate**: [Name of a commented-out MCP tool that might address this, or "None identified"]
```

### Known friction categories to watch for

- **No batch lookup**: Each choice type required a separate `universal_lookup` call. Same throughput issue as codesets and components — a `batch_lookup` would address all three.
- **Variant structure clarity**: Did `universal_lookup` clearly enumerate all variants of the choice with their XML tags, element types, and multiplicities in one call? Or did each variant require a follow-up?
- **Nested structure depth**: Choice types often wrap components which themselves wrap other types. Was the lookup result deep enough to write the variant files without additional calls, or did it return only one level of depth?
- **No choice-only filter**: Same cross-cutting concern as codesets and components — was there a direct way to retrieve "all changed choice types" from the diff without manually filtering a mixed result set?
- **File structure convention**: The two-file pattern (abstract base `_.cs` + per-variant files in a directory) is library-specific. The MCP server has no way to know this. Note if the lookup result made it easy or difficult to derive the correct file layout.
