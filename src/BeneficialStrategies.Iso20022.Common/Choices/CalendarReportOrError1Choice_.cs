// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between details of the audit trail data or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(CalendarReportOrError1Choice.CalendarReport))]
    [KnownType(typeof(CalendarReportOrError1Choice.OperationalError))]
    [JsonDerivedType(typeof(CalendarReportOrError1Choice.CalendarReport),nameof(CalendarReportOrError1Choice.CalendarReport))]
    [JsonDerivedType(typeof(CalendarReportOrError1Choice.OperationalError),nameof(CalendarReportOrError1Choice.OperationalError))]
    [IsoId("_dVcQ4Ym7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Report Or Error 1 Choice")]
    public abstract partial record CalendarReportOrError1Choice_
    {
    }
}
