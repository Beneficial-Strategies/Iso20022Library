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
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat16Choice.Date))]
    [KnownType(typeof(DateFormat16Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat16Choice.Date),nameof(DateFormat16Choice.Date))]
    [JsonDerivedType(typeof(DateFormat16Choice.DateCode),nameof(DateFormat16Choice.DateCode))]
    #endif
    [IsoId("_C4q7ceENEd-qUMZtd_eZuQ")]
    [DisplayName("Date Format 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat16Choice_
    #else
    public abstract partial class DateFormat16Choice_
    #endif
    {
    }
}
