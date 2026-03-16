// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format75Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat75Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat75Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat75Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat75Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat75Choice.Amount),nameof(RateAndAmountFormat75Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat75Choice.NotSpecifiedRate),nameof(RateAndAmountFormat75Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat75Choice.Rate),nameof(RateAndAmountFormat75Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat75Choice.RateTypeAndRate),nameof(RateAndAmountFormat75Choice.RateTypeAndRate))]
    [IsoId("_nLi6XZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format75Choice")]
    public abstract partial record RateAndAmountFormat75Choice_
    {
    }
}
