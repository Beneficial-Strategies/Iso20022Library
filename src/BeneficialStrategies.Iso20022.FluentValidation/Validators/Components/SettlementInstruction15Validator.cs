// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SettlementInstruction15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wFG0kTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides further details on the settlement of the instruction.
/// <list type="table">
///   <item><term>ClearingSystem</term><description>ClearingSystemIdentification3Choice_ — optional (0..1)</description></item>
///   <item><term>InstructedReimbursementAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedReimbursementAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>InstructingReimbursementAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructingReimbursementAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>SettlementAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>SettlementMethod</term><description>SettlementMethod1Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>ThirdReimbursementAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>ThirdReimbursementAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> validator instance is reused across
/// all three agent fields and the same <see cref="CashAccount40"/> validator instance across all
/// four account fields — see the two constructors below.
/// </remarks>
public class SettlementInstruction15Validator : AbstractValidator<SettlementInstruction15>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public SettlementInstruction15Validator(
        IValidator<ClearingSystemIdentification3Choice_> clearingSystemValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator
    )
    {
        When(
            x => x.ClearingSystem is not null,
            () => RuleFor(x => x.ClearingSystem).SetValidator(clearingSystemValidator!)
        );
        When(
            x => x.InstructedReimbursementAgent is not null,
            () => RuleFor(x => x.InstructedReimbursementAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.InstructedReimbursementAgentAccount is not null,
            () => RuleFor(x => x.InstructedReimbursementAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.InstructingReimbursementAgent is not null,
            () => RuleFor(x => x.InstructingReimbursementAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.InstructingReimbursementAgentAccount is not null,
            () => RuleFor(x => x.InstructingReimbursementAgentAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.SettlementAccount is not null,
            () => RuleFor(x => x.SettlementAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.ThirdReimbursementAgent is not null,
            () => RuleFor(x => x.ThirdReimbursementAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.ThirdReimbursementAgentAccount is not null,
            () => RuleFor(x => x.ThirdReimbursementAgentAccount).SetValidator(cashAccountValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public SettlementInstruction15Validator()
        : this(
            new ClearingSystemIdentification3Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator()
        ) { }
}
