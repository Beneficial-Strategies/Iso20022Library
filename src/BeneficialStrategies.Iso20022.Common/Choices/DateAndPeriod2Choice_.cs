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
    /// Choice between a date and period.
    /// </summary>
    [KnownType(typeof(DateAndPeriod2Choice.Date))]
    [KnownType(typeof(DateAndPeriod2Choice.Period))]
    [KnownType(typeof(DateAndPeriod2Choice.FromDate))]
    [KnownType(typeof(DateAndPeriod2Choice.ToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndPeriod2Choice.Date),nameof(DateAndPeriod2Choice.Date))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.Period),nameof(DateAndPeriod2Choice.Period))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.FromDate),nameof(DateAndPeriod2Choice.FromDate))]
    [JsonDerivedType(typeof(DateAndPeriod2Choice.ToDate),nameof(DateAndPeriod2Choice.ToDate))]
    #endif
    [IsoId("_76Z3ZaMgEeCJ6YNENx4h-w_1548347311")]
    [DisplayName("Date And Period 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndPeriod2Choice_
    #else
    public abstract partial class DateAndPeriod2Choice_
    #endif
    {
    }
}
