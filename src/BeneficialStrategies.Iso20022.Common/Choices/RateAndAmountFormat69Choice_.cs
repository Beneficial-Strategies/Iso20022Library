// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format69Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat69Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat69Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat69Choice.Rate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat69Choice.Amount),
        nameof(RateAndAmountFormat69Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat69Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat69Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat69Choice.Rate),
        nameof(RateAndAmountFormat69Choice.Rate)
    )]
    [IsoId("_l6T835t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format69Choice")]
    public abstract record RateAndAmountFormat69Choice_ { }
}
