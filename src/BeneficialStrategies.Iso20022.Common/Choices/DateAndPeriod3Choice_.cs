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
    [KnownType(typeof(DateAndPeriod3Choice.StatementDate))]
    [KnownType(typeof(DateAndPeriod3Choice.StatementPeriod))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndPeriod3Choice.StatementDate),nameof(DateAndPeriod3Choice.StatementDate))]
    [JsonDerivedType(typeof(DateAndPeriod3Choice.StatementPeriod),nameof(DateAndPeriod3Choice.StatementPeriod))]
    #endif
    [IsoId("_xstj3QzJEeuTPv2wqaotHg")]
    [DisplayName("Date And Period 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndPeriod3Choice_
    #else
    public abstract partial class DateAndPeriod3Choice_
    #endif
    {
    }
}
