// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aSEqxtp-Ed-ak6NoX_4Aeg_1781619075")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus5Code
{
    /// <summary>
    /// Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aSEqx9p-Ed-ak6NoX_4Aeg_1838875056")]
    [Description(
        @"Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received = OrderStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aSEqyNp-Ed-ak6NoX_4Aeg_1838874961")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied)."
    )]
    Accepted = OrderStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is already executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aSN0sNp-Ed-ak6NoX_4Aeg_1838874996")]
    [Description(@"Order is already executed and confirmation has been sent.")]
    AlreadyExecuted = OrderStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aSN0sdp-Ed-ak6NoX_4Aeg_1838875038")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication problems with the next party.
    /// Encoded/decoded by serializers as &quot;CPNP&quot;.
    /// </summary>
    [EnumMember(Value = "CPNP")]
    [IsoId("_aSN0stp-Ed-ak6NoX_4Aeg_1838875133")]
    [Description(@"Communication problems with the next party.")]
    CommunicationProblemNextParty = OrderStatusCode.CommunicationProblemNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is settled. The cash is credited or debited.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_aSN0s9p-Ed-ak6NoX_4Aeg_-1101289239")]
    [Description(@"Order is settled. The cash is credited or debited.")]
    Settled = OrderStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied). Cash is settled, but the order is not executed.
    /// Encoded/decoded by serializers as &quot;CSNE&quot;.
    /// </summary>
    [EnumMember(Value = "CSNE")]
    [IsoId("_aSN0tNp-Ed-ak6NoX_4Aeg_-1074505844")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied). Cash is settled, but the order is not executed."
    )]
    CashSettledOrderNotExecuted = OrderStatusCode.CashSettledOrderNotExecuted, // same ordinal as derivation source for type conversions
}
