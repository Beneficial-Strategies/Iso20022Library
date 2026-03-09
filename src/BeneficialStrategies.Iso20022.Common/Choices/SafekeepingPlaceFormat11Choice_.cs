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
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.Identification),nameof(SafekeepingPlaceFormat11Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.Country),nameof(SafekeepingPlaceFormat11Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat11Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat11Choice.Proprietary),nameof(SafekeepingPlaceFormat11Choice.Proprietary))]
    #endif
    [IsoId("_cdRpWZKQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat11Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat11Choice_
    #endif
    {
    }
}
