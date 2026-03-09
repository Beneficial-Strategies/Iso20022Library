// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IsFrkXC7Ee2bmOA3bkVsMg")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType13Code
{
    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_I3MIUXC7Ee2bmOA3bkVsMg")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_I3MIU3C7Ee2bmOA3bkVsMg")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_I3MIVXC7Ee2bmOA3bkVsMg")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as &quot;NOVR&quot;.
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_I3MIV3C7Ee2bmOA3bkVsMg")]
    [Description(@"Payment application cannot propose to the merchant an override of the payment transaction.")]
    ForbidOverride = ActionTypeCode.ForbidOverride, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_I3MIWXC7Ee2bmOA3bkVsMg")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_I3MIW3C7Ee2bmOA3bkVsMg")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_I3MIXXC7Ee2bmOA3bkVsMg")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_I3MIX3C7Ee2bmOA3bkVsMg")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_I3MIYXC7Ee2bmOA3bkVsMg")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_I3MIY3C7Ee2bmOA3bkVsMg")]
    [Description(@"Request additional data through a displayed text and request confirmation by an attendant.")]
    RequestData = ActionTypeCode.RequestData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_I3MIZXC7Ee2bmOA3bkVsMg")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fall-forward from contactless to chip card transaction required.
    /// Encoded/decoded by serializers as &quot;FLFW&quot;.
    /// </summary>
    [EnumMember(Value = "FLFW")]
    [IsoId("_I3MIZ3C7Ee2bmOA3bkVsMg")]
    [Description(@"Fall-forward from contactless to chip card transaction required.")]
    FallForward = ActionTypeCode.FallForward, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request Cardholder Authentification through PIN insertion.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_I3MIaXC7Ee2bmOA3bkVsMg")]
    [Description(@"Request Cardholder Authentification through PIN insertion.")]
    PINRequest = ActionTypeCode.PINRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.
    /// Encoded/decoded by serializers as &quot;CDCV&quot;.
    /// </summary>
    [EnumMember(Value = "CDCV")]
    [IsoId("_I3MIa3C7Ee2bmOA3bkVsMg")]
    [Description(@"Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.")]
    ConsumerDeviceCardholderVerificationMethod = ActionTypeCode.ConsumerDeviceCardholderVerificationMethod, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional authentication of cardholder required.
    /// Encoded/decoded by serializers as &quot;CHDA&quot;.
    /// </summary>
    [EnumMember(Value = "CHDA")]
    [IsoId("_I3MIbXC7Ee2bmOA3bkVsMg")]
    [Description(@"Additional authentication of cardholder required.")]
    CardholderAuthentication = ActionTypeCode.CardholderAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recurring transactions is no more allowed for this card and for all merchants.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_I3MIb3C7Ee2bmOA3bkVsMg")]
    [Description(@"Recurring transactions is no more allowed for this card and for all merchants.")]
    StopAllRecurring = ActionTypeCode.StopAllRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder has revocated this recurring transaction for this merchant.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_I3MIcXC7Ee2bmOA3bkVsMg")]
    [Description(@"Cardholder has revocated this recurring transaction for this merchant.")]
    StopOneRecurring = ActionTypeCode.StopOneRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the account was updated and should be taken into account for future authorisation.
    /// Encoded/decoded by serializers as &quot;ACUP&quot;.
    /// </summary>
    [EnumMember(Value = "ACUP")]
    [IsoId("_fAorsXC7Ee2bmOA3bkVsMg")]
    [Description(@"Indicates that the account was updated and should be taken into account for future authorisation.")]
    AccountUpdate = ActionTypeCode.AccountUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the authorization should be resubmitted at a later time.
    /// Encoded/decoded by serializers as &quot;TALT&quot;.
    /// </summary>
    [EnumMember(Value = "TALT")]
    [IsoId("_dusxIXSJEe2HedJwQoP0gA")]
    [Description(@"Indicates that the authorization should be resubmitted at a later time.")]
    TryAgainLater = ActionTypeCode.TryAgainLater, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that this account shouldn&apos;t be used anymore.
    /// Encoded/decoded by serializers as &quot;DNTA&quot;.
    /// </summary>
    [EnumMember(Value = "DNTA")]
    [IsoId("_fKy7sXSJEe2HedJwQoP0gA")]
    [Description(@"Indicates that this account shouldn't be used anymore.")]
    DoNotTryAgain = ActionTypeCode.DoNotTryAgain, // same ordinal as derivation source for type conversions
    
}
