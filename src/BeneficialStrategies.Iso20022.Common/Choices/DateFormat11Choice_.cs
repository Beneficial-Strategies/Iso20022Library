// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat11Choice.Date))]
    [KnownType(typeof(DateFormat11Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat11Choice.Date),nameof(DateFormat11Choice.Date))]
    [JsonDerivedType(typeof(DateFormat11Choice.DateCode),nameof(DateFormat11Choice.DateCode))]
    [IsoId("_Q48_S9p-Ed-ak6NoX_4Aeg_1138966230")]
    [DisplayName("Date Format 11 Choice")]
    public abstract partial record DateFormat11Choice_
    {
    }
}
