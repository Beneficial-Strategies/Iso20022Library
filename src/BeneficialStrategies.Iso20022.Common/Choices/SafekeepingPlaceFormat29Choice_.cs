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
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat29Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.Identification),nameof(SafekeepingPlaceFormat29Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.Country),nameof(SafekeepingPlaceFormat29Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat29Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat29Choice.Proprietary),nameof(SafekeepingPlaceFormat29Choice.Proprietary))]
    #endif
    [IsoId("_XZQIObXEEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Place Format 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat29Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat29Choice_
    #endif
    {
    }
}
