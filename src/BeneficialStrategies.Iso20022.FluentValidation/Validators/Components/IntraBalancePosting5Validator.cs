// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="IntraBalancePosting5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _ZMt4zTneEem7JZMuWtwtsg
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Movement</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class IntraBalancePosting5Validator : AbstractValidator<IntraBalancePosting5>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="IntraBalancePosting5"/>.
    /// </summary>
    public IntraBalancePosting5Validator()
    {
        // BalanceFrom (CashSubBalanceTypeAndQuantityBreakdown3): required (1..1) and already
        // `required` C# property — no rule needed. No validator exists yet for it; nested fields
        // unvalidated.

        // Movement: IntraBalancePosting6, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Movement)
            .NotEmpty()
            .WithMessage("IntraBalancePosting5.Movement must contain at least one element (1..∞).");
    }
}
