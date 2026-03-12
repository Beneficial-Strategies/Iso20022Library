// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat20Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat20Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat20Choice.QuantityToQuantity),nameof(RatioFormat20Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat20Choice.AmountToAmount),nameof(RatioFormat20Choice.AmountToAmount))]
    [IsoId("_DHUNIUGNEeWqy4niLuXETA")]
    [DisplayName("Ratio Format 20 Choice")]
    public abstract partial record RatioFormat20Choice_
    {
    }
}
