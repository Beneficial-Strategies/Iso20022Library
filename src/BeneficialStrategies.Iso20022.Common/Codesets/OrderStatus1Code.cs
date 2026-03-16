// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies current status of order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRn-1dp-Ed-ak6NoX_4Aeg_1586352296")]
[Description(@"Identifies current status of order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus1Code
{
    /// <summary>
    /// Outstanding order with no executions.
    /// Encoded/decoded by serializers as &quot;NEWW&quot;.
    /// </summary>
    [EnumMember(Value = "NEWW")]
    [IsoId("_aRn-1tp-Ed-ak6NoX_4Aeg_1651923156")]
    [Description(@"Outstanding order with no executions.")]
    New = OrderStatusCode.New, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Outstanding order with executions and remaining quantity.
    /// Encoded/decoded by serializers as &quot;PARF&quot;.
    /// </summary>
    [EnumMember(Value = "PARF")]
    [IsoId("_aRn-19p-Ed-ak6NoX_4Aeg_1651923198")]
    [Description(@"Outstanding order with executions and remaining quantity.")]
    PartialFill = OrderStatusCode.PartialFill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order completely filled, no remaining quantity.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_aRn-2Np-Ed-ak6NoX_4Aeg_1651923216")]
    [Description(@"Order completely filled, no remaining quantity.")]
    Filled = OrderStatusCode.Filled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been partially filled, and is done for the day, ie, no further executions will take place today.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_aRxIwNp-Ed-ak6NoX_4Aeg_1651923258")]
    [Description(
        @"Order has been partially filled, and is done for the day, ie, no further executions will take place today."
    )]
    DoneForDay = OrderStatusCode.DoneForDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancelled order with or without executions.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aRxIwdp-Ed-ak6NoX_4Aeg_1651923293")]
    [Description(@"Cancelled order with or without executions.")]
    Cancelled = OrderStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been replaced.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_aRxIwtp-Ed-ak6NoX_4Aeg_1651923336")]
    [Description(@"Order has been replaced.")]
    Replaced = OrderStatusCode.Replaced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aRxIw9p-Ed-ak6NoX_4Aeg_1651923371")]
    [Description(
        @"Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled."
    )]
    PendingCancel = OrderStatusCode.PendingCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been stopped at the exchange. Used when guaranteeing or protecting a price and quantity.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_aRxIxNp-Ed-ak6NoX_4Aeg_1651923630")]
    [Description(
        @"Order has been stopped at the exchange. Used when guaranteeing or protecting a price and quantity."
    )]
    Stopped = OrderStatusCode.Stopped, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aRxIxdp-Ed-ak6NoX_4Aeg_1651923674")]
    [Description(
        @"Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status."
    )]
    Rejected = OrderStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been placed in suspended state at the request of the client.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_aRxIxtp-Ed-ak6NoX_4Aeg_1651923726")]
    [Description(@"Order has been placed in suspended state at the request of the client.")]
    Suspended = OrderStatusCode.Suspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received by sell-side system but not yet accepted for execution. An execution message with this status will only be sent in response to a Status Request message.
    /// Encoded/decoded by serializers as &quot;PENN&quot;.
    /// </summary>
    [EnumMember(Value = "PENN")]
    [IsoId("_aRxIx9p-Ed-ak6NoX_4Aeg_1651923769")]
    [Description(
        @"Order has been received by sell-side system but not yet accepted for execution. An execution message with this status will only be sent in response to a Status Request message."
    )]
    PendingNew = OrderStatusCode.PendingNew, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been completed for the day (either filled or done for day). Commission or currency settlement details have been calculated and reported in this execution message.
    /// Encoded/decoded by serializers as &quot;CALC&quot;.
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_aRxIyNp-Ed-ak6NoX_4Aeg_1651924052")]
    [Description(
        @"Order has been completed for the day (either filled or done for day). Commission or currency settlement details have been calculated and reported in this execution message."
    )]
    Calculated = OrderStatusCode.Calculated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been cancelled in the broker&apos;s system due to time in force instructions.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_aRxIydp-Ed-ak6NoX_4Aeg_1651924112")]
    [Description(
        @"Order has been cancelled in the broker's system due to time in force instructions."
    )]
    Expired = OrderStatusCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received and is being evaluated for pricing.
    /// Encoded/decoded by serializers as &quot;ACBI&quot;.
    /// </summary>
    [EnumMember(Value = "ACBI")]
    [IsoId("_aR65wNp-Ed-ak6NoX_4Aeg_1651924172")]
    [Description(@"Order has been received and is being evaluated for pricing.")]
    AcceptedForBidding = OrderStatusCode.AcceptedForBidding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order with an Order Cancel/Replace Request pending, used to confirm receipt of an Order Cancel/Replace Request. Does not indicate that the order has been replaced.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_aR65wdp-Ed-ak6NoX_4Aeg_1651924207")]
    [Description(
        @"Order with an Order Cancel/Replace Request pending, used to confirm receipt of an Order Cancel/Replace Request. Does not indicate that the order has been replaced."
    )]
    PendingReplace = OrderStatusCode.PendingReplace, // same ordinal as derivation source for type conversions
}
