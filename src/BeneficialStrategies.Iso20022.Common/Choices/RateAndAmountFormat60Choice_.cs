// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format60Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat60Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat60Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat60Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat60Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat60Choice.Amount),nameof(RateAndAmountFormat60Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat60Choice.NotSpecifiedRate),nameof(RateAndAmountFormat60Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat60Choice.Rate),nameof(RateAndAmountFormat60Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat60Choice.RateTypeAndRate),nameof(RateAndAmountFormat60Choice.RateTypeAndRate))]
    [IsoId("_WpfZIYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format60Choice")]
    public abstract partial record RateAndAmountFormat60Choice_
    {
    }
}
