// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="IntraBalanceMovements4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _3syXoTEyEe6g-ffJsqGiSA
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
///   <item><term>CashAccountRule</term><description>CashAccount must be present or Movement(*)/CashAccount must be present, but not both.</description></item>
///   <item><term>CashAccountOwnerRule</term><description>CashAccountOwner must be present or Movement(*)/AccountOwner must be present, but not both.</description></item>
///   <item><term>StatusAndReasonRule</term><description>StatusAndReason must be present or Movement(*)/StatusAndReason must be present, but not both.</description></item>
///   <item><term>CashAccountServicerRule</term><description>CashAccountServicer must be present or Movement(*)/AccountOwner must be present, but not both.</description></item>
/// </list>
///
/// Note on <c>CashAccountServicerRule</c>: the spec text literally reads
/// "Movement(*)/AccountOwner" — identical wording to <c>CashAccountOwnerRule</c> just above it.
/// <see cref="IntraBalanceMovement7"/> has no <c>AccountOwner</c> element at all (only
/// <c>CashAccountOwner</c> and <c>CashAccountServicer</c>), and the rule name plus the pattern of
/// the other rules (each pairs the top-level field with the identically-named nested field) make
/// it clear this is a copy-paste typo in the spec's constraint text (same one found on
/// <see cref="IntraBalanceCancellation7"/> and <see cref="IntraBalanceModification7"/>) —
/// implemented here against <c>Movement(*)/CashAccountServicer</c>, the obviously-intended field,
/// not the literal (nonexistent) text.
/// </remarks>
public class IntraBalanceMovements4Validator : AbstractValidator<IntraBalanceMovements4>
{
    public IntraBalanceMovements4Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────
        // "X must be present or Movement(*)/X must be present, but not both" is a mandatory XOR
        // between the top-level field and the same field on every Movement entry.

        RuleFor(x => x)
            .Must(x => (x.CashAccount is not null) != x.Movement.All(m => m.CashAccount is not null))
            .WithName("CashAccountRule")
            .WithMessage(
                "CashAccount must be present or Movement(*)/CashAccount must be present, but not "
                    + "both (CashAccountRule)."
            );

        RuleFor(x => x)
            .Must(x => (x.CashAccountOwner is not null) != x.Movement.All(m => m.CashAccountOwner is not null))
            .WithName("CashAccountOwnerRule")
            .WithMessage(
                "CashAccountOwner must be present or Movement(*)/AccountOwner must be present, but "
                    + "not both (CashAccountOwnerRule)."
            );

        RuleFor(x => x)
            .Must(x => (x.StatusAndReason is not null) != x.Movement.All(m => m.StatusAndReason is not null))
            .WithName("StatusAndReasonRule")
            .WithMessage(
                "StatusAndReason must be present or Movement(*)/StatusAndReason must be present, "
                    + "but not both (StatusAndReasonRule)."
            );

        RuleFor(x => x)
            .Must(x => (x.CashAccountServicer is not null) != x.Movement.All(m => m.CashAccountServicer is not null))
            .WithName("CashAccountServicerRule")
            .WithMessage(
                "CashAccountServicer must be present or Movement(*)/CashAccountServicer must be "
                    + "present, but not both (CashAccountServicerRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // CashAccount (CashAccount40, 0..1), CashAccountOwner (SystemPartyIdentification8, 0..1),
        // CashAccountServicer (BranchAndFinancialInstitutionIdentification8, 0..1),
        // StatusAndReason (IntraBalanceStatusAndReason2, 0..1): no validator exists yet for
        // these; nested fields unvalidated beyond the cross-field constraints already enforced
        // above.

        // Movement: IntraBalanceMovement7, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.Movement)
            .NotEmpty()
            .WithMessage("IntraBalanceMovements4.Movement must contain at least one element (1..∞).");
    }
}
