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
    /// Choice of status for an order.
    /// </summary>
    [KnownType(typeof(OrderStatus5Choice.Status))]
    [KnownType(typeof(OrderStatus5Choice.Cancelled))]
    [KnownType(typeof(OrderStatus5Choice.ConditionallyAccepted))]
    [KnownType(typeof(OrderStatus5Choice.Rejected))]
    [KnownType(typeof(OrderStatus5Choice.Suspended))]
    [KnownType(typeof(OrderStatus5Choice.InRepair))]
    [KnownType(typeof(OrderStatus5Choice.PartiallySettled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OrderStatus5Choice.Status),nameof(OrderStatus5Choice.Status))]
    [JsonDerivedType(typeof(OrderStatus5Choice.Cancelled),nameof(OrderStatus5Choice.Cancelled))]
    [JsonDerivedType(typeof(OrderStatus5Choice.ConditionallyAccepted),nameof(OrderStatus5Choice.ConditionallyAccepted))]
    [JsonDerivedType(typeof(OrderStatus5Choice.Rejected),nameof(OrderStatus5Choice.Rejected))]
    [JsonDerivedType(typeof(OrderStatus5Choice.Suspended),nameof(OrderStatus5Choice.Suspended))]
    [JsonDerivedType(typeof(OrderStatus5Choice.InRepair),nameof(OrderStatus5Choice.InRepair))]
    [JsonDerivedType(typeof(OrderStatus5Choice.PartiallySettled),nameof(OrderStatus5Choice.PartiallySettled))]
    #endif
    [IsoId("_GSNBUEHREeasdbKMiqizqA")]
    [DisplayName("Order Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OrderStatus5Choice_
    #else
    public abstract partial class OrderStatus5Choice_
    #endif
    {
    }
}
