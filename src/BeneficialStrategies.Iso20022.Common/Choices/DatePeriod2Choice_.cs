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
    [KnownType(typeof(DatePeriod2Choice.FromDate))]
    [KnownType(typeof(DatePeriod2Choice.ToDate))]
    [KnownType(typeof(DatePeriod2Choice.FromToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DatePeriod2Choice.FromDate),nameof(DatePeriod2Choice.FromDate))]
    [JsonDerivedType(typeof(DatePeriod2Choice.ToDate),nameof(DatePeriod2Choice.ToDate))]
    [JsonDerivedType(typeof(DatePeriod2Choice.FromToDate),nameof(DatePeriod2Choice.FromToDate))]
    #endif
    [IsoId("_jNAKm5lPEee-Zps0fZQaFQ")]
    [DisplayName("Date Period 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DatePeriod2Choice_
    #else
    public abstract partial class DatePeriod2Choice_
    #endif
    {
    }
}
