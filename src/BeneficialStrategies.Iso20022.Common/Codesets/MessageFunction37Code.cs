// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies messages related to a retrieval request process.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VzKWseE8EeeV6-yubHrZaQ")]
[Description(@"Identifies messages related to a retrieval request process.|ISO 8583 MTI")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction37Code>))]
#endif
public enum MessageFunction37Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_lp1m8emuEemNVKPwszFC-A")]
    [Description(
        @"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. "
    )]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_m5bmkemuEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_nhTe4emuEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STNO&quot;.
    /// </summary>
    [EnumMember(Value = "STNO")]
    [IsoId("_osSrUemuEemNVKPwszFC-A")]
    [Description(@"Notification about the status of a transaction.")]
    StatusNotification = MessageFunctionCode.StatusNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message function is a status request.
    /// Encoded/decoded by serializers as &quot;STRQ&quot;.
    /// </summary>
    [EnumMember(Value = "STRQ")]
    [IsoId("_pBkXwemuEemNVKPwszFC-A")]
    [Description(@"Message function is a status request.")]
    StatusRequest = MessageFunctionCode.StatusRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice about the status of a transaction.
    /// Encoded/decoded by serializers as &quot;STAD&quot;.
    /// </summary>
    [EnumMember(Value = "STAD")]
    [IsoId("_reXxYemuEemNVKPwszFC-A")]
    [Description(@"Advice about the status of a transaction.")]
    StatusAdvice = MessageFunctionCode.StatusAdvice, // same ordinal as derivation source for type conversions
}
