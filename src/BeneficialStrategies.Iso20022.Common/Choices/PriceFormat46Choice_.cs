// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat46Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat46Choice.NotSpecifiedPrice))]
    [JsonDerivedType(
        typeof(PriceFormat46Choice.AmountPrice),
        nameof(PriceFormat46Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat46Choice.NotSpecifiedPrice),
        nameof(PriceFormat46Choice.NotSpecifiedPrice)
    )]
    [IsoId("_bq05QUELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 46 Choice")]
    public abstract record PriceFormat46Choice_ { }
}
