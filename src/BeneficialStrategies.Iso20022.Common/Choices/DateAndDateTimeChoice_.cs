// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeChoice.Date))]
    [KnownType(typeof(DateAndDateTimeChoice.DateTime))]
    [JsonDerivedType(typeof(DateAndDateTimeChoice.Date), nameof(DateAndDateTimeChoice.Date))]
    [JsonDerivedType(
        typeof(DateAndDateTimeChoice.DateTime),
        nameof(DateAndDateTimeChoice.DateTime)
    )]
    [IsoId("_T6OX59p-Ed-ak6NoX_4Aeg_1215657154")]
    [DisplayName("Date And Date Time Choice")]
    public abstract record DateAndDateTimeChoice_ { }
}
