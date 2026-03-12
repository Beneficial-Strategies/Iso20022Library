// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat15Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat15Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat15Choice.Amount),nameof(RateAndAmountFormat15Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat15Choice.NotSpecifiedRate),nameof(RateAndAmountFormat15Choice.NotSpecifiedRate))]
    [IsoId("_637-sOwOEd-sn-FiNtktcA")]
    [DisplayName("Rate And Amount Format 15 Choice")]
    public abstract partial record RateAndAmountFormat15Choice_
    {
    }
}
