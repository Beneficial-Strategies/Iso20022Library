// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price.
    /// </summary>
    [KnownType(typeof(PriceFormat50Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat50Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat50Choice.PercentagePrice),nameof(PriceFormat50Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat50Choice.AmountPrice),nameof(PriceFormat50Choice.AmountPrice))]
    [IsoId("_P1ygYUGMEeWqy4niLuXETA")]
    [DisplayName("Price Format 50 Choice")]
    public abstract partial record PriceFormat50Choice_
    {
    }
}
