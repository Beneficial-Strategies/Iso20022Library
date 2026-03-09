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
    /// Choice of formats for a blocked status reason.
    /// </summary>
    [KnownType(typeof(BlockedStatusReason2Choice.NoSpecifiedReason))]
    [KnownType(typeof(BlockedStatusReason2Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BlockedStatusReason2Choice.NoSpecifiedReason),nameof(BlockedStatusReason2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(BlockedStatusReason2Choice.Reason),nameof(BlockedStatusReason2Choice.Reason))]
    #endif
    [IsoId("_8TcccV1LEeagR5I1rq5oaw")]
    [DisplayName("Blocked Status Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BlockedStatusReason2Choice_
    #else
    public abstract partial class BlockedStatusReason2Choice_
    #endif
    {
    }
}
