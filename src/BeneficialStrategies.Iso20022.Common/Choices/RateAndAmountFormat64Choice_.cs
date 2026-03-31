// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format64Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat64Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat64Choice.Rate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat64Choice.Amount),
        nameof(RateAndAmountFormat64Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat64Choice.Rate),
        nameof(RateAndAmountFormat64Choice.Rate)
    )]
    [IsoId("_kV6wrZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format64Choice")]
    public abstract record RateAndAmountFormat64Choice_ { }
}
