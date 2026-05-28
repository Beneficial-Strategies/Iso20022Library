---
name: snapshot-sync-components
description: Phase 2 of the iso20022 snapshot sync. Reads Phase 2 from the active PLAN.md and processes up to 20 component (record type) additions, changes, and removals per invocation. Fully reentrant.
argument-hint: (none — reads state from active snapshot-sync/DATE/iso20022/PLAN.md)
---

# Snapshot Sync — Components (Phase 2)

Process Phase 2 (Components) of the active iso20022 snapshot sync plan. Each invocation handles up to **20 items**, then commits progress and stops. Re-invoke to continue.

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

Collect all unchecked items (`- [ ]`) from `## Phase 2: Components`, in document order. Take the first 20.

If there are no unchecked items in Phase 2, report that Phase 2 is already complete.

### 2. Load the lookup tool

```
ToolSearch: select:mcp__iso20022__universal_lookup
```

## Processing Each Item

---

### New Component

1. Call `mcp__iso20022__universal_lookup` with the component name to get: IsoId, display name, description, and all fields with their IsoId, display name, XML tag, type, and multiplicity.

2. Create `src/BeneficialStrategies.Iso20022.Common/Components/{ComponentName}.cs` using this pattern:

```csharp
// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// {ISO description}
/// </summary>
[IsoId("{IsoId}")]
[DisplayName("{Display Name}")]
public record {ComponentName}
{
    /// <summary>
    /// {field description}
    /// </summary>
    [IsoId("{field IsoId}")]
    [DisplayName("{Field Display Name}")]
    [IsoXmlTag("{XmlTag}")]
    {multiplicity-attribute}
    public {FieldType} {PropertyName} { get; init; }
}
```

**Multiplicity rules** (from ISO spec):
- `1..1` → `required {Type} {Name} { get; init; }`
- `0..1` → `{Type}? {Name} { get; init; }`
- `0..∞` → `ValueList<{Type}> {Name} { get; init; } = [];`
- `1..∞` → `ValueList<{Type}> {Name} { get; init; } = [];` (add `[MinLength(1)]` attribute; note in a comment that a validator enforces the minimum)

Do **not** add explicit constructors. Use `required` + init-only properties.

3. Mark the item `[x]` in PLAN.md.

---

### Changed Component

1. Call `mcp__iso20022__universal_lookup` to get the authoritative current field list.

2. Read the existing file.

3. Apply changes:
   - **New field**: append the property with correct attributes at the end of the record body.
   - **Removed field**: delete the property block. Search for direct access to that field (`grep -r "\.{PropertyName}" src/ --include="*.cs"`) and add follow-up notes for any callers found.
   - **Type change**: update the property type. If this changes nullability or collection type, note it as a potentially breaking change.
   - **Multiplicity change** (e.g., `0..1` → `0..∞`): change the property type from `T?` to `ValueList<T>` — this is a breaking change; add a `// BREAKING: multiplicity changed` comment and list any callers in the progress report.

4. Mark the item `[x]` in PLAN.md.

---

### Removed Component

1. Search for all type references: `grep -r "{ComponentName}" src/ --include="*.cs" -l`

2. If references exist (outside the file itself), **do not delete**. Add a follow-up item below the checked line:
   ```
     - [ ] FOLLOW-UP: {ComponentName} referenced in {files} — remove usages before deletion
   ```

3. If no external references, delete the file.

4. Mark the original item `[x]` in PLAN.md.

---

## Cascade Notes

Component changes can cascade. If a field's type changes, other components or messages that use this component may also need updates. **Do not try to fix cascades eagerly.** Instead:

- Add a `FOLLOW-UP` note in the PLAN.md below any item that introduced a cascade risk.
- Build failures at Milestone 2 will surface any unresolved cascades.

## After the Batch

Update `**Last updated**` in PLAN.md metadata, then commit:

```bash
git add -A
git commit -m "Snapshot sync {date} (iso20022): components — {N} done, {R} remaining"
```

Report: items processed, items remaining, any follow-up items added. If Phase 2 is fully checked, remind the user that Milestone 2 (build) is next.
