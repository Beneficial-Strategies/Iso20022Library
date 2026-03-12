// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat12Choice.Date))]
    [KnownType(typeof(DateFormat12Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat12Choice.Date),nameof(DateFormat12Choice.Date))]
    [JsonDerivedType(typeof(DateFormat12Choice.NotSpecifiedDate),nameof(DateFormat12Choice.NotSpecifiedDate))]
    [IsoId("_T6Em6dp-Ed-ak6NoX_4Aeg_-1991980092")]
    [DisplayName("Date Format 12 Choice")]
    public abstract partial record DateFormat12Choice_
    {
    }
}
