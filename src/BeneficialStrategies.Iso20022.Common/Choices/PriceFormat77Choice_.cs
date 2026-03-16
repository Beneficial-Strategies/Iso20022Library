// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format77Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat77Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat77Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat77Choice.AmountPrice),nameof(PriceFormat77Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat77Choice.PercentagePrice),nameof(PriceFormat77Choice.PercentagePrice))]
    [IsoId("_DME-WYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format77Choice")]
    public abstract partial record PriceFormat77Choice_
    {
    }
}
