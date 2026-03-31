// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType4Choice.Market))]
    [KnownType(typeof(PriceType4Choice.Indicative))]
    [JsonDerivedType(typeof(PriceType4Choice.Market), nameof(PriceType4Choice.Market))]
    [JsonDerivedType(typeof(PriceType4Choice.Indicative), nameof(PriceType4Choice.Indicative))]
    [IsoId("_ys8oMbQBEee1Ke-6rZgsrA")]
    [DisplayName("Price Type 4 Choice")]
    public abstract record PriceType4Choice_ { }
}
