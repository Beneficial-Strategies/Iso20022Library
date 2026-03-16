// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format66Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat66Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat66Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat66Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat66Choice.Amount),nameof(RateAndAmountFormat66Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat66Choice.Rate),nameof(RateAndAmountFormat66Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat66Choice.RateTypeAndRate),nameof(RateAndAmountFormat66Choice.RateTypeAndRate))]
    [IsoId("_kv5-LZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format66Choice")]
    public abstract partial record RateAndAmountFormat66Choice_
    {
    }
}
