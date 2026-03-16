// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat1Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat1Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(RatioFormat1Choice.QuantityToQuantity),
        nameof(RatioFormat1Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat1Choice.AmountToAmount),
        nameof(RatioFormat1Choice.AmountToAmount)
    )]
    [JsonDerivedType(
        typeof(RatioFormat1Choice.NotSpecifiedRate),
        nameof(RatioFormat1Choice.NotSpecifiedRate)
    )]
    [IsoId("_Rjuamtp-Ed-ak6NoX_4Aeg_-320337061")]
    [DisplayName("Ratio Format 1 Choice")]
    public abstract record RatioFormat1Choice_ { }
}
