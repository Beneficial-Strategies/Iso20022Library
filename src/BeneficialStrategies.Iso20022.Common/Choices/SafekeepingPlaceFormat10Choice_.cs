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
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat10Choice.Identification),nameof(SafekeepingPlaceFormat10Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat10Choice.Country),nameof(SafekeepingPlaceFormat10Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat10Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat10Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat10Choice.Proprietary),nameof(SafekeepingPlaceFormat10Choice.Proprietary))]
    #endif
    [IsoId("_43Qi8TnTEeWV5sr121Fc8A")]
    [DisplayName("Safekeeping Place Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat10Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat10Choice_
    #endif
    {
    }
}
