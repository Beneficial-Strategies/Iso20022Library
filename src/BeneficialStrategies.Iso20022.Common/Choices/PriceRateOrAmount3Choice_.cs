// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmount3Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmount3Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmount3Choice.Rate),nameof(PriceRateOrAmount3Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmount3Choice.Amount),nameof(PriceRateOrAmount3Choice.Amount))]
    [IsoId("_dnG1obQBEee1Ke-6rZgsrA")]
    [DisplayName("Price Rate Or Amount 3 Choice")]
    public abstract partial record PriceRateOrAmount3Choice_
    {
    }
}
