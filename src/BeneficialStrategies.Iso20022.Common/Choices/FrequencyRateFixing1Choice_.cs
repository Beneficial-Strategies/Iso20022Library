// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the frequency fixing for the rate.
    /// </summary>
    [KnownType(typeof(FrequencyRateFixing1Choice.Code))]
    [KnownType(typeof(FrequencyRateFixing1Choice.NumberOfDays))]
    [JsonDerivedType(
        typeof(FrequencyRateFixing1Choice.Code),
        nameof(FrequencyRateFixing1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FrequencyRateFixing1Choice.NumberOfDays),
        nameof(FrequencyRateFixing1Choice.NumberOfDays)
    )]
    [IsoId("_OPAdMI9PEeqMo4JxiuZGSw")]
    [DisplayName("Frequency Rate Fixing 1 Choice")]
    public abstract record FrequencyRateFixing1Choice_ { }
}
