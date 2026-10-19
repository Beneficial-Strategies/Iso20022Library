// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction74"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// Rewritten from the ISO 20022 repository when the members of the component were corrected (#47): the members, their order and
/// occurrences are the repository's. Every member that is a component or a choice is validated by an injected
/// <see cref="IValidator{T}"/>; the simple types and code sets check themselves when they are built.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification6 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation29 — optional (0..1)</description></item>
///   <item><term>PaymentCondition</term><description>PaymentCondition2 — optional (0..1)</description></item>
///   <item><term>RequestedExecutionDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>Amount</term><description>AmountType4Choice_ — required (1..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — optional (0..1)</description></item>
///   <item><term>MandateRelatedInformation</term><description>CreditTransferMandateData1 — optional (0..1)</description></item>
///   <item><term>ChequeInstruction</term><description>Cheque19 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent2</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 — collection (0..n)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 — collection (0..n)</description></item>
///   <item><term>Tax</term><description>TaxData1 — optional (0..1)</description></item>
///   <item><term>RelatedRemittanceInformation</term><description>RemittanceLocation8 — collection (0..n)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>EnclosedFile</term><description>Document15 — collection (0..n)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — collection (0..n)</description></item>
/// </list>
/// </remarks>
public class CreditTransferTransaction74Validator : AbstractValidator<ICreditTransferTransaction74>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditTransferTransaction74Validator(
        IValidator<IPaymentIdentification6> paymentIdentification6Validator,
        IValidator<IPaymentTypeInformation29> paymentTypeInformation29Validator,
        IValidator<IPaymentCondition2> paymentCondition2Validator,
        IValidator<IDateAndDateTime2Choice> dateAndDateTime2ChoiceValidator,
        IValidator<IAmountType4Choice> amountType4ChoiceValidator,
        IValidator<ICreditTransferMandateData1> creditTransferMandateData1Validator,
        IValidator<ICheque19> cheque19Validator,
        IValidator<IPartyIdentification272> partyIdentification272Validator,
        IValidator<IBranchAndFinancialInstitutionIdentification8> branchAndFinancialInstitutionIdentification8Validator,
        IValidator<ICashAccount40> cashAccount40Validator,
        IValidator<IInstructionForCreditorAgent3> instructionForCreditorAgent3Validator,
        IValidator<IPurpose2Choice> purpose2ChoiceValidator,
        IValidator<IRegulatoryReporting10> regulatoryReporting10Validator,
        IValidator<ITaxData1> taxData1Validator,
        IValidator<IRemittanceLocation8> remittanceLocation8Validator,
        IValidator<IRemittanceInformation26> remittanceInformation26Validator,
        IValidator<IDocument15> document15Validator,
        IValidator<ISupplementaryData1> supplementaryData1Validator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentification6Validator!);
        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformation29Validator!)
        );
        When(
            x => x.PaymentCondition is not null,
            () => RuleFor(x => x.PaymentCondition).SetValidator(paymentCondition2Validator!)
        );
        When(
            x => x.RequestedExecutionDate is not null,
            () => RuleFor(x => x.RequestedExecutionDate).SetValidator(dateAndDateTime2ChoiceValidator!)
        );
        RuleFor(x => x.Amount).SetValidator(amountType4ChoiceValidator!);
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
            x => x.IntermediaryAgent2 is not null,
            () => RuleFor(x => x.IntermediaryAgent2).SetValidator(branchAndFinancialInstitutionIdentification8Validator!)
        );
        When(
            x => x.IntermediaryAgent3 is not null,
            () => RuleFor(x => x.IntermediaryAgent3).SetValidator(branchAndFinancialInstitutionIdentification8Validator!)
        );
        RuleFor(x => x.CreditorAgent).SetValidator(branchAndFinancialInstitutionIdentification8Validator!);
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccount40Validator!)
        );
        RuleFor(x => x.Creditor).SetValidator(partyIdentification272Validator!);
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
        RuleForEach(x => x.EnclosedFile).SetValidator(document15Validator!);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryData1Validator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditTransferTransaction74Validator()
        : this(
            new PaymentIdentification6Validator(),
            new PaymentTypeInformation29Validator(),
            new PaymentCondition2Validator(),
            new DateAndDateTime2Choice_Validator(),
            new AmountType4Choice_Validator(),
            new CreditTransferMandateData1Validator(),
            new Cheque19Validator(),
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new InstructionForCreditorAgent3Validator(),
            new Purpose2Choice_Validator(),
            new RegulatoryReporting10Validator(),
            new TaxData1Validator(),
            new RemittanceLocation8Validator(),
            new RemittanceInformation26Validator(),
            new Document15Validator(),
            new SupplementaryData1Validator()
        ) { }
}
