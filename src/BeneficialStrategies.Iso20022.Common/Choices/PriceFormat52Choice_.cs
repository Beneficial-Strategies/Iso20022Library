// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price.
    /// </summary>
    [KnownType(typeof(PriceFormat52Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat52Choice.AmountPrice))]
    [JsonDerivedType(
        typeof(PriceFormat52Choice.PercentagePrice),
        nameof(PriceFormat52Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat52Choice.AmountPrice),
        nameof(PriceFormat52Choice.AmountPrice)
    )]
    [IsoId("_chez55KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 52 Choice")]
    public abstract record PriceFormat52Choice_ { }
}
