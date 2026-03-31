// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vep_Etp-Ed-ak6NoX_4Aeg_-933053776")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OrderStatus3Code>))]
#endif
public enum OrderStatus3Code
{
    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_Vep_E9p-Ed-ak6NoX_4Aeg_-913662626")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_Vep_FNp-Ed-ak6NoX_4Aeg_-887802624")]
    [Description(
        @"Order with an Order Cancel Request pending, used to confirm receipt of an Order Cancel Request. Does not indicate that the order has been cancelled."
    )]
    PendingCancel = OrderStatusCode.PendingCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for cancellation instruction for the order has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_Vep_Fdp-Ed-ak6NoX_4Aeg_-672621299")]
    [Description(
        @"Request for cancellation instruction for the order has been accepted and processed; the order has been cancelled."
    )]
    Completed = OrderStatusCode.Completed, // same ordinal as derivation source for type conversions
}
