// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat23Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat23Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat23Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat23Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat23Choice.PercentagePrice),nameof(PriceFormat23Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat23Choice.AmountPrice),nameof(PriceFormat23Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat23Choice.NotSpecifiedPrice),nameof(PriceFormat23Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat23Choice.IndexPoints),nameof(PriceFormat23Choice.IndexPoints))]
    [IsoId("_ASFIoOwOEd-sn-FiNtktcA")]
    [DisplayName("Price Format 23 Choice")]
    public abstract partial record PriceFormat23Choice_
    {
    }
}
