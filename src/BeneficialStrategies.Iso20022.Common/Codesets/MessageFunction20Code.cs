// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of chargeback process related to the message.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-KhpoFBNEeedyPuM0kK2EQ")]
[Description(@"Identifies the type of chargeback process related to the message.|ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction20Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. 
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_xtHBAemtEemNVKPwszFC-A")]
    [Description(@"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. ")]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_zKVM8OmtEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_zzsTAemtEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice for reversal without financial capture.
    /// Encoded/decoded by serializers as &quot;RVRA&quot;.
    /// </summary>
    [EnumMember(Value = "RVRA")]
    [IsoId("_1H5F0emtEemNVKPwszFC-A")]
    [Description(@"Advice for reversal without financial capture.")]
    ReversalAdvice = MessageFunctionCode.ReversalAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification of reversal for either an authorisation or a financial message (response not expected).
    /// Encoded/decoded by serializers as &quot;RVNO&quot;.
    /// </summary>
    [EnumMember(Value = "RVNO")]
    [IsoId("_1rYNYemtEemNVKPwszFC-A")]
    [Description(@"Notification of reversal for either an authorisation or a financial message (response not expected).")]
    ReversalNotification = MessageFunctionCode.ReversalNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STAD&quot;.
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_3BoOoemtEemNVKPwszFC-A")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice = MessageFunctionCode.StatusAdvice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STNO&quot;.
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_3I7JcemtEemNVKPwszFC-A")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification = MessageFunctionCode.StatusNotification, // same ordinal as derivation source for type conversions
    
}
