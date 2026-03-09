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
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat27Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.Identification),nameof(SafekeepingPlaceFormat27Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.Country),nameof(SafekeepingPlaceFormat27Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat27Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat27Choice.Proprietary),nameof(SafekeepingPlaceFormat27Choice.Proprietary))]
    #endif
    [IsoId("_k1xAAaWXEeahOrvW2rewGg")]
    [DisplayName("Safekeeping Place Format 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat27Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat27Choice_
    #endif
    {
    }
}
