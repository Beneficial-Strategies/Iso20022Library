// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format73Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat73Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat73Choice.IndexPoints))]
    [KnownType(typeof(RateAndAmountFormat73Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat73Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat73Choice.Amount),nameof(RateAndAmountFormat73Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat73Choice.IndexPoints),nameof(RateAndAmountFormat73Choice.IndexPoints))]
    [JsonDerivedType(typeof(RateAndAmountFormat73Choice.NotSpecifiedRate),nameof(RateAndAmountFormat73Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat73Choice.Rate),nameof(RateAndAmountFormat73Choice.Rate))]
    [IsoId("_nLgd85t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format73Choice")]
    public abstract partial record RateAndAmountFormat73Choice_
    {
    }
}
