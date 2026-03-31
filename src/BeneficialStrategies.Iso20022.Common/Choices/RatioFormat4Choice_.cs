// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat4Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat4Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat4Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat4Choice.QuantityToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat4Choice.QuantityToQuantity),
        nameof(RatioFormat4Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat4Choice.AmountToAmount),
        nameof(RatioFormat4Choice.AmountToAmount)
    )]
    [JsonDerivedType(
        typeof(RatioFormat4Choice.AmountToQuantity),
        nameof(RatioFormat4Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat4Choice.QuantityToAmount),
        nameof(RatioFormat4Choice.QuantityToAmount)
    )]
    [IsoId("_Q1h31dp-Ed-ak6NoX_4Aeg_544072927")]
    [DisplayName("Ratio Format 4 Choice")]
    public abstract record RatioFormat4Choice_ { }
}
