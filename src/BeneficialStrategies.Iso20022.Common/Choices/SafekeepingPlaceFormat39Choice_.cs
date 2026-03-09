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
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat39Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.Identification),nameof(SafekeepingPlaceFormat39Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.Country),nameof(SafekeepingPlaceFormat39Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat39Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat39Choice.Proprietary),nameof(SafekeepingPlaceFormat39Choice.Proprietary))]
    #endif
    [IsoId("_8GiP_ffREeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place Format 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat39Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat39Choice_
    #endif
    {
    }
}
