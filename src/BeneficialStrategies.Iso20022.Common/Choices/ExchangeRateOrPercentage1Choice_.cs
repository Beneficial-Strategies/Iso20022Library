// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a choice between an absolute rate and a percentage rate. 
    /// </summary>
    [KnownType(typeof(ExchangeRateOrPercentage1Choice.Rate))]
    [KnownType(typeof(ExchangeRateOrPercentage1Choice.Percentage))]
    [JsonDerivedType(typeof(ExchangeRateOrPercentage1Choice.Rate),nameof(ExchangeRateOrPercentage1Choice.Rate))]
    [JsonDerivedType(typeof(ExchangeRateOrPercentage1Choice.Percentage),nameof(ExchangeRateOrPercentage1Choice.Percentage))]
    [IsoId("_lW_QMNfvEeqoweZZxm4TPQ")]
    [DisplayName("Exchange Rate Or Percentage 1 Choice")]
    public abstract partial record ExchangeRateOrPercentage1Choice_
    {
    }
}
