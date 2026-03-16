// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format75Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat75Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat75Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat75Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat75Choice.AmountPrice),
        nameof(PriceFormat75Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat75Choice.IndexPoints),
        nameof(PriceFormat75Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat75Choice.PercentagePrice),
        nameof(PriceFormat75Choice.PercentagePrice)
    )]
    [IsoId("_DAyUP4V6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format75Choice")]
    public abstract record PriceFormat75Choice_ { }
}
