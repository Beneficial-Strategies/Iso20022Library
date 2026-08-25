// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SettlementInstruction14"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _g2NR-9cZEeqRFcf2R4bPBw
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further details on the settlement of the instruction.
/// <list type="table">
///   <item><term>SettlementMethod</term><description>SettlementMethod2Code — required (1..1); closed enum, already `required` C# property — no rule needed</description></item>
///   <item><term>SettlementAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>ClearingSystem</term><description>ClearingSystemIdentification3Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>SettlementAccount</c> and <c>ClearingSystem</c> are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class SettlementInstruction14Validator : AbstractValidator<SettlementInstruction14>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the optional <c>SettlementAccount</c> and <c>ClearingSystem</c> building blocks — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="settlementAccountValidator">
    /// Validator for the optional <c>SettlementAccount</c> building block (CashAccount40, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="clearingSystemValidator">
    /// Validator for the optional <c>ClearingSystem</c> building block
    /// (ClearingSystemIdentification3Choice_, 0..1) — only invoked when present.
    /// </param>
    public SettlementInstruction14Validator(
        IValidator<CashAccount40> settlementAccountValidator,
        IValidator<ClearingSystemIdentification3Choice_> clearingSystemValidator
    )
    {
        // SettlementMethod: closed SettlementMethod2Code enum, required — no rule needed.

        When(
            x => x.SettlementAccount is not null,
            () => RuleFor(x => x.SettlementAccount).SetValidator(settlementAccountValidator!)
        );

        When(
            x => x.ClearingSystem is not null,
            () => RuleFor(x => x.ClearingSystem).SetValidator(clearingSystemValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>SettlementAccount</c> and
    /// <c>ClearingSystem</c> are each validated by their own default validator
    /// (<see cref="CashAccount40Validator"/>, <see cref="ClearingSystemIdentification3Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public SettlementInstruction14Validator()
        : this(new CashAccount40Validator(), new ClearingSystemIdentification3Choice_Validator()) { }
}
