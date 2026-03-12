// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat5Choice.Rate))]
    [KnownType(typeof(RateFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat5Choice.Rate),nameof(RateFormat5Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat5Choice.NotSpecifiedRate),nameof(RateFormat5Choice.NotSpecifiedRate))]
    [IsoId("_UPF0p9p-Ed-ak6NoX_4Aeg_918914452")]
    [DisplayName("Rate Format 5 Choice")]
    public abstract partial record RateFormat5Choice_
    {
    }
}
