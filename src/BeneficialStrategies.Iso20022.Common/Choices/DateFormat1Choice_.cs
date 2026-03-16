// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the formats to express a date.
    /// </summary>
    [KnownType(typeof(DateFormat1Choice.Date))]
    [KnownType(typeof(DateFormat1Choice.Code))]
    [KnownType(typeof(DateFormat1Choice.DateTime))]
    [JsonDerivedType(typeof(DateFormat1Choice.Date), nameof(DateFormat1Choice.Date))]
    [JsonDerivedType(typeof(DateFormat1Choice.Code), nameof(DateFormat1Choice.Code))]
    [JsonDerivedType(typeof(DateFormat1Choice.DateTime), nameof(DateFormat1Choice.DateTime))]
    [IsoId("_RE37ZNp-Ed-ak6NoX_4Aeg_-1132412760")]
    [DisplayName("Date Format 1 Choice")]
    public abstract record DateFormat1Choice_ { }
}
