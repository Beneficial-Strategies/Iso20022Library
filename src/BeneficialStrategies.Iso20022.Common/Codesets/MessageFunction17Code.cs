// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to the reconciliation of financial totals.
/// ISO 8583 MTI
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nDae0E92EeePXdaAO32Uew")]
[Description(
    @"Identifies the type of process related to the reconciliation of financial totals.|ISO 8583 MTI "
)]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction17Code>))]
#endif
public enum MessageFunction17Code
{
    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_6Wa1oemsEemNVKPwszFC-A")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_7dPTwemsEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_8JbrYemsEemNVKPwszFC-A")]
    [Description(
        @"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. "
    )]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions
}
