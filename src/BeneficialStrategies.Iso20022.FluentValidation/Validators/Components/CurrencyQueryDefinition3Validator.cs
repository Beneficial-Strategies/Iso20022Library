// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CurrencyQueryDefinition3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Ho80EZlZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the query criteria.
/// <list type="table">
///   <item><term>QueryType</term><description>QueryType2Code — optional (0..1)</description></item>
///   <item><term>CurrencyCriteria</term><description>CurrencyCriteriaDefinition1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>QueryType</c> is a closed C#
/// enum — no rule needed.
///
/// Dependency injection: <c>CurrencyCriteria</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class CurrencyQueryDefinition3Validator : AbstractValidator<CurrencyQueryDefinition3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>CurrencyCriteria</c> building block — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="currencyCriteriaValidator">
    /// Validator for the optional <c>CurrencyCriteria</c> building block
    /// (CurrencyCriteriaDefinition1Choice_, 0..1) — only invoked when present.
    /// </param>
    public CurrencyQueryDefinition3Validator(IValidator<CurrencyCriteriaDefinition1Choice_> currencyCriteriaValidator)
    {
        When(
            x => x.CurrencyCriteria is not null,
            () => RuleFor(x => x.CurrencyCriteria).SetValidator(currencyCriteriaValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>CurrencyCriteria</c> is
    /// validated by its own default validator
    /// (<see cref="CurrencyCriteriaDefinition1Choice_Validator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public CurrencyQueryDefinition3Validator()
        : this(new CurrencyCriteriaDefinition1Choice_Validator()) { }
}
