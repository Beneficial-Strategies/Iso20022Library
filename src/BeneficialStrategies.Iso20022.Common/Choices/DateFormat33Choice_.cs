// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat33Choice.Date))]
    [KnownType(typeof(DateFormat33Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat33Choice.Date), nameof(DateFormat33Choice.Date))]
    [JsonDerivedType(typeof(DateFormat33Choice.DateCode), nameof(DateFormat33Choice.DateCode))]
    [IsoId("_TjOqkUEMEeWVgfuHGaKtRQ")]
    [DisplayName("Date Format 33 Choice")]
    public abstract record DateFormat33Choice_ { }
}
