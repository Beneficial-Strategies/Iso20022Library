// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date time pattern as search selection criteria.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeSearch3Choice.DateTimeSearch))]
    [KnownType(typeof(DateAndDateTimeSearch3Choice.DateSearch))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch3Choice.DateTimeSearch),nameof(DateAndDateTimeSearch3Choice.DateTimeSearch))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch3Choice.DateSearch),nameof(DateAndDateTimeSearch3Choice.DateSearch))]
    [IsoId("_xs2zZ5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Date And Date Time Search 3 Choice")]
    public abstract partial record DateAndDateTimeSearch3Choice_
    {
    }
}
