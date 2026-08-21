// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalTransactionReference46"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 2c1c1fe9-2ee1-4fde-9241-77fb34759ccb
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Key elements used to refer the original transaction.
/// <list type="table">
///   <item><term>Amount</term><description>AmountType4Choice_ — optional (0..1)</description></item>
///   <item><term>RequestedExecutionDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>ExpiryDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>PaymentCondition</term><description>PaymentCondition2 — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation29 — optional (0..1)</description></item>
///   <item><term>PaymentMethod</term><description>PaymentMethod4Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>MandateRelatedInformation</term><description>CreditTransferMandateData1 — optional (0..1)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>EnclosedFile</term><description>Document15 collection — optional (0..n)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="PartyIdentification272"/> validator instance is reused across all five party
/// fields, the same <see cref="CashAccount40"/> validator instance across all three account
/// fields, and the same <see cref="BranchAndFinancialInstitutionIdentification8"/> validator
/// instance across <c>DebtorAgent</c> and <c>CreditorAgent</c> — see the two constructors below.
/// </remarks>
public class OriginalTransactionReference46Validator : AbstractValidator<OriginalTransactionReference46>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public OriginalTransactionReference46Validator(
        IValidator<AmountType4Choice_> amountValidator,
        IValidator<DateAndDateTime2Choice_> dateValidator,
        IValidator<PaymentCondition2> paymentConditionValidator,
        IValidator<PaymentTypeInformation29> paymentTypeInformationValidator,
        IValidator<CreditTransferMandateData1> mandateRelatedInformationValidator,
        IValidator<RemittanceInformation26> remittanceInformationValidator,
        IValidator<Document15> enclosedFileValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator
    )
    {
        When(x => x.Amount is not null, () => RuleFor(x => x.Amount).SetValidator(amountValidator!));
        When(
            x => x.RequestedExecutionDate is not null,
            () => RuleFor(x => x.RequestedExecutionDate).SetValidator(dateValidator!)
        );
        When(x => x.ExpiryDate is not null, () => RuleFor(x => x.ExpiryDate).SetValidator(dateValidator!));
        When(
            x => x.PaymentCondition is not null,
            () => RuleFor(x => x.PaymentCondition).SetValidator(paymentConditionValidator!)
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
        RuleForEach(x => x.EnclosedFile).SetValidator(enclosedFileValidator!);
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
        RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!);
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!)
        );
        RuleFor(x => x.Creditor).SetValidator(partyValidator!);
        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalTransactionReference46Validator()
        : this(
            new AmountType4Choice_Validator(),
            new DateAndDateTime2Choice_Validator(),
            new PaymentCondition2Validator(),
            new PaymentTypeInformation29Validator(),
            new CreditTransferMandateData1Validator(),
            new RemittanceInformation26Validator(),
            new Document15Validator(),
            new PartyIdentification272Validator(),
            new CashAccount40Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator()
        ) { }
}
