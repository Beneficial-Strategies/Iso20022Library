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
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period5Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period5Choice.FromDateToDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Period5Choice.FromDateTimeToDateTime),nameof(Period5Choice.FromDateTimeToDateTime))]
    [JsonDerivedType(typeof(Period5Choice.FromDateToDate),nameof(Period5Choice.FromDateToDate))]
    #endif
    [IsoId("_W6N3ca3NEeey8N0JWnVPUw")]
    [DisplayName("Period 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Period5Choice_
    #else
    public abstract partial class Period5Choice_
    #endif
    {
    }
}
