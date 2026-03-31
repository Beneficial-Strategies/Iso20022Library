// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat8Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat8Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat8Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat8Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat8Choice.PercentagePrice),
        nameof(PriceFormat8Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat8Choice.AmountPrice),
        nameof(PriceFormat8Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat8Choice.NotSpecifiedPrice),
        nameof(PriceFormat8Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat8Choice.IndexPoints),
        nameof(PriceFormat8Choice.IndexPoints)
    )]
    [IsoId("_Q2Reutp-Ed-ak6NoX_4Aeg_1518172190")]
    [DisplayName("Price Format 8 Choice")]
    public abstract record PriceFormat8Choice_ { }
}
