// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CurrencyExchangeSearchCriteria1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _IB771ZlZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the criteria used to search for currency exchange information.
/// <list type="table">
///   <item><term>SourceCurrency</term><description>ActiveOrHistoricCurrencyCode — required (1..1)</description></item>
///   <item><term>TargetCurrency</term><description>ActiveOrHistoricCurrencyCode — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: <c>SourceCurrency</c> and <c>TargetCurrency</c> share the same
/// <see cref="IValidator{T}"/> for the external code set <c>ActiveOrHistoricCurrencyCode</c> — one
/// injected validator serves both properties.
/// </remarks>
public class CurrencyExchangeSearchCriteria1Validator : AbstractValidator<CurrencyExchangeSearchCriteria1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>SourceCurrency</c>/<c>TargetCurrency</c> building blocks — e.g. resolved from a
    /// DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="currencyValidator">
    /// Validator for the <c>SourceCurrency</c> and <c>TargetCurrency</c> building blocks (both
    /// ActiveOrHistoricCurrencyCode).
    /// </param>
    public CurrencyExchangeSearchCriteria1Validator(IValidator<ActiveOrHistoricCurrencyCode> currencyValidator)
    {
        RuleFor(x => x.SourceCurrency).SetValidator(currencyValidator);
        RuleFor(x => x.TargetCurrency).SetValidator(currencyValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>SourceCurrency</c>/
    /// <c>TargetCurrency</c> are validated by their own default validator
    /// (<see cref="ActiveOrHistoricCurrencyCodeValidator"/>). Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CurrencyExchangeSearchCriteria1Validator()
        : this(new ActiveOrHistoricCurrencyCodeValidator()) { }
}
