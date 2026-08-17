# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is the **Iso20022Library** - a .NET library containing 3,311 ISO20022 financial message types as immutable C# records.

**NuGet Package**: `BeneficialStrategies.Iso20022`

### Transition Notice

This library was originally auto-generated from the ISO20022 specification by the Iso20022MasterControl project. **The code generation approach is being discontinued.** Going forward:

- This repository will become independent (no longer a submodule of Iso20022MasterControl)
- The `.g.cs` files will be maintained directly with assistance from Claude and the ISO20022 MCP server
- The original generators in Iso20022MasterControl will be abandoned

## XML Documentation — Non-Negotiable Requirement

**Every public type and every public member must carry the verbatim ISO 20022 specification
description as its XML doc comment.** This is a hard requirement, not a style preference. The
NuGet package surfaces these descriptions directly to consumers via IntelliSense and generated
API documentation — paraphrasing, truncation, or substituting the display name destroys the
understanding the ISO spec authors encoded.

### What "verbatim" means

- **Do not paraphrase.** "Reference that uniquely identifies the message from a business
  application standpoint." is correct. "Message Identification." is not.
- **Do not infer from the name.** The display name (`[DisplayName]`) and the XML doc summary are
  separate concerns. The display name is a label; the summary is explanatory prose from the spec.
- **Do not truncate** lengthy Scope/Usage/Constraint text. If the ISO text is long, use
  `<remarks>` for the overflow — but keep it all.
- **`<seealso>` tags** are welcome where the spec cross-references other types or messages.

### Where to put the content

| ISO text | XML doc placement |
|---|---|
| Primary one-sentence description | `<summary>` |
| Scope / Usage / Constraint paragraphs (when lengthy) | `<remarks>` |
| Cross-references to related types or messages | `<seealso cref="..."/>` |

### What must be on every generated type

**Message record (class):**
```csharp
/// <summary>
/// {ISO primary description — the first sentence or the "Scope" intro.}
/// </summary>
/// <remarks>
/// {Full ISO Usage / Scope text, preserved verbatim, as many paragraphs as needed.}
/// </remarks>
[Description(@"Scope|{ISO pipe-delimited full text}")]
[IsoId("...")]
[DisplayName("...")]
public record MyMessageV01 : IOuterRecord { ... }
```

**Message property:**
```csharp
/// <summary>
/// {Verbatim ISO field description — NOT just the display name.}
/// </summary>
[IsoId("...")]          // present on properties in older files; may be omitted in newer style
[DisplayName("...")]
[IsoXmlTag("...")]
public required SomeType MyField { get; init; }
```

**Component record and its properties:** same rules — class gets the ISO component description,
each property gets the ISO element description.

**Codeset enum and its members:** same rules — enum gets the ISO code-set description, each
`[EnumMember]`-decorated value gets the ISO code description.

### Where to source the descriptions

Use the ISO 20022 MCP server tools:
- `universal_lookup` — returns full spec text for a named artifact (message, component, element,
  code set, code value).
- `get_data_type_members_snapshot` — bulk element descriptions for a component.
- `get_code_set_details` — full descriptions for a code set and its values.

Always fetch descriptions from the MCP server rather than guessing or deriving them from names.
If a description cannot be retrieved, leave a `// TODO: fetch ISO description via MCP` comment
rather than fabricating one.

#### Exception: primitives defined by an external (non-ISO-20022) standard

Some ISO 20022 `IdentifierSet` primitives (SEDOL, CUSIP, Valoren, WKN/Wertpapier, etc.) are
identifiers whose *own* structure — length, character set, and especially check-digit algorithms —
is defined by an external standards body (LSE, CUSIP Global Services, SIX Financial Information,
Wertpapier Mitteilungen...), not by ISO 20022 itself. ISO 20022's own text for these is often a
one-line description with no format detail at all; MCP has nothing more to give.

For these — and only these, i.e. types where the *format itself* originates outside ISO 20022, not
ordinary ISO 20022 elements — it's acceptable to research the external standard directly (web
search, published algorithm references) rather than stop at "MCP has nothing." Requirements:

- **Cite the source.** Every fact pulled from outside MCP (pattern, length, check-digit algorithm)
  gets an XML-doc `<remarks>` note and/or inline comment naming where it came from (organization,
  document, or URL) — so a future maintainer can verify or update it without redoing the research.
