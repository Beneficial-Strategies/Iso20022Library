// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of incidents happening at the acceptor during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QgO6ATG8EeOH78pE3LSlGw")]
[Description(@"List of incidents happening at the acceptor during the transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason3Code
{
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_QwmRQTG8EeOH78pE3LSlGw")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined = FailureReasonCode.CardDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CUCL&quot;.
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_QwmRQzG8EeOH78pE3LSlGw")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel = FailureReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_QwmRRTG8EeOH78pE3LSlGw")]
    [Description(@"Suspected malfunction.")]
    Malfunction = FailureReasonCode.Malfunction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_QwmRRzG8EeOH78pE3LSlGw")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined = FailureReasonCode.OfflineDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_QwmRSTG8EeOH78pE3LSlGw")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined = FailureReasonCode.OnLineDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Completed partially.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_QwmRSzG8EeOH78pE3LSlGw")]
    [Description(@"Completed partially.")]
    Partial = FailureReasonCode.Partial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as &quot;SFRD&quot;.
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_QwmRTTG8EeOH78pE3LSlGw")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud = FailureReasonCode.SuspectedFraud, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_QwmRTzG8EeOH78pE3LSlGw")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut = FailureReasonCode.TimeOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_QwmRUTG8EeOH78pE3LSlGw")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse = FailureReasonCode.TooLateResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_QwmRUzG8EeOH78pE3LSlGw")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete = FailureReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_QwmRVTG8EeOH78pE3LSlGw")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend = FailureReasonCode.UnableToSend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_SbRDUTG8EeOH78pE3LSlGw")]
    [Description(@"Security error has occurred in the authorisation response message sent by the acquirer.")]
    SecurityError = FailureReasonCode.SecurityError, // same ordinal as derivation source for type conversions
    
}
