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
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat34Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.Identification),nameof(SafekeepingPlaceFormat34Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.Country),nameof(SafekeepingPlaceFormat34Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat34Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat34Choice.Proprietary),nameof(SafekeepingPlaceFormat34Choice.Proprietary))]
    #endif
    [IsoId("_9C3BB_fEEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place Format 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat34Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat34Choice_
    #endif
    {
    }
}
