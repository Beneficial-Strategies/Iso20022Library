// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format56Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat56Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat56Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat56Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat56Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat56Choice.Amount),nameof(RateAndAmountFormat56Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat56Choice.NotSpecifiedRate),nameof(RateAndAmountFormat56Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat56Choice.Rate),nameof(RateAndAmountFormat56Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat56Choice.RateTypeAndRate),nameof(RateAndAmountFormat56Choice.RateTypeAndRate))]
    [IsoId("_2udcYYV4Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format56Choice")]
    public abstract partial record RateAndAmountFormat56Choice_
    {
    }
}
