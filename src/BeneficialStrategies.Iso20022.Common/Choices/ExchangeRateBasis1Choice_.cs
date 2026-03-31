// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the exchange rate basis for a foreign exchange transaction.
    /// </summary>
    [KnownType(typeof(ExchangeRateBasis1Choice.CurrencyPair))]
    [KnownType(typeof(ExchangeRateBasis1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ExchangeRateBasis1Choice.CurrencyPair),
        nameof(ExchangeRateBasis1Choice.CurrencyPair)
    )]
    [JsonDerivedType(
        typeof(ExchangeRateBasis1Choice.Proprietary),
        nameof(ExchangeRateBasis1Choice.Proprietary)
    )]
    [IsoId("_n2_eYLppEea_jI1vMH_RbA")]
    [DisplayName("Exchange Rate Basis 1 Choice")]
    public abstract record ExchangeRateBasis1Choice_ { }
}
