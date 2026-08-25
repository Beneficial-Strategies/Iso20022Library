// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DirectDebitTransactionInformation35"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: a6fc8316-6307-4582-89c4-560440222204
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Provides further details specific to the individual direct debit transaction(s) included in
/// the message.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification13 — required (1..1)</description></item>
///   <item><term>InterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — required (1..1); closed enum, no rule needed</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — required (1..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation27 — optional (0..1)</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>InstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..&#8734;)</description></item>
///   <item><term>DirectDebitTransaction</term><description>DirectDebitTransaction12 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 collection — optional (0..10)</description></item>
///   <item><term>RelatedRemittanceInformation</term><description>RemittanceLocation8 collection — optional (0..10)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// All remaining scalar fields (<c>InterbankSettlementDate</c>, <c>SettlementPriority</c>,
/// <c>ExchangeRate</c>, <c>RequestedCollectionDate</c>) are already fully enforced at their own
/// struct/enum level — no rule needed.
///
/// No cross-field constraints found for this component itself (no "constraint" declaration rows
/// under its ISO dictionary entry) — the message-level constraints tying this component's
/// <c>InstructingAgent</c>, <c>InstructedAgent</c>, <c>InterbankSettlementDate</c>,
/// <c>PaymentTypeInformation</c>, and <c>InterbankSettlementAmount</c> fields to the message's
/// <c>GroupHeader</c> are enforced in <c>FIToFICustomerDirectDebitV12Validator</c>.
///
/// <c>InterbankSettlementAmount</c> (required, <c>ActiveCurrencyAndAmount</c>) and
/// <c>InstructedAmount</c> (optional, <c>ActiveOrHistoricCurrencyAndAmount</c>) are plain records
/// (not <see cref="IIsoSimpleValue{T}"/> wrappers) — their <c>Currency</c> and <c>Amount</c>
/// fields are validated inline here per the established convention (see
/// <c>PaymentTransaction137Validator</c> and <c>AmountAndDirection5Validator</c>): ISO 4217
/// three-letter currency pattern, amount greater than zero.
///
/// Dependency injection: per the pattern established in <c>OriginalTransactionReference47Validator</c>,
/// a single <see cref="IValidator{T}"/> instance is shared across every field of the same model
/// type rather than one parameter per field — one <c>PartyIdentification272</c> validator across
/// all 5 party fields, one <c>BranchAndFinancialInstitutionIdentification8</c> validator across
/// all 7 agent fields, one <c>CashAccount40</c> validator across all 6 account fields — see the
/// two constructors below.
/// </remarks>
public class DirectDebitTransactionInformation35Validator : AbstractValidator<DirectDebitTransactionInformation35>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>PaymentIdentification</c>, <c>Creditor</c>, <c>CreditorAgent</c>,
    /// <c>Debtor</c>, <c>DebtorAccount</c>, <c>DebtorAgent</c>, and every other optional building
    /// block — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DirectDebitTransactionInformation35Validator(
        IValidator<PaymentIdentification13> paymentIdentificationValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PaymentTypeInformation27> paymentTypeInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<DirectDebitTransaction12> directDebitTransactionValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<RegulatoryReporting10> regulatoryReportingValidator,
        IValidator<RemittanceLocation8> relatedRemittanceInformationValidator,
        IValidator<RemittanceInformation26> remittanceInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!);
        RuleFor(x => x.Creditor).SetValidator(partyValidator!);
        RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!);
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);
        RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!);
        RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!);

        // ── InterbankSettlementAmount (ActiveCurrencyAndAmount, required 1..1) ───────
        RuleFor(x => x.InterbankSettlementAmount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "DirectDebitTransactionInformation35.InterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );
        RuleFor(x => x.InterbankSettlementAmount.Amount)
            .GreaterThan(0)
            .WithMessage(
                "DirectDebitTransactionInformation35.InterbankSettlementAmount.Amount must be greater than zero."
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
            x => x.InstructedAmount is not null,
            () =>
            {
                RuleFor(x => x.InstructedAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "DirectDebitTransactionInformation35.InstructedAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.InstructedAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage(
                        "DirectDebitTransactionInformation35.InstructedAmount.Amount must be greater than zero."
                    );
            }
        );

        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);

        When(
            x => x.DirectDebitTransaction is not null,
            () => RuleFor(x => x.DirectDebitTransaction).SetValidator(directDebitTransactionValidator!)
        );

        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );
        When(
            x => x.InitiatingParty is not null,
            () => RuleFor(x => x.InitiatingParty).SetValidator(partyValidator!)
        );

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(agentValidator!)
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

        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!)
        );

        When(x => x.Purpose is not null, () => RuleFor(x => x.Purpose).SetValidator(purposeValidator!));

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
    public DirectDebitTransactionInformation35Validator()
        : this(
            new PaymentIdentification13Validator(),
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PaymentTypeInformation27Validator(),
            new SettlementDateTimeIndication1Validator(),
            new Charges16Validator(),
            new DirectDebitTransaction12Validator(),
            new Purpose2Choice_Validator(),
            new RegulatoryReporting10Validator(),
            new RemittanceLocation8Validator(),
            new RemittanceInformation26Validator(),
            new SupplementaryData1Validator()
        ) { }
}
