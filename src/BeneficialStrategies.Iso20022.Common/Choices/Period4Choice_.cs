// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period4Choice.Date))]
    [KnownType(typeof(Period4Choice.FromDate))]
    [KnownType(typeof(Period4Choice.ToDate))]
    [KnownType(typeof(Period4Choice.FromDateToDate))]
    [JsonDerivedType(typeof(Period4Choice.Date),nameof(Period4Choice.Date))]
    [JsonDerivedType(typeof(Period4Choice.FromDate),nameof(Period4Choice.FromDate))]
    [JsonDerivedType(typeof(Period4Choice.ToDate),nameof(Period4Choice.ToDate))]
    [JsonDerivedType(typeof(Period4Choice.FromDateToDate),nameof(Period4Choice.FromDateToDate))]
    [IsoId("_kTJKSZfjEeSfnc-VXAEapg")]
    [DisplayName("Period 4 Choice")]
    public abstract partial record Period4Choice_
    {
    }
}
