// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction76"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: c1b2745a-8979-4069-a0c7-2a93a3ff6de8
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details specific to the individual transaction(s) included in the message.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification6 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>Amount</term><description>AmountType4Choice_ — required (1..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>PreviousInstructingAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>PreviousInstructingAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructionForDebtorAgent</term><description>InstructionForDebtorAgent1 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 collection — optional (0..n)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 collection — optional (0..n)</description></item>
///   <item><term>RelatedRemittanceInformation</term><description>RemittanceLocation8 collection — optional (0..n)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation22 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> validator instance is reused across
/// all seven agent fields, the same <see cref="CashAccount40"/> validator instance across all
/// seven account fields, and the same <see cref="PartyIdentification272"/> validator instance
/// across <c>Creditor</c> and <c>UltimateCreditor</c> — see the two constructors below.
/// </remarks>
public class CreditTransferTransaction76Validator : AbstractValidator<CreditTransferTransaction76>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditTransferTransaction76Validator(
        IValidator<PaymentIdentification6> paymentIdentificationValidator,
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<AmountType4Choice_> amountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<InstructionForDebtorAgent1> instructionForDebtorAgentValidator,
        IValidator<InstructionForCreditorAgent3> instructionForCreditorAgentValidator,
        IValidator<RegulatoryReporting10> regulatoryReportingValidator,
        IValidator<RemittanceLocation8> relatedRemittanceInformationValidator,
        IValidator<RemittanceInformation22> remittanceInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!);
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
        );
        RuleFor(x => x.Amount).SetValidator(amountValidator!);

        When(
            x => x.PreviousInstructingAgent1 is not null,
            () => RuleFor(x => x.PreviousInstructingAgent1).SetValidator(agentValidator!)
        );
        When(
            x => x.PreviousInstructingAgent1Account is not null,
            () => RuleFor(x => x.PreviousInstructingAgent1Account).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.PreviousInstructingAgent2 is not null,
            () => RuleFor(x => x.PreviousInstructingAgent2).SetValidator(agentValidator!)
        );
        When(
            x => x.PreviousInstructingAgent2Account is not null,
            () => RuleFor(x => x.PreviousInstructingAgent2Account).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.PreviousInstructingAgent3 is not null,
            () => RuleFor(x => x.PreviousInstructingAgent3).SetValidator(agentValidator!)
        );
        When(
            x => x.PreviousInstructingAgent3Account is not null,
            () => RuleFor(x => x.PreviousInstructingAgent3Account).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.IntermediaryAgent1 is not null,
            () => RuleFor(x => x.IntermediaryAgent1).SetValidator(agentValidator!)
        );
        When(
            x => x.IntermediaryAgent1Account is not null,
            () => RuleFor(x => x.IntermediaryAgent1Account).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.IntermediaryAgent2 is not null,
            () => RuleFor(x => x.IntermediaryAgent2).SetValidator(agentValidator!)
        );
        When(
            x => x.IntermediaryAgent2Account is not null,
            () => RuleFor(x => x.IntermediaryAgent2Account).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.IntermediaryAgent3 is not null,
            () => RuleFor(x => x.IntermediaryAgent3).SetValidator(agentValidator!)
        );
        When(
            x => x.IntermediaryAgent3Account is not null,
            () => RuleFor(x => x.IntermediaryAgent3Account).SetValidator(cashAccountValidator!)
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

        When(
            x => x.InstructionForDebtorAgent is not null,
            () => RuleFor(x => x.InstructionForDebtorAgent).SetValidator(instructionForDebtorAgentValidator!)
        );
        RuleForEach(x => x.InstructionForCreditorAgent).SetValidator(instructionForCreditorAgentValidator!);
        RuleForEach(x => x.RegulatoryReporting).SetValidator(regulatoryReportingValidator!);
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
    public CreditTransferTransaction76Validator()
        : this(
            new PaymentIdentification6Validator(),
            new PaymentTypeInformation28Validator(),
            new AmountType4Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PartyIdentification272Validator(),
            new InstructionForDebtorAgent1Validator(),
            new InstructionForCreditorAgent3Validator(),
            new RegulatoryReporting10Validator(),
            new RemittanceLocation8Validator(),
            new RemittanceInformation22Validator(),
            new SupplementaryData1Validator()
        ) { }
}
