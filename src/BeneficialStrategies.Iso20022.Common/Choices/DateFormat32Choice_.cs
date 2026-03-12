// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat32Choice.Date))]
    [KnownType(typeof(DateFormat32Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat32Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat32Choice.Date),nameof(DateFormat32Choice.Date))]
    [JsonDerivedType(typeof(DateFormat32Choice.DateCodeAndTime),nameof(DateFormat32Choice.DateCodeAndTime))]
    [JsonDerivedType(typeof(DateFormat32Choice.DateCode),nameof(DateFormat32Choice.DateCode))]
    [IsoId("_MAvDZUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Format 32 Choice")]
    public abstract partial record DateFormat32Choice_
    {
    }
}
