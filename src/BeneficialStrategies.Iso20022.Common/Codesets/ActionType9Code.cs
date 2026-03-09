// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_42sRoQvBEeqgUfvUJi0f5w")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType9Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_5CnNwQvBEeqgUfvUJi0f5w")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_5CnNwwvBEeqgUfvUJi0f5w")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_5CnNxQvBEeqgUfvUJi0f5w")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as &quot;NOVR&quot;.
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_5CnNxwvBEeqgUfvUJi0f5w")]
    [Description(@"Payment application cannot propose to the merchant an override of the payment transaction.")]
    ForbidOverride = ActionTypeCode.ForbidOverride, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_5CnNyQvBEeqgUfvUJi0f5w")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_5CnNywvBEeqgUfvUJi0f5w")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_5CnNzQvBEeqgUfvUJi0f5w")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_5CnNzwvBEeqgUfvUJi0f5w")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_5CnN0QvBEeqgUfvUJi0f5w")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_5CnN0wvBEeqgUfvUJi0f5w")]
    [Description(@"Request additional data through a displayed text and request confirmation by an attendant.")]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_5CnN1QvBEeqgUfvUJi0f5w")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fall-forward from contactless to chip card transaction required.
    /// Encoded/decoded by serializers as &quot;FLFW&quot;.
    /// </summary>
    [EnumMember(Value = "FLFW")]
    [IsoId("_5CnN1wvBEeqgUfvUJi0f5w")]
    [Description(@"Fall-forward from contactless to chip card transaction required.")]
    FallForward = ActionTypeCode.FallForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request Cardholder Authentification through PIN insertion.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_-6m74QvBEeqgUfvUJi0f5w")]
    [Description(@"Request Cardholder Authentification through PIN insertion.")]
    PINRequest = ActionTypeCode.PINRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.
    /// Encoded/decoded by serializers as &quot;CDCV&quot;.
    /// </summary>
    [EnumMember(Value = "CDCV")]
    [IsoId("__4KwUQvBEeqgUfvUJi0f5w")]
    [Description(@"Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.")]
    ConsumerDeviceCardholderVerificationMethod = ActionTypeCode.ConsumerDeviceCardholderVerificationMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional authentication of cardholder required.
    /// Encoded/decoded by serializers as &quot;CHDA&quot;.
    /// </summary>
    [EnumMember(Value = "CHDA")]
    [IsoId("_tSmGYRHiEeqHXfNbCUQ1KA")]
    [Description(@"Additional authentication of cardholder required.")]
    CardholderAuthentication = ActionTypeCode.CardholderAuthentication, // same ordinal as derivation source for type conversions
    
}
