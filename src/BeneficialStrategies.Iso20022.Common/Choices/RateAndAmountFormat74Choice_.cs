// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format74Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat74Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat74Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat74Choice.Amount),nameof(RateAndAmountFormat74Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat74Choice.Rate),nameof(RateAndAmountFormat74Choice.Rate))]
    [IsoId("_nLgeIZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format74Choice")]
    public abstract partial record RateAndAmountFormat74Choice_
    {
    }
}
