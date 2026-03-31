// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeSearch5Choice.Date))]
    [KnownType(typeof(DateAndDateTimeSearch5Choice.DateTime))]
    [JsonDerivedType(
        typeof(DateAndDateTimeSearch5Choice.Date),
        nameof(DateAndDateTimeSearch5Choice.Date)
    )]
    [JsonDerivedType(
        typeof(DateAndDateTimeSearch5Choice.DateTime),
        nameof(DateAndDateTimeSearch5Choice.DateTime)
    )]
    [IsoId("_Ve-bjTp9EemwKdP955WBJQ")]
    [DisplayName("Date And Date Time Search 5 Choice")]
    public abstract record DateAndDateTimeSearch5Choice_ { }
}
