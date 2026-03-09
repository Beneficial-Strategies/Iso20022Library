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
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat59Choice.Date))]
    [KnownType(typeof(DateFormat59Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat59Choice.Date),nameof(DateFormat59Choice.Date))]
    [JsonDerivedType(typeof(DateFormat59Choice.DateCode),nameof(DateFormat59Choice.DateCode))]
    #endif
    [IsoId("_8YeEGu3CEeqc-LCjwLsUVg")]
    [DisplayName("Date Format 59 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat59Choice_
    #else
    public abstract partial class DateFormat59Choice_
    #endif
    {
    }
}
