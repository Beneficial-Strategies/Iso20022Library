# Beneficial Strategies ISO20022 FluentValidation Library

This project contains [FluentValidation](https://docs.fluentvalidation.net/) validators for the message domain model published in [`BeneficialStrategies.Iso20022`](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) — 1,004 validators covering message components, generated from and cross-checked against the ISO 20022 specification.

## Thank you

`BeneficialStrategies.Iso20022` gives you a strongly-typed, compiler-enforced rendering of ISO 20022 messages in memory — but the C# type system can only express so much. Some ISO 20022 rules are cross-field ("a case identification may appear in at most one of three possible locations") or depend on runtime data the compiler can't see. This package is the follow-on project that covers that ground: validators that check field-level constraints and cross-field business rules the record types themselves cannot enforce.

Coverage today:
- **93 validators** — full ISO 20022 spec-compliance coverage (field-level constraints and cross-field rules), for CAMT-reachable components.
- **911 validators** — abbreviated coverage. These currently only enforce a known minimum-collection-size gap (some `required`-looking collections were generated with no lower bound, so an empty collection compiles but violates the spec); they have not yet been reviewed for the remaining field-level constraints and cross-field rules a full validator would cover.

Every validator — full or abbreviated — carries an XML doc `<remarks>` block naming exactly which spec constraints it currently checks, so you always know what you're getting from a specific type, not just its category.

Known limitations:
- No composite message-level validator yet for most business areas — validators exist per component (and per full message for the CAMT-reachable set); you compose them yourself for now via `SetValidator()` where needed.
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
