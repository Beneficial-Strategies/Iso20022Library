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
    /// Choice of formats for a date.
    /// </summary>
    [KnownType(typeof(DateFormat42Choice.YearMonth))]
    [KnownType(typeof(DateFormat42Choice.YearMonthDay))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat42Choice.YearMonth),nameof(DateFormat42Choice.YearMonth))]
    [JsonDerivedType(typeof(DateFormat42Choice.YearMonthDay),nameof(DateFormat42Choice.YearMonthDay))]
    #endif
    [IsoId("_rQn0cJBrEeaGiLsfv6g8MA")]
    [DisplayName("Date Format 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat42Choice_
    #else
    public abstract partial class DateFormat42Choice_
    #endif
    {
    }
}
