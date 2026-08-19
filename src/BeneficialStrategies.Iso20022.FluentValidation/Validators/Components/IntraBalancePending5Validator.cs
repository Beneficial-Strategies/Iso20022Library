// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="IntraBalancePending5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Ys-BmzneEem7JZMuWtwtsg
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Movement</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item><term>StatusAndReasonRule</term><description>StatusAndReason must be present or Movement(*)/StatusAndReason must be present, but not both.</description></item>
/// </list>
/// </remarks>
public class IntraBalancePending5Validator : AbstractValidator<IntraBalancePending5>
{
    public IntraBalancePending5Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────

        RuleFor(x => x)
            .Must(x => (x.StatusAndReason is not null) != x.Movement.All(m => m.StatusAndReason is not null))
            .WithName("StatusAndReasonRule")
            .WithMessage(
                "StatusAndReason must be present or Movement(*)/StatusAndReason must be present, "
                    + "but not both (StatusAndReasonRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // Movement: IntraBalancePending6, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Movement)
            .NotEmpty()
            .WithMessage("IntraBalancePending5.Movement must contain at least one element (1..∞).");
    }
}
