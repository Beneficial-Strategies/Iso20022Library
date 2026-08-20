# Beneficial Strategies ISO20022 FluentValidation Library

This project contains [FluentValidation](https://docs.fluentvalidation.net/) validators for the message domain model published in [`BeneficialStrategies.Iso20022`](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) — 1,066 validators covering top-level messages, message components, choice types, and external code sets, generated from and cross-checked against the ISO 20022 specification.

## Welcome!

`BeneficialStrategies.Iso20022` gives you a strongly-typed, compiler-enforced rendering of ISO 20022 messages in memory — but the C# type system can only express so much. Some ISO 20022 rules are cross-field ("a case identification may appear in at most one of three possible locations") or depend on runtime data the compiler can't see. This package is the follow-on project that covers that ground: validators that check field-level constraints and cross-field business rules the record types themselves cannot enforce.

Coverage today:
- **155 validators** — full ISO 20022 spec-compliance coverage (field-level constraints and cross-field rules), including 4 top-level messages validated completely, top to bottom, with zero exceptions anywhere in their reachable graph: `FIToFIPaymentCancellationRequestV10` (camt.056), `CancelCaseAssignmentV05` (camt.032), `RequestForDuplicateV07` (camt.033), and `MandateCopyRequestV04` (pain.017).
- **911 validators** — abbreviated coverage. These currently only enforce a known minimum-collection-size gap (some `required`-looking collections were generated with no lower bound, so an empty collection compiles but violates the spec); they have not yet been reviewed for the remaining field-level constraints and cross-field rules a full validator would cover.

Every validator — full or abbreviated — carries an XML doc `<remarks>` block naming exactly which spec constraints it currently checks, so you always know what you're getting from a specific type, not just its category.

Known limitations:
- No composite message-level validator yet for most business areas — validators exist per component (and per full message for the 4 messages above); you compose them yourself for now via `SetValidator()` where needed.
- Abbreviated validators (see above) are not yet a complete spec-compliance check.

For more information about the project, see [the repository](https://github.com/Beneficial-Strategies/Iso20022Library).

This is provided free of charge under a very non-restrictive license as a good-faith contribution to the community. This library is a working proof of concept built using Claude Code and the [Beneficial Strategies ISO20022 MCP server](https://beneficialstrategies.com/product/mcp-server/).

If you have questions or concerns about the implementation, please send developer comments or questions to [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com).

## Trying out the library

```bash
mkdir test
cd test
dotnet new console
dotnet add package BeneficialStrategies.Iso20022 --version 0.6.1-alpha
dotnet add package BeneficialStrategies.Iso20022.FluentValidation --version 0.6.1-alpha
```

Open your `Program.cs` and paste the following. This validates `camt.056.001.10` (FIToFIPaymentCancellationRequest) — one of the full-spec-compliance validators — first against a well-formed message, then against one that violates a cross-field rule no C# type could express on its own:

```C#
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices.Party40Choice;
using BeneficialStrategies.Iso20022.Validation.camt;

var validator = new FIToFIPaymentCancellationRequestV10Validator();

// A well-formed cancellation request.
var request = new FIToFIPaymentCancellationRequestV10
{
    Assignment = new CaseAssignment5
    {
        Identification = "CASE-2026-0001",
        Assigner = new Agent { FinancialInstitutionIdentification = new() { BICFI = "AAAAGB2L" } },
        Assignee = new Agent { FinancialInstitutionIdentification = new() { BICFI = "BBBBUS33" } },
        CreationDateTime = new DateTime(2026, 8, 17, 9, 0, 0),
    },
    Underlying = new UnderlyingTransaction28
    {
        TransactionInformation = [new PaymentTransaction137()],
    },
};

var result = validator.Validate(request);
Console.WriteLine($"IsValid={result.IsValid}"); // True

// The same message, but with a case identification present at both the message level
// and the transaction level — a spec rule (MessageOrGroupCaseRule) that no property type
// alone can enforce, since both locations are individually optional.
var invalidRequest = request with
{
    Case = new Case5
    {
        Identification = "CASE-2026-0001",
        Creator = new Agent { FinancialInstitutionIdentification = new() { BICFI = "AAAAGB2L" } },
    },
    Underlying = new UnderlyingTransaction28
    {
        TransactionInformation =
        [
            new PaymentTransaction137
            {
                Case = new Case5
                {
                    Identification = "CASE-2026-0001",
                    Creator = new Agent { FinancialInstitutionIdentification = new() { BICFI = "AAAAGB2L" } },
                },
            },
        ],
    },
};

var invalidResult = validator.Validate(invalidRequest);
Console.WriteLine($"IsValid={invalidResult.IsValid}"); // False
foreach (var error in invalidResult.Errors)
{
    Console.WriteLine($"  {error.PropertyName}: {error.ErrorMessage}");
}
// MessageOrGroupCaseRule: Case identification must appear in at most one location: message-level
// Case, Underlying.OriginalGroupInformationAndCancellation.Case, or
// Underlying.TransactionInformation.Case (MessageOrGroupCaseRule / MessageOrTransactionCaseRule).
```

## Registering validators with dependency injection

Constructing one validator with `new` is fine for a quick check, but every validator in this
package composes its children via constructor injection — the two-constructor pattern you'll see
throughout the source (a DI constructor taking `IValidator<T>` for each child, and a parameterless
convenience constructor for exactly the kind of one-off use above). `AddIso20022Validators()`
registers all of them at once with a standard `IServiceCollection`:

```C#
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Validation;
using BeneficialStrategies.Iso20022.Validation.camt;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddIso20022Validators();
using var provider = services.BuildServiceProvider();

var validator = provider.GetRequiredService<IValidator<CancelCaseAssignmentV05>>();
```

Registering every validator in the assembly is the simplest option, but not always the leanest —
three narrower overloads are available when you know your scope up front:

```C#
// Only validators for a specific ISO 20022 business area (plus whatever shared component/choice
// validators those messages actually depend on — never fewer than that, so nothing breaks).
services.AddIso20022Validators(businessAreas: ["camt", "pain"]);

// The exact transitive closure one specific message needs — nothing more, nothing approximated.
// Computed via reflection over the validators' own constructors, not a namespace guess.
services.AddIso20022Validators(rootTypes: [typeof(CancelCaseAssignmentV05)]);

// A raw predicate over each concrete validator type, for anything the two above don't cover.
services.AddIso20022Validators(filter: validatorType => validatorType.Namespace!.EndsWith(".camt"));
```

`rootTypes` is the tightest of the three — it registers precisely what the given message(s) need,
computed by walking each validator's own dependency-injection constructor. It's the one to reach
for if you're only ever validating a known, fixed set of message types and want to avoid
registering the other 1,000+ validators in the assembly you'll never resolve.

## External code set validation

Some ISO 20022 fields — country codes, currency codes, and ISO 20022's own externally-maintained
code lists — are only checked for *format* by the type itself (`CountryCode`'s constructor
enforces "two uppercase letters," for example, not "is an actual assigned country"). The
acceptable values for these live in a registry maintained outside this library — sometimes an
external standard like ISO 3166, sometimes your own reference-data table — and this package gives
you a pluggable way to check against it: `IExternalCodeRegistry<TCode>`, one per code set type,
defaulting to an in-memory implementation you populate.

`AddIso20022Validators()` already registers the in-memory default for every external code type in
one line — you don't need to do anything for validation to run, but by default an unpopulated code
set is **permissive** (nothing to check against, so nothing gets rejected on that basis). To
actually restrict `CountryCode` to a specific set of countries, construct a registry, populate it,
and register the instance:

```C#
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Validation;

var countries = new InMemoryExternalCodeRegistry<CountryCode>();
countries.Add("US");
countries.Add("CA");
countries.Add("KP");    // added first, then...
countries.Remove("KP"); // ...reconsidered and taken back out.

services.AddIso20022Validators();
services.AddSingleton<IExternalCodeRegistry<CountryCode>>(countries);
using var provider = services.BuildServiceProvider();

var validator = provider.GetRequiredService<IValidator<CountryCode>>();
Console.WriteLine(validator.Validate((CountryCode)"US").IsValid); // True
Console.WriteLine(validator.Validate((CountryCode)"KP").IsValid); // False — removed above
Console.WriteLine(validator.Validate((CountryCode)"FR").IsValid); // False — never added
```

Some external code types (the ones ISO 20022's own registry snapshot had known values for) start
pre-populated automatically — `Add`/`Remove` still work the same way, adjusting the seeded set
rather than starting from nothing.

If populating a fixed list isn't enough — you want a rule of your own layered on top, or values
that come from a database instead of an in-memory set — subclass `InMemoryExternalCodeRegistry<TCode>`
and override `IsAcceptable`. It's declared `virtual` specifically for this:

```C#
public class EmbargoedCountryRegistry : InMemoryExternalCodeRegistry<CountryCode>
{
    private static readonly HashSet<string> Embargoed = ["KP", "IR", "SY"];

    public override bool IsAcceptable(CountryCode value) =>
        base.IsAcceptable(value) && !Embargoed.Contains(value.Value);
}
```

```C#
services.AddIso20022Validators();
services.AddSingleton<IExternalCodeRegistry<CountryCode>, EmbargoedCountryRegistry>();
using var provider = services.BuildServiceProvider();

var validator = provider.GetRequiredService<IValidator<CountryCode>>();
Console.WriteLine(validator.Validate((CountryCode)"US").IsValid); // True  — base is permissive
Console.WriteLine(validator.Validate((CountryCode)"KP").IsValid); // False — rejected by the override
```

Register your override *after* `AddIso20022Validators()` — the last registration for a given
service type wins, so this replaces the in-memory default for `CountryCode` only; every other
external code type keeps using it.
