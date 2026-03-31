// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat29Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat29Choice.NotSpecifiedPrice))]
    [JsonDerivedType(
        typeof(PriceFormat29Choice.AmountPrice),
        nameof(PriceFormat29Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat29Choice.NotSpecifiedPrice),
        nameof(PriceFormat29Choice.NotSpecifiedPrice)
    )]
    [IsoId("_i3P9Afo1EeCqjOT-vUu2sQ")]
    [DisplayName("Price Format 29 Choice")]
    public abstract record PriceFormat29Choice_ { }
}
