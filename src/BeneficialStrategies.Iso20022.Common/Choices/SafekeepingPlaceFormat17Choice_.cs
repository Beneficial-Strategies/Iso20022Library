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
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat17Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat17Choice.Identification),nameof(SafekeepingPlaceFormat17Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat17Choice.Country),nameof(SafekeepingPlaceFormat17Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat17Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat17Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat17Choice.Proprietary),nameof(SafekeepingPlaceFormat17Choice.Proprietary))]
    #endif
    [IsoId("_cj_8gZKQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place Format 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat17Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat17Choice_
    #endif
    {
    }
}
