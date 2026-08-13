// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ChargesPerType6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _I__DMT0QEe-thIfLZ94a1w
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>Record</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item><term>ChargesAccountAgent2Rule</term><description>When Record/ChargesAccountAgent is present or Record/ChargesAccountAgentAccount is present then ChargesAccountAgent must be absent and ChargesAccountAgentAccount must be absent.</description></item>
///   <item><term>ChargesAccountAgentRule</term><description>When ChargesAccountAgent is present or ChargesAccountAgentAccount is present then Record/ChargesAccountAgent must be absent and Record/ChargesAccountAgentAccount must be absent.</description></item>
/// </list>
/// </remarks>
public sealed class ChargesPerType6Validator : AbstractValidator<ChargesPerType6>
{
    public ChargesPerType6Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────
        // Both rules express the same mutual-exclusivity between the top-level charges account
        // agent fields and the per-record equivalents; the spec states it from both directions.

        RuleFor(x => x)
            .Must(x =>
                !(
                    x.Record.Any(r => r.ChargesAccountAgent is not null || r.ChargesAccountAgentAccount is not null)
                    && (x.ChargesAccountAgent is not null || x.ChargesAccountAgentAccount is not null)
                )
            )
            .WithName("ChargesAccountAgent2Rule")
            .WithMessage(
                "When Record/ChargesAccountAgent is present or Record/ChargesAccountAgentAccount is "
                    + "present then ChargesAccountAgent must be absent and ChargesAccountAgentAccount "
                    + "must be absent (ChargesAccountAgent2Rule)."
            );

        RuleFor(x => x)
            .Must(x =>
                !(
                    (x.ChargesAccountAgent is not null || x.ChargesAccountAgentAccount is not null)
                    && x.Record.Any(r => r.ChargesAccountAgent is not null || r.ChargesAccountAgentAccount is not null)
                )
            )
            .WithName("ChargesAccountAgentRule")
            .WithMessage(
                "When ChargesAccountAgent is present or ChargesAccountAgentAccount is present then "
                    + "Record/ChargesAccountAgent must be absent and Record/ChargesAccountAgentAccount "
                    + "must be absent (ChargesAccountAgentRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // Type (ChargeType3Choice_): required (1..1) and already `required` C# property — no
        // rule needed. No validator exists yet for ChargeType3Choice_ variants; nested fields
        // unvalidated.

        // AdditionalInformation (Max140Text), ChargesIdentification (Max35Text): optional (0..1)
        // scalars, length enforced by struct constructors — no rule needed.

        // ChargesAccountAgent (BranchAndFinancialInstitutionIdentification8, 0..1),
        // ChargesAccountAgentAccount (CashAccount40, 0..1), TotalChargesPerChargeType
        // (TotalCharges7, 0..1): no validator exists yet for these; nested fields unvalidated
        // beyond the cross-field constraints already enforced above.

        // Record: ChargesPerTypeRecord6, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Record)
            .NotEmpty()
            .WithMessage("ChargesPerType6.Record must contain at least one element (1..*).");
    }
}
