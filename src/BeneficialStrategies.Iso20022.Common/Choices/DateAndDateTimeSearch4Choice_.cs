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
    /// Choice between a date or a date time pattern as search selection criteria.
    /// </summary>
    [KnownType(typeof(DateAndDateTimeSearch4Choice.DateTime))]
    [KnownType(typeof(DateAndDateTimeSearch4Choice.Date))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateAndDateTimeSearch4Choice.DateTime),nameof(DateAndDateTimeSearch4Choice.DateTime))]
    [JsonDerivedType(typeof(DateAndDateTimeSearch4Choice.Date),nameof(DateAndDateTimeSearch4Choice.Date))]
    #endif
    [IsoId("_6yG5333sEeibM9CPDGCw0g")]
    [DisplayName("Date And Date Time Search 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateAndDateTimeSearch4Choice_
    #else
    public abstract partial class DateAndDateTimeSearch4Choice_
    #endif
    {
    }
}
