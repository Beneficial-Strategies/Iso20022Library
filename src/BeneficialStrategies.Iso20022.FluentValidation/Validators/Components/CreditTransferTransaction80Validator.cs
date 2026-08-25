// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction80"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _eyUN4XePEfCdoODv2ypKfw
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Provides further details specific to the individual transaction(s) included in the message —
/// the underlying financial institution credit transfer carried inside a cover-method
/// <see cref="CreditTransferTransaction79"/>. Every party/agent field on this version is a
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> (both debtor and creditor sides are
/// financial institutions), unlike <see cref="CreditTransferTransaction72"/>'s
/// <see cref="PartyIdentification272"/> debtor/creditor fields.
/// <list type="table">
///   <item><term>PaymentIdentification</term><description>PaymentIdentification13 — required (1..1)</description></item>
///   <item><term>InterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>Debtor</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>Creditor</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>SettlementTimeIndication</term><description>SettlementDateTimeIndication1 — optional (0..1)</description></item>
///   <item><term>SettlementTimeRequest</term><description>SettlementTimeRequest2 — optional (0..1)</description></item>
///   <item><term>PaymentSignature</term><description>CryptographicKey1Choice_ — optional (0..1)</description></item>
///   <item><term>PreviousInstructingAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>PreviousInstructingAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>UltimateDebtor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 collection — optional (0..&#8734;)</description></item>
///   <item><term>InstructionForNextAgent</term><description>InstructionForNextAgent1 collection — optional (0..&#8734;)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>RegulatoryReporting</term><description>RegulatoryReporting10 collection — optional (0..10)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation2 — optional (0..1)</description></item>
///   <item><term>UnderlyingAllocation</term><description>TransactionAllocation2 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// All remaining scalar fields (<c>InterbankSettlementDate</c>, <c>SettlementPriority</c>,
/// <c>ExpiryDateTime</c>) are already fully enforced at their own struct/enum level — no rule
/// needed.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// <c>InterbankSettlementAmount</c> is an <c>ActiveCurrencyAndAmount</c> (plain record, not an
/// <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero.
///
/// Dependency injection: a single <see cref="IValidator{T}"/> instance is shared across every
/// field of the same model type — one <c>BranchAndFinancialInstitutionIdentification8</c>
/// validator across all 12 agent fields, one <c>CashAccount40</c> validator across all 9 account
/// fields — see the two constructors below.
/// </remarks>
public class CreditTransferTransaction80Validator : AbstractValidator<CreditTransferTransaction80>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>PaymentIdentification</c>, <c>Debtor</c>, <c>Creditor</c>, and every
    /// other optional building block — e.g. resolved from a DI container — instead of this type
    /// constructing its own.
    /// </summary>
    public CreditTransferTransaction80Validator(
        IValidator<PaymentIdentification13> paymentIdentificationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<SettlementDateTimeIndication1> settlementTimeIndicationValidator,
        IValidator<SettlementTimeRequest2> settlementTimeRequestValidator,
        IValidator<CryptographicKey1Choice_> paymentSignatureValidator,
        IValidator<InstructionForCreditorAgent3> instructionForCreditorAgentValidator,
        IValidator<InstructionForNextAgent1> instructionForNextAgentValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<RegulatoryReporting10> regulatoryReportingValidator,
        IValidator<RemittanceInformation2> remittanceInformationValidator,
        IValidator<TransactionAllocation2> underlyingAllocationValidator
    )
    {
        RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!);
        RuleFor(x => x.Debtor).SetValidator(agentValidator!);
        RuleFor(x => x.Creditor).SetValidator(agentValidator!);

        // ── InterbankSettlementAmount (ActiveCurrencyAndAmount, required 1..1) ───────
        RuleFor(x => x.InterbankSettlementAmount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "CreditTransferTransaction80.InterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );
        RuleFor(x => x.InterbankSettlementAmount.Amount)
            .GreaterThan(0)
            .WithMessage("CreditTransferTransaction80.InterbankSettlementAmount.Amount must be greater than zero.");

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
            x => x.UltimateDebtor is not null,
            () => RuleFor(x => x.UltimateDebtor).SetValidator(agentValidator!)
        );
        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.DebtorAgent is not null,
            () => RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
        );

        When(
            x => x.CreditorAgent is not null,
            () => RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!)
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
            () => RuleFor(x => x.UltimateCreditor).SetValidator(agentValidator!)
        );

        RuleForEach(x => x.InstructionForCreditorAgent).SetValidator(instructionForCreditorAgentValidator!);
        RuleForEach(x => x.InstructionForNextAgent).SetValidator(instructionForNextAgentValidator!);

        When(x => x.Purpose is not null, () => RuleFor(x => x.Purpose).SetValidator(purposeValidator!));

        RuleForEach(x => x.RegulatoryReporting).SetValidator(regulatoryReportingValidator!);

        When(
            x => x.RemittanceInformation is not null,
            () => RuleFor(x => x.RemittanceInformation).SetValidator(remittanceInformationValidator!)
        );

        RuleForEach(x => x.UnderlyingAllocation).SetValidator(underlyingAllocationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditTransferTransaction80Validator()
        : this(
            new PaymentIdentification13Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PaymentTypeInformation28Validator(),
            new SettlementDateTimeIndication1Validator(),
            new SettlementTimeRequest2Validator(),
            new CryptographicKey1Choice_Validator(),
            new InstructionForCreditorAgent3Validator(),
            new InstructionForNextAgent1Validator(),
            new Purpose2Choice_Validator(),
            new RegulatoryReporting10Validator(),
            new RemittanceInformation2Validator(),
            new TransactionAllocation2Validator()
        ) { }
}
