// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat30Choice.Date))]
    [KnownType(typeof(DateFormat30Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat30Choice.Date), nameof(DateFormat30Choice.Date))]
    [JsonDerivedType(typeof(DateFormat30Choice.DateCode), nameof(DateFormat30Choice.DateCode))]
    [IsoId("_X1sw4UECEeWVgfuHGaKtRQ")]
    [DisplayName("Date Format 30 Choice")]
    public abstract record DateFormat30Choice_ { }
}
