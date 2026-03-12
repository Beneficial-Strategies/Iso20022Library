// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the formats to express a date.
    /// </summary>
    [KnownType(typeof(DateFormat3Choice.Date))]
    [KnownType(typeof(DateFormat3Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat3Choice.Date),nameof(DateFormat3Choice.Date))]
    [JsonDerivedType(typeof(DateFormat3Choice.DateCode),nameof(DateFormat3Choice.DateCode))]
    [IsoId("_RVkCydp-Ed-ak6NoX_4Aeg_1324481717")]
    [DisplayName("Date Format 3 Choice")]
    public abstract partial record DateFormat3Choice_
    {
    }
}
