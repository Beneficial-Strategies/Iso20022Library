// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to a financial initiation and financial response message.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_96BnAE9yEeePXdaAO32Uew")]
[Description(@"Identifies the type of process related to a financial initiation and financial response message.|ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction16Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. 
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_4blWEemrEemNVKPwszFC-A")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. ")]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_68aUEemrEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice about the capture of an activity already performed (response expected).
    /// Encoded/decoded by serializers as &quot;CAAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAAD")]
    [IsoId("_86kp4emrEemNVKPwszFC-A")]
    [Description(@"Advice about the capture of an activity already performed (response expected).")]
    CaptureAdvice = MessageFunctionCode.CaptureAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification about the capture of an activity already performed (no response expected).
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_9CAuoemrEemNVKPwszFC-A")]
    [Description(@"Notification about the capture of an activity already performed (no response expected).")]
    CaptureNotification = MessageFunctionCode.CaptureNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_90vMEemrEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
    
}
