// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format86Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat86Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat86Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat86Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat86Choice.AmountPrice),nameof(PriceFormat86Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat86Choice.IndexPoints),nameof(PriceFormat86Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat86Choice.PercentagePrice),nameof(PriceFormat86Choice.PercentagePrice))]
    [IsoId("_kv70HZt3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format86Choice")]
    public abstract partial record PriceFormat86Choice_
    {
    }
}
