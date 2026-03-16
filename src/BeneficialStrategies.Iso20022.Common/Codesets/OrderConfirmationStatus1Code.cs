// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of an order confirmation or of an order confirmation amendment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQ4X8Np-Ed-ak6NoX_4Aeg_-2026694302")]
[Description(
    @"Specifies the current status of an order confirmation or of an order confirmation amendment."
)]
[DerivedFrom(typeof(OrderConfirmationStatusCode))]
public enum OrderConfirmationStatus1Code
{
    /// <summary>
    /// Order confirmation or order confirmation cancellation instruction or order confirmation amendment has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aQ4X8dp-Ed-ak6NoX_4Aeg_-1681562215")]
    [Description(
        @"Order confirmation or order confirmation cancellation instruction or order confirmation amendment has been sent to the next party, eg, the next intermediary."
    )]
    SentToNextParty = OrderConfirmationStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication problems with the next party.
    /// Encoded/decoded by serializers as &quot;CPNP&quot;.
    /// </summary>
    [EnumMember(Value = "CPNP")]
    [IsoId("_aQ4X8tp-Ed-ak6NoX_4Aeg_1277403271")]
    [Description(@"Communication problems with the next party.")]
    CommunicationProblemNextParty = OrderConfirmationStatusCode.CommunicationProblemNextParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order confirmation or order confirmation amendment is accepted.
    /// Encoded/decoded by serializers as &quot;COAC&quot;.
    /// </summary>
    [EnumMember(Value = "COAC")]
    [IsoId("_aQ4X89p-Ed-ak6NoX_4Aeg_-1681562310")]
    [Description(@"Order confirmation or order confirmation amendment is accepted.")]
    ConfirmationAccepted = OrderConfirmationStatusCode.ConfirmationAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order confirmation or order confirmation amendment is received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;CREC&quot;.
    /// </summary>
    [EnumMember(Value = "CREC")]
    [IsoId("_aQ4X9Np-Ed-ak6NoX_4Aeg_-1681562275")]
    [Description(
        @"Order confirmation or order confirmation amendment is received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    ConfirmationReceived = OrderConfirmationStatusCode.ConfirmationReceived, // same ordinal as derivation source for type conversions
}
