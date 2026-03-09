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
    [KnownType(typeof(DateFormat4Choice.Date))]
    [KnownType(typeof(DateFormat4Choice.NotSpecifiedDate))]
    [KnownType(typeof(DateFormat4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat4Choice.Date),nameof(DateFormat4Choice.Date))]
    [JsonDerivedType(typeof(DateFormat4Choice.NotSpecifiedDate),nameof(DateFormat4Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat4Choice.Proprietary),nameof(DateFormat4Choice.Proprietary))]
    #endif
    [IsoId("_RlgjQ9p-Ed-ak6NoX_4Aeg_-1364711561")]
    [DisplayName("Date Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat4Choice_
    #else
    public abstract partial class DateFormat4Choice_
    #endif
    {
    }
}
