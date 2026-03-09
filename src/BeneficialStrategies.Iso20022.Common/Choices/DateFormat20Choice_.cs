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
    [KnownType(typeof(DateFormat20Choice.Date))]
    [KnownType(typeof(DateFormat20Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat20Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat20Choice.Date),nameof(DateFormat20Choice.Date))]
    [JsonDerivedType(typeof(DateFormat20Choice.DateCodeAndTime),nameof(DateFormat20Choice.DateCodeAndTime))]
    [JsonDerivedType(typeof(DateFormat20Choice.DateCode),nameof(DateFormat20Choice.DateCode))]
    #endif
    [IsoId("_lH2aRfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat20Choice_
    #else
    public abstract partial class DateFormat20Choice_
    #endif
    {
    }
}
