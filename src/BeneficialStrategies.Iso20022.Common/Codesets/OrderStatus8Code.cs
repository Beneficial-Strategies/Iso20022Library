// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies current status of order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wh4GcIv6EeSJHZdigg3NTg")]
[Description(@"Identifies current status of order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus8Code
{
    /// <summary>
    /// Cancelled order with or without executions.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_3C5jcYv6EeSJHZdigg3NTg")]
    [Description(@"Cancelled order with or without executions.")]
    Cancelled = OrderStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Outstanding order with no executions.
    /// Encoded/decoded by serializers as &quot;NEWW&quot;.
    /// </summary>
    [EnumMember(Value = "NEWW")]
    [IsoId("_3ZYw0Yv6EeSJHZdigg3NTg")]
    [Description(@"Outstanding order with no executions.")]
    New = OrderStatusCode.New, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been replaced.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_4Z7n0Yv6EeSJHZdigg3NTg")]
    [Description(@"Order has been replaced.")]
    Replaced = OrderStatusCode.Replaced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been stopped at the exchange. Used when guaranteeing or protecting a price and quantity.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_40GbUYv6EeSJHZdigg3NTg")]
    [Description(@"Order has been stopped at the exchange. Used when guaranteeing or protecting a price and quantity.")]
    Stopped = OrderStatusCode.Stopped, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_6C1fUIv6EeSJHZdigg3NTg")]
    [Description(@"Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status.")]
    Rejected = OrderStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been cancelled in the broker&apos;s system due to time in force instructions.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("__Trt4Yv6EeSJHZdigg3NTg")]
    [Description(@"Order has been cancelled in the broker's system due to time in force instructions.")]
    Expired = OrderStatusCode.Expired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_DrW4wYv7EeSJHZdigg3NTg")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_YmKewYv7EeSJHZdigg3NTg")]
    [Description(@"Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.")]
    Received = OrderStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_bh_WsYv7EeSJHZdigg3NTg")]
    [Description(@"Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.")]
    PendingCancel = OrderStatusCode.PendingCancel, // same ordinal as derivation source for type conversions
    
}
