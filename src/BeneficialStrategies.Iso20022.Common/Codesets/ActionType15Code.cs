// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of action to be performed by the point of interaction (POI).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ActionType15Code")]
[Description(@"Type of action to be performed by the point of interaction (POI).")]
[DerivedFrom(typeof(ActionTypeCode))]
public enum ActionType15Code
{
    /// <summary>
    /// Indicates that the account was updated and should be taken into account for future authorisation.
    /// Encoded/decoded by serializers as &quot;ACUP&quot;.
    /// </summary>
    [EnumMember(Value = "ACUP")]
    [IsoId("_ActionType15Code_AccountUpdate")]
    [Description(@"Indicates that the account was updated and should be taken into account for future authorisation.")]
    AccountUpdate = ActionTypeCode.AccountUpdate,

    /// <summary>
    /// Server busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_ActionType15Code_Busy")]
    [Description(@"Server busy, try later.")]
    Busy = ActionTypeCode.Busy,

    /// <summary>
    /// Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.
    /// Encoded/decoded by serializers as &quot;CDCV&quot;.
    /// </summary>
    [EnumMember(Value = "CDCV")]
    [IsoId("_ActionType15Code_ConsumerDeviceCardholderVerificationMethod")]
    [Description(@"Request Cardholder Authentification according to the ConsumerDeviceCardholderVerificationMethod.")]
    ConsumerDeviceCardholderVerificationMethod = ActionTypeCode.ConsumerDeviceCardholderVerificationMethod,

    /// <summary>
    /// Additional authentication of cardholder required.
    /// Encoded/decoded by serializers as &quot;CHDA&quot;.
    /// </summary>
    [EnumMember(Value = "CHDA")]
    [IsoId("_ActionType15Code_CardholderAuthentication")]
    [Description(@"Additional authentication of cardholder required.")]
    CardholderAuthentication = ActionTypeCode.CardholderAuthentication,

    /// <summary>
    /// Capture the card.
    /// Encoded/decoded by serializers as &quot;CPTR&quot;.
    /// </summary>
    [EnumMember(Value = "CPTR")]
    [IsoId("_ActionType15Code_CaptureCard")]
    [Description(@"Capture the card.")]
    CaptureCard = ActionTypeCode.CaptureCard,

    /// <summary>
    /// Ask the cardholder to accept the currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCCQ")]
    [IsoId("_ActionType15Code_AcceptCurrencyConversion")]
    [Description(@"Ask the cardholder to accept the currency conversion.")]
    AcceptCurrencyConversion = ActionTypeCode.AcceptCurrencyConversion,

    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ActionType15Code_DisplayMessage")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage,

    /// <summary>
    /// Indicates that this account shouldn’t be used anymore.
    /// Encoded/decoded by serializers as &quot;DNTA&quot;.
    /// </summary>
    [EnumMember(Value = "DNTA")]
    [IsoId("_ActionType15Code_DoNotTryAgain")]
    [Description(@"Indicates that this account shouldn’t be used anymore.")]
    DoNotTryAgain = ActionTypeCode.DoNotTryAgain,

    /// <summary>
    /// Fall-forward from contactless to chip card transaction required.
    /// Encoded/decoded by serializers as &quot;FLFW&quot;.
    /// </summary>
    [EnumMember(Value = "FLFW")]
    [IsoId("_ActionType15Code_FallForward")]
    [Description(@"Fall-forward from contactless to chip card transaction required.")]
    FallForward = ActionTypeCode.FallForward,

    /// <summary>
    /// Reference used to process the transaction has been created for this transaction and shouldn’t be used for additional transactions.
    /// Encoded/decoded by serializers as &quot;NCOF&quot;.
    /// </summary>
    [EnumMember(Value = "NCOF")]
    [IsoId("_ActionType15Code_CardOnFileNotSupported")]
    [Description(@"Reference used to process the transaction has been created for this transaction and shouldn’t be used for additional transactions.")]
    CardOnFileNotSupported,

    /// <summary>
    /// Payment application cannot propose to the merchant an override of the payment transaction.
    /// Encoded/decoded by serializers as &quot;NOVR&quot;.
    /// </summary>
    [EnumMember(Value = "NOVR")]
    [IsoId("_ActionType15Code_ForbidOverride")]
    [Description(@"Payment application cannot propose to the merchant an override of the payment transaction.")]
    ForbidOverride = ActionTypeCode.ForbidOverride,

    /// <summary>
    /// Last PIN (Personal Identification Number) try.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_ActionType15Code_PINLastTry")]
    [Description(@"Last PIN (Personal Identification Number) try.")]
    PINLastTry = ActionTypeCode.PINLastTry,

    /// <summary>
    /// Request Cardholder Authentification through PIN insertion.
    /// Encoded/decoded by serializers as &quot;PINQ&quot;.
    /// </summary>
    [EnumMember(Value = "PINQ")]
    [IsoId("_ActionType15Code_PINRequest")]
    [Description(@"Request Cardholder Authentification through PIN insertion.")]
    PINRequest = ActionTypeCode.PINRequest,

    /// <summary>
    /// PIN (Personal Identification Number) is wrong, retry a PIN verification.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_ActionType15Code_PINRetry")]
    [Description(@"PIN (Personal Identification Number) is wrong, retry a PIN verification.")]
    PINRetry = ActionTypeCode.PINRetry,

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_ActionType15Code_PrintMessage")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage,

    /// <summary>
    /// Referral has to be performed.
    /// Encoded/decoded by serializers as &quot;RFRL&quot;.
    /// </summary>
    [EnumMember(Value = "RFRL")]
    [IsoId("_ActionType15Code_Referral")]
    [Description(@"Referral has to be performed.")]
    Referral = ActionTypeCode.Referral,

    /// <summary>
    /// Request additional data through a displayed text and request confirmation by an attendant.
    /// Encoded/decoded by serializers as &quot;RQDT&quot;.
    /// </summary>
    [EnumMember(Value = "RQDT")]
    [IsoId("_ActionType15Code_RequestData")]
    [Description(@"Request additional data through a displayed text and request confirmation by an attendant.")]
    RequestData = ActionTypeCode.RequestData,

    /// <summary>
    /// Additional identification required (passport, ID card, etc.).
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("_ActionType15Code_IdentificationRequired")]
    [Description(@"Additional identification required (passport, ID card, etc.).")]
    IdentificationRequired = ActionTypeCode.IdentificationRequired,

    /// <summary>
    /// Recurring transactions is no more allowed for this card and for all merchants.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_ActionType15Code_StopAllRecurring")]
    [Description(@"Recurring transactions is no more allowed for this card and for all merchants.")]
    StopAllRecurring = ActionTypeCode.StopAllRecurring,

    /// <summary>
    /// Cardholder has revocated this recurring transaction for this merchant.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_ActionType15Code_StopOneRecurring")]
    [Description(@"Cardholder has revocated this recurring transaction for this merchant.")]
    StopOneRecurring = ActionTypeCode.StopOneRecurring,

    /// <summary>
    /// Indicates that the authorization should be resubmitted at a later time.
    /// Encoded/decoded by serializers as &quot;TALT&quot;.
    /// </summary>
    [EnumMember(Value = "TALT")]
    [IsoId("_ActionType15Code_TryAgainLater")]
    [Description(@"Indicates that the authorization should be resubmitted at a later time.")]
    TryAgainLater = ActionTypeCode.TryAgainLater,

}
