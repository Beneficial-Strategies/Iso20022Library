// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat15Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat15Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat15Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat15Choice.QuantityToQuantity),nameof(RatioFormat15Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat15Choice.AmountToAmount),nameof(RatioFormat15Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat15Choice.QuantityToAmount),nameof(RatioFormat15Choice.QuantityToAmount))]
    [IsoId("_CTIcofpYEeCRofvVIFrSrw")]
    [DisplayName("Ratio Format 15 Choice")]
    public abstract partial record RatioFormat15Choice_
    {
    }
}
