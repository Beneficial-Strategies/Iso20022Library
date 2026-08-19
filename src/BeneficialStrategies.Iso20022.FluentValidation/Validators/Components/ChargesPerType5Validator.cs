// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ChargesPerType5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _sjYHYT0JEe-thIfLZ94a1w
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
///   <item><term>ChargesAccountTypeOrRecord2Rule</term><description>When Record/ChargesAccount is present or Record/ChargesAccountOwner is present then ChargesAccount must be absent and ChargesAccountOwner must be absent.</description></item>
///   <item><term>ChargesAccountTypeOrRecord1Rule</term><description>When ChargesAccount is present or ChargesAccountOwner is present then Record/ChargesAccount must be absent and Record/ChargesAccountOwner must be absent.</description></item>
/// </list>
/// </remarks>
public class ChargesPerType5Validator : AbstractValidator<ChargesPerType5>
{
    public ChargesPerType5Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────
        // Both rules express the same mutual-exclusivity between the top-level charges account
        // fields and the per-record equivalents; the spec states it from both directions.

        RuleFor(x => x)
            .Must(x =>
                !(
                    x.Record.Any(r => r.ChargesAccount is not null || r.ChargesAccountOwner is not null)
                    && (x.ChargesAccount is not null || x.ChargesAccountOwner is not null)
                )
            )
            .WithName("ChargesAccountTypeOrRecord2Rule")
            .WithMessage(
                "When Record/ChargesAccount is present or Record/ChargesAccountOwner is present "
                    + "then ChargesAccount must be absent and ChargesAccountOwner must be absent "
                    + "(ChargesAccountTypeOrRecord2Rule)."
            );

        RuleFor(x => x)
            .Must(x =>
                !(
                    (x.ChargesAccount is not null || x.ChargesAccountOwner is not null)
                    && x.Record.Any(r => r.ChargesAccount is not null || r.ChargesAccountOwner is not null)
                )
            )
            .WithName("ChargesAccountTypeOrRecord1Rule")
            .WithMessage(
                "When ChargesAccount is present or ChargesAccountOwner is present then "
                    + "Record/ChargesAccount must be absent and Record/ChargesAccountOwner must be "
                    + "absent (ChargesAccountTypeOrRecord1Rule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // Type (ChargeType3Choice_): required (1..1) and already `required` C# property — no
        // rule needed. No validator exists yet for ChargeType3Choice_ variants; nested fields
        // unvalidated.

        // AdditionalInformation (Max140Text), ChargesIdentification (Max35Text): optional (0..1)
        // scalars, length enforced by struct constructors — no rule needed.

        // ChargesAccount (CashAccount40, 0..1), ChargesAccountOwner
        // (BranchAndFinancialInstitutionIdentification8, 0..1), TotalChargesPerChargeType
        // (TotalCharges7, 0..1): no validator exists yet for these; nested fields unvalidated
        // beyond the cross-field constraints already enforced above.

        // Record: ChargesPerTypeRecord5, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Record)
            .NotEmpty()
            .WithMessage("ChargesPerType5.Record must contain at least one element (1..*).");
    }
}
