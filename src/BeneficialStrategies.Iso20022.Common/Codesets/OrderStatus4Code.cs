// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aR65wtp-Ed-ak6NoX_4Aeg_300707129")]
[Description(@"Specifies the current status of the order.")]
[DerivedFrom(typeof(OrderStatusCode))]
public enum OrderStatus4Code
{
    /// <summary>
    /// Order is accepted and is ready for execution (execution is the moment when pricing is applied).
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aR65w9p-Ed-ak6NoX_4Aeg_329337861")]
    [Description(
        @"Order is accepted and is ready for execution (execution is the moment when pricing is applied)."
    )]
    Accepted = OrderStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is already executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aR65xNp-Ed-ak6NoX_4Aeg_330260418")]
    [Description(@"Order is already executed and confirmation has been sent.")]
    AlreadyExecuted = OrderStatusCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aR65xdp-Ed-ak6NoX_4Aeg_330260898")]
    [Description(@"Order has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_aR65xtp-Ed-ak6NoX_4Aeg_330260941")]
    [Description(
        @"Order has been received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    Received = OrderStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is settled. The cash is credited or debited.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_aR65x9p-Ed-ak6NoX_4Aeg_966938848")]
    [Description(@"Order is settled. The cash is credited or debited.")]
    Settled = OrderStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication problems with the next party.
    /// Encoded/decoded by serializers as &quot;CPNP&quot;.
    /// </summary>
    [EnumMember(Value = "CPNP")]
    [IsoId("_aSEqwNp-Ed-ak6NoX_4Aeg_966938883")]
    [Description(@"Communication problems with the next party.")]
    CommunicationProblemNextParty = OrderStatusCode.CommunicationProblemNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order confirmation cancellation has been sent and will be followed by a confirmation amendment, or a confirmation amendment has been sent.
    /// Encoded/decoded by serializers as &quot;CNFC&quot;.
    /// </summary>
    [EnumMember(Value = "CNFC")]
    [IsoId("_aSEqwdp-Ed-ak6NoX_4Aeg_966939233")]
    [Description(
        @"Order confirmation cancellation has been sent and will be followed by a confirmation amendment, or a confirmation amendment has been sent."
    )]
    ConfirmationAmendment = OrderStatusCode.ConfirmationAmendment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been partially filled, and is done for the day, ie, no further executions will take place today.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_aSEqwtp-Ed-ak6NoX_4Aeg_-2113826740")]
    [Description(
        @"Order has been partially filled, and is done for the day, ie, no further executions will take place today."
    )]
    DoneForDay = OrderStatusCode.DoneForDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been partially filled and will not be filled further.
    /// Encoded/decoded by serializers as &quot;DONF&quot;.
    /// </summary>
    [EnumMember(Value = "DONF")]
    [IsoId("_aSEqw9p-Ed-ak6NoX_4Aeg_1047712210")]
    [Description(@"Order has been partially filled and will not be filled further.")]
    PartiallyDone = OrderStatusCode.PartiallyDone, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is open.
    /// Encoded/decoded by serializers as &quot;OPOD&quot;.
    /// </summary>
    [EnumMember(Value = "OPOD")]
    [IsoId("_aSEqxNp-Ed-ak6NoX_4Aeg_1085577922")]
    [Description(@"Order is open.")]
    Open = OrderStatusCode.Open, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order confirmation received from agent is invalid.
    /// Encoded/decoded by serializers as &quot;IACO&quot;.
    /// </summary>
    [EnumMember(Value = "IACO")]
    [IsoId("_aSEqxdp-Ed-ak6NoX_4Aeg_-1148340037")]
    [Description(@"Order confirmation received from agent is invalid.")]
    InvalidAgentConfirmation = OrderStatusCode.InvalidAgentConfirmation, // same ordinal as derivation source for type conversions
}
