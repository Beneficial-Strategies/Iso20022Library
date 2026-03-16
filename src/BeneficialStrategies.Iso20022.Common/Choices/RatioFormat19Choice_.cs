// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat19Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat19Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat19Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat19Choice.QuantityToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat19Choice.QuantityToQuantity),
        nameof(RatioFormat19Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat19Choice.AmountToAmount),
        nameof(RatioFormat19Choice.AmountToAmount)
    )]
    [JsonDerivedType(
        typeof(RatioFormat19Choice.AmountToQuantity),
        nameof(RatioFormat19Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat19Choice.QuantityToAmount),
        nameof(RatioFormat19Choice.QuantityToAmount)
    )]
    [IsoId("_7_6m0UEKEeWVgfuHGaKtRQ")]
    [DisplayName("Ratio Format 19 Choice")]
    public abstract record RatioFormat19Choice_ { }
}
