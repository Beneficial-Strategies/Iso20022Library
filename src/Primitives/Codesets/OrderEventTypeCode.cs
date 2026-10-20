// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Events affecting the orders in financial instruments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_O3l80GvfEe2Re-GccwOX8g")]
[Description(@"Events affecting the orders in financial instruments.")]
[Derivations(typeof(OrderEventType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderEventTypeCode>))]
public enum OrderEventTypeCode
{
    /// <summary>
    /// Member, participant or client decides upon its own initiative to cancel the order it has previously entered.
    /// Encoded/decoded by serializers as &quot;CAME&quot;.
    /// </summary>
    [EnumMember(Value = "CAME")]
    [IsoId("_XYwQIGvgEe2Re-GccwOX8g")]
    [Description(
        @"Member, participant or client decides upon its own initiative to cancel the order it has previously entered."
    )]
    CancelledAtTheInitiativeOfTheMemberOrParticipantOfTheTradingVenue,

    /// <summary>
    /// Includes a protection mechanism provided for investment firms carrying out a market-making activity.
    /// Encoded/decoded by serializers as &quot;CAMO&quot;.
    /// </summary>
    [EnumMember(Value = "CAMO")]
    [IsoId("_euRFIGvgEe2Re-GccwOX8g")]
    [Description(
        @"Includes a protection mechanism provided for investment firms carrying out a market-making activity."
    )]
    CancelledByMarketOperations,

    /// <summary>
    /// Includes activation and deactivation.
    /// Encoded/decoded by serializers as &quot;CHME&quot;.
    /// </summary>
    [EnumMember(Value = "CHME")]
    [IsoId("_FXqCMGvgEe2Re-GccwOX8g")]
    [Description(@"Includes activation and deactivation.")]
    ChangeOfStatusAtTheInitiativeOfTheMemberOrParticipantOfTheTradingVenue,

    /// <summary>
    /// Change of status due to market operations.
    /// Encoded/decoded by serializers as &quot;CHMO&quot;.
    /// </summary>
    [EnumMember(Value = "CHMO")]
    [IsoId("_QZO5QGvgEe2Re-GccwOX8g")]
    [Description(@"Change of status due to market operations.")]
    ChangeOfStatusDuetoMarketOperations,

    /// <summary>
    /// Where the order is removed from the order book upon the end of its validity period.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_uEnkEGvgEe2Re-GccwOX8g")]
    [Description(
        @"Where the order is removed from the order book upon the end of its validity period.  "
    )]
    ExpiredOrder,

    /// <summary>
    /// Where there is no more quantity to be executed.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_3x798GvgEe2Re-GccwOX8g")]
    [Description(@"Where there is no more quantity to be executed.")]
    Filled,

    /// <summary>
    /// Receipt of a new order by the operator of the trading venue.
    /// Encoded/decoded by serializers as &quot;NEWO&quot;.
    /// </summary>
    [EnumMember(Value = "NEWO")]
    [IsoId("_anggkGvfEe2Re-GccwOX8g")]
    [Description(@"Receipt of a new order by the operator of the trading venue. ")]
    NewOrder,

    /// <summary>
    /// Where the order is not fully executed so that there remains a quantity to be executed.
    /// Encoded/decoded by serializers as &quot;PARF&quot;.
    /// </summary>
    [EnumMember(Value = "PARF")]
    [IsoId("_yqQ5gGvgEe2Re-GccwOX8g")]
    [Description(
        @"Where the order is not fully executed so that there remains a quantity to be executed.  "
    )]
    PartiallyFilled,

    /// <summary>
    /// Where any characteristic of an order is changed by the trading venue operator's IT systems.
    /// Encoded/decoded by serializers as &quot;REMA&quot;.
    /// </summary>
    [EnumMember(Value = "REMA")]
    [IsoId("_tFjJMGvfEe2Re-GccwOX8g")]
    [Description(
        @"Where any characteristic of an order is changed by the trading venue operator's IT systems. This includes where a peg order's or a trailing stop order's current characteristics are changed to reflect how the order is located within the order book. "
    )]
    ReplacedByMarketOperationsAutomatic,

    /// <summary>
    /// Where a member, participant or client of the trading venue decides upon its own initiative to change any characteristic of the order it has previously entered into the order book.
    /// Encoded/decoded by serializers as &quot;REME&quot;.
    /// </summary>
    [EnumMember(Value = "REME")]
    [IsoId("_ixkX8GvfEe2Re-GccwOX8g")]
    [Description(
        @"Where a member, participant or client of the trading venue decides upon its own initiative to change any characteristic of the order it has previously entered into the order book. "
    )]
    ReplacedByTheMemberOrParticipantOfTheTradingVenue,

    /// <summary>
    /// Where any characteristic of an order is changed by a trading venue operator's staff.
    /// Encoded/decoded by serializers as &quot;REMH&quot;.
    /// </summary>
    [EnumMember(Value = "REMH")]
    [IsoId("_80crAGvfEe2Re-GccwOX8g")]
    [Description(
        @"Where any characteristic of an order is changed by a trading venue operator's staff. This includes the situation where a member, participant of the trading venue has IT issues and needs its orders to be cancelled urgently. "
    )]
    ReplacedByMarketOperationsHumanIntervention,

    /// <summary>
    /// Order received but rejected by the operator of the trading venue.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_nrvWcGvgEe2Re-GccwOX8g")]
    [Description(@"Order received but rejected by the operator of the trading venue. ")]
    RejectedOrder,

    /// <summary>
    /// Response to a request for quote submitted by one or more members or participants.
    /// Encoded/decoded by serializers as &quot;RFQR&quot;.
    /// </summary>
    [EnumMember(Value = "RFQR")]
    [IsoId("_FnRgMHYgEe2qcfPWtIciGg")]
    [Description(
        @"Response to a request for quote submitted by one or more members or participants. "
    )]
    QuoteResponse,

    /// <summary>
    /// Request for quote by one or more members or participants.
    /// Encoded/decoded by serializers as &quot;RFQS&quot;.
    /// </summary>
    [EnumMember(Value = "RFQS")]
    [IsoId("_cpmBwHYfEe2qcfPWtIciGg")]
    [Description(@"Request for quote by one or more members or participants.")]
    QuoteRequest,

    /// <summary>
    /// Order which becomes executable or, as the case may be, non-executable upon the realisation of a pre-determined condition.
    /// Encoded/decoded by serializers as &quot;TRIG&quot;.
    /// </summary>
    [EnumMember(Value = "TRIG")]
    [IsoId("_d2VNAGvfEe2Re-GccwOX8g")]
    [Description(
        @"Order which becomes executable or, as the case may be, non-executable upon the realisation of a pre-determined condition. "
    )]
    Triggered,
}
