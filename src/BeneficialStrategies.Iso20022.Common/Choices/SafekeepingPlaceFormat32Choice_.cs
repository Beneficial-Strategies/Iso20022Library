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
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat32Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat32Choice.Identification),nameof(SafekeepingPlaceFormat32Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat32Choice.Country),nameof(SafekeepingPlaceFormat32Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat32Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat32Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat32Choice.Proprietary),nameof(SafekeepingPlaceFormat32Choice.Proprietary))]
    #endif
    [IsoId("__2YuD_fDEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place Format 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat32Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat32Choice_
    #endif
    {
    }
}
