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
[IsoId("_W9SeUSCZEe64P8jfINlL1Q")]
[Description(@"Specifies the current status of an order.")]
[DerivedFrom(typeof(OrderStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderStatus10Code>))]
public enum OrderStatus10Code
{
    /// <summary>
    /// Non-quote orders that are tradable.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_W-IL0SCZEe64P8jfINlL1Q")]
    [Description(@"Non-quote orders that are tradable.")]
    Active = OrderStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-quote orders that are not tradable.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_W-IL1yCZEe64P8jfINlL1Q")]
    [Description(@"Non-quote orders that are not tradable.")]
    Inactive = OrderStatusCode.Inactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been placed in suspended state at the request of the client.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_TVrU0SFREe6gq6wfohoIlg")]
    [Description(@"Order has been placed in suspended state at the request of the client.")]
    Suspended = OrderStatusCode.Suspended, // same ordinal as derivation source for type conversions
}
