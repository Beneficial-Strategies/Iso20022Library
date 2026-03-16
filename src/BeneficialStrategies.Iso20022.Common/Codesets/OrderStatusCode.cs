// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aSXltNp-Ed-ak6NoX_4Aeg_336257668")]
[Description(@"Specifies the current status of the order.")]
[Derivations(
    typeof(OrderStatus2Code),
    typeof(OrderStatus4Code),
    typeof(OrderStatus7Code),
    typeof(OrderStatus1Code),
    typeof(OrderStatus3Code),
    typeof(OrderStatus5Code),
    typeof(OrderStatus6Code),
    typeof(OrderStatus8Code)
)]
public enum OrderStatusCode
{
    /// <summary>
    /// Outstanding order with no executions.
    /// Encoded/decoded by serializers as &quot;NEWW&quot;.
    /// </summary>
    [EnumMember(Value = "NEWW")]
    [IsoId("_aSXltdp-Ed-ak6NoX_4Aeg_336257669")]
    [Description(@"Outstanding order with no executions.")]
    New,

    /// <summary>
    /// Outstanding order with executions and remaining quantity.
    /// Encoded/decoded by serializers as &quot;PARF&quot;.
    /// </summary>
    [EnumMember(Value = "PARF")]
    [IsoId("_aSXlttp-Ed-ak6NoX_4Aeg_336257670")]
    [Description(@"Outstanding order with executions and remaining quantity.")]
    PartialFill,

    /// <summary>
    /// Order completely filled, no remaining quantity.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_aSXlt9p-Ed-ak6NoX_4Aeg_336257671")]
    [Description(@"Order completely filled, no remaining quantity.")]
    Filled,

    /// <summary>
    /// Order has been partially filled, and is done for the day, ie, no further executions will take place today.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_aSXluNp-Ed-ak6NoX_4Aeg_336257672")]
    [Description(
        @"Order has been partially filled, and is done for the day, ie, no further executions will take place today."
    )]
    DoneForDay,

    /// <summary>
    /// Cancelled order with or without executions.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_aSXludp-Ed-ak6NoX_4Aeg_336257673")]
    [Description(@"Cancelled order with or without executions.")]
    Cancelled,

    /// <summary>
    /// Order has been replaced.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_aShWsNp-Ed-ak6NoX_4Aeg_336257674")]
    [Description(@"Order has been replaced.")]
    Replaced,

    /// <summary>
    /// Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aShWsdp-Ed-ak6NoX_4Aeg_336257682")]
    [Description(
        @"Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled."
    )]
    PendingCancel,

    /// <summary>
    /// Order has been stopped at the exchange. Used when guaranteeing or protecting a price and quantity.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_aShWstp-Ed-ak6NoX_4Aeg_336257683")]
    [Description(
        @"Order has been stopped at the exchange. Used when guaranteeing or protecting a price and quantity."
    )]
    Stopped,

    /// <summary>
    /// Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aShWs9p-Ed-ak6NoX_4Aeg_336257684")]
    [Description(
        @"Order has been rejected by sell-side. NOTE: An order can be rejected subsequent to order acknowledgment, i.e. an order can pass from New to Rejected status."
    )]
    Rejected,

    /// <summary>
    /// Order has been placed in suspended state at the request of the client.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_aShWtNp-Ed-ak6NoX_4Aeg_336257685")]
    [Description(@"Order has been placed in suspended state at the request of the client.")]
    Suspended,

    /// <summary>
    /// Order has been received by sell-side system but not yet accepted for execution. An execution message with this status will only be sent in response to a Status Request message.
    /// Encoded/decoded by serializers as &quot;PENN&quot;.
    /// </summary>
    [EnumMember(Value = "PENN")]
    [IsoId("_aShWtdp-Ed-ak6NoX_4Aeg_336257686")]
    [Description(
        @"Order has been received by sell-side system but not yet accepted for execution. An execution message with this status will only be sent in response to a Status Request message."
    )]
    PendingNew,

    /// <summary>
    /// Order has been completed for the day (either filled or done for day). Commission or currency settlement details have been calculated and reported in this execution message.
    /// Encoded/decoded by serializers as &quot;CALC&quot;.
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_aShWttp-Ed-ak6NoX_4Aeg_336257687")]
    [Description(
        @"Order has been completed for the day (either filled or done for day). Commission or currency settlement details have been calculated and reported in this execution message."
    )]
    Calculated,

