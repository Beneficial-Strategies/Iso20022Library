# Beneficial Strategies ISO20022 FluentValidation Library

This project contains [FluentValidation](https://docs.fluentvalidation.net/) validators for the message domain model published in [`BeneficialStrategies.Iso20022`](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) — 1,265 validators covering top-level messages, message components, choice types, and external code sets, generated from and cross-checked against the ISO 20022 specification.

## Welcome!

`BeneficialStrategies.Iso20022` gives you a strongly-typed, compiler-enforced rendering of ISO 20022 messages in memory — but the C# type system can only express so much. Some ISO 20022 rules are cross-field ("a case identification may appear in at most one of three possible locations") or depend on runtime data the compiler can't see. This package is the follow-on project that covers that ground: validators that check field-level constraints and cross-field business rules the record types themselves cannot enforce.

Coverage today:
- **360 validators** — full ISO 20022 spec-compliance coverage (field-level constraints and cross-field rules), including 37 top-level messages validated completely, top to bottom, with zero exceptions anywhere in their reachable graph — **the entire `pain` (Payments Initiation) business area is 100% complete** (12/12 addressable message families; two additional legacy IDs, `PaymentCancellationRequestV01` and `PaymentStatusReportV02`, are permanently out of scope — see the note below the table), and the `pacs` (Payments Clearing and Settlement) business area is now underway (`MultilateralSettlementRequestV02`, `FinancialInstitutionDirectDebitV06`, `FIToFIPaymentStatusRequestV07`). This list only grows, so it's kept here as a table, sorted by ISO ID:

  | ISO ID | Message | C# type | Description |
  |---|---|---|---|
  | camt.012.001.08 | Delete Limit | `DeleteLimitV08` | Sent by a member to the transaction administrator to request the deletion of one, several, or all limits set by the member and managed by the transaction administrator. |
  | camt.016.001.04 | Get Currency Exchange Rate | `GetCurrencyExchangeRateV04` | Sent by a member to the transaction administrator to request static data related to currency exchange details, by source and/or target currency. |
  | camt.020.001.04 | Get General Business Information | `GetGeneralBusinessInformationV04` | Sent by a member to the transaction administrator to request the full content of a broadcast-type business information message previously sent. |
  | camt.024.001.08 | Modify Standing Order | `ModifyStandingOrderV08` | Sent by a member to the transaction administrator to request a change in the features of a permanent funds-transfer order between two of its accounts. |
  | camt.030.001.06 | Notification Of Case Assignment | `NotificationOfCaseAssignmentV06` | Sent by a case assignee to a case creator/case assigner to inform them of further action undertaken on the case (reassignment, or working it directly). |
  | camt.031.001.07 | Reject Investigation | `RejectInvestigationV07` | Sent by a case assignee to a case creator or case assigner to reject a case given to it. |
  | camt.032.001.05 | Cancel Case Assignment | `CancelCaseAssignmentV05` | Sent by a case creator or case assigner to a case assignee to request the cancellation of a case. |
  | camt.033.001.07 | Request For Duplicate | `RequestForDuplicateV07` | Sent by the case assignee to the case creator or case assigner to request a copy of the original payment instruction considered in the case. |
  | camt.034.001.07 | Duplicate | `DuplicateV07` | Sent in response to a RequestForDuplicate message, to exchange a duplicate payment instruction. |
  | camt.035.001.06 | Proprietary Format Investigation | `ProprietaryFormatInvestigationV06` | Used, by bilateral agreement, as an envelope for a non-standard message managing an exception or investigation outside the scope of any other formatted message. |
  | camt.036.001.06 | Debit Authorisation Response | `DebitAuthorisationResponseV06` | Sent by an account owner to its account servicing institution to approve or reject a debit authorisation request. |
  | camt.038.001.05 | Case Status Report Request | `CaseStatusReportRequestV05` | Sent by a case creator or case assigner to a case assignee to request the status of a case. |
  | camt.039.001.06 | Case Status Report | `CaseStatusReportV06` | Sent by a case assignee to a case creator or case assigner to report on the status of a case, in reply to a CaseStatusReportRequest message. |
  | camt.048.001.07 | Modify Reservation | `ModifyReservationV07` | Used to request modifications in the details of one particular reservation set by the member and managed by the transaction administrator. |
  | camt.049.001.07 | Delete Reservation | `DeleteReservationV07` | Used to request the deletion of one particular reservation by the member and managed by the transaction administrator. |
  | camt.050.001.07 | Liquidity Credit Transfer | `LiquidityCreditTransferV07` | Sent by a member to the transaction administrator to request a transfer of funds between two accounts belonging to the same member or group of accounts. |
  | camt.051.001.07 | Liquidity Debit Transfer | `LiquidityDebitTransferV07` | Sent by a member to the transaction administrator to request a transfer of funds between two accounts belonging to the same member or group of accounts. |
  | camt.063.001.02 | Pay In Event Acknowledgement | `PayInEventAcknowledgementV02` | Sent by a participant of a central system to the central system to confirm a PayInSchedule or a PayInCall has been received. |
  | camt.071.001.05 | Delete Standing Order | `DeleteStandingOrderV05` | Sent by the system member to delete one or more standing orders within the static data held by the system transaction administrator. |
  | camt.101.001.02 | Create Limit | `CreateLimitV02` | Sent by a member to the transaction administrator to create one or several limits set by the member and managed by the transaction administrator. |
  | camt.102.001.03 | Create Standing Order | `CreateStandingOrderV03` | Sent by a member to the transaction administrator to create a permanent order for the transfer of funds between two of its accounts. |
  | camt.103.001.03 | Create Reservation | `CreateReservationV03` | Used to request the creation of one particular reservation by the member and managed by the transaction administrator. |
  | pacs.010.001.06 | Financial Institution Direct Debit | `FinancialInstitutionDirectDebitV06` | Sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent, to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions. |
  | pacs.028.001.07 | FI To FI Payment Status Request | `FIToFIPaymentStatusRequestV07` | Sent by the debtor agent to the creditor agent, directly or through other agents and/or a payment clearing and settlement system, to request a FIToFIPaymentStatusReport message containing information on the status of a previously sent instruction. |
  | pacs.029.001.02 | Multilateral Settlement Request | `MultilateralSettlementRequestV02` | Sent from an instructing agent to a market infrastructure, to settle obligations between their participants using accounts held in a settlement service. |
  | pain.001.001.13 | Customer Credit Transfer Initiation | `CustomerCreditTransferInitiationV13` | Sent by the initiating party to the forwarding agent or debtor agent, to request movement of funds from the debtor account to a creditor. |
  | pain.002.001.15 | Customer Payment Status Report | `CustomerPaymentStatusReportV15` | Sent by an instructed agent to the previous party in the payment chain, to inform them about the positive or negative status of an instruction, or to report on a pending instruction. |
  | pain.007.001.13 | Customer Payment Reversal | `CustomerPaymentReversalV13` | Sent by the initiating party to the next party in the payment chain, to reverse a payment previously executed. |
  | pain.008.001.12 | Customer Direct Debit Initiation | `CustomerDirectDebitInitiationV12` | Sent by the initiating party to the forwarding agent or creditor agent, to request single or bulk collection(s) of funds from one or various debtor's account(s) for a creditor. |
  | pain.009.001.08 | Mandate Initiation Request | `MandateInitiationRequestV08` | Sent by the initiator of a mandate request (debtor or creditor) to their agent, to set up the instruction that allows the debtor agent to accept debit instructions from the creditor agent. |
  | pain.010.001.08 | Mandate Amendment Request | `MandateAmendmentRequestV08` | Sent by the initiator of the request (debtor or creditor) to their agent and/or counterparty to request the amendment of specific information in an existing mandate. |
  | pain.011.001.08 | Mandate Cancellation Request | `MandateCancellationRequestV08` | Sent by the initiator of the request (debtor or creditor) to their agent to request the cancellation of an existing mandate. |
  | pain.012.001.08 | Mandate Acceptance Report | `MandateAcceptanceReportV08` | Sent from the agent of the receiver of a mandate request to the agent of the initiator, to confirm the acceptance or rejection of that request. |
  | pain.013.001.12 | Creditor Payment Activation Request | `CreditorPaymentActivationRequestV12` | Sent by the Creditor sending party to the Debtor receiving party, directly or through agents, to request movement of funds from the debtor account to a creditor. |
  | pain.014.001.12 | Creditor Payment Activation Request Status Report | `CreditorPaymentActivationRequestStatusReportV12` | Sent by a party to the next party in the creditor payment activation request chain, to inform them about the positive or negative status of a creditor payment activation request. |
  | pain.017.001.04 | Mandate Copy Request | `MandateCopyRequestV04` | Sent by the initiator of the request (debtor or creditor) to their agent to request a copy of an existing mandate. |
  | pain.018.001.04 | Mandate Suspension Request | `MandateSuspensionRequestV04` | Sent by the initiator of the request (debtor, debtor agent, creditor, or creditor agent) to its agent to request the suspension of an existing mandate. |

  (`FIToFIPaymentCancellationRequestV10`, camt.056.001.10, has a validator too, but mechanical verification found gaps in its dependency graph — not yet complete enough to list above. See the FluentValidation project's own `CLAUDE.md` for tracking.)

  (Two `pain` message IDs are intentionally absent above, not merely unbuilt: `PaymentCancellationRequestV01` (pain.006.001.01) and `PaymentStatusReportV02` (pain.002.001.02) are both superseded — per ISO 20022's own `nextVersions` pointer, each was renamed decades ago into the `CustomerXxx` naming convention. `PaymentCancellationRequestV01`'s lineage continued as `CustomerPaymentCancellationRequestV01` → ... → `CustomerPaymentCancellationRequestV11`, which now lives in the `camt` business area (camt.055.001.11) — permanently out of `pain` scope. `PaymentStatusReportV02`'s lineage continued as `CustomerPaymentStatusReportV03` → ... → `CustomerPaymentStatusReportV15`, which stays in `pain` and is tracked under its current name instead. Neither of the two old IDs will ever be built under those names.)
- **905 validators** — abbreviated coverage. These currently only enforce a known minimum-collection-size gap (some `required`-looking collections were generated with no lower bound, so an empty collection compiles but violates the spec); they have not yet been reviewed for the remaining field-level constraints and cross-field rules a full validator would cover.

Every validator — full or abbreviated — carries an XML doc `<remarks>` block naming exactly which spec constraints it currently checks, so you always know what you're getting from a specific type, not just its category.

Known limitations:
- No composite message-level validator yet for most business areas — validators exist per component (and per full message for the messages in the table above); you compose them yourself for now via `SetValidator()` where needed.
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
