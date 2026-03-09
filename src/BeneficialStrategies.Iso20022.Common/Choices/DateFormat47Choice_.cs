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
    [KnownType(typeof(DateFormat47Choice.Date))]
    [KnownType(typeof(DateFormat47Choice.NotSpecifiedDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat47Choice.Date),nameof(DateFormat47Choice.Date))]
    [JsonDerivedType(typeof(DateFormat47Choice.NotSpecifiedDate),nameof(DateFormat47Choice.NotSpecifiedDate))]
    #endif
    [IsoId("_HVVRC8kbEee7W-rN1yqPMg")]
    [DisplayName("Date Format 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat47Choice_
    #else
    public abstract partial class DateFormat47Choice_
    #endif
    {
    }
}
