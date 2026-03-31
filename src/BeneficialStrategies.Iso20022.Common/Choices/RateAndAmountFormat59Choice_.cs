// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format59Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat59Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat59Choice.Rate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat59Choice.Amount),
        nameof(RateAndAmountFormat59Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat59Choice.Rate),
        nameof(RateAndAmountFormat59Choice.Rate)
    )]
    [IsoId("_3T2zAYV5Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format59Choice")]
    public abstract record RateAndAmountFormat59Choice_ { }
}
