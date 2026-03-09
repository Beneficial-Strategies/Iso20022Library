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
    /// Choice of formats for a closed reason code.
    /// </summary>
    [KnownType(typeof(ClosedStatusReason2Choice.Code))]
    [KnownType(typeof(ClosedStatusReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ClosedStatusReason2Choice.Code),nameof(ClosedStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(ClosedStatusReason2Choice.Proprietary),nameof(ClosedStatusReason2Choice.Proprietary))]
    #endif
    [IsoId("_k4eZ0UzDEeafiMTDrtSnyw")]
    [DisplayName("Closed Status Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClosedStatusReason2Choice_
    #else
    public abstract partial class ClosedStatusReason2Choice_
    #endif
    {
    }
}
