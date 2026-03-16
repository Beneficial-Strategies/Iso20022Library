// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Veg1Jtp-Ed-ak6NoX_4Aeg_-352988908")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus2Code
{
    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_Veg1J9p-Ed-ak6NoX_4Aeg_1339886390")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied)."
    )]
    Accepted = OrderStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is already executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_Veg1KNp-Ed-ak6NoX_4Aeg_222160179")]
    [Description(@"Order is already executed and confirmation has been sent.")]
    AlreadyExecuted = OrderStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_Vep_ENp-Ed-ak6NoX_4Aeg_1015729936")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_Vep_Edp-Ed-ak6NoX_4Aeg_1045282174")]
    [Description(
        @"Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received = OrderStatusCode.Received, // same ordinal as derivation source for type conversions
}
