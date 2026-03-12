// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat55Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat55Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat55Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat55Choice.PercentagePrice),nameof(PriceFormat55Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat55Choice.AmountPrice),nameof(PriceFormat55Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat55Choice.IndexPoints),nameof(PriceFormat55Choice.IndexPoints))]
    [IsoId("_ckDmi5KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 55 Choice")]
    public abstract partial record PriceFormat55Choice_
    {
    }
}
