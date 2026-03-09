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
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period4Choice.Date))]
    [KnownType(typeof(Period4Choice.FromDate))]
    [KnownType(typeof(Period4Choice.ToDate))]
    [KnownType(typeof(Period4Choice.FromDateToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period4Choice.Date),nameof(Period4Choice.Date))]
    [JsonDerivedType(typeof(Period4Choice.FromDate),nameof(Period4Choice.FromDate))]
    [JsonDerivedType(typeof(Period4Choice.ToDate),nameof(Period4Choice.ToDate))]
    [JsonDerivedType(typeof(Period4Choice.FromDateToDate),nameof(Period4Choice.FromDateToDate))]
    #endif
    [IsoId("_kTJKSZfjEeSfnc-VXAEapg")]
    [DisplayName("Period 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period4Choice_
    #else
    public abstract partial class Period4Choice_
    #endif
    {
    }
}
