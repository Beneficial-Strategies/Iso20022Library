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
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason16Choice.Code))]
    [KnownType(typeof(DeniedReason16Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeniedReason16Choice.Code),nameof(DeniedReason16Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason16Choice.Proprietary),nameof(DeniedReason16Choice.Proprietary))]
    #endif
    [IsoId("_uWhgITs8EeWRTLSN0i0tng")]
    [DisplayName("Denied Reason 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeniedReason16Choice_
    #else
    public abstract partial class DeniedReason16Choice_
    #endif
    {
    }
}
