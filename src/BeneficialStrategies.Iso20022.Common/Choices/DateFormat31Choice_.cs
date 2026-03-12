// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat31Choice.Date))]
    [KnownType(typeof(DateFormat31Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat31Choice.Date),nameof(DateFormat31Choice.Date))]
    [JsonDerivedType(typeof(DateFormat31Choice.DateCode),nameof(DateFormat31Choice.DateCode))]
    [IsoId("_J3amMUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Format 31 Choice")]
    public abstract partial record DateFormat31Choice_
    {
    }
}
