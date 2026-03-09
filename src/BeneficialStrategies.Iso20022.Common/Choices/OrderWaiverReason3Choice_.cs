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
    /// Choice of formats for an order waiver reason.
    /// </summary>
    [KnownType(typeof(OrderWaiverReason3Choice.Code))]
    [KnownType(typeof(OrderWaiverReason3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrderWaiverReason3Choice.Code),nameof(OrderWaiverReason3Choice.Code))]
    [JsonDerivedType(typeof(OrderWaiverReason3Choice.Proprietary),nameof(OrderWaiverReason3Choice.Proprietary))]
    #endif
    [IsoId("_PJanIToREeabspMEjqY5TQ")]
    [DisplayName("Order Waiver Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrderWaiverReason3Choice_
    #else
    public abstract partial class OrderWaiverReason3Choice_
    #endif
    {
    }
}
