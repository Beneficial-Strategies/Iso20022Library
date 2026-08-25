// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditTransferTransaction72"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 83c0d23e-26b3-45a5-9881-5eba6c105141
/// Spec source: queried via ISO 20022 MCP server (2026-08-25). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID (see [[project_stale_model_component_fields_defect]]
/// — matched exactly, no gap this time.
///
/// Provides further details specific to the individual transaction(s) included in the message —
/// the underlying customer credit transfer carried inside a cover-method
/// <see cref="CreditTransferTransaction79"/>.
/// <list type="table">
///   <item><term>Debtor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — required (1..1)</description></item>
///   <item><term>Creditor</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>PaymentIdentification</term><description>PaymentIdentification13 — optional (0..1)</description></item>
///   <item><term>PaymentTypeInformation</term><description>PaymentTypeInformation28 — optional (0..1)</description></item>
///   <item><term>UltimateDebtor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>PreviousInstructingAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>PreviousInstructingAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>UltimateCreditor</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructionForCreditorAgent</term><description>InstructionForCreditorAgent3 collection — optional (0..&#8734;)</description></item>
///   <item><term>InstructionForNextAgent</term><description>InstructionForNextAgent1 collection — optional (0..&#8734;)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — optional (0..1)</description></item>
///   <item><term>Tax</term><description>TaxData1 — optional (0..1)</description></item>
///   <item><term>RemittanceInformation</term><description>RemittanceInformation26 — optional (0..1)</description></item>
///   <item><term>InstructedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// <c>InstructedAmount</c> is an <c>ActiveOrHistoricCurrencyAndAmount</c> (plain record, not an
/// <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero.
///
/// Dependency injection: per the pattern established in <c>OriginalTransactionReference47Validator</c>,
/// a single <see cref="IValidator{T}"/> instance is shared across every field of the same model
/// type rather than one parameter per field — one <c>PartyIdentification272</c> validator across
/// all 4 party fields, one <c>BranchAndFinancialInstitutionIdentification8</c> validator across
/// all 8 agent fields, one <c>CashAccount40</c> validator across all 8 account fields — see the
/// two constructors below.
/// </remarks>
public class CreditTransferTransaction72Validator : AbstractValidator<CreditTransferTransaction72>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>Debtor</c>, <c>DebtorAgent</c>, <c>CreditorAgent</c>, <c>Creditor</c>,
    /// and every other optional building block — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    public CreditTransferTransaction72Validator(
        IValidator<PartyIdentification272> partyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PaymentIdentification13> paymentIdentificationValidator,
        IValidator<PaymentTypeInformation28> paymentTypeInformationValidator,
        IValidator<InstructionForCreditorAgent3> instructionForCreditorAgentValidator,
        IValidator<InstructionForNextAgent1> instructionForNextAgentValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<TaxData1> taxValidator,
        IValidator<RemittanceInformation26> remittanceInformationValidator
    )
    {
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);
        RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!);
        RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!);
        RuleFor(x => x.Creditor).SetValidator(partyValidator!);

        When(
            x => x.PaymentIdentification is not null,
            () => RuleFor(x => x.PaymentIdentification).SetValidator(paymentIdentificationValidator!)
        );

        When(
            x => x.PaymentTypeInformation is not null,
            () => RuleFor(x => x.PaymentTypeInformation).SetValidator(paymentTypeInformationValidator!)
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
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.DebtorAgentAccount is not null,
            () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!)
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

        When(x => x.Tax is not null, () => RuleFor(x => x.Tax).SetValidator(taxValidator!));

        When(
            x => x.RemittanceInformation is not null,
            () => RuleFor(x => x.RemittanceInformation).SetValidator(remittanceInformationValidator!)
        );

        When(
            x => x.InstructedAmount is not null,
            () =>
            {
                RuleFor(x => x.InstructedAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "CreditTransferTransaction72.InstructedAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.InstructedAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage("CreditTransferTransaction72.InstructedAmount.Amount must be greater than zero.");
            }
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditTransferTransaction72Validator()
        : this(
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PaymentIdentification13Validator(),
            new PaymentTypeInformation28Validator(),
            new InstructionForCreditorAgent3Validator(),
            new InstructionForNextAgent1Validator(),
            new Purpose2Choice_Validator(),
            new TaxData1Validator(),
            new RemittanceInformation26Validator()
        ) { }
}
