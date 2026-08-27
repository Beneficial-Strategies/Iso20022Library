---
name: snapshot-sync-choices
description: Phase 3 of the iso20022 snapshot sync. Reads Phase 3 from the active PLAN.md and processes up to 20 choice type additions, changes, obsoletions, and removals per invocation. Fully reentrant.
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

   **COMPLETENESS CHECK — REQUIRED BEFORE WRITING ANY FILES.**
   Verify the variant list is complete:
   - If the response includes a variant count or `total_variants`: confirm it matches what was returned. Fetch additional pages if paginated.
   - If there is no completeness signal and the number of variants seems suspiciously low or round: treat this as a potential truncation. Do **not** write any files. Instead:
     1. Add a `BLOCKED` entry in PLAN.md below the item.
     2. Append a friction entry to `snapshot-sync/{date}/MCP-FEEDBACK.md`.
     3. Skip to the next item.

   A choice type missing variants will break polymorphic deserialization at runtime for any message that uses the truncated variants. This is not acceptable.

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

3. Create the directory `Choices/{ChoiceName}/` and one `.cs` file per variant.

**CRITICAL: Do NOT use nested/partial records.** Each variant is a standalone top-level record in its own sub-namespace. The namespace is `BeneficialStrategies.Iso20022.Choices.{ChoiceName}` (no underscore) — this is what isolates name-clash-prone classes like `Code`, `Other`, or `IBAN` that appear in many choice types.

**Single-value variant** (wraps one value — the common case):
- `[IsoXmlTag]` goes on the `Value` property, NOT on the class.
- Property must be named `Value`.
- No `[IsoId]` or `[DisplayName]` on the property.

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.{ChoiceName}
{
    /// <summary>{variant description}</summary>
    [IsoId("{variant IsoId}")]
    [DisplayName("{Variant Display Name}")]
    public record {VariantName} : {ChoiceName}_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("{XmlTag}")]
        public required {ElementType} Value { get; init; }
    }
}
```

**Multi-field variant** (expands its own fields inline — less common, matches ISO component structure):
- `[IsoXmlTag]` goes on the class (the wrapper element).
- Each property has `[IsoId]`, `[DisplayName]`, and `[IsoXmlTag]`.
- Properties are named semantically (not `Value`).

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.{ChoiceName}
{
    /// <summary>{variant description}</summary>
    [IsoId("{variant IsoId}")]
    [DisplayName("{Variant Display Name}")]
    [IsoXmlTag("{XmlTag}")]
    public record {VariantName} : {ChoiceName}_
    {
        /// <summary>{field description}</summary>
        [IsoId("{field IsoId}")]
        [DisplayName("{Field Display Name}")]
        [IsoXmlTag("{FieldXmlTag}")]
        public required {FieldType} {FieldName} { get; init; }

        // ... additional fields
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

### Obsolete Choice

A choice whose `registrationStatus` flipped to `Obsolete` in `get_snapshot_diff` but which **still
appears** in `get_spec_snapshot` output. Not a removal.

1. Read the existing base file at `src/BeneficialStrategies.Iso20022.Common/Choices/{ChoiceName}_.cs`.

2. Add the `[Obsolete]` attribute immediately before `public abstract record {ChoiceName}_`, after
   all other attributes:
   - If a removalDate is recorded in PLAN.md: `[Obsolete("Marked obsolete in the ISO 20022 {snapshot-date} snapshot. Removal date: {removalDate}.")]`
   - If no removalDate: `[Obsolete("Marked obsolete in the ISO 20022 {snapshot-date} snapshot. No removal date recorded.")]`

3. Do NOT delete the base file, the variant directory, or any variant files.

4. Mark the item `[x]` in PLAN.md.

---

### Removed Choice

A choice that no longer appears in `get_spec_snapshot` output at all — genuinely absent, not
merely `Obsolete`-flagged (see the Obsolete step above).

1. Search for references: `grep -r "{ChoiceName}" src/ --include="*.cs" -l`

2. If external references exist, do not delete. Add follow-up:
   ```
     - [ ] FOLLOW-UP: {ChoiceName} referenced in {files} — resolve before deletion
   ```
   A referencing type that is *itself* also Removed in this same sync should be processed first —
   follow the dependency chain, not checklist order.

3. If no external references, delete `Choices/{ChoiceName}_.cs` and the entire `Choices/{ChoiceName}/`
   directory, **and its FluentValidation validator in the same commit** if one exists
   (`src/BeneficialStrategies.Iso20022.FluentValidation/Validators/Choices/{ChoiceName}_Validator.cs`).
   See `snapshot-sync-validator-checksums` for the FluentValidation-side manifest this should also
   update.

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
