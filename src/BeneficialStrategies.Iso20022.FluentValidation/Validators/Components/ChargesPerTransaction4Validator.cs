// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ChargesPerTransaction4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6FpFYTEyEe6g-ffJsqGiSA
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
///   <item><term>ChargesAccountTransactionOrRecord2Rule</term><description>When Record/ChargesAccount is present or Record/ChargesAccountOwner is present then ChargesAccount must be absent and ChargesAccountOwner must be absent.</description></item>
///   <item><term>ChargesAccountTransactionOrRecord1Rule</term><description>When ChargesAccount is present or ChargesAccountOwner is present then Record/ChargesAccount must be absent and Record/ChargesAccountOwner must be absent.</description></item>
/// </list>
///
/// Dependency injection: the <c>Record</c> collection is validated per-item by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class ChargesPerTransaction4Validator : AbstractValidator<ChargesPerTransaction4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Record</c> collection's item type — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="recordValidator">
    /// Validator for each item of the <c>Record</c> collection (ChargesPerTransactionRecord4, 1..∞).
    /// </param>
    public ChargesPerTransaction4Validator(IValidator<ChargesPerTransactionRecord4> recordValidator)
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
            .WithName("ChargesAccountTransactionOrRecord2Rule")
            .WithMessage(
                "When Record/ChargesAccount is present or Record/ChargesAccountOwner is present "
                    + "then ChargesAccount must be absent and ChargesAccountOwner must be absent "
                    + "(ChargesAccountTransactionOrRecord2Rule)."
            );

        RuleFor(x => x)
            .Must(x =>
                !(
                    (x.ChargesAccount is not null || x.ChargesAccountOwner is not null)
                    && x.Record.Any(r => r.ChargesAccount is not null || r.ChargesAccountOwner is not null)
                )
            )
            .WithName("ChargesAccountTransactionOrRecord1Rule")
            .WithMessage(
                "When ChargesAccount is present or ChargesAccountOwner is present then "
                    + "Record/ChargesAccount must be absent and Record/ChargesAccountOwner must be "
                    + "absent (ChargesAccountTransactionOrRecord1Rule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // AdditionalInformation (Max140Text), ChargesIdentification (Max35Text): optional (0..1)
        // scalars, length enforced by struct constructors — no rule needed.

        // ChargesAccount (CashAccount40, 0..1), ChargesAccountOwner
        // (BranchAndFinancialInstitutionIdentification8, 0..1), TotalChargesPerTransaction
        // (TotalCharges7, 0..1): no validator exists yet for these; nested fields unvalidated
        // beyond the cross-field constraints already enforced above.

        // Record: ChargesPerTransactionRecord4, 1..∞ — NotEmpty on the collection, plus its own
        // validator applied per item.
        RuleFor(x => x.Record)
            .NotEmpty()
            .WithMessage("ChargesPerTransaction4.Record must contain at least one element (1..*).");

        RuleForEach(x => x.Record).SetValidator(recordValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Record</c> collection is
    /// validated by its own default validator (<see cref="ChargesPerTransactionRecord4Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public ChargesPerTransaction4Validator()
        : this(new ChargesPerTransactionRecord4Validator()) { }
}
