// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat62Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat62Choice.NotSpecifiedPrice))]
    [JsonDerivedType(
        typeof(PriceFormat62Choice.AmountPrice),
        nameof(PriceFormat62Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat62Choice.NotSpecifiedPrice),
        nameof(PriceFormat62Choice.NotSpecifiedPrice)
    )]
    [IsoId("_47qewdBXEee0mNiKMkpGNQ")]
    [DisplayName("Price Format 62 Choice")]
    public abstract record PriceFormat62Choice_ { }
}
