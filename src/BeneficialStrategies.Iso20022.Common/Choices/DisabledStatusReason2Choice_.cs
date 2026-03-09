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
    /// Choice of formats for a disabled reason code.
    /// </summary>
    [KnownType(typeof(DisabledStatusReason2Choice.Code))]
    [KnownType(typeof(DisabledStatusReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DisabledStatusReason2Choice.Code),nameof(DisabledStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(DisabledStatusReason2Choice.Proprietary),nameof(DisabledStatusReason2Choice.Proprietary))]
    #endif
    [IsoId("_hNiggUzAEeafiMTDrtSnyw")]
    [DisplayName("Disabled Status Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisabledStatusReason2Choice_
    #else
    public abstract partial class DisabledStatusReason2Choice_
    #endif
    {
    }
}
