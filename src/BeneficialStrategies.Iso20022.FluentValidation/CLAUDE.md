# BeneficialStrategies.Iso20022.FluentValidation

FluentValidation validators for all 3,311 ISO 20022 message types.
Companion package to `BeneficialStrategies.Iso20022`.

## Purpose

Messages must be 100% specification-compliant before transmission.
Incoming messages should be validated and rejected before processing if invalid.
Each validator is derived directly from the ISO 20022 specification via the MCP server —
not from the C# data annotations, which are incomplete.

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
| Message validator | `{MessageClassName}Validator` (e.g. `FIToFIPaymentCancellationRequestV10Validator`) |
| Namespace — components | `BeneficialStrategies.Iso20022.Validation.Components` |
| Namespace — messages | `BeneficialStrategies.Iso20022.Validation.{area}` (e.g. `.camt`, `.pacs`, `.pain`) |

## Directory Structure

```
Validators/
├── Components/                    # Reusable component validators (shared across messages)
│   ├── CaseAssignment5Validator.cs
│   ├── Case5Validator.cs
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
