// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CurrencyExchange26"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _rA87IT6lEe-QZYT2pcGFZw
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Set of elements used to provide details of the currency exchange.
/// <list type="table">
///   <item><term>PreAgreedExchangeRate</term><description>BaseOneRate — required (1..1); enforced by struct constructor — no rule needed</description></item>
///   <item><term>ForeignExchangeAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>QuotationDateTime</term><description>ISODateTime — optional (0..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>QuotedCurrency</term><description>ActiveOrHistoricCurrencyCode — optional (0..1)</description></item>
///   <item><term>QuoteIdentification</term><description>UUIDv4Identifier — optional (0..1); pattern enforced by struct constructor — no rule needed</description></item>
///   <item><term>UnitCurrency</term><description>ActiveOrHistoricCurrencyCode — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ForeignExchangeAgent</c>, <c>QuotedCurrency</c>, and
/// <c>UnitCurrency</c> are each validated by an injected <see cref="IValidator{T}"/> rather than
/// a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class CurrencyExchange26Validator : AbstractValidator<CurrencyExchange26>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>ForeignExchangeAgent</c>, <c>QuotedCurrency</c>, and
    /// <c>UnitCurrency</c> building blocks — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public CurrencyExchange26Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> foreignExchangeAgentValidator,
        IValidator<ActiveOrHistoricCurrencyCode> quotedCurrencyValidator,
        IValidator<ActiveOrHistoricCurrencyCode> unitCurrencyValidator
    )
    {
        // PreAgreedExchangeRate: required, enforced by struct constructor — no rule needed.
        // QuotationDateTime: optional, lexical form enforced by struct constructor — no rule needed.
        // QuoteIdentification: optional UUIDv4Identifier, pattern enforced by struct constructor — no rule needed.

        When(
            x => x.ForeignExchangeAgent is not null,
            () => RuleFor(x => x.ForeignExchangeAgent).SetValidator(foreignExchangeAgentValidator!)
        );

        When(
            x => x.QuotedCurrency is not null,
            () => RuleFor(x => x.QuotedCurrency!.Value).SetValidator(quotedCurrencyValidator)
        );

        When(
            x => x.UnitCurrency is not null,
            () => RuleFor(x => x.UnitCurrency!.Value).SetValidator(unitCurrencyValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CurrencyExchange26Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new ActiveOrHistoricCurrencyCodeValidator(),
            new ActiveOrHistoricCurrencyCodeValidator()
        ) { }
}
