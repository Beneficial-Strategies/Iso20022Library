// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the date.
    /// </summary>
    [KnownType(typeof(DateFormat57Choice.Date))]
    [KnownType(typeof(DateFormat57Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat57Choice.Date),nameof(DateFormat57Choice.Date))]
    [JsonDerivedType(typeof(DateFormat57Choice.DateCode),nameof(DateFormat57Choice.DateCode))]
    [IsoId("_zBT-Az5-EemPvNTzinB5Vw")]
    [DisplayName("Date Format 57 Choice")]
    public abstract partial record DateFormat57Choice_
    {
    }
}
