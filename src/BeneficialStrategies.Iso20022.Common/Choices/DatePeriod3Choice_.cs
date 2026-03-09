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
    /// Range of time defined by a start date and an end date.
    /// </summary>
    [KnownType(typeof(DatePeriod3Choice.FromDate))]
    [KnownType(typeof(DatePeriod3Choice.ToDate))]
    [KnownType(typeof(DatePeriod3Choice.FromToDate))]
    [KnownType(typeof(DatePeriod3Choice.Date))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DatePeriod3Choice.FromDate),nameof(DatePeriod3Choice.FromDate))]
    [JsonDerivedType(typeof(DatePeriod3Choice.ToDate),nameof(DatePeriod3Choice.ToDate))]
    [JsonDerivedType(typeof(DatePeriod3Choice.FromToDate),nameof(DatePeriod3Choice.FromToDate))]
    [JsonDerivedType(typeof(DatePeriod3Choice.Date),nameof(DatePeriod3Choice.Date))]
    #endif
    [IsoId("_Az9J8YwDEei289CGNqs21g")]
    [DisplayName("Date Period 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DatePeriod3Choice_
    #else
    public abstract partial class DatePeriod3Choice_
    #endif
    {
    }
}
