// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction73"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: d64d5a68-1284-4122-abcc-66b60f276023
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further details specific to the individual transaction(s) included in the message.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification13 — required (1..1)</description></item>
///   <item><term>InterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>ChargeBearer</term><description>ChargeBearerType1Code — required (1..1); closed enum, no rule needed</description></item>
///   <item><term>Debtor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>SettlementTimeRequest</term><description>SettlementTimeRequest2 — optional (0..1)</description></item>
///   <item><term>AdditionalDateTime</term><description>AdditionalDateTime1 — optional (0..1)</description></item>
///   <item><term>InstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
///   <item><term>ChargesInformation</term><description>Charges16 collection — optional (0..&#8734;)</description></item>
///   <item><term>AgreedRate</term><description>CurrencyExchange26 — optional (0..1)</description></item>
///   <item><term>MandateRelatedInformation</term><description>CreditTransferMandateData1 — optional (0..1)</description></item>
///   <item><term>PaymentSignature</term><description>CryptographicKey1Choice_ — optional (0..1)</description></item>
///   <item><term>PreviousInstructingAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>PreviousInstructingAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 collection — optional (0..&#8734;)</description></item>
///   <item><term>InstructionForNextAgent</term><description>InstructionForNextAgent1 collection — optional (0..&#8734;)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 collection — optional (0..&#8734;)</description></item>
///   <item><term>Tax</term><description>TaxData1 — optional (0..1)</description></item>
///   <item><term>RelatedRemittanceInformation</term><description>RemittanceLocation8 collection — optional (0..&#8734;)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation22 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// No cross-field constraints found for this component itself (no "constraint" declaration rows
/// under its ISO dictionary entry) — the message-level constraints tying this component's
/// <c>InstructingAgent</c>, <c>InstructedAgent</c>, <c>InterbankSettlementDate</c>,
/// <c>PaymentTypeInformation</c>, <c>InterbankSettlementAmount</c>, and
/// <c>AdditionalDateTime.ExpiryDateTime</c> fields to the message's <c>GroupHeader</c> are
/// enforced in <c>FIToFICustomerCreditTransferV14Validator</c>.
///
/// <c>InstructedAmount</c> is an <c>ActiveOrHistoricCurrencyAndAmount</c> (plain record, not an
/// <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero. <c>InterbankSettlementAmount</c> (required, <c>ActiveCurrencyAndAmount</c>)
/// gets the same treatment.
///
/// Dependency injection: per the pattern established in <c>OriginalTransactionReference47Validator</c>,
/// a single <see cref="IValidator{T}"/> instance is shared across every field of the same model
/// type rather than one parameter per field — one <c>BranchAndFinancialInstitutionIdentification8</c>
/// validator across all 8 agent fields, one <c>CashAccount40</c> validator across all 8 account
/// fields, one <c>PartyIdentification272</c> validator across all 5 party fields — see the two
/// constructors below.
/// </remarks>
public class CreditTransferTransaction73Validator : AbstractValidator<CreditTransferTransaction73>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>PaymentIdentification</c>, <c>Debtor</c>, <c>DebtorAgent</c>,
    /// <c>CreditorAgent</c>, <c>Creditor</c>, and every other optional building block — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditTransferTransaction73Validator(
        IValidator<PaymentIdentification13> paymentIdentificationValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<SettlementTimeRequest2> settlementTimeRequestValidator,
        IValidator<AdditionalDateTime1> additionalDateTimeValidator,
        IValidator<Charges16> chargesInformationValidator,
        IValidator<CurrencyExchange26> agreedRateValidator,
        IValidator<CreditTransferMandateData1> mandateRelatedInformationValidator,
        IValidator<CryptographicKey1Choice_> paymentSignatureValidator,
        IValidator<InstructionForCreditorAgent3> instructionForCreditorAgentValidator,
        IValidator<InstructionForNextAgent1> instructionForNextAgentValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<RegulatoryReporting10> regulatoryReportingValidator,
        IValidator<TaxData1> taxValidator,
        IValidator<RemittanceLocation8> relatedRemittanceInformationValidator,
        IValidator<RemittanceInformation22> remittanceInformationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!);
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);
        RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!);
        RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!);
        RuleFor(x => x.Creditor).SetValidator(partyValidator!);

        // ── InterbankSettlementAmount (ActiveCurrencyAndAmount, required 1..1) ───────
        RuleFor(x => x.InterbankSettlementAmount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "CreditTransferTransaction73.InterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );
        RuleFor(x => x.InterbankSettlementAmount.Amount)
            .GreaterThan(0)
            .WithMessage("CreditTransferTransaction73.InterbankSettlementAmount.Amount must be greater than zero.");

        // ChargeBearer: closed ChargeBearerType1Code enum, required — no rule needed.

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
            x => x.AdditionalDateTime is not null,
            () => RuleFor(x => x.AdditionalDateTime).SetValidator(additionalDateTimeValidator!)
        );

        When(
            x => x.InstructedAmount is not null,
            () =>
            {
                RuleFor(x => x.InstructedAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "CreditTransferTransaction73.InstructedAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.InstructedAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("CreditTransferTransaction73.InstructedAmount.Amount must be greater than zero.");
            }
        );

        RuleForEach(x => x.ChargesInformation).SetValidator(chargesInformationValidator!);

        When(x => x.AgreedRate is not null, () => RuleFor(x => x.AgreedRate).SetValidator(agreedRateValidator!));

        When(
            x => x.MandateRelatedInformation is not null,
            () => RuleFor(x => x.MandateRelatedInformation).SetValidator(mandateRelatedInformationValidator!)
        );

        When(
            x => x.PaymentSignature is not null,
            () => RuleFor(x => x.PaymentSignature).SetValidator(paymentSignatureValidator!)
        );

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
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!)
        );
        When(
            x => x.InitiatingParty is not null,
            () => RuleFor(x => x.InitiatingParty).SetValidator(partyValidator!)
        );
        When(
            x => x.CreditorAgentAccount is not null,
            () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.UltimateCreditor is not null,
            () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!)
        );

        RuleForEach(x => x.InstructionForCreditorAgent).SetValidator(instructionForCreditorAgentValidator!);
        RuleForEach(x => x.InstructionForNextAgent).SetValidator(instructionForNextAgentValidator!);

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
    public CreditTransferTransaction73Validator()
        : this(
            new PaymentIdentification13Validator(),
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PaymentTypeInformation28Validator(),
            new SettlementDateTimeIndication1Validator(),
            new SettlementTimeRequest2Validator(),
            new AdditionalDateTime1Validator(),
            new Charges16Validator(),
            new CurrencyExchange26Validator(),
            new CreditTransferMandateData1Validator(),
            new CryptographicKey1Choice_Validator(),
            new InstructionForCreditorAgent3Validator(),
            new InstructionForNextAgent1Validator(),
            new Purpose2Choice_Validator(),
            new RegulatoryReporting10Validator(),
            new TaxData1Validator(),
            new RemittanceLocation8Validator(),
            new RemittanceInformation22Validator(),
            new SupplementaryData1Validator()
        ) { }
}
