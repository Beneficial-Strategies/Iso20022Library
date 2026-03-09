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
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat7Choice.Identification),nameof(SafekeepingPlaceFormat7Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat7Choice.Country),nameof(SafekeepingPlaceFormat7Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat7Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat7Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat7Choice.Proprietary),nameof(SafekeepingPlaceFormat7Choice.Proprietary))]
    #endif
    [IsoId("_Ww2fMS7CEeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Place Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat7Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat7Choice_
    #endif
    {
    }
}
