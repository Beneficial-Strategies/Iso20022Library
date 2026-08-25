// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TransactionParties11"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5b7aATEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-26). Field-completeness cross-checked
/// against the current MCP snapshot for this exact ISO ID — matched exactly, no gap.
///
/// Provides further details on the parties specific to the individual transaction.
/// <list type="table">
///   <item><term>Creditor</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>Debtor</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>CreditorAccount/DebtorAccount</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>CreditorAgent/DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>CreditorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>DebtorAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>InitiatingParty/UltimateCreditor/UltimateDebtor</term><description>Party50Choice_ — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>IntermediaryAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
///   <item><term>PreviousInstructingAgent1/2/3</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1) each</description></item>
///   <item><term>PreviousInstructingAgent1/2/3Account</term><description>CashAccount40 — optional (0..1) each</description></item>
/// </list>
///
/// No cross-field constraints found for this component itself.
///
/// Dependency injection: per the pattern established in <c>OriginalTransactionReference47Validator</c>,
/// a single <see cref="IValidator{T}"/> instance is shared across every field of the same model
/// type rather than one parameter per field — one <c>Party50Choice_</c> validator across all 5
/// party fields, one <c>BranchAndFinancialInstitutionIdentification8</c> validator across all 8
/// agent fields, one <c>CashAccount40</c> validator across all 9 account fields — see the two
/// constructors below.
/// </remarks>
public class TransactionParties11Validator : AbstractValidator<TransactionParties11>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>Creditor</c>/<c>Debtor</c> and every optional building block — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TransactionParties11Validator(
        IValidator<Party50Choice_> partyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator
    )
    {
        RuleFor(x => x.Creditor).SetValidator(partyValidator!);
        RuleFor(x => x.Debtor).SetValidator(partyValidator!);

        When(x => x.CreditorAccount is not null, () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!));
        When(x => x.CreditorAgent is not null, () => RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!));
        When(x => x.CreditorAgentAccount is not null, () => RuleFor(x => x.CreditorAgentAccount).SetValidator(cashAccountValidator!));

        When(x => x.DebtorAccount is not null, () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!));
        When(x => x.DebtorAgent is not null, () => RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!));
        When(x => x.DebtorAgentAccount is not null, () => RuleFor(x => x.DebtorAgentAccount).SetValidator(cashAccountValidator!));

        When(x => x.InitiatingParty is not null, () => RuleFor(x => x.InitiatingParty).SetValidator(partyValidator!));

        When(x => x.IntermediaryAgent1 is not null, () => RuleFor(x => x.IntermediaryAgent1).SetValidator(agentValidator!));
        When(x => x.IntermediaryAgent1Account is not null, () => RuleFor(x => x.IntermediaryAgent1Account).SetValidator(cashAccountValidator!));
        When(x => x.IntermediaryAgent2 is not null, () => RuleFor(x => x.IntermediaryAgent2).SetValidator(agentValidator!));
        When(x => x.IntermediaryAgent2Account is not null, () => RuleFor(x => x.IntermediaryAgent2Account).SetValidator(cashAccountValidator!));
        When(x => x.IntermediaryAgent3 is not null, () => RuleFor(x => x.IntermediaryAgent3).SetValidator(agentValidator!));
        When(x => x.IntermediaryAgent3Account is not null, () => RuleFor(x => x.IntermediaryAgent3Account).SetValidator(cashAccountValidator!));

        When(x => x.PreviousInstructingAgent1 is not null, () => RuleFor(x => x.PreviousInstructingAgent1).SetValidator(agentValidator!));
        When(x => x.PreviousInstructingAgent1Account is not null, () => RuleFor(x => x.PreviousInstructingAgent1Account).SetValidator(cashAccountValidator!));
        When(x => x.PreviousInstructingAgent2 is not null, () => RuleFor(x => x.PreviousInstructingAgent2).SetValidator(agentValidator!));
        When(x => x.PreviousInstructingAgent2Account is not null, () => RuleFor(x => x.PreviousInstructingAgent2Account).SetValidator(cashAccountValidator!));
        When(x => x.PreviousInstructingAgent3 is not null, () => RuleFor(x => x.PreviousInstructingAgent3).SetValidator(agentValidator!));
        When(x => x.PreviousInstructingAgent3Account is not null, () => RuleFor(x => x.PreviousInstructingAgent3Account).SetValidator(cashAccountValidator!));

        When(x => x.UltimateCreditor is not null, () => RuleFor(x => x.UltimateCreditor).SetValidator(partyValidator!));
        When(x => x.UltimateDebtor is not null, () => RuleFor(x => x.UltimateDebtor).SetValidator(partyValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TransactionParties11Validator()
        : this(
            new Party50Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator()
        ) { }
}
