// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format63Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat63Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat63Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat63Choice.Rate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat63Choice.Amount),
        nameof(RateAndAmountFormat63Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat63Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat63Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat63Choice.Rate),
        nameof(RateAndAmountFormat63Choice.Rate)
    )]
    [IsoId("_kV6Jg5t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format63Choice")]
    public abstract record RateAndAmountFormat63Choice_ { }
}
