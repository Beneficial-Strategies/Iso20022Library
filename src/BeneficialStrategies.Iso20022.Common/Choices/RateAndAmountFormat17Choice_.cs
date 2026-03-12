// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat17Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat17Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat17Choice.Amount),nameof(RateAndAmountFormat17Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat17Choice.NotSpecifiedRate),nameof(RateAndAmountFormat17Choice.NotSpecifiedRate))]
    [IsoId("_fq6xMggYEeCVlvYcV4HKqQ")]
    [DisplayName("Rate And Amount Format 17 Choice")]
    public abstract partial record RateAndAmountFormat17Choice_
    {
    }
}
