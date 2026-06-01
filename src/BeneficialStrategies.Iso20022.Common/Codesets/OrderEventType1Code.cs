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
[IsoId("_9FvZ4GvgEe2Re-GccwOX8g")]
[Description(@"Events affecting the orders in financial instruments.")]
[DerivedFrom(typeof(OrderEventTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderEventType1Code>))]
public enum OrderEventType1Code
{
    /// <summary>
    /// Member, participant or client decides upon its own initiative to cancel the order it has previously entered.
    /// Encoded/decoded by serializers as &quot;CAME&quot;.
    /// </summary>
    [EnumMember(Value = "CAME")]
    [IsoId("_-KBhYWvgEe2Re-GccwOX8g")]
    [Description(
        @"Member, participant or client decides upon its own initiative to cancel the order it has previously entered."
    )]
    CancelledAtTheInitiativeOfTheMemberOrParticipantOfTheTradingVenue = OrderEventTypeCode.CancelledAtTheInitiativeOfTheMemberOrParticipantOfTheTradingVenue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Includes a protection mechanism provided for investment firms carrying out a market-making activity.
    /// Encoded/decoded by serializers as &quot;CAMO&quot;.
    /// </summary>
    [EnumMember(Value = "CAMO")]
    [IsoId("_-PGOoWvgEe2Re-GccwOX8g")]
    [Description(
        @"Includes a protection mechanism provided for investment firms carrying out a market-making activity."
    )]
    CancelledByMarketOperations = OrderEventTypeCode.CancelledByMarketOperations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Includes activation and deactivation.
    /// Encoded/decoded by serializers as &quot;CHME&quot;.
    /// </summary>
    [EnumMember(Value = "CHME")]
    [IsoId("_-Ur5QWvgEe2Re-GccwOX8g")]
    [Description(@"Includes activation and deactivation.")]
    ChangeOfStatusAtTheInitiativeOfTheMemberOrParticipantOfTheTradingVenue = OrderEventTypeCode.ChangeOfStatusAtTheInitiativeOfTheMemberOrParticipantOfTheTradingVenue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Change of status due to market operations.
    /// Encoded/decoded by serializers as &quot;CHMO&quot;.
    /// </summary>
    [EnumMember(Value = "CHMO")]
    [IsoId("_-dOxQWvgEe2Re-GccwOX8g")]
    [Description(@"Change of status due to market operations.")]
    ChangeOfStatusDuetoMarketOperations = OrderEventTypeCode.ChangeOfStatusDuetoMarketOperations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where the order is removed from the order book upon the end of its validity period.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_-kWF4WvgEe2Re-GccwOX8g")]
    [Description(
        @"Where the order is removed from the order book upon the end of its validity period.  "
    )]
    ExpiredOrder = OrderEventTypeCode.ExpiredOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where there is no more quantity to be executed.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_-qM2QWvgEe2Re-GccwOX8g")]
    [Description(@"Where there is no more quantity to be executed.")]
    Filled = OrderEventTypeCode.Filled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt of a new order by the operator of the trading venue.
    /// Encoded/decoded by serializers as &quot;NEWO&quot;.
    /// </summary>
    [EnumMember(Value = "NEWO")]
    [IsoId("_-v_VMWvgEe2Re-GccwOX8g")]
    [Description(@"Receipt of a new order by the operator of the trading venue. ")]
    NewOrder = OrderEventTypeCode.NewOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where the order is not fully executed so that there remains a quantity to be executed.
    /// Encoded/decoded by serializers as &quot;PARF&quot;.
    /// </summary>
    [EnumMember(Value = "PARF")]
    [IsoId("_-1eSIWvgEe2Re-GccwOX8g")]
    [Description(
        @"Where the order is not fully executed so that there remains a quantity to be executed.  "
    )]
    PartiallyFilled = OrderEventTypeCode.PartiallyFilled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where any characteristic of an order is changed by the trading venue operator's IT systems.
    /// Encoded/decoded by serializers as &quot;REMA&quot;.
    /// </summary>
    [EnumMember(Value = "REMA")]
    [IsoId("_-7HnIWvgEe2Re-GccwOX8g")]
    [Description(
        @"Where any characteristic of an order is changed by the trading venue operator's IT systems. This includes where a peg order's or a trailing stop order's current characteristics are changed to reflect how the order is located within the order book. "
    )]
    ReplacedByMarketOperationsAutomatic = OrderEventTypeCode.ReplacedByMarketOperationsAutomatic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where a member, participant or client of the trading venue decides upon its own initiative to change any characteristic of the order it has previously entered into the order book.
    /// Encoded/decoded by serializers as &quot;REME&quot;.
    /// </summary>
    [EnumMember(Value = "REME")]
    [IsoId("__P2hAWvgEe2Re-GccwOX8g")]
    [Description(
        @"Where a member, participant or client of the trading venue decides upon its own initiative to change any characteristic of the order it has previously entered into the order book. "
    )]
    ReplacedByTheMemberOrParticipantOfTheTradingVenue = OrderEventTypeCode.ReplacedByTheMemberOrParticipantOfTheTradingVenue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where any characteristic of an order is changed by a trading venue operator's staff.
    /// Encoded/decoded by serializers as &quot;REMH&quot;.
    /// </summary>
    [EnumMember(Value = "REMH")]
    [IsoId("__KTSoWvgEe2Re-GccwOX8g")]
    [Description(
        @"Where any characteristic of an order is changed by a trading venue operator's staff. This includes the situation where a member, participant of the trading venue has IT issues and needs its orders to be cancelled urgently. "
    )]
    ReplacedByMarketOperationsHumanIntervention = OrderEventTypeCode.ReplacedByMarketOperationsHumanIntervention, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order received but rejected by the operator of the trading venue.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("__Ck6AWvgEe2Re-GccwOX8g")]
    [Description(@"Order received but rejected by the operator of the trading venue. ")]
    RejectedOrder = OrderEventTypeCode.RejectedOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to a request for quote submitted by one or more members or participants.
    /// Encoded/decoded by serializers as &quot;RFQR&quot;.
    /// </summary>
    [EnumMember(Value = "RFQR")]
    [IsoId("_qcD50XYkEe2qcfPWtIciGg")]
    [Description(
        @"Response to a request for quote submitted by one or more members or participants. "
    )]
    QuoteResponse = OrderEventTypeCode.QuoteResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for quote by one or more members or participants.
    /// Encoded/decoded by serializers as &quot;RFQS&quot;.
    /// </summary>
    [EnumMember(Value = "RFQS")]
    [IsoId("_qU2ekXYkEe2qcfPWtIciGg")]
    [Description(@"Request for quote by one or more members or participants.")]
    QuoteRequest = OrderEventTypeCode.QuoteRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order which becomes executable or, as the case may be, non-executable upon the realisation of a pre-determined condition.
    /// Encoded/decoded by serializers as &quot;TRIG&quot;.
    /// </summary>
    [EnumMember(Value = "TRIG")]
    [IsoId("__Vi5UWvgEe2Re-GccwOX8g")]
    [Description(
        @"Order which becomes executable or, as the case may be, non-executable upon the realisation of a pre-determined condition. "
    )]
    Triggered = OrderEventTypeCode.Triggered, // same ordinal as derivation source for type conversions
}
