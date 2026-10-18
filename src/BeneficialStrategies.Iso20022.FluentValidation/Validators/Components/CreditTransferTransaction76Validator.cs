// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction76"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// Rewritten from the ISO 20022 repository when the members of the component were corrected (#47): the members, their order and
/// occurrences are the repository's. Every member that is a component or a choice is validated by an injected
/// <see cref="IValidator{T}"/>; the simple types and code sets check themselves when they are built.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification6 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation26 — optional (0..1)</description></item>
///   <item><term>Amount</term><description>AmountType4Choice_ — required (1..1)</description></item>
///   <item><term>ExchangeRateInformation</term><description>ExchangeRate1 — optional (0..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1)</description></item>
///   <item><term>MandateRelatedInformation</term><description>CreditTransferMandateData1 — optional (0..1)</description></item>
///   <item><term>ChequeInstruction</term><description>Cheque19 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1Account</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent2</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent2Account</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent3Account</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 — collection (0..n)</description></item>
///   <item><term>InstructionForDebtorAgent</term><description>InstructionForDebtorAgent1 — optional (0..1)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 — collection (0..n)</description></item>
///   <item><term>Tax</term><description>TaxData1 — optional (0..1)</description></item>
///   <item><term>RelatedRemittanceInformation</term><description>RemittanceLocation8 — collection (0..n)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — collection (0..n)</description></item>
/// </list>
/// </remarks>
public class CreditTransferTransaction76Validator : AbstractValidator<CreditTransferTransaction76>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditTransferTransaction76Validator(
        IValidator<PaymentIdentification6> paymentIdentification6Validator,
        IValidator<PaymentTypeInformation26> paymentTypeInformation26Validator,
        IValidator<AmountType4Choice_> amountType4ChoiceValidator,
        IValidator<ExchangeRate1> exchangeRate1Validator,
        IValidator<CreditTransferMandateData1> creditTransferMandateData1Validator,
        IValidator<Cheque19> cheque19Validator,
        IValidator<PartyIdentification272> partyIdentification272Validator,
        IValidator<BranchAndFinancialInstitutionIdentification8> branchAndFinancialInstitutionIdentification8Validator,
        IValidator<CashAccount40> cashAccount40Validator,
        IValidator<InstructionForCreditorAgent3> instructionForCreditorAgent3Validator,
        IValidator<InstructionForDebtorAgent1> instructionForDebtorAgent1Validator,
        IValidator<Purpose2Choice_> purpose2ChoiceValidator,
        IValidator<RegulatoryReporting10> regulatoryReporting10Validator,
        IValidator<TaxData1> taxData1Validator,
        IValidator<RemittanceLocation8> remittanceLocation8Validator,
        IValidator<RemittanceInformation26> remittanceInformation26Validator,
        IValidator<SupplementaryData1> supplementaryData1Validator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentification6Validator!);
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformation26Validator!)
        );
        RuleFor(x => x.Amount).SetValidator(amountType4ChoiceValidator!);
        When(
            x => x.ExchangeRateInformation is not null,
            () => RuleFor(x => x.ExchangeRateInformation).SetValidator(exchangeRate1Validator!)
        );
        When(
            x => x.MandateRelatedInformation is not null,
            () => RuleFor(x => x.MandateRelatedInformation).SetValidator(creditTransferMandateData1Validator!)
        );
        When(
            x => x.ChequeInstruction is not null,
            () => RuleFor(x => x.ChequeInstruction).SetValidator(cheque19Validator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyIdentification272Validator!)
        );
        When(
            x => x.IntermediaryAgent1 is not null,
            () => RuleFor(x => x.IntermediaryAgent1).SetValidator(branchAndFinancialInstitutionIdentification8Validator!)
        );
        When(
            x => x.IntermediaryAgent1Account is not null,
            () => RuleFor(x => x.IntermediaryAgent1Account).SetValidator(cashAccount40Validator!)
        );
        When(
            x => x.IntermediaryAgent2 is not null,
            () => RuleFor(x => x.IntermediaryAgent2).SetValidator(branchAndFinancialInstitutionIdentification8Validator!)
        );
        When(
            x => x.IntermediaryAgent2Account is not null,
            () => RuleFor(x => x.IntermediaryAgent2Account).SetValidator(cashAccount40Validator!)
        );
        When(
            x => x.IntermediaryAgent3 is not null,
            () => RuleFor(x => x.IntermediaryAgent3).SetValidator(branchAndFinancialInstitutionIdentification8Validator!)
        );
        When(
            x => x.IntermediaryAgent3Account is not null,
            () => RuleFor(x => x.IntermediaryAgent3Account).SetValidator(cashAccount40Validator!)
        );
        When(
            x => x.CreditorAgent is not null,
            () => RuleFor(x => x.CreditorAgent).SetValidator(branchAndFinancialInstitutionIdentification8Validator!)
        );
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccount40Validator!)
        );
        When(
            x => x.Creditor is not null,
            () => RuleFor(x => x.Creditor).SetValidator(partyIdentification272Validator!)
        );
        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccount40Validator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyIdentification272Validator!)
        );
        RuleForEach(x => x.InstructionForCreditorAgent).SetValidator(instructionForCreditorAgent3Validator!);
        When(
            x => x.InstructionForDebtorAgent is not null,
            () => RuleFor(x => x.InstructionForDebtorAgent).SetValidator(instructionForDebtorAgent1Validator!)
        );
        When(
            x => x.Purpose is not null,
            () => RuleFor(x => x.Purpose).SetValidator(purpose2ChoiceValidator!)
        );
        RuleForEach(x => x.RegulatoryReporting).SetValidator(regulatoryReporting10Validator!);
        When(
            x => x.Tax is not null,
            () => RuleFor(x => x.Tax).SetValidator(taxData1Validator!)
        );
        RuleForEach(x => x.RelatedRemittanceInformation).SetValidator(remittanceLocation8Validator!);
        When(
            x => x.RemittanceInformation is not null,
            () => RuleFor(x => x.RemittanceInformation).SetValidator(remittanceInformation26Validator!)
        );
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryData1Validator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditTransferTransaction76Validator()
        : this(
            new PaymentIdentification6Validator(),
            new PaymentTypeInformation26Validator(),
            new AmountType4Choice_Validator(),
            new ExchangeRate1Validator(),
            new CreditTransferMandateData1Validator(),
            new Cheque19Validator(),
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new InstructionForCreditorAgent3Validator(),
            new InstructionForDebtorAgent1Validator(),
            new Purpose2Choice_Validator(),
            new RegulatoryReporting10Validator(),
            new TaxData1Validator(),
            new RemittanceLocation8Validator(),
            new RemittanceInformation26Validator(),
            new SupplementaryData1Validator()
        ) { }
}
