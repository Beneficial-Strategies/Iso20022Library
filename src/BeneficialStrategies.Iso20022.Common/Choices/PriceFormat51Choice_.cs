// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat51Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat51Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat51Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat51Choice.PercentagePrice),
        nameof(PriceFormat51Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat51Choice.AmountPrice),
        nameof(PriceFormat51Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat51Choice.IndexPoints),
        nameof(PriceFormat51Choice.IndexPoints)
    )]
    [IsoId("_Wy2joUGNEeWqy4niLuXETA")]
    [DisplayName("Price Format 51 Choice")]
    public abstract record PriceFormat51Choice_ { }
}
