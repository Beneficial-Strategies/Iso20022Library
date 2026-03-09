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
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.Identification),nameof(SafekeepingPlaceFormat3Choice.Identification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.Country),nameof(SafekeepingPlaceFormat3Choice.Country))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.TypeAndIdentification),nameof(SafekeepingPlaceFormat3Choice.TypeAndIdentification))]
    [JsonDerivedType(typeof(SafekeepingPlaceFormat3Choice.Proprietary),nameof(SafekeepingPlaceFormat3Choice.Proprietary))]
    #endif
    [IsoId("_SfeRKdp-Ed-ak6NoX_4Aeg_-955186669")]
    [DisplayName("Safekeeping Place Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SafekeepingPlaceFormat3Choice_
    #else
    public abstract partial class SafekeepingPlaceFormat3Choice_
    #endif
    {
    }
}
