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
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat56Choice.Date))]
    [KnownType(typeof(DateFormat56Choice.NotSpecifiedDate))]
    [KnownType(typeof(DateFormat56Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat56Choice.Date),nameof(DateFormat56Choice.Date))]
    [JsonDerivedType(typeof(DateFormat56Choice.NotSpecifiedDate),nameof(DateFormat56Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat56Choice.Proprietary),nameof(DateFormat56Choice.Proprietary))]
    #endif
    [IsoId("_7fQ0QeWdEeevU7McUP3D1w")]
    [DisplayName("Date Format 56 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat56Choice_
    #else
    public abstract partial class DateFormat56Choice_
    #endif
    {
    }
}
