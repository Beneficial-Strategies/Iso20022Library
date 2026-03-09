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
    /// Choice between search criteria based on dates and time ranges.
    /// </summary>
    [KnownType(typeof(DatePeriodSearch1Choice.FromDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.ToDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.FromToDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.EqualDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.NotEqualDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.FromDate),nameof(DatePeriodSearch1Choice.FromDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.ToDate),nameof(DatePeriodSearch1Choice.ToDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.FromToDate),nameof(DatePeriodSearch1Choice.FromToDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.EqualDate),nameof(DatePeriodSearch1Choice.EqualDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.NotEqualDate),nameof(DatePeriodSearch1Choice.NotEqualDate))]
    #endif
    [IsoId("_aIDZIYaAEee8r9VKRbnJSg")]
    [DisplayName("Date Period Search 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DatePeriodSearch1Choice_
    #else
    public abstract partial class DatePeriodSearch1Choice_
    #endif
    {
    }
}
