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
    /// Choice of order waiver reason.
    /// </summary>
    [KnownType(typeof(OrderWaiverReason1Choice.Reason))]
    [KnownType(typeof(OrderWaiverReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrderWaiverReason1Choice.Reason),nameof(OrderWaiverReason1Choice.Reason))]
    [JsonDerivedType(typeof(OrderWaiverReason1Choice.Proprietary),nameof(OrderWaiverReason1Choice.Proprietary))]
    #endif
    [IsoId("_SdiXddp-Ed-ak6NoX_4Aeg_-117604914")]
    [DisplayName("Order Waiver Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrderWaiverReason1Choice_
    #else
    public abstract partial class OrderWaiverReason1Choice_
    #endif
    {
    }
}
