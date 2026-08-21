// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalTransactionReference47"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: b6168479-406c-4e82-b807-50ae6886bee6
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies key elements as defined in the original transaction.
/// <list type="table">
///   <item><term>InterbankSettlementAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>Amount</term><description>AmountType4Choice_ — optional (0..1)</description></item>
///   <item><term>InterbankSettlementDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RequestedCollectionDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RequestedExecutionDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>CreditorSchemeIdentification</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>SettlementInformation</term><description>SettlementInstruction15 — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation27 — optional (0..1)</description></item>
///   <item><term>PaymentMethod</term><description>PaymentMethod4Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>MandateRelatedInformation</term><description>MandateRelatedData5Choice_ — optional (0..1)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>Party50Choice_ — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>Party50Choice_ — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>Party50Choice_ — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>Party50Choice_ — optional (0..1)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry) — this is the same "original transaction reference" pattern
/// documented on <see cref="FIToFIPaymentCancellationRequestV10"/>'s dependency graph, but this
/// version carries no structured tax/garnishment cascade beyond what's already built here (see
/// <see cref="RemittanceInformation26Validator"/>).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="Party50Choice_"/> validator instance is reused across all four party fields
/// (<c>UltimateDebtor</c>, <c>Debtor</c>, <c>Creditor</c>, <c>UltimateCreditor</c>), the same
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> validator instance across
/// <c>DebtorAgent</c> and <c>CreditorAgent</c>, and the same <see cref="CashAccount40"/>
/// validator instance across all four account fields — see the two constructors below.
/// </remarks>
public class OriginalTransactionReference47Validator : AbstractValidator<OriginalTransactionReference47>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public OriginalTransactionReference47Validator(
        IValidator<AmountType4Choice_> amountValidator,
        IValidator<DateAndDateTime2Choice_> requestedExecutionDateValidator,
        IValidator<PartyIdentification272> creditorSchemeIdentificationValidator,
        IValidator<SettlementInstruction15> settlementInformationValidator,
        IValidator<PaymentTypeInformation27> paymentTypeInformationValidator,
        IValidator<MandateRelatedData5Choice_> mandateRelatedInformationValidator,
        IValidator<RemittanceInformation26> remittanceInformationValidator,
        IValidator<Party50Choice_> partyValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<Purpose2Choice_> purposeValidator
    )
    {
        When(x => x.Amount is not null, () => RuleFor(x => x.Amount).SetValidator(amountValidator!));
        When(
            x => x.RequestedExecutionDate is not null,
            () => RuleFor(x => x.RequestedExecutionDate).SetValidator(requestedExecutionDateValidator!)
        );
        When(
            x => x.CreditorSchemeIdentification is not null,
            () => RuleFor(x => x.CreditorSchemeIdentification).SetValidator(creditorSchemeIdentificationValidator!)
        );
        When(
            x => x.SettlementInformation is not null,
            () => RuleFor(x => x.SettlementInformation).SetValidator(settlementInformationValidator!)
        );
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );
        When(
            x => x.MandateRelatedInformation is not null,
            () => RuleFor(x => x.MandateRelatedInformation).SetValidator(mandateRelatedInformationValidator!)
        );
        When(
            x => x.RemittanceInformation is not null,
            () => RuleFor(x => x.RemittanceInformation).SetValidator(remittanceInformationValidator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!)
        );
        When(x => x.Debtor is not null, () => RuleFor(x => x.Debtor).SetValidator(partyValidator!));
        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );
        When(x => x.DebtorAgent is not null, () => RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!));
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(x => x.CreditorAgent is not null, () => RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!));
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(x => x.Creditor is not null, () => RuleFor(x => x.Creditor).SetValidator(partyValidator!));
        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );
        When(x => x.Purpose is not null, () => RuleFor(x => x.Purpose).SetValidator(purposeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalTransactionReference47Validator()
        : this(
            new AmountType4Choice_Validator(),
            new DateAndDateTime2Choice_Validator(),
            new PartyIdentification272Validator(),
            new SettlementInstruction15Validator(),
            new PaymentTypeInformation27Validator(),
            new MandateRelatedData5Choice_Validator(),
            new RemittanceInformation26Validator(),
            new Party50Choice_Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new Purpose2Choice_Validator()
        ) { }
}