    /// <summary>
    /// Order has been cancelled in the broker&apos;s system due to time in force instructions.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_aShWt9p-Ed-ak6NoX_4Aeg_336257696")]
    [Description(
        @"Order has been cancelled in the broker's system due to time in force instructions."
    )]
    Expired,

    /// <summary>
    /// Order has been received and is being evaluated for pricing.
    /// Encoded/decoded by serializers as &quot;ACBI&quot;.
    /// </summary>
    [EnumMember(Value = "ACBI")]
    [IsoId("_aShWuNp-Ed-ak6NoX_4Aeg_336257697")]
    [Description(@"Order has been received and is being evaluated for pricing.")]
    AcceptedForBidding,

    /// <summary>
    /// Order with an Order Cancel/Replace Request pending, used to confirm receipt of an Order Cancel/Replace Request. Does not indicate that the order has been replaced.
    /// Encoded/decoded by serializers as &quot;PENR&quot;.
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_aShWudp-Ed-ak6NoX_4Aeg_336257698")]
    [Description(
        @"Order with an Order Cancel/Replace Request pending, used to confirm receipt of an Order Cancel/Replace Request. Does not indicate that the order has been replaced."
    )]
    PendingReplace,

    /// <summary>
    /// Request for cancellation instruction for the order has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aSqgoNp-Ed-ak6NoX_4Aeg_1778081951")]
    [Description(
        @"Request for cancellation instruction for the order has been accepted and processed; the order has been cancelled."
    )]
    Completed,

    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aSqgodp-Ed-ak6NoX_4Aeg_1778082064")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied)."
    )]
    Accepted,

    /// <summary>
    /// Order is already executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aSqgotp-Ed-ak6NoX_4Aeg_1778082089")]
    [Description(@"Order is already executed and confirmation has been sent.")]
    AlreadyExecuted,

    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aSqgo9p-Ed-ak6NoX_4Aeg_1778082124")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty,

    /// <summary>
    /// Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aSqgpNp-Ed-ak6NoX_4Aeg_1778082141")]
    [Description(
        @"Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received,

    /// <summary>
    /// Order is settled. The cash is credited or debited.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_aSqgpdp-Ed-ak6NoX_4Aeg_1338641451")]
    [Description(@"Order is settled. The cash is credited or debited.")]
    Settled,

    /// <summary>
    /// Communication problems with the next party.
    /// Encoded/decoded by serializers as &quot;CPNP&quot;.
    /// </summary>
    [EnumMember(Value = "CPNP")]
    [IsoId("_aSqgptp-Ed-ak6NoX_4Aeg_1338641823")]
    [Description(@"Communication problems with the next party.")]
    CommunicationProblemNextParty,

    /// <summary>
    /// Order confirmation cancellation has been sent and will be followed by a confirmation amendment, or a confirmation amendment has been sent.
    /// Encoded/decoded by serializers as &quot;CNFC&quot;.
    /// </summary>
    [EnumMember(Value = "CNFC")]
    [IsoId("_aSqgp9p-Ed-ak6NoX_4Aeg_1338642321")]
    [Description(
        @"Order confirmation cancellation has been sent and will be followed by a confirmation amendment, or a confirmation amendment has been sent."
    )]
    ConfirmationAmendment,

    /// <summary>
    /// Order has been partially filled and will not be filled further.
    /// Encoded/decoded by serializers as &quot;DONF&quot;.
    /// </summary>
    [EnumMember(Value = "DONF")]
    [IsoId("_aSqgqNp-Ed-ak6NoX_4Aeg_1338642458")]
    [Description(@"Order has been partially filled and will not be filled further.")]
    PartiallyDone,

    /// <summary>
    /// Order is open.
    /// Encoded/decoded by serializers as &quot;OPOD&quot;.
    /// </summary>
    [EnumMember(Value = "OPOD")]
    [IsoId("_aSqgqdp-Ed-ak6NoX_4Aeg_1338643157")]
    [Description(@"Order is open.")]
    Open,

    /// <summary>
    /// Order confirmation received from agent is invalid.
    /// Encoded/decoded by serializers as &quot;IACO&quot;.
    /// </summary>
    [EnumMember(Value = "IACO")]
    [IsoId("_aS0RoNp-Ed-ak6NoX_4Aeg_1338643312")]
    [Description(@"Order confirmation received from agent is invalid.")]
    InvalidAgentConfirmation,

    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied). Cash is settled, but the order is not executed.
    /// Encoded/decoded by serializers as &quot;CSNE&quot;.
    /// </summary>
    [EnumMember(Value = "CSNE")]
    [IsoId("_aS0Rodp-Ed-ak6NoX_4Aeg_-1535100428")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied). Cash is settled, but the order is not executed."
    )]
    CashSettledOrderNotExecuted,

    /// <summary>
    /// Indicates that a list has been received and the sell side is working it.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_aS0Rotp-Ed-ak6NoX_4Aeg_-27867462")]
    [Description(@"Indicates that a list has been received and the sell side is working it.")]
    Executing,

    /// <summary>
    /// Indicates that a cancellation request has been received and the sell side is in the process of pulling any orders that were being worked. The status of individual order can be found out from the detail repeating group.
    /// Encoded/decoded by serializers as &quot;CACE&quot;.
    /// </summary>
    [EnumMember(Value = "CACE")]
    [IsoId("_aS0Ro9p-Ed-ak6NoX_4Aeg_569382449")]
    [Description(
        @"Indicates that a cancellation request has been received and the sell side is in the process of pulling any orders that were being worked. The status of individual order can be found out from the detail repeating group."
    )]
    Cancelling,

    /// <summary>
    /// Used whenever any of the individual orders have a status that requires something to be done. For instance, an alert would be used when a buy-side firm has submitted a list that has individual stock reject that have not been addressed.
    /// Encoded/decoded by serializers as &quot;ALER&quot;.
    /// </summary>
    [EnumMember(Value = "ALER")]
    [IsoId("_aS0RpNp-Ed-ak6NoX_4Aeg_-554023409")]
    [Description(
        @"Used whenever any of the individual orders have a status that requires something to be done. For instance, an alert would be used when a buy-side firm has submitted a list that has individual stock reject that have not been addressed."
    )]
    Alert,

    /// <summary>
    /// Non-quote orders that are tradable.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_WRblQGvsEe2Re-GccwOX8g")]
    [Description(@"Non-quote orders that are tradable.")]
    Active,

    /// <summary>
    /// Quotes that can be executed.
    /// Encoded/decoded by serializers as &quot;FIRM&quot;.
    /// </summary>
    [EnumMember(Value = "FIRM")]
    [IsoId("_amoD4GvsEe2Re-GccwOX8g")]
    [Description(@"Quotes that can be executed.")]
    FirmQuotes,

    /// <summary>
    /// Used for strategy orders that are derived from implied in or implied out functionality.
    /// Encoded/decoded by serializers as &quot;IMPL&quot;.
    /// </summary>
    [EnumMember(Value = "IMPL")]
    [IsoId("_dZYfYGvsEe2Re-GccwOX8g")]
    [Description(
        @"Used for strategy orders that are derived from implied in or implied out functionality."
    )]
    ImpliedStrategyOrders,

    /// <summary>
    /// Non-quote orders that are not tradable.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_gZRX8GvsEe2Re-GccwOX8g")]
    [Description(@"Non-quote orders that are not tradable.")]
    Inactive,

    /// <summary>
    /// Quotes that are visible but cannot be executed. Includes warrants in some trading venue.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_jhIgwGvsEe2Re-GccwOX8g")]
    [Description(
        @"Quotes that are visible but cannot be executed. Includes warrants in some trading venue."
    )]
    IndicativeQuotes,

    /// <summary>
    /// Orders that are routed by the trading venue to other venues.
    /// Encoded/decoded by serializers as &quot;ROUT&quot;.
    /// </summary>
    [EnumMember(Value = "ROUT")]
    [IsoId("_mcA9gGvsEe2Re-GccwOX8g")]
    [Description(@"Orders that are routed by the trading venue to other venues.")]
    RoutedOrders,
}
