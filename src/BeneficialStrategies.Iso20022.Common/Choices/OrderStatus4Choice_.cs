// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for an order.
    /// </summary>
    [KnownType(typeof(OrderStatus4Choice.Status))]
    [KnownType(typeof(OrderStatus4Choice.Cancelled))]
    [KnownType(typeof(OrderStatus4Choice.ConditionallyAccepted))]
    [KnownType(typeof(OrderStatus4Choice.Rejected))]
    [KnownType(typeof(OrderStatus4Choice.Suspended))]
    [KnownType(typeof(OrderStatus4Choice.InRepair))]
    [KnownType(typeof(OrderStatus4Choice.PartiallySettled))]
    [JsonDerivedType(typeof(OrderStatus4Choice.Status), nameof(OrderStatus4Choice.Status))]
    [JsonDerivedType(typeof(OrderStatus4Choice.Cancelled), nameof(OrderStatus4Choice.Cancelled))]
    [JsonDerivedType(
        typeof(OrderStatus4Choice.ConditionallyAccepted),
        nameof(OrderStatus4Choice.ConditionallyAccepted)
    )]
    [JsonDerivedType(typeof(OrderStatus4Choice.Rejected), nameof(OrderStatus4Choice.Rejected))]
    [JsonDerivedType(typeof(OrderStatus4Choice.Suspended), nameof(OrderStatus4Choice.Suspended))]
    [JsonDerivedType(typeof(OrderStatus4Choice.InRepair), nameof(OrderStatus4Choice.InRepair))]
    [JsonDerivedType(
        typeof(OrderStatus4Choice.PartiallySettled),
        nameof(OrderStatus4Choice.PartiallySettled)
    )]
    [IsoId("_9XxY8UH8EeaV3ab_pHzFIQ")]
    [DisplayName("Order Status 4 Choice")]
    public abstract record OrderStatus4Choice_ { }
}
