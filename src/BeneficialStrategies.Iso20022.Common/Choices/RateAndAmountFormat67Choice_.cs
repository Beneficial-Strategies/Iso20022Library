// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format67Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat67Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat67Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat67Choice.Amount),nameof(RateAndAmountFormat67Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat67Choice.Rate),nameof(RateAndAmountFormat67Choice.Rate))]
    [IsoId("_kv5-lZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format67Choice")]
    public abstract partial record RateAndAmountFormat67Choice_
    {
    }
}
