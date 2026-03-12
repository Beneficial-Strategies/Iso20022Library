// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date time pattern as search selection criteria.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeSearch4Choice.DateTime))]
    [KnownType(typeof(DateAndDateTimeSearch4Choice.Date))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch4Choice.DateTime),nameof(DateAndDateTimeSearch4Choice.DateTime))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch4Choice.Date),nameof(DateAndDateTimeSearch4Choice.Date))]
    [IsoId("_6yG5333sEeibM9CPDGCw0g")]
    [DisplayName("Date And Date Time Search 4 Choice")]
    public abstract partial record DateAndDateTimeSearch4Choice_
    {
    }
}
