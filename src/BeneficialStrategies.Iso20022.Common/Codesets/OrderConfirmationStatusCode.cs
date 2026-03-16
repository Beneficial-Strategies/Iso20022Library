// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of an order confirmation or of an order confirmation amendment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQ4X9dp-Ed-ak6NoX_4Aeg_-2067326858")]
[Description(
    @"Specifies the current status of an order confirmation or of an order confirmation amendment."
)]
[Derivations(typeof(OrderConfirmationStatus1Code))]
public enum OrderConfirmationStatusCode
{
    /// <summary>
    /// Order confirmation or order confirmation amendment is accepted.
    /// Encoded/decoded by serializers as &quot;COAC&quot;.
    /// </summary>
    [EnumMember(Value = "COAC")]
    [IsoId("_aQ4X9tp-Ed-ak6NoX_4Aeg_-1108714477")]
    [Description(@"Order confirmation or order confirmation amendment is accepted.")]
    ConfirmationAccepted,

    /// <summary>
    /// Order confirmation or order confirmation amendment is received, ie, technical validation of the message is ok, and the message is now at the receiving side.
    /// Encoded/decoded by serializers as &quot;CREC&quot;.
    /// </summary>
    [EnumMember(Value = "CREC")]
    [IsoId("_aQ4X99p-Ed-ak6NoX_4Aeg_-838121726")]
    [Description(
        @"Order confirmation or order confirmation amendment is received, ie, technical validation of the message is ok, and the message is now at the receiving side."
    )]
    ConfirmationReceived,

    /// <summary>
    /// Order confirmation or order confirmation cancellation instruction or order confirmation amendment has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aQ4X-Np-Ed-ak6NoX_4Aeg_-1770220242")]
    [Description(
        @"Order confirmation or order confirmation cancellation instruction or order confirmation amendment has been sent to the next party, eg, the next intermediary."
    )]
    SentToNextParty,

    /// <summary>
    /// Communication problems with the next party.
    /// Encoded/decoded by serializers as &quot;CPNP&quot;.
    /// </summary>
    [EnumMember(Value = "CPNP")]
    [IsoId("_aRBh4Np-Ed-ak6NoX_4Aeg_-1023092651")]
    [Description(@"Communication problems with the next party.")]
    CommunicationProblemNextParty,
}
