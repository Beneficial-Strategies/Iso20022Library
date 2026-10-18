// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ExchangeRate1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// Written from the ISO 20022 repository (#47). Every member is a simple type or a code set, which check themselves when they are
/// built, so there is no rule to add at this level; the validator exists so the type is recorded as reviewed and a message that
/// reaches it is validated end to end.
/// <list type="table">
///   <item><term>UnitCurrency</term><description>ActiveOrHistoricCurrencyCode — optional (0..1)</description></item>
///   <item><term>ExchangeRate</term><description>BaseOneRate — optional (0..1)</description></item>
///   <item><term>RateType</term><description>ExchangeRateType1Code — optional (0..1)</description></item>
///   <item><term>ContractIdentification</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
/// </remarks>
public class ExchangeRate1Validator : AbstractValidator<ExchangeRate1> { }
