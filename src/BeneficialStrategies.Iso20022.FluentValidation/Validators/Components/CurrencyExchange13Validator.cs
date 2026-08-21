// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CurrencyExchange13"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _M5wl0IW7EeiDBOVr6AJAFA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Describes the details of the currency exchange.
/// <list type="table">
///   <item><term>SourceCurrency</term><description>ActiveCurrencyCode — required (1..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="ActiveCurrencyCodeValidator"/></description></item>
///   <item><term>TargetCurrency</term><description>ActiveCurrencyCode — required (1..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="ActiveCurrencyCodeValidator"/></description></item>
///   <item><term>ExchangeRate</term><description>BaseOneRate — required (1..1), fully struct-enforced</description></item>
///   <item><term>UnitCurrency</term><description>ActiveCurrencyCode — optional (0..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="ActiveCurrencyCodeValidator"/></description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>SourceCurrency</c>, <c>TargetCurrency</c>, and <c>UnitCurrency</c>
/// all share the same injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> —
/// see the two constructors below.
/// </remarks>
public class CurrencyExchange13Validator : AbstractValidator<CurrencyExchange13>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CurrencyExchange13Validator(IValidator<ActiveCurrencyCode> currencyValidator)
    {
        RuleFor(x => x.SourceCurrency).SetValidator(currencyValidator!);
        RuleFor(x => x.TargetCurrency).SetValidator(currencyValidator!);
        When(
            x => x.UnitCurrency is not null,
            () => RuleFor(x => x.UnitCurrency!.Value).SetValidator(currencyValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CurrencyExchange13Validator()
        : this(new ActiveCurrencyCodeValidator()) { }
}
