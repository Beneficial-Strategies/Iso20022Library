// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction177"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 1d3ef31d-3e56-47a4-ba45-f1c8e218be78
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further details on the original transactions, to which the status report message
/// refers.
/// <list type="table">
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupInformation33 — optional (0..1)</description></item>
///   <item><term>TransactionStatus</term><description>ExternalPaymentTransactionStatus1Code — optional (0..1); closed enum, no rule needed</description></item>
///   <item><term>StatusReasonInformation</term><description>StatusReasonInformation14 collection — optional (0..&#8734;)</description></item>
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..&#8734;)</description></item>
///   <item><term>ProcessingDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>EffectiveInterbankSettlementDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference47 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// All remaining scalar fields (<c>StatusIdentification</c>, <c>OriginalInstructionIdentification</c>,
/// <c>OriginalEndToEndIdentification</c>, <c>OriginalTransactionIdentification</c>,
/// <c>OriginalUETR</c>, <c>AcceptanceDateTime</c>, <c>AccountServicerReference</c>,
/// <c>ClearingSystemReference</c>, <c>CreditSettlementKey</c>) are already fully enforced at
/// their own struct/enum level — no rule needed.
///
/// No cross-field constraints found for this component itself (no "constraint" declaration rows
/// under its ISO dictionary entry) — the message-level constraints tying this component's
/// <c>TransactionStatus</c> and <c>OriginalGroupInformation</c> to the message's own
/// <c>OriginalGroupInformationAndStatus</c> collection are enforced in
/// <c>FIToFIPaymentStatusReportV16Validator</c>.
///
/// Dependency injection: <c>OriginalGroupInformation</c>, <c>StatusReasonInformation</c> (each
/// item), <c>ChargesInformation</c> (each item), <c>ProcessingDate</c>,
/// <c>EffectiveInterbankSettlementDate</c>, <c>InstructingAgent</c>, <c>InstructedAgent</c>,
/// <c>OriginalTransactionReference</c>, and <c>SupplementaryData</c> (each item) are each
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class PaymentTransaction177Validator : AbstractValidator<PaymentTransaction177>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for every optional building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public PaymentTransaction177Validator(
        IValidator<OriginalGroupInformation33> originalGroupInformationValidator,
        IValidator<StatusReasonInformation14> statusReasonInformationValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<DateAndDateTime2Choice_> processingDateValidator,
        IValidator<DateAndDateTime2Choice_> effectiveInterbankSettlementDateValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator,
        IValidator<OriginalTransactionReference47> originalTransactionReferenceValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        When(
            x => x.OriginalGroupInformation is not null,
            () => RuleFor(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!)
        );

        RuleForEach(x => x.StatusReasonInformation).SetValidator(statusReasonInformationValidator!);
        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);

        When(
            x => x.ProcessingDate is not null,
            () => RuleFor(x => x.ProcessingDate).SetValidator(processingDateValidator!)
        );

        When(
            x => x.EffectiveInterbankSettlementDate is not null,
            () =>
                RuleFor(x => x.EffectiveInterbankSettlementDate)
                    .SetValidator(effectiveInterbankSettlementDateValidator!)
        );

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(instructingAgentValidator!)
        );

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(instructedAgentValidator!)
        );

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
    public PaymentTransaction177Validator()
        : this(
            new OriginalGroupInformation33Validator(),
            new StatusReasonInformation14Validator(),
            new Charges16Validator(),
            new DateAndDateTime2Choice_Validator(),
            new DateAndDateTime2Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new OriginalTransactionReference47Validator(),
            new SupplementaryData1Validator()
        ) { }
}
