// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price.
    /// </summary>
    [KnownType(typeof(PriceFormat5Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat5Choice.AmountPrice))]
    [JsonDerivedType(
        typeof(PriceFormat5Choice.PercentagePrice),
        nameof(PriceFormat5Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat5Choice.AmountPrice),
        nameof(PriceFormat5Choice.AmountPrice)
    )]
    [IsoId("_Q10yydp-Ed-ak6NoX_4Aeg_334581022")]
    [DisplayName("Price Format 5 Choice")]
    public abstract record PriceFormat5Choice_ { }
}
