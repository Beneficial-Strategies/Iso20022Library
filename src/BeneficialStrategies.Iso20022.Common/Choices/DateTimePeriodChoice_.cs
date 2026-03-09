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
    /// Choice between various date time patterns.
    /// </summary>
    [KnownType(typeof(DateTimePeriodChoice.FromDateTime))]
    [KnownType(typeof(DateTimePeriodChoice.ToDateTime))]
    [KnownType(typeof(DateTimePeriodChoice.DateTimeRange))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DateTimePeriodChoice.FromDateTime),nameof(DateTimePeriodChoice.FromDateTime))]
    [JsonDerivedType(typeof(DateTimePeriodChoice.ToDateTime),nameof(DateTimePeriodChoice.ToDateTime))]
    [JsonDerivedType(typeof(DateTimePeriodChoice.DateTimeRange),nameof(DateTimePeriodChoice.DateTimeRange))]
    #endif
    [IsoId("_T5xr99p-Ed-ak6NoX_4Aeg_1215657172")]
    [DisplayName("Date Time Period Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DateTimePeriodChoice_
    #else
    public abstract partial class DateTimePeriodChoice_
    #endif
    {
    }
}
