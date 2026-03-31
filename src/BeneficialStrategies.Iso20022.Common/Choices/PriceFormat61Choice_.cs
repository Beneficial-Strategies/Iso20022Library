// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat61Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat61Choice.NotSpecifiedPrice))]
    [JsonDerivedType(
        typeof(PriceFormat61Choice.AmountPrice),
        nameof(PriceFormat61Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat61Choice.NotSpecifiedPrice),
        nameof(PriceFormat61Choice.NotSpecifiedPrice)
    )]
    [IsoId("_4doiepbREee8S7xwGG7Veg")]
    [DisplayName("Price Format 61 Choice")]
    public abstract record PriceFormat61Choice_ { }
}
