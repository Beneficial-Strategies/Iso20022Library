// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between details of the audit trail data or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(CalendarReportOrError1Choice.CalendarReport))]
    [KnownType(typeof(CalendarReportOrError1Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CalendarReportOrError1Choice.CalendarReport),nameof(CalendarReportOrError1Choice.CalendarReport))]
    [JsonDerivedType(typeof(CalendarReportOrError1Choice.OperationalError),nameof(CalendarReportOrError1Choice.OperationalError))]
    #endif
    [IsoId("_dVcQ4Ym7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Report Or Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CalendarReportOrError1Choice_
    #else
    public abstract partial class CalendarReportOrError1Choice_
    #endif
    {
    }
}
