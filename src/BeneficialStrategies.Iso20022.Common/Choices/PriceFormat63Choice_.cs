// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat63Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat63Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat63Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat63Choice.PercentagePrice),nameof(PriceFormat63Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat63Choice.AmountPrice),nameof(PriceFormat63Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat63Choice.NotSpecifiedPrice),nameof(PriceFormat63Choice.NotSpecifiedPrice))]
    [IsoId("_Rt7u8Q-zEeuE0Pnt-OcNOA")]
    [DisplayName("Price Format 63 Choice")]
    public abstract partial record PriceFormat63Choice_
    {
    }
}
