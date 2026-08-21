// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AdviceType1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5ZNFsNolEembTrt_WixjyQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the type of advice to report back for the transaction.
/// <list type="table">
///   <item><term>CreditAdvice</term><description>AdviceType1Choice_ — optional (0..1)</description></item>
///   <item><term>DebitAdvice</term><description>AdviceType1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: both building blocks are validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class AdviceType1Validator : AbstractValidator<AdviceType1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public AdviceType1Validator(IValidator<AdviceType1Choice_> adviceTypeValidator)
    {
        When(x => x.CreditAdvice is not null, () => RuleFor(x => x.CreditAdvice).SetValidator(adviceTypeValidator!));
        When(x => x.DebitAdvice is not null, () => RuleFor(x => x.DebitAdvice).SetValidator(adviceTypeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public AdviceType1Validator()
        : this(new AdviceType1Choice_Validator()) { }
}
