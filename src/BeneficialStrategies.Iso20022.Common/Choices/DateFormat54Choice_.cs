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
    [KnownType(typeof(DateFormat54Choice.Date))]
    [KnownType(typeof(DateFormat54Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat54Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat54Choice.Date),nameof(DateFormat54Choice.Date))]
    [JsonDerivedType(typeof(DateFormat54Choice.DateCodeAndTime),nameof(DateFormat54Choice.DateCodeAndTime))]
    [JsonDerivedType(typeof(DateFormat54Choice.DateCode),nameof(DateFormat54Choice.DateCode))]
    #endif
    [IsoId("_k9m0rc3xEee5nJBZsW8MFQ")]
    [DisplayName("Date Format 54 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat54Choice_
    #else
    public abstract partial class DateFormat54Choice_
    #endif
    {
    }
}
