// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for an order.
    /// </summary>
    [KnownType(typeof(OrderStatus3Choice.Status))]
    [KnownType(typeof(OrderStatus3Choice.Cancelled))]
    [KnownType(typeof(OrderStatus3Choice.ConditionallyAccepted))]
    [KnownType(typeof(OrderStatus3Choice.Rejected))]
    [KnownType(typeof(OrderStatus3Choice.Suspended))]
    [KnownType(typeof(OrderStatus3Choice.PartiallySettled))]
    [JsonDerivedType(typeof(OrderStatus3Choice.Status),nameof(OrderStatus3Choice.Status))]
    [JsonDerivedType(typeof(OrderStatus3Choice.Cancelled),nameof(OrderStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(OrderStatus3Choice.ConditionallyAccepted),nameof(OrderStatus3Choice.ConditionallyAccepted))]
    [JsonDerivedType(typeof(OrderStatus3Choice.Rejected),nameof(OrderStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(OrderStatus3Choice.Suspended),nameof(OrderStatus3Choice.Suspended))]
    [JsonDerivedType(typeof(OrderStatus3Choice.PartiallySettled),nameof(OrderStatus3Choice.PartiallySettled))]
    [IsoId("_uvD4kUH7EeaV3ab_pHzFIQ")]
    [DisplayName("Order Status 3 Choice")]
    public abstract partial record OrderStatus3Choice_
    {
    }
}
