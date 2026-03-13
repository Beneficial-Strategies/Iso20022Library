# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is the **Iso20022Library** - a .NET library containing 2,665 ISO20022 financial message types as immutable C# records.

**NuGet Package**: `BeneficialStrategies.Iso20022`

### Transition Notice

This library was originally auto-generated from the ISO20022 specification by the Iso20022MasterControl project. **The code generation approach is being discontinued.** Going forward:

- This repository will become independent (no longer a submodule of Iso20022MasterControl)
- The `.g.cs` files will be maintained directly with assistance from Claude and the ISO20022 MCP server
- The original generators in Iso20022MasterControl will be abandoned

## Build Commands

```bash
# Build the library
cd src && dotnet build iso20022.sln

# Build for all target frameworks
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

**Target Frameworks**: NET8, NET7, NET6

## Architecture

### Code Maintenance

The `.g.cs` files were originally auto-generated but are now maintained directly. Claude may edit these files as needed to fix bugs, add features, or align with ISO20022 specification updates. The MCP server provides access to ISO20022 specification data to assist with maintenance.

### Directory Structure

```
src/BeneficialStrategies.Iso20022.Common/
├── Framework/           # Hand-written base interfaces and helpers
├── Components/          # Generated message components (12,653 types)
├── Choices/             # Generated polymorphic choice types
├── Codesets/            # Generated enums (3,774 types)
├── Amounts/             # Generated amount types
├── ExternalSchema/      # External schema references
├── UserDefined/         # User-defined content placeholders
├── Metadata/            # Attribute definitions
└── [business areas]/    # 36 business area folders (pain, pacs, camt, seev, etc.)
```

### Business Area Abbreviations

| Abbr | Description |
|------|-------------|
| `pain` | Payment Initiation (customer-to-bank) |
| `pacs` | Payments Clearing and Settlement |
| `camt` | Cash Management (statements, reports) |
| `seev` | Securities Events (corporate actions) |
| `sese` | Securities Settlement |
| `semt` | Securities Management |

### Generated Code Patterns

**Messages** (`[area]/MessageName.g.cs`):
- Implement `IOuterRecord` interface
- Include `IsoIdentifier` constant (e.g., `"pain.001.001.11"`)
- Rich XML documentation from ISO spec

**Choice Types** (`Choices/[ChoiceName]/`):
- Abstract base record with `[JsonDerivedType]` attributes
- Concrete variant records for each option

**Codesets** (`Codesets/[Name]Code.g.cs`):
- Enums with `[EnumMember]` and `[IsoId]` attributes
- Versioned codes (e.g., `PaymentMethod3Code`)

### Key Interfaces (Framework/)

- `IOuterRecord` - All top-level messages
- `IOuterDocument` - XML document wrapper
- `IIsoXmlSerializable` - Serialization contract

## Multi-Package Repository Strategy

**Chosen approach: monorepo.**

All NuGet packages produced by Beneficial Strategies that depend on each other live in this
single repository. The planned packages include (at minimum):

- `BeneficialStrategies.Iso20022` — this library (ISO 20022 message types)
- `BeneficialStrategies.Iso20022.Sagas` — MassTransit Sagas strongly correlated to ISO 20022 messages

**Reasons:**

- **Atomic changes** — when a type changes in the ISO 20022 library that the Sagas library depends
  on, both can be updated and validated in a single PR. No cross-repo version coordination.
- **Single build/CI** — one pipeline validates the entire dependency graph together, catching
  breaking changes before they ship to NuGet.
- **No bootstrap problem** — dependent projects reference each other as `<ProjectReference>` during
  development. No need to publish `-preview` packages just to test an in-progress change.
- **Consistent versioning** — package versions are managed in one place and released together on
  the same cadence (Sagas releases track the ISO 20022 library release schedule).
- **Simpler developer experience** — one clone, one `dotnet build`, everything works.

Each package retains its own `.csproj` with its own `<PackageId>` and `<Version>`. CI packs and
publishes them in dependency order (ISO 20022 library first, then Sagas).

## Test Patterns

### Embedded XML Sample Files

XML sample files live in `src/BeneficialStrategies.Iso20022.Common.Tests/TestData/` and are
compiled as `EmbeddedResource`. Every file **must** be validated against the official ISO 20022
XSD **before** it is committed.

**Validation requirement (mandatory):**

1. Obtain the XSD from `https://www.iso20022.org/sites/default/files/schemas/<message-id>.xsd`
   (e.g. `camt.056.001.10.xsd`).
2. Validate the XML file against the XSD using an external tool (e.g. `xmllint --schema`
   or an online validator such as freeformatter.com/xml-validator.html).
3. Record the result in the file's header comment:
   ```xml
   <!--
     XSD VALIDATION STATUS: VALID
     Validated : YYYY-MM-DD
     Schema    : https://www.iso20022.org/sites/default/files/schemas/<message-id>.xsd
   -->
   ```
4. If the file cannot be validated externally, set the status to `PENDING EXTERNAL VALIDATION`
   and add a TODO comment explaining why (e.g. amounts excluded due to Ccy-attribute mismatch).

**Amount elements** use the ISO XSD `simpleContent+Ccy-attribute` pattern:
`<Amt Ccy="EUR">47250.00</Amt>` — NOT child elements. The library's `Iso20022XmlSerializer`
handles this correctly for all types in the `BeneficialStrategies.Iso20022.Amounts` namespace.

### Embedded resource naming

The manifest resource name is built from the `<RootNamespace>` (not the assembly name):
`{RootNamespace}.TestData.{filename}` where path separators become dots.
For this project: `BeneficialStrategies.Iso20022.TestData.<filename>`
