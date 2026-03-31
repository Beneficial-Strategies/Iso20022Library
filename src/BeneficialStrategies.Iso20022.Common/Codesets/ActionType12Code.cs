// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5S5igUxbEey2lJnsdq4TIg")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ActionType12Code>))]
#endif
public enum ActionType12Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_5dVQ4UxbEey2lJnsdq4TIg")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_5dVQ40xbEey2lJnsdq4TIg")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_5dVQ5UxbEey2lJnsdq4TIg")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as &quot;NOVR&quot;.
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_5dVQ50xbEey2lJnsdq4TIg")]
    [Description(
        @"Payment application cannot propose to the merchant an override of the payment transaction."
    )]
    ForbidOverride = ActionTypeCode.ForbidOverride, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_5dVQ6UxbEey2lJnsdq4TIg")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_5dV38UxbEey2lJnsdq4TIg")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_5dV380xbEey2lJnsdq4TIg")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_5dV39UxbEey2lJnsdq4TIg")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_5dV390xbEey2lJnsdq4TIg")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_5dV3-UxbEey2lJnsdq4TIg")]
    [Description(
        @"Request additional data through a displayed text and request confirmation by an attendant."
    )]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_5dV3-0xbEey2lJnsdq4TIg")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fall-forward from contactless to chip card transaction required.
    /// Encoded/decoded by serializers as &quot;FLFW&quot;.
    /// </summary>
    [EnumMember(Value = "FLFW")]
    [IsoId("_5dV3_UxbEey2lJnsdq4TIg")]
    [Description(@"Fall-forward from contactless to chip card transaction required.")]
    FallForward = ActionTypeCode.FallForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request Cardholder Authentification through PIN insertion.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_5dV3_0xbEey2lJnsdq4TIg")]
    [Description(@"Request Cardholder Authentification through PIN insertion.")]
    PINRequest = ActionTypeCode.PINRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.
    /// Encoded/decoded by serializers as &quot;CDCV&quot;.
    /// </summary>
    [EnumMember(Value = "CDCV")]
    [IsoId("_5dV4AUxbEey2lJnsdq4TIg")]
    [Description(
        @"Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod."
    )]
    ConsumerDeviceCardholderVerificationMethod =
        ActionTypeCode.ConsumerDeviceCardholderVerificationMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional authentication of cardholder required.
    /// Encoded/decoded by serializers as &quot;CHDA&quot;.
    /// </summary>
    [EnumMember(Value = "CHDA")]
    [IsoId("_5dV4A0xbEey2lJnsdq4TIg")]
    [Description(@"Additional authentication of cardholder required.")]
    CardholderAuthentication = ActionTypeCode.CardholderAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recurring transactions is no more allowed for this card and for all merchants.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_-AFqYUxbEey2lJnsdq4TIg")]
    [Description(@"Recurring transactions is no more allowed for this card and for all merchants.")]
    StopAllRecurring = ActionTypeCode.StopAllRecurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder has revocated this recurring transaction for this merchant.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_-LH1sUxbEey2lJnsdq4TIg")]
    [Description(@"Cardholder has revocated this recurring transaction for this merchant.")]
    StopOneRecurring = ActionTypeCode.StopOneRecurring, // same ordinal as derivation source for type conversions
}
