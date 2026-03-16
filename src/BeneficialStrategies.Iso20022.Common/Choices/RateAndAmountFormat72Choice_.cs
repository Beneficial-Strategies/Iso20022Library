// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format72Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat72Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat72Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat72Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat72Choice.Amount),nameof(RateAndAmountFormat72Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat72Choice.NotSpecifiedRate),nameof(RateAndAmountFormat72Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat72Choice.Rate),nameof(RateAndAmountFormat72Choice.Rate))]
    [IsoId("_nLgdzZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format72Choice")]
    public abstract partial record RateAndAmountFormat72Choice_
    {
    }
}
