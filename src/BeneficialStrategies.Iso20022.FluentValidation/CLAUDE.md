# BeneficialStrategies.Iso20022.FluentValidation

FluentValidation validators for all 3,311 ISO 20022 message types.
Companion package to `BeneficialStrategies.Iso20022`.

## Purpose

Messages must be 100% specification-compliant before transmission.
Incoming messages should be validated and rejected before processing if invalid.
Each validator is derived directly from the ISO 20022 specification via the MCP server —
not from the C# data annotations, which are incomplete.

## Coverage Scoping Policy (which messages get full-spec validators)

Full-spec coverage is scoped by **top-level message currency**, not by which components happened
to already have multiplicity data on hand. For each message family within a business area:

- Support full-spec validation for the newest **Registered** version.
- Also support the newest **Provisionally Registered** version, if one exists newer than the
  latest Registered version.
- Older versions are out of scope for full-spec upgrade (they may still carry abbreviated
  validators from earlier work — that's fine, just not a priority to deepen).

A top-level message is only "fully supported" once every component and choice type reachable from
it — transitively, all the way down — has its own full-spec validator wired in via
`.SetValidator()`. This means the real backlog is *whatever the latest messages in each business
area actually reference*, not a fixed alphabetical or convenience-ordered slice of
`Validators/Components/`.

### Registration status verification

`RegistrationStatus` (`Registered` / `Provisionally Registered` / etc.) comes from the ISO 20022
MCP server (`universal_lookup` on the message's ISO ID) — it is **not** tracked anywhere in this
repository's generated code, so it can't be read off the C# source. The highest version number
present in `MessageDefinitions/{area}/` is usually the latest Registered version — spot-checked via
MCP for `camt.056` (`FIToFIPaymentCancellationRequest`) and `pain.001`
(`CustomerCreditTransferInitiation`) on 2026-08-19: both confirmed `Registered` with no
`nextVersions` pointer (i.e. nothing newer exists in the repository). That's a useful proxy, not a
guarantee — spot-check via MCP when scoping a new business area rather than assuming the highest
local version number is always correct; a family could have its highest version still
Provisionally Registered while an earlier one is the true latest Registered version, in which case
both are in scope per the policy above.

### Build order: shared foundation first

The transitive dependency graph out of top-level messages is heavily skewed: a handful of
component/choice types (`SupplementaryData1`, `PostalAddress27`,
`BranchAndFinancialInstitutionIdentification8`, country/address/party choice types, etc.) are each
referenced by dozens of different messages, while most types are referenced by only one or two.
When scoping a new business area (or expanding an existing one), build the shared, high-reuse
types first — this unlocks the largest fraction of the message graph per unit of validator-authoring
effort, and every message built afterward mostly composes existing pieces via DI rather than
starting from scratch. To find what to build next, do a transitive BFS from each in-scope
top-level message's record type over its `Component`/`Choice`-typed properties, count how many
messages reach each type, and rank by reuse count descending.

## Adding a New Validator

### Step 1 — Query the spec via MCP

For each message and its components, call `show_item_details` to get the authoritative
spec table (multiplicities, types, constraints, patterns):

```
show_item_details("pain.001.001.12")         # message building blocks + constraints
show_item_details("CreditTransferTransaction61")  # component elements with Min/Max
show_item_details("Max35Text")               # string constraint: MinLength=1, MaxLength=35
show_item_details("UUIDv4Identifier")        # pattern: [a-f0-9]{8}-...-4...-[89ab]...-...
```

### Step 2 — Create component validators first

Place in `Validators/Components/{ComponentName}Validator.cs`.
Namespace: `BeneficialStrategies.Iso20022.Validation.Components`.

One validator class per ISO 20022 component. Component validators are **reused** across
multiple message validators — do not duplicate them.

### Step 2b — Create choice validators

Place in `Validators/Choices/{ChoiceName}_Validator.cs` (the trailing underscore matches the
model type's own name — `{ChoiceName}_`). Namespace: **`BeneficialStrategies.Iso20022.Validation.ChoiceValidators`**
— deliberately *not* `Validation.Choices`, even though that would match the `Components`/`camt`/
`pain` naming pattern. `Validation.Choices` collides with the model's own
`BeneficialStrategies.Iso20022.Choices` namespace: C# resolves an unqualified `Choices.Foo`
reference inside `BeneficialStrategies.Iso20022.Validation.Components` by checking sibling
namespace `BeneficialStrategies.Iso20022.Validation.Choices` *before* falling back to the
`using BeneficialStrategies.Iso20022.Choices;` global using — so the moment that sibling namespace
exists at all, every pre-existing `Choices.SomeChoiceType.Variant` reference elsewhere in the
project silently starts resolving to the wrong namespace and fails to compile. Confirmed by
hitting this exact break when the namespace was first introduced (2026-08-19) — `ChoiceValidators`
avoids the collision entirely since no model sub-namespace shares that name.

Validating a choice type is validating *which concrete variant is present and what it carries* —
FluentValidation's `SetInheritanceValidator` (`RuleFor(x => x).SetInheritanceValidator(v => v.Add(...))`)
is the idiomatic tool: build one small `InlineValidator<TVariant>` per variant (DI-injected with
the validator for that variant's nested `Value`, where it has one), and register each with
`v.Add(variantValidator)` — type inference picks the right variant type from the `InlineValidator<TVariant>`
argument. See `Party50Choice_Validator` for the reference example (both variants wrap a real,
fully-validated component).

**Not every choice type needs full `SetInheritanceValidator` dispatch.** When every variant's
payload is either a closed codeset enum, an `IIsoExternalCode` struct, or a scalar
`IIsoSimpleValue<string>` field — i.e. already fully enforced at the struct level with nothing left
for FluentValidation to add — the validator can be an empty `AbstractValidator<T>` with no rules
(see `AddressType3Choice_Validator`, `Authorisation1Choice_Validator`, etc.). It still exists as a
first-class type — don't skip creating the file — so the coverage-scoping policy can record the
type as *reviewed and confirmed to need nothing* rather than silently unaccounted for. The same
applies when a variant's payload is itself a component with no validator yet (out of scope for the
current pass, e.g. `Mandate20` via `OriginalMandate10Choice_.OriginalMandate`) — leave the shell
empty with a comment naming the deferred type, exactly like any other "no validator exists yet"
gap elsewhere in this project; don't block finishing the choice type on writing that component too.

### Step 3 — Create the message validator

Place in `Validators/{area}/{MessageName}Validator.cs` (e.g. `Validators/camt/`).
Namespace: `BeneficialStrategies.Iso20022.Validation.{area}`.

Compose component validators via `.SetValidator(new XxxValidator())` and `When(...)`.
Implement message-level cross-field constraints (from the spec "Constraints" section)
as `RuleFor(x => x).Must(...)` with descriptive `.WithName(constraintName)`.

### Step 4 — Create the test file

Place in the Tests project at `Validators/{area}/{MessageName}ValidatorTests.cs`.

Every test file must include:
- A `ValidMessage()` helper returning a fully valid instance
- At least one happy-path test (`ShouldNotHaveAnyValidationErrors`)
- Tests for each required field (null/empty → error)
- Tests for each string length boundary (MaxLength+1 → error, MaxLength → no error)
- Tests for each regex pattern (invalid → error, valid → no error)
- Tests for each cross-field constraint

## Naming Conventions

| Item | Convention |
|------|-----------|
| Component validator | `{ComponentName}Validator` |
| Choice validator | `{ChoiceName}_Validator` (trailing underscore matches the model type name) |
| Message validator | `{MessageClassName}Validator` (e.g. `FIToFIPaymentCancellationRequestV10Validator`) |
| Namespace — components | `BeneficialStrategies.Iso20022.Validation.Components` |
| Namespace — choices | `BeneficialStrategies.Iso20022.Validation.ChoiceValidators` (not `.Choices` — see Step 2b) |
| Namespace — messages | `BeneficialStrategies.Iso20022.Validation.{area}` (e.g. `.camt`, `.pacs`, `.pain`) |

## Directory Structure

```
Validators/
├── Components/                    # Reusable component validators (shared across messages)
│   ├── CaseAssignment5Validator.cs
│   ├── Case5Validator.cs
│   └── ...
├── Choices/                       # Reusable choice validators (namespace: .ChoiceValidators — see Step 2b)
│   ├── Party50Choice_Validator.cs
│   └── ...
├── camt/
│   ├── FIToFIPaymentCancellationRequestV10Validator.cs
│   └── ...                        # one file per message version
├── pacs/
│   └── ...
├── pain/
│   └── ...
└── ...                            # one folder per business area
```

## Spec Encoding Rules

| ISO type | Validation rule |
|----------|----------------|
| `Max35Text` | `MinimumLength(1).MaximumLength(35)` |
| `Max140Text` | `MinimumLength(1).MaximumLength(140)` |
| `Max105Text` | `MinimumLength(1).MaximumLength(105)` |
| `Max15NumericText` | `.Matches(@"^[0-9]{1,15}$")` |
| `UUIDv4Identifier` | `.Matches(@"^[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}$")` |
| `ActiveOrHistoricCurrencyCode` | `.Matches(@"^[A-Z]{3}$")` |
| `ISODateTime` | `.NotEqual(default(DateTime))` |
| `DecimalNumber` / amount | `.GreaterThan(0)` |
| Min=1,Max=1 field | `.NotNull()` + `.NotEmpty()` for strings |
| Min=0,Max=1 field | wrap in `When(x => x.Field is not null, ...)` |

Always anchor regex patterns with `^` and `$`.

## DI Registration

```csharp
// Manual
services.AddScoped<IValidator<FIToFIPaymentCancellationRequestV10>,
                   FIToFIPaymentCancellationRequestV10Validator>();

// Assembly scan (registers all validators in this package at once)
services.AddValidatorsFromAssemblyContaining<FIToFIPaymentCancellationRequestV10Validator>();
```

## Important Notes

- Validators are intentionally **not** generated from Data Annotations on the C# records.
  The spec is the single source of truth; Data Annotations are incomplete and may lag.
- Cross-field constraints from the spec "Constraints" section are implemented in the
  **message validator**, not the component validators.
- Component validators must be stateless and reusable — do not capture mutable state.
- The spec MCP server ISO ID appears in each validator's XML doc comment for traceability.
