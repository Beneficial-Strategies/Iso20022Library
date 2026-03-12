// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount, index points or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat38Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat38Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat38Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat38Choice.IndexPoints))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.Rate),nameof(RateAndAmountFormat38Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.NotSpecifiedRate),nameof(RateAndAmountFormat38Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.Amount),nameof(RateAndAmountFormat38Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.IndexPoints),nameof(RateAndAmountFormat38Choice.IndexPoints))]
    [IsoId("_yF0j0UEEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 38 Choice")]
    public abstract partial record RateAndAmountFormat38Choice_
    {
    }
}
