// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between various date time patterns.
    /// </summary>
    [KnownType(typeof(DateTimePeriodChoice.FromDateTime))]
    [KnownType(typeof(DateTimePeriodChoice.ToDateTime))]
    [KnownType(typeof(DateTimePeriodChoice.DateTimeRange))]
    [JsonDerivedType(typeof(DateTimePeriodChoice.FromDateTime),nameof(DateTimePeriodChoice.FromDateTime))]
    [JsonDerivedType(typeof(DateTimePeriodChoice.ToDateTime),nameof(DateTimePeriodChoice.ToDateTime))]
    [JsonDerivedType(typeof(DateTimePeriodChoice.DateTimeRange),nameof(DateTimePeriodChoice.DateTimeRange))]
    [IsoId("_T5xr99p-Ed-ak6NoX_4Aeg_1215657172")]
    [DisplayName("Date Time Period Choice")]
    public abstract partial record DateTimePeriodChoice_
    {
    }
}
