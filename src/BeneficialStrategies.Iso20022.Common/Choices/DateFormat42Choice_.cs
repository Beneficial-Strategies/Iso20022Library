// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a date.
    /// </summary>
    [KnownType(typeof(DateFormat42Choice.YearMonth))]
    [KnownType(typeof(DateFormat42Choice.YearMonthDay))]
    [JsonDerivedType(typeof(DateFormat42Choice.YearMonth),nameof(DateFormat42Choice.YearMonth))]
    [JsonDerivedType(typeof(DateFormat42Choice.YearMonthDay),nameof(DateFormat42Choice.YearMonthDay))]
    [IsoId("_rQn0cJBrEeaGiLsfv6g8MA")]
    [DisplayName("Date Format 42 Choice")]
    public abstract partial record DateFormat42Choice_
    {
    }
}
