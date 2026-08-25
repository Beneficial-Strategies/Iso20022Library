// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalTransactionReference45"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 4e387edc-deca-49ee-beb0-bf53f204c1d5
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Specifies key elements as defined in the original transaction. All 22 fields are optional
/// (0..1) — this component has no required fields.
/// <list type="table">
///   <item><term>InterbankSettlementAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>Amount</term><description>AmountType4Choice_ — optional (0..1)</description></item>
///   <item><term>RequestedExecutionDate</term><description>DateAndDateTime2Choice_ — optional (0..1)</description></item>
///   <item><term>CreditorSchemeIdentification</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>SettlementInformation</term><description>SettlementInstruction15 — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation27 — optional (0..1)</description></item>
///   <item><term>MandateRelatedInformation</term><description>MandateRelatedData5Choice_ — optional (0..1)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor/Debtor/Creditor/UltimateCreditor</term><description>Party50Choice_ — optional (0..1) each</description></item>
///   <item><term>DebtorAccount/CreditorAccount</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>DebtorAgent/CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>DebtorAgentAccount/CreditorAgentAccount</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>UnderlyingCustomerCreditTransfer</term><description>CreditTransferTransaction72 — optional (0..1)</description></item>
///   <item><term>UnderlyingFinancialInstitutionCreditTransfer</term><description>CreditTransferTransaction82 — optional (0..1)</description></item>
/// </list>
///
/// <c>InterbankSettlementDate</c>, <c>RequestedCollectionDate</c>, and <c>PaymentMethod</c> are
/// already fully enforced at their own struct/enum level — no rule needed.
///
/// No cross-field constraints found for this component itself.
///
/// <c>InterbankSettlementAmount</c> (<c>ActiveOrHistoricCurrencyAndAmount</c>, plain record, not
/// an <see cref="IIsoSimpleValue{T}"/> wrapper) has its <c>Currency</c> and <c>Amount</c> fields
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero. Only checked when present (0..1).
///
/// Dependency injection: per the pattern established in <c>OriginalTransactionReference47Validator</c>,
/// a single <see cref="IValidator{T}"/> instance is shared across every field of the same model
/// type rather than one parameter per field — one <c>Party50Choice_</c> validator across all 4
/// party fields, one <c>BranchAndFinancialInstitutionIdentification8</c> validator across both
/// agent fields, one <c>CashAccount40</c> validator across all 4 account fields — see the two
/// constructors below.
/// </remarks>
public class OriginalTransactionReference45Validator : AbstractValidator<OriginalTransactionReference45>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for every optional building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public OriginalTransactionReference45Validator(
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
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<CreditTransferTransaction72> underlyingCustomerCreditTransferValidator,
        IValidator<CreditTransferTransaction82> underlyingFinancialInstitutionCreditTransferValidator
    )
    {
        When(
            x => x.InterbankSettlementAmount is not null,
            () =>
            {
                RuleFor(x => x.InterbankSettlementAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "OriginalTransactionReference45.InterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.InterbankSettlementAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage(
                        "OriginalTransactionReference45.InterbankSettlementAmount.Amount must be greater than zero."
                    );
            }
        );

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

        When(x => x.UltimateDebtor is not null, () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!));
        When(x => x.Debtor is not null, () => RuleFor(x => x.Debtor).SetValidator(partyValidator!));
        When(x => x.DebtorAccount is not null, () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!));
        When(x => x.DebtorAgent is not null, () => RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!));
        When(x => x.DebtorAgentAccount is not null, () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!));
        When(x => x.CreditorAgent is not null, () => RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!));
        When(x => x.CreditorAgentAccount is not null, () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!));
        When(x => x.Creditor is not null, () => RuleFor(x => x.Creditor).SetValidator(partyValidator!));
        When(x => x.CreditorAccount is not null, () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!));
        When(x => x.UltimateCreditor is not null, () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!));

        When(x => x.Purpose is not null, () => RuleFor(x => x.Purpose).SetValidator(purposeValidator!));

        When(
            x => x.UnderlyingCustomerCreditTransfer is not null,
            () => RuleFor(x => x.UnderlyingCustomerCreditTransfer).SetValidator(underlyingCustomerCreditTransferValidator!)
        );
        When(
            x => x.UnderlyingFinancialInstitutionCreditTransfer is not null,
            () => RuleFor(x => x.UnderlyingFinancialInstitutionCreditTransfer)
                .SetValidator(underlyingFinancialInstitutionCreditTransferValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public OriginalTransactionReference45Validator()
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
            new Purpose2Choice_Validator(),
            new CreditTransferTransaction72Validator(),
            new CreditTransferTransaction82Validator()
        ) { }
}
