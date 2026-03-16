// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format83Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat83Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat83Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat83Choice.AmountPrice),nameof(PriceFormat83Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat83Choice.PercentagePrice),nameof(PriceFormat83Choice.PercentagePrice))]
    [IsoId("_kV6xZZt3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format83Choice")]
    public abstract partial record PriceFormat83Choice_
    {
    }
}
