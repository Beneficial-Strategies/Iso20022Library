// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4BrFQSCZEe64P8jfINlL1Q")]
[Description(@"Specifies the current status of an order.")]
[DerivedFrom(typeof(OrderStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderStatus11Code>))]
public enum OrderStatus11Code
{
    /// <summary>
    /// Quotes that can be executed.
    /// Encoded/decoded by serializers as &quot;FIRM&quot;.
    /// </summary>
    [EnumMember(Value = "FIRM")]
    [IsoId("_4CdIYyCZEe64P8jfINlL1Q")]
    [Description(@"Quotes that can be executed.")]
    FirmQuotes = OrderStatusCode.FirmQuotes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used for strategy orders that are derived from implied in or implied out functionality.
    /// Encoded/decoded by serializers as &quot;IMPL&quot;.
    /// </summary>
    [EnumMember(Value = "IMPL")]
    [IsoId("_4CdIZSCZEe64P8jfINlL1Q")]
    [Description(
        @"Used for strategy orders that are derived from implied in or implied out functionality."
    )]
    ImpliedStrategyOrders = OrderStatusCode.ImpliedStrategyOrders, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quotes that are visible but cannot be executed. Includes warrants in some trading venue.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_4CdIaSCZEe64P8jfINlL1Q")]
    [Description(
        @"Quotes that are visible but cannot be executed. Includes warrants in some trading venue."
    )]
    IndicativeQuotes = OrderStatusCode.IndicativeQuotes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Orders that are routed by the trading venue to other venues.
    /// Encoded/decoded by serializers as &quot;ROUT&quot;.
    /// </summary>
    [EnumMember(Value = "ROUT")]
    [IsoId("_4CdIayCZEe64P8jfINlL1Q")]
    [Description(@"Orders that are routed by the trading venue to other venues.")]
    RoutedOrders = OrderStatusCode.RoutedOrders, // same ordinal as derivation source for type conversions
}