- **Check digits are verified and can be generated.** If the external standard defines a check
  digit, the struct validates it on construction when a full value (core + check digit) is
  supplied, and computes+appends it automatically when only the core is supplied. Expose the
  parts as separate `Core` and `CheckDigit` properties alongside the full `Value`.
- **When the external standard can't be pinned down, stay permissive and say so.** Not every one
  of these turns up a usable public spec (some are obscure legacy national schemes with no
  findable documentation). When that happens, keep the pattern permissive (e.g. "non-empty
  string") rather than guessing at structure, and leave a comment stating that external
  verification was attempted and came up empty — so it reads as "investigated, not overlooked."
  Same principle applies to genuinely uncertain details within an otherwise-known standard: default
  to the more permissive interpretation and comment the doubt for later tightening. A pattern is
  easy to tighten later; it's a breaking change to loosen one after consumers depend on it.
- **Recognize when a type isn't actually a checksummed identifier at all.** Some `IdentifierSet`
  members that look superficially similar (e.g. credit-rating symbols, hierarchical classification
  codes) aren't numbered identifiers with check digits — don't force the `Core`/`CheckDigit` shape
  onto something that isn't structured that way.

#### Exception: primitives defined by a W3C standard

Some ISO 20022 primitives are directly W3C XSD builtins or map one-to-one onto a W3C-defined
concept (`xs:anyURI`, `xs:duration`, `xs:QName`, and similar). Where the .NET BCL already ships a
type for the underlying W3C standard (e.g. something in `System.Xml`), it's fine to alias straight
to that existing type in `GlobalUsings.cs` instead of hand-writing a new `IIsoSimpleValue<T>`
wrapper struct — no need to reinvent parsing/validation the framework already gets right.

- This can point the alias at a **class**, not just a struct — some `System.Xml` types are
  reference types. That's fine; the ISO primitives template's "always a `readonly struct`" rule is
  specifically about hand-written `IIsoSimpleValue<T>` wrappers, not about this exception.
- A type aliased this way won't implement `IIsoSimpleValue<T>` and won't throw
  `Iso20022FormatException` — it relies on the BCL type's own parsing/validation/serialization
  instead. Note that in a comment on the alias line so it's clear the type is intentionally outside
  the usual contract-test/serializer plumbing, not an oversight.
- Still verify the mapping is actually correct for the specific ISO 20022 primitive (e.g. does the
  BCL type's wire format match what ISO 20022 expects on the XML/JSON side?) before aliasing —
  this exception is about not re-implementing a solved problem, not about skipping verification.

#### Class-typed properties and hierarchical record equality

Message and component types are `record`s specifically so that `==`/`Equals` gives correct
hierarchical, structural equality without hand-written comparison code. That guarantee comes from
the compiler-synthesized `Equals`/`GetHashCode`, which calls `EqualityComparer<T>.Default` on every
property — **struct or class, it makes no difference to the mechanism.** Our `IIsoSimpleValue<T>`
structs work with this because every one of them implements `IEquatable<T>` with real value
comparison; that's *why* the struct convention is safe, not because it's a struct per se. A `class`
property (from the W3C exception above, or a hand-modeled type for embedded/raw XML content) goes
through the exact same mechanism — it only preserves the record's equality guarantee if that class
itself overrides `Equals`/`GetHashCode` for value semantics. If it doesn't (falls back to
`object.Equals`, i.e. reference identity), the record's `==` silently breaks for that property: two
records built from byte-identical input, but holding two separately-constructed instances of that
class, compare unequal — with no compiler warning, since it type-checks fine.

**Before embedding any class-typed property in a record, verify from the actual source, not just
documentation, whether it implements value equality.** Docs can be wrong: `XmlQualifiedName`'s own
Microsoft Learn page states `Equals` "returns true if the two are the same instance object"
(reference equality) — the real shipped implementation
(`dotnet/runtime`'s `XmlQualifiedName.cs`) does a proper `Name`+`Namespace` value comparison with a
reference-equality fast path first. Trusting the doc page over the source would have been wrong.
Two data points already checked, to save re-deriving them:
- `System.Xml.XmlQualifiedName` — value equality confirmed from source. Safe to embed directly.
- `System.Xml.Linq.XElement` / `XNode` / `XmlElement` — reference equality confirmed (well-documented
  .NET behavior); structural comparison is opt-in only via `XNode.DeepEquals`/`XNodeEqualityComparer`,
  and even that has known rough edges (namespace-prefix-vs-default-namespace and attribute-ordering
  differences read as "not equal" despite being semantically identical XML — see
  [Equality Semantics of LINQ to XML Trees](https://learn.microsoft.com/en-us/archive/blogs/ericwhite/equality-semantics-of-linq-to-xml-trees)).
  **Not safe to embed without one of the mitigations below.**

When a class-typed property does *not* have value equality (most likely scenario: a component that
carries embedded/raw XML content — e.g. `ExternalSchema/LaxPayload.cs`, `SignatureEnvelope.cs`,
`ATICALaxProcessing.cs`, currently unimplemented stub records with no properties yet), pick one,
in order of preference:

1. **Override `Equals`/`GetHashCode` on that record explicitly**, using `XNode.DeepEquals` (or a
   canonicalized-string comparison if robustness to `DeepEquals`'s prefix/attribute-order
   sensitivity matters) instead of letting the compiler synthesize member-wise equality for that
   property.
2. **Store canonicalized XML as a `string`** inside an `IIsoSimpleValue<string>` struct wrapper
   instead of holding a live `XElement`/`XmlElement` graph — gets correct record equality for free
   via the normal struct convention, at the cost of losing in-place LINQ-to-XML querying (a
   consumer parses the string on demand instead).
3. **Accept reference equality, but document it.** Not a disaster on its own — but say so
   explicitly in the type's `<remarks>` (e.g. "Equality for this property is reference-based; two
   instances with identical XML content are not guaranteed to compare equal") so it reads as a
   deliberate, acknowledged tradeoff instead of a silent gap someone finds the hard way, debugging
   a failing `Assert.Equal` months later.

### Historical gap

Files written during snapshot syncs prior to 2026-06 were often written without verbatim
descriptions — properties received only the display name as their `<summary>`, and class-level
`[Description(...)]` attributes were omitted. These files must be corrected as they are
encountered. The correct reference style is shown in the older auto-generated files such as
`MessageDefinitions/setr/RedemptionOrderV04.cs`.

## Build Commands

```bash
# Build the whole solution (both TFMs, all projects)
cd src && dotnet build iso20022.sln

# Build the library for Release/publish verification
cd src && dotnet build BeneficialStrategies.Iso20022.Common -c Release
```

### Target Framework Policy

**Multi-target the two most recent .NET LTS releases** — deliberately *LTS releases*, not the two
most recent version numbers. .NET alternates LTS (even-numbered, 3-year support) and STS
(odd-numbered, 24-month support) every November. Tracking raw version numbers instead of LTS
status causes needless churn: an STS release reaches end-of-support around the same time as the
LTS release two versions behind it, and the next LTS release would force dropping a still-fully-supported
older LTS a year early just to make room. Concretely as of 2026-08: **net8.0 + net10.0** (net9.0,
an STS release, is skipped entirely — it reaches end-of-support 2026-11-10, the same day as
net8.0). When .NET 12 (LTS) ships in November 2027, the policy becomes net10.0 + net12.0, dropping
net8.0 (by then over a year past its own end-of-support) — not net11.0 + net12.0.

This applies identically to `BeneficialStrategies.Iso20022`, `BeneficialStrategies.Iso20022.FluentValidation`,
and both test projects — **test projects multi-target the same TFMs as the library they test**,
not just the newest one. Source is identical across TFMs, but source-identical does not guarantee
runtime-identical: BCL default behavior (JSON serialization, globalization/culture formatting,
regex engine internals) has changed across major .NET versions before, and for a financial-data
library a format drifting by one runtime is a real-money bug, not a style issue. A test project
that only runs on the newest TFM never actually *executes* the older-TFM build, only compiles it.

`src/global.json` pins the SDK's major version to the newer of the two targets (`rollForward:
latestMinor` — matches the existing convention, just bumped). A single newer SDK can always build
older TFM outputs via downloaded reference packs; you don't need multiple SDKs installed side by
side just to build (CI only installs one). You do need the older runtime installed locally to
*run* tests against it, which the `dotnet-install` / SDK installer already provides alongside the
SDK.

**Package versions are unified** across `BeneficialStrategies.Iso20022` and
`BeneficialStrategies.Iso20022.FluentValidation` via `src/Directory.Build.props` (`<Version>` and
the rest of the shared package metadata) — see "Multi-Package Repository Strategy" below for why.

### Build Performance (Known, Not a Misconfiguration)

A clean or touch-any-file build of `BeneficialStrategies.Iso20022.Common` takes roughly 80-100
seconds **per TFM** — confirmed via `-clp:PerformanceSummary` to be almost entirely the `Csc` task
itself (~80s), not restore (~3.5s) or anything else. This is inherent to compiling one ~24,000-file
single-assembly project — Roslyn recompiles the whole assembly on any change (C# has no true
per-file incremental compilation within one project), and this project's "everything in one
package" design means that's ~24K files, not a handful. It is not a flag you can toggle away
without restructuring into multiple smaller assemblies, which is a real architectural trade-off
(current design vs. more, smaller published surface) — not something to do casually as a build-speed
fix.

Practical mitigations for interim/dev-loop builds (all confirmed against this repo, not
theoretical):
- **Build only the one project you're iterating on**, not the whole solution:
  `dotnet build BeneficialStrategies.Iso20022.Common`, not `dotnet build iso20022.sln`.
- **Build a single TFM while iterating**, not both: `dotnet build -f net8.0` (or whichever you're
  actively targeting). Now that the library multi-targets two TFMs, building both on every save
  doubles the ~80-100s cost for no benefit until you're actually checking cross-TFM behavior.
  Reserve full multi-TFM builds/tests for pre-commit verification (this is exactly the difference
  between the day-to-day workflow used throughout this project's history and the
  `snapshot-sync-verify` skill's Milestone builds, which intentionally use `--no-incremental` and
  build everything for an accurate final signal).
- **`--no-restore`** on repeat invocations within a session saves the ~3.5s restore tax when
  dependencies haven't changed — small, but free.
- Test *execution* itself is not the bottleneck (the full 6,600+ test suite runs in ~1 second) —
  only the build that precedes it is slow. `dotnet test --filter` to a narrower set doesn't
  meaningfully speed up your local loop; skipping unnecessary rebuilds does.

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
└── MessageDefinitions/  # Top-level message type files
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

**Messages** (`MessageDefinitions/[area]/MessageName.g.cs`):
- Implement `IOuterRecord` interface
- Include `IsoIdentifier` constant (e.g., `"pain.001.001.11"`)
- Rich XML documentation from ISO spec

**Choice Types** (`Choices/[ChoiceName]/`):
- Abstract base: `Choices/{ChoiceName}_.cs` — `public abstract record {ChoiceName}_` in namespace `BeneficialStrategies.Iso20022.Choices`, with `[KnownType]` and `[JsonDerivedType]` attributes referencing `{ChoiceName}.{VariantName}` (namespace-qualified, no underscore on the namespace)
- Variants: `Choices/{ChoiceName}/{VariantName}.cs` — standalone (non-nested, non-partial) records in namespace `BeneficialStrategies.Iso20022.Choices.{ChoiceName}`, each inheriting `{ChoiceName}_`
- The sub-namespace isolates common names (`Code`, `Other`, `IBAN`, etc.) that would otherwise clash across choice types
- Single-value variants: `[IsoId]`+`[DisplayName]` on class, `[IsoXmlTag]` on `Value` property only
- Multi-field variants: `[IsoId]`+`[DisplayName]`+`[IsoXmlTag]` on class, each property has its own attributes

**Codesets** (`Codesets/[Name]Code.g.cs`):
- Enums with `[EnumMember]` and `[IsoId]` attributes
- Versioned codes (e.g., `PaymentMethod3Code`)

### ISO Simple Value Primitives — Non-Negotiable Design Pattern

**An empty `enum` is never an acceptable type for a field in this library.** If a user cannot
assign a value to a `required` property, the library is broken — full stop.

All ISO 20022 primitive types that carry constraints (pattern, length, range, character set) are
represented as `readonly struct` wrappers implementing `IIsoSimpleValue<T>`. This covers:

- External code sets (open-value registries like `ExternalBankTransactionDomainCode`)
- Spec-fixed string types (`BICIdentifier`, `IBANIdentifier`, `Max35Text`, etc.)
- Decimal types with range/precision constraints (`IsoDecimal`, etc.)
- Binary types for cryptographic material (`SignatureValue`, `DigestValue`, etc.)

#### Interface Hierarchy (`Framework/`)

```
IIsoSimpleValue<T>          — base: any ISO primitive wrapping a CLR value of type T
  IIsoExternalCode          — semantic marker: value list is an external ISO registry
```

`IIsoSimpleValue<T>` is the serialization hook. Both `Iso20022XmlSerializer` and
`Iso20022ExternalCodeJsonConverter<T>` detect this interface to treat the type as a scalar.
Implementing the interface is what registers correct serialization behavior — no per-type
XML attribute is needed.

#### Struct Template

Every primitive struct follows this exact shape. Replace `MyCode`, `string`, `Pattern`,
and the `[IsoId]`/`[Description]` values:

```csharp
[DataContract]
[Serializable]
[IsoId("...")]
[Description(@"...")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<MyCode>))]   // string types
public readonly struct MyCode : IIsoExternalCode, IEquatable<MyCode>
{
    /// <summary>ISO 20022 format constraint for this type.</summary>
    public const string Pattern = @"^[A-Z0-9]{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <exception cref="Iso20022FormatException">Value does not satisfy <see cref="Pattern"/>.</exception>
    public MyCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(MyCode), value, Pattern);
        Value = value;
    }

    public static bool TryCreate(string value, [NotNullWhen(true)] out MyCode result)
    {
        if (Regex.IsMatch(value, Pattern)) { result = new(value); return true; }
        result = default;
        return false;
    }

    public static implicit operator MyCode(string value) => new(value);
    public static implicit operator string(MyCode code) => code.Value;

    public override string ToString() => Value ?? string.Empty;

    public bool Equals(MyCode other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is MyCode other && Equals(other);
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public static bool operator ==(MyCode a, MyCode b)    => a.Equals(b);
    public static bool operator !=(MyCode a, MyCode b)    => !a.Equals(b);
    public static bool operator ==(MyCode a, string? b)   => a.Value == b;
    public static bool operator !=(MyCode a, string? b)   => a.Value != b;
    public static bool operator ==(string? a, MyCode b)   => a == b.Value;
    public static bool operator !=(string? a, MyCode b)   => a != b.Value;
}
```

**For `IIsoSimpleValue<decimal>` types:** the constructor receives a `decimal` (not a string).
The XML serializer parses text → `decimal.Parse()` → passes to the constructor. The constructor
then applies ISO-specific constraints (min/max, scale).

**For `IIsoSimpleValue<byte[]>` types** (digital signatures, digests, certificates): the
constructor receives a `byte[]`. The XML serializer base64-decodes → passes to constructor.
These types may have additional behavioral contracts (e.g. minimum length, OID validation)
tested separately.

#### Hybrid Pattern: External Code Set With Known Members

Some `IIsoExternalCode` types are classified by the ISO 20022 data dictionary as an **external
code set** ("codes maintained outside ISO 20022" — the registry can add new codes without a new
ISO 20022 schema version) **and yet the MCP server's `get_code_set_details` tool still returns a
concrete, named member table for them** (fetched from a secondary published external-registry
file, not just the base repository). `ExternalAuthenticationMethod1Code` is the first confirmed
example: 68 named codes with full definitions, despite being formally external.

**Always verify this per type — don't assume.** Call `get_code_set_details` and check whether the
response actually contains member rows. Many external code sets genuinely have no data available
via MCP; those stay a plain open struct per the template above, nothing more. Only apply this
hybrid when MCP demonstrably returns members.

**When it does, do not convert the type to a closed `enum`.** The struct must stay exactly as
open as the base template — same `(string)` constructor validating only length/pattern, same
`TryCreate`, same implicit operators — because the "external code set" classification means a
registry addition next month is a valid ISO 20022 value with zero schema-version signal. A closed
`enum` would reject that value outright: a real interoperability bug, not a theoretical one.

**Instead, add the known members as `public static readonly` named instances alongside the open
struct** — giving IntelliSense/compile-time-friendly discoverability for the values known today,
without narrowing what the constructor accepts:

```csharp
public readonly struct MyExternalCode : IIsoExternalCode, IEquatable<MyExternalCode>
{
    // ... Pattern, Value, constructor, TryCreate, operators — unchanged from the base template ...

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Serial Number of the acceptor's certificate.</summary>
    [IsoId("_w_NQIbJSEe-rYMhHpAEI4A")]
    [Description(@"Serial Number of the acceptor's certificate.")]
    public static readonly MyExternalCode AcceptorCertificateSerialNumber = new("ACSN");

    // ... one such field per member MCP returned ...
}
```

Preserve, per member, everything the equivalent `enum` member would have carried: the field name
(matches the original enum member identifier — least astonishment, no reason to rename), the
verbatim `<summary>`/`[Description]` text (same non-negotiable rule as any other public member —
see "XML Documentation" above), and `[IsoId]` set to that specific **code's own** id from the MCP
table (not the codeset's id, which belongs on the type-level `[IsoId]` instead).

**Retrofit sweep of pre-existing conversions — done 2026-08-13, re-confirmed 2026-08-16, both came
back empty.** All 35 `IIsoExternalCode` structs converted before this pattern was identified (the
original Batch 1 primitives pass, plus a handful of other Bucket B types) were individually
re-checked against `get_code_set_details` on two separate occasions, 3 days apart. Both times every
one returned zero member rows — none had unused data to retrofit, so all 35 are confirmed already
in their correct final form (plain open struct, no known-value constants; nothing missing, nothing
still an enum). Full list: `BusinessMessagePriorityCode`, `CountryCode`, `CountrySubDivisionCode`,
`EuroCurrencyCode`, `UnicodeChartsCode`, `ExternalClearingSystemMemberCode_Obsolete`, and 29
`External*Code`/`External*1Code` pairs (bank-transaction domain/family/sub-family, card-transaction
category, cheque-agent instruction, communication format, credit-line type, entity size/type,
financial-institution identification, financial-instrument product type, industry-sector
classification, mandate-setup reason, payment-scenario). If the MCP snapshot is ever refreshed with
new external-registry data, this sweep is worth re-running — `get_code_set_details` per type, same
as before.

#### Serialization Contract

| Layer | String types | Decimal types | Binary types |
|---|---|---|---|
| XML | `IIsoSimpleValue<string>` detected → text content | `IIsoSimpleValue<decimal>` → `decimal.Parse()` → ctor | `IIsoSimpleValue<byte[]>` → Base64 decode → ctor |
| JSON | `[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<T>))]` on class | Same converter, generic over T | Same converter |
| Error | `Iso20022FormatException` from ctor → wrapped as `JsonException` / `InvalidOperationException` | ← same | ← same |

#### Contract Test Registration

Every `IIsoSimpleValue<T>` type must have an entry in the contract test data source in
`Codesets/SimpleValueContractTests.cs`. The test verifies: valid construction, invalid
construction throws `Iso20022FormatException`, `TryCreate` both paths, struct/struct equality,
struct/value equality, `ToString`, JSON round-trip, XML round-trip via the serializer.

Adding a new primitive = one new entry in the data dictionary. A meta-test fails if any
`IIsoSimpleValue<T>` type in the assembly is missing from the dictionary.

Special types with additional behavioral requirements (binary, signatures) still participate
in the base contract test and add their own test methods alongside it.

#### Before writing or modifying any primitive type, verify

1. Is it an `enum` with zero members? → Must be converted to `readonly struct`.
2. Does the struct implement `IIsoSimpleValue<T>` (or `IIsoExternalCode`)? → Required.
3. Does the constructor validate and throw `Iso20022FormatException` on failure? → Required.
4. Are all six equality operators present (struct/struct and struct/T)? → Required.
5. Is there an entry in the contract test data source? → Required.

### Key Interfaces (Framework/)

- `IOuterRecord` - All top-level messages
- `IOuterDocument` - XML document wrapper
- `IIsoXmlSerializable` - Serialization contract
- `IIsoSimpleValue<T>` - All ISO primitive value wrappers (string, decimal, byte[], Uri)
- `IIsoExternalCode` - Semantic sub-interface of `IIsoSimpleValue<string>` for external registry types
- `Iso20022FormatException` - Thrown when a value violates an ISO format constraint

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
