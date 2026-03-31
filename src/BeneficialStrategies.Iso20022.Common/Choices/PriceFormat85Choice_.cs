// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format85Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat85Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat85Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat85Choice.AmountPrice),
        nameof(PriceFormat85Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat85Choice.PercentagePrice),
        nameof(PriceFormat85Choice.PercentagePrice)
    )]
    [IsoId("_kv5-95t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format85Choice")]
    public abstract record PriceFormat85Choice_ { }
}
