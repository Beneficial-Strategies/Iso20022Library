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
    /// Provides the date.
    /// </summary>
    [KnownType(typeof(DateFormat57Choice.Date))]
    [KnownType(typeof(DateFormat57Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateFormat57Choice.Date),nameof(DateFormat57Choice.Date))]
    [JsonDerivedType(typeof(DateFormat57Choice.DateCode),nameof(DateFormat57Choice.DateCode))]
    #endif
    [IsoId("_zBT-Az5-EemPvNTzinB5Vw")]
    [DisplayName("Date Format 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateFormat57Choice_
    #else
    public abstract partial class DateFormat57Choice_
    #endif
    {
    }
}
