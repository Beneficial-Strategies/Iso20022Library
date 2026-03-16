// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WOpRltp-Ed-ak6NoX_4Aeg_1655560201")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus7Code
{
    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_WOpRl9p-Ed-ak6NoX_4Aeg_1655560203")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied)."
    )]
    Accepted = OrderStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_WOybgNp-Ed-ak6NoX_4Aeg_1655560233")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_WOybgdp-Ed-ak6NoX_4Aeg_1655560262")]
    [Description(
        @"Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received = OrderStatusCode.Received, // same ordinal as derivation source for type conversions
}
