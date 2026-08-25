// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction168"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: fccbf899-2453-42a4-ac0e-594ac02c735b
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Provides further details on the reference and status on the original transactions, included
/// in the original instruction, to which the return message applies.
/// <list type="table">
///   <item><term>ReturnedInterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupInformation33 — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>SettlementTimeRequest</term><description>SettlementTimeRequest2 — optional (0..1)</description></item>
///   <item><term>ReturnedInstructedAmount/OriginalInterbankSettlementAmount/CompensationAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1) each</description></item>
///   <item><term>AgreedRate</term><description>CurrencyExchange26 — optional (0..1)</description></item>
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..&#8734;)</description></item>
///   <item><term>InstructingAgent/InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>ReturnChain</term><description>TransactionParties11 — optional (0..1)</description></item>
///   <item><term>ReturnReasonInformation</term><description>PaymentReturnReason7 collection — optional (0..&#8734;)</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference45 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// All remaining scalar fields (<c>ReturnIdentification</c>, <c>OriginalInstructionIdentification</c>,
/// <c>OriginalEndToEndIdentification</c>, <c>OriginalTransactionIdentification</c>,
/// <c>OriginalUETR</c>, <c>OriginalClearingSystemReference</c>, <c>OriginalInterbankSettlementDate</c>,
/// <c>InterbankSettlementDate</c>, <c>SettlementPriority</c>, <c>ExchangeRate</c>,
/// <c>ChargeBearer</c>, <c>ClearingSystemReference</c>) are already fully enforced at their own
/// struct/enum level — no rule needed.
///
/// No cross-field constraints found for this component itself — the message-level constraints
/// tying its fields to <c>GroupHeader123</c> are enforced in <c>PaymentReturnV15Validator</c>.
///
/// <c>ReturnedInterbankSettlementAmount</c> (required, <c>ActiveCurrencyAndAmount</c>) and
/// <c>ReturnedInstructedAmount</c>/<c>OriginalInterbankSettlementAmount</c>/<c>CompensationAmount</c>
/// (optional, <c>ActiveOrHistoricCurrencyAndAmount</c>) are plain records (not
/// <see cref="IIsoSimpleValue{T}"/> wrappers) — their <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero.
///
/// Dependency injection: <c>InstructingAgent</c> and <c>InstructedAgent</c> share a single
/// injected <see cref="IValidator{T}"/> instance, per the pattern established in
/// <c>OriginalTransactionReference47Validator</c> — see the two constructors below.
/// </remarks>
public class PaymentTransaction168Validator : AbstractValidator<PaymentTransaction168>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for every optional building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public PaymentTransaction168Validator(
        IValidator<OriginalGroupInformation33> originalGroupInformationValidator,
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<SettlementTimeRequest2> settlementTimeRequestValidator,
        IValidator<CurrencyExchange26> agreedRateValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<TransactionParties11> returnChainValidator,
        IValidator<PaymentReturnReason7> returnReasonInformationValidator,
        IValidator<OriginalTransactionReference45> originalTransactionReferenceValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.ReturnedInterbankSettlementAmount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "PaymentTransaction168.ReturnedInterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );
        RuleFor(x => x.ReturnedInterbankSettlementAmount.Amount)
            .GreaterThan(0)
            .WithMessage("PaymentTransaction168.ReturnedInterbankSettlementAmount.Amount must be greater than zero.");

        When(
            x => x.OriginalGroupInformation is not null,
            () => RuleFor(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!)
        );
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );
        When(
            x => x.SettlementTimeIndication is not null,
            () => RuleFor(x => x.SettlementTimeIndication).SetValidator(settlementTimeIndicationValidator!)
        );
        When(
            x => x.SettlementTimeRequest is not null,
            () => RuleFor(x => x.SettlementTimeRequest).SetValidator(settlementTimeRequestValidator!)
        );

        When(
            x => x.ReturnedInstructedAmount is not null,
            () =>
            {
                RuleFor(x => x.ReturnedInstructedAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "PaymentTransaction168.ReturnedInstructedAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );
                RuleFor(x => x.ReturnedInstructedAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("PaymentTransaction168.ReturnedInstructedAmount.Amount must be greater than zero.");
            }
        );

        When(
            x => x.OriginalInterbankSettlementAmount is not null,
            () =>
            {
                RuleFor(x => x.OriginalInterbankSettlementAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "PaymentTransaction168.OriginalInterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );
                RuleFor(x => x.OriginalInterbankSettlementAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("PaymentTransaction168.OriginalInterbankSettlementAmount.Amount must be greater than zero.");
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
                        "PaymentTransaction168.CompensationAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );
                RuleFor(x => x.CompensationAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("PaymentTransaction168.CompensationAmount.Amount must be greater than zero.");
            }
        );

        When(x => x.AgreedRate is not null, () => RuleFor(x => x.AgreedRate).SetValidator(agreedRateValidator!));

        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);

        When(x => x.InstructingAgent is not null, () => RuleFor(x => x.InstructingAgent).SetValidator(agentValidator!));
        When(x => x.InstructedAgent is not null, () => RuleFor(x => x.InstructedAgent).SetValidator(agentValidator!));

        When(x => x.ReturnChain is not null, () => RuleFor(x => x.ReturnChain).SetValidator(returnChainValidator!));

        RuleForEach(x => x.ReturnReasonInformation).SetValidator(returnReasonInformationValidator!);

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
    public PaymentTransaction168Validator()
        : this(
            new OriginalGroupInformation33Validator(),
            new PaymentTypeInformation28Validator(),
            new SettlementDateTimeIndication1Validator(),
            new SettlementTimeRequest2Validator(),
            new CurrencyExchange26Validator(),
            new Charges16Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new TransactionParties11Validator(),
            new PaymentReturnReason7Validator(),
            new OriginalTransactionReference45Validator(),
            new SupplementaryData1Validator()
        ) { }
}
