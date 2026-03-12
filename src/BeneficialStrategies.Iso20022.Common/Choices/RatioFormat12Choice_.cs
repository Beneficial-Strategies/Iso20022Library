// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat12Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat12Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat12Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat12Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat12Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat12Choice.QuantityToQuantity),nameof(RatioFormat12Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat12Choice.NotSpecifiedRate),nameof(RatioFormat12Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat12Choice.AmountToAmount),nameof(RatioFormat12Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat12Choice.AmountToQuantity),nameof(RatioFormat12Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat12Choice.QuantityToAmount),nameof(RatioFormat12Choice.QuantityToAmount))]
    [IsoId("_g3oegOwOEd-sn-FiNtktcA")]
    [DisplayName("Ratio Format 12 Choice")]
    public abstract partial record RatioFormat12Choice_
    {
    }
}
