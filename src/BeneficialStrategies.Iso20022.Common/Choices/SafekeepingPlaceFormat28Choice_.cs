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
    /// Choice of formats for a place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat28Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.Identification),nameof(SafekeepingPlaceFormat28Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.Country),nameof(SafekeepingPlaceFormat28Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat28Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat28Choice.Proprietary),nameof(SafekeepingPlaceFormat28Choice.Proprietary))]
    #endif
    [IsoId("_oTwbEWpXEeipaMTLlhaKMQ")]
    [DisplayName("Safekeeping Place Format 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat28Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat28Choice_
    #endif
    {
    }
}
