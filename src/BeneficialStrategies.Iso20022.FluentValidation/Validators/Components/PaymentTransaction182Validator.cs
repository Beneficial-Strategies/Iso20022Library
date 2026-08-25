// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction182"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _qAAHgZe-EfCsfrvk22Hpaw
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further details on the reference and status on the original transactions, included
/// in the original instruction, to which the reversal message applies.
/// <list type="table">
///   <item><term>ReversedInterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupInformation33 — optional (0..1)</description></item>
///   <item><term>OriginalInterbankSettlementAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>ReversedInstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>CompensationAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..&#8734;)</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>ReversalReasonInformation</term><description>PaymentReversalReason10 collection — optional (0..&#8734;)</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference47 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// All remaining scalar fields (<c>ReversalIdentification</c>, <c>OriginalInstructionIdentification</c>,
/// <c>OriginalEndToEndIdentification</c>, <c>OriginalTransactionIdentification</c>,
/// <c>OriginalClearingSystemReference</c>, <c>OriginalUETR</c>, <c>InterbankSettlementDate</c>,
/// <c>SettlementPriority</c>, <c>ExchangeRate</c>, <c>ChargeBearer</c>) are already fully enforced
/// at their own struct/enum level — no rule needed.
///
/// No cross-field constraints found for this component itself (no "constraint" declaration rows
/// under its ISO dictionary entry) — the message-level constraints tying this component's fields
/// (<c>OriginalGroupInformation</c>, <c>InstructingAgent</c>, <c>InstructedAgent</c>,
/// <c>InterbankSettlementDate</c>, <c>ReversedInterbankSettlementAmount</c>) to the
/// <c>GroupHeader</c>/other transactions are enforced in <c>FIToFIPaymentReversalV14Validator</c>.
///
/// The three <c>ActiveOrHistoricCurrencyAndAmount</c> fields and the required
/// <c>ActiveCurrencyAndAmount</c> field are plain records (not <see cref="IIsoSimpleValue{T}"/>
/// wrappers) — their <c>Currency</c>/<c>Amount</c> fields are validated inline here per the
/// established convention (see <c>PaymentTransaction137Validator</c> and
/// <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount greater
/// than zero.
///
/// Dependency injection: <c>OriginalGroupInformation</c>, <c>SettlementTimeIndication</c>,
/// <c>ChargesInformation</c> (each item), <c>InstructingAgent</c>, <c>InstructedAgent</c>,
/// <c>ReversalReasonInformation</c> (each item), <c>OriginalTransactionReference</c>, and
/// <c>SupplementaryData</c> (each item) are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class PaymentTransaction182Validator : AbstractValidator<PaymentTransaction182>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for every optional building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public PaymentTransaction182Validator(
        IValidator<OriginalGroupInformation33> originalGroupInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator,
        IValidator<PaymentReversalReason10> reversalReasonInformationValidator,
        IValidator<OriginalTransactionReference47> originalTransactionReferenceValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        // ── ReversedInterbankSettlementAmount (ActiveCurrencyAndAmount, required 1..1) ───
        RuleFor(x => x.ReversedInterbankSettlementAmount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "PaymentTransaction182.ReversedInterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );

        RuleFor(x => x.ReversedInterbankSettlementAmount.Amount)
            .GreaterThan(0)
            .WithMessage("PaymentTransaction182.ReversedInterbankSettlementAmount.Amount must be greater than zero.");

        When(
            x => x.OriginalGroupInformation is not null,
            () => RuleFor(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!)
        );

        When(
            x => x.OriginalInterbankSettlementAmount is not null,
            () =>
            {
                RuleFor(x => x.OriginalInterbankSettlementAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "PaymentTransaction182.OriginalInterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.OriginalInterbankSettlementAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage(
                        "PaymentTransaction182.OriginalInterbankSettlementAmount.Amount must be greater than zero."
                    );
            }
        );

        When(
            x => x.ReversedInstructedAmount is not null,
            () =>
            {
                RuleFor(x => x.ReversedInstructedAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "PaymentTransaction182.ReversedInstructedAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.ReversedInstructedAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("PaymentTransaction182.ReversedInstructedAmount.Amount must be greater than zero.");
            }
        );

        When(
            x => x.CompensationAmount is not null,
            () =>
            {
                RuleFor(x => x.CompensationAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "PaymentTransaction182.CompensationAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.CompensationAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("PaymentTransaction182.CompensationAmount.Amount must be greater than zero.");
            }
        );

        When(
            x => x.SettlementTimeIndication is not null,
            () => RuleFor(x => x.SettlementTimeIndication).SetValidator(settlementTimeIndicationValidator!)
        );

        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(instructingAgentValidator!)
        );

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(instructedAgentValidator!)
        );

        RuleForEach(x => x.ReversalReasonInformation).SetValidator(reversalReasonInformationValidator!);

        When(
            x => x.OriginalTransactionReference is not null,
            () => RuleFor(x => x.OriginalTransactionReference).SetValidator(originalTransactionReferenceValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentTransaction182Validator()
        : this(
            new OriginalGroupInformation33Validator(),
            new SettlementDateTimeIndication1Validator(),
            new Charges16Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new PaymentReversalReason10Validator(),
            new OriginalTransactionReference47Validator(),
            new SupplementaryData1Validator()
        ) { }
}
