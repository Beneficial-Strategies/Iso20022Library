// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmount1Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmount1Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmount1Choice.Rate),nameof(PriceRateOrAmount1Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmount1Choice.Amount),nameof(PriceRateOrAmount1Choice.Amount))]
    [IsoId("_Wi6RYtp-Ed-ak6NoX_4Aeg_143429586")]
    [DisplayName("Price Rate Or Amount 1 Choice")]
    public abstract partial record PriceRateOrAmount1Choice_
    {
    }
}
