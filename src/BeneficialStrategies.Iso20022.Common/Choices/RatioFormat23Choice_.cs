// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat23Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat23Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat23Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat23Choice.QuantityToQuantity),nameof(RatioFormat23Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat23Choice.NotSpecifiedRate),nameof(RatioFormat23Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat23Choice.AmountToAmount),nameof(RatioFormat23Choice.AmountToAmount))]
    [IsoId("_cti6FpKQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 23 Choice")]
    public abstract partial record RatioFormat23Choice_
    {
    }
}
