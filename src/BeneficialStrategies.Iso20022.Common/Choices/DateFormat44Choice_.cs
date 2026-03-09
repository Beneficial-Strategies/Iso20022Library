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
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat44Choice.Date))]
    [KnownType(typeof(DateFormat44Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat44Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat44Choice.Date),nameof(DateFormat44Choice.Date))]
    [JsonDerivedType(typeof(DateFormat44Choice.DateCodeAndTime),nameof(DateFormat44Choice.DateCodeAndTime))]
    [JsonDerivedType(typeof(DateFormat44Choice.DateCode),nameof(DateFormat44Choice.DateCode))]
    #endif
    [IsoId("_QCI9UbQYEeeKRKrD60ELBQ")]
    [DisplayName("Date Format 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat44Choice_
    #else
    public abstract partial class DateFormat44Choice_
    #endif
    {
    }
}
