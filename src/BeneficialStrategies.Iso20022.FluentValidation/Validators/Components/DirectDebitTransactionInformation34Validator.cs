// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DirectDebitTransactionInformation34"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: ef49b2c4-35cf-4b49-8961-2811120821b6
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details specific to the individual direct debit transaction(s) included in
/// the message.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification6 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation29 — optional (0..1)</description></item>
///   <item><term>InstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — required (1..1), Amounts-namespace exemption</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>DirectDebitTransaction</term><description>DirectDebitTransaction12 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — required (1..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 collection — optional (0..n)</description></item>
///   <item><term>Tax</term><description>TaxData1 — optional (0..1)</description></item>
///   <item><term>RelatedRemittanceInformation</term><description>RemittanceLocation8 collection — optional (0..n)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="PartyIdentification272"/> validator instance is reused across <c>UltimateCreditor</c>,
/// <c>Debtor</c>, and <c>UltimateDebtor</c> — see the two constructors below.
/// </remarks>
public class DirectDebitTransactionInformation34Validator : AbstractValidator<DirectDebitTransactionInformation34>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DirectDebitTransactionInformation34Validator(
        IValidator<PaymentIdentification6> paymentIdentificationValidator,
        IValidator<PaymentTypeInformation29> paymentTypeInformationValidator,
        IValidator<DirectDebitTransaction12> directDebitTransactionValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<RegulatoryReporting10> regulatoryReportingValidator,
        IValidator<TaxData1> taxValidator,
        IValidator<RemittanceLocation8> relatedRemittanceInformationValidator,
        IValidator<RemittanceInformation26> remittanceInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!);
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );
        When(
            x => x.DirectDebitTransaction is not null,
            () => RuleFor(x => x.DirectDebitTransaction).SetValidator(directDebitTransactionValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );
        RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!);
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);
        RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!);
        When(x => x.UltimateDebtor is not null, () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!));
        When(x => x.Purpose is not null, () => RuleFor(x => x.Purpose).SetValidator(purposeValidator!));
        RuleForEach(x => x.RegulatoryReporting).SetValidator(regulatoryReportingValidator!);
        When(x => x.Tax is not null, () => RuleFor(x => x.Tax).SetValidator(taxValidator!));
        RuleForEach(x => x.RelatedRemittanceInformation).SetValidator(relatedRemittanceInformationValidator!);
        When(
            x => x.RemittanceInformation is not null,
            () => RuleFor(x => x.RemittanceInformation).SetValidator(remittanceInformationValidator!)
        );
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DirectDebitTransactionInformation34Validator()
        : this(
            new PaymentIdentification6Validator(),
            new PaymentTypeInformation29Validator(),
            new DirectDebitTransaction12Validator(),
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new Purpose2Choice_Validator(),
            new RegulatoryReporting10Validator(),
            new TaxData1Validator(),
            new RemittanceLocation8Validator(),
            new RemittanceInformation26Validator(),
            new SupplementaryData1Validator()
        ) { }
}
