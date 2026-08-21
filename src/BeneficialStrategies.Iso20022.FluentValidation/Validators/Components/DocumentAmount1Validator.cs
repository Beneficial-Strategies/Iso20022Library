// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentAmount1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _vRiGoDKzEe6dJsbzsnAdDg
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides details on the amount and type of the referred document.
/// <list type="table">
///   <item><term>Amount</term><description>ActiveOrHistoricCurrencyAndAmount — required (1..1), Amounts-namespace exemption</description></item>
///   <item><term>Type</term><description>DocumentAmountType1Choice_ — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Type</c> is validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class DocumentAmount1Validator : AbstractValidator<DocumentAmount1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DocumentAmount1Validator(IValidator<DocumentAmountType1Choice_> typeValidator)
    {
        RuleFor(x => x.Type).SetValidator(typeValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DocumentAmount1Validator()
        : this(new DocumentAmountType1Choice_Validator()) { }
}
