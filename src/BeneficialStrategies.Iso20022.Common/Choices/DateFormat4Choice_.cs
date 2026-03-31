// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat4Choice.Date))]
    [KnownType(typeof(DateFormat4Choice.NotSpecifiedDate))]
    [KnownType(typeof(DateFormat4Choice.Proprietary))]
    [JsonDerivedType(typeof(DateFormat4Choice.Date), nameof(DateFormat4Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat4Choice.NotSpecifiedDate),
        nameof(DateFormat4Choice.NotSpecifiedDate)
    )]
    [JsonDerivedType(typeof(DateFormat4Choice.Proprietary), nameof(DateFormat4Choice.Proprietary))]
    [IsoId("_RlgjQ9p-Ed-ak6NoX_4Aeg_-1364711561")]
    [DisplayName("Date Format 4 Choice")]
    public abstract record DateFormat4Choice_ { }
}
