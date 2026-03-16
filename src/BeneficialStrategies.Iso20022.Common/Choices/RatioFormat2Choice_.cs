// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat2Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat2Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat2Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat2Choice.QuantityToAmount))]
    [KnownType(typeof(RatioFormat2Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(RatioFormat2Choice.QuantityToQuantity),
        nameof(RatioFormat2Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat2Choice.AmountToAmount),
        nameof(RatioFormat2Choice.AmountToAmount)
    )]
    [JsonDerivedType(
        typeof(RatioFormat2Choice.AmountToQuantity),
        nameof(RatioFormat2Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat2Choice.QuantityToAmount),
        nameof(RatioFormat2Choice.QuantityToAmount)
    )]
    [JsonDerivedType(
        typeof(RatioFormat2Choice.NotSpecifiedRate),
        nameof(RatioFormat2Choice.NotSpecifiedRate)
    )]
    [IsoId("_Rj3kg9p-Ed-ak6NoX_4Aeg_1081569462")]
    [DisplayName("Ratio Format 2 Choice")]
    public abstract record RatioFormat2Choice_ { }
}
