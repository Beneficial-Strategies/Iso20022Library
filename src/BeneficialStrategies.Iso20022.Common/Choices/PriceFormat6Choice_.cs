// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat6Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat6Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat6Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat6Choice.PercentagePrice),
        nameof(PriceFormat6Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat6Choice.AmountPrice),
        nameof(PriceFormat6Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat6Choice.IndexPoints),
        nameof(PriceFormat6Choice.IndexPoints)
    )]
    [IsoId("_Q1ro3Np-Ed-ak6NoX_4Aeg_633561620")]
    [DisplayName("Price Format 6 Choice")]
    public abstract record PriceFormat6Choice_ { }
}
