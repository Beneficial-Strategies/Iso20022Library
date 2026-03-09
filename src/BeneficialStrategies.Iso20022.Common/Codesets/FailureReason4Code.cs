// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Incident occurring during the processing of an ATM transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0dFU4IqTEeSRT5rEzcAHEw")]
[Description(@"Incident occurring during the processing of an ATM transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason4Code
{
    /// <summary>
    /// ATM manager has requested to capture the card.
    /// Encoded/decoded by serializers as &quot;CDCP&quot;.
    /// </summary>
    [EnumMember(Value = "CDCP")]
    [IsoId("_4-wwUYqTEeSRT5rEzcAHEw")]
    [Description(@"ATM manager has requested to capture the card.")]
    CardCaptured = FailureReasonCode.CardCaptured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_5IAL44qTEeSRT5rEzcAHEw")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined = FailureReasonCode.CardDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to complete transaction with the card.
    /// Encoded/decoded by serializers as &quot;CDER&quot;.
    /// </summary>
    [EnumMember(Value = "CDER")]
    [IsoId("_6KBCg4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to complete transaction with the card.")]
    CardError = FailureReasonCode.CardError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CUCL&quot;.
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_6QkWc4qTEeSRT5rEzcAHEw")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel = FailureReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer has declined additional fees or a lower amount, transaction fails.
    /// Encoded/decoded by serializers as &quot;CUDC&quot;.
    /// </summary>
    [EnumMember(Value = "CUDC")]
    [IsoId("_636DQ4qTEeSRT5rEzcAHEw")]
    [Description(@"Customer has declined additional fees or a lower amount, transaction fails.")]
    CustomerDecline = FailureReasonCode.CustomerDecline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer has left the card in the ATM or a motorised card reader.
    /// Encoded/decoded by serializers as &quot;CDFG&quot;.
    /// </summary>
    [EnumMember(Value = "CDFG")]
    [IsoId("_69kmY4qTEeSRT5rEzcAHEw")]
    [Description(@"Customer has left the card in the ATM or a motorised card reader.")]
    ForgottenCard = FailureReasonCode.ForgottenCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to fulfil, for instance dispensing the cash.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_7y66A4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to fulfil, for instance dispensing the cash.")]
    FullfilmentError = FailureReasonCode.FullfilmentError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_76Eq44qTEeSRT5rEzcAHEw")]
    [Description(@"Suspected malfunction.")]
    Malfunction = FailureReasonCode.Malfunction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_9fja84qTEeSRT5rEzcAHEw")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined = FailureReasonCode.OnLineDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_9ucyk4qTEeSRT5rEzcAHEw")]
    [Description(@"Security error has occurred in the authorisation response message sent by the acquirer.")]
    SecurityError = FailureReasonCode.SecurityError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as &quot;SFRD&quot;.
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_-wnaM4qTEeSRT5rEzcAHEw")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud = FailureReasonCode.SuspectedFraud, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_-23zM4qTEeSRT5rEzcAHEw")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut = FailureReasonCode.TimeOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_-8PbY4qTEeSRT5rEzcAHEw")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse = FailureReasonCode.TooLateResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to capture the card as requested.
    /// Encoded/decoded by serializers as &quot;UCPT&quot;.
    /// </summary>
    [EnumMember(Value = "UCPT")]
    [IsoId("__rK984qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to capture the card as requested.")]
    UnableToCapture = FailureReasonCode.UnableToCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("__wF6M4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete = FailureReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("__03Fc4qTEeSRT5rEzcAHEw")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend = FailureReasonCode.UnableToSend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ATM manager has requested to the ATM to stop customer services.
    /// Encoded/decoded by serializers as &quot;CSRV&quot;.
    /// </summary>
    [EnumMember(Value = "CSRV")]
    [IsoId("_6sItcY6LEeSYc-j6zfGsZg")]
    [Description(@"ATM manager has requested to the ATM to stop customer services.")]
    OutOfCustomerService = FailureReasonCode.OutOfCustomerService, // same ordinal as derivation source for type conversions
    
}
