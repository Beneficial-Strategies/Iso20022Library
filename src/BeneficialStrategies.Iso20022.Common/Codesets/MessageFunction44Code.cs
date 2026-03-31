// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of process related to a specific message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eYxeEEGJEeyZG7AU5fJYtQ")]
[Description(@"Type of process related to a specific message.")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction44Code>))]
#endif
public enum MessageFunction44Code
{
    /// <summary>
    /// Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response.
    /// Encoded/decoded by serializers as &quot;ADVC&quot;.
    /// </summary>
    [EnumMember(Value = "ADVC")]
    [IsoId("_idxkkUGJEeyZG7AU5fJYtQ")]
    [Description(
        @"Advice indicates where the sender informs the receiver of an activity that has been taken that requires a response. "
    )]
    Advice = MessageFunctionCode.Advice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information about the transaction.
    /// Encoded/decoded by serializers as &quot;NOTI&quot;.
    /// </summary>
    [EnumMember(Value = "NOTI")]
    [IsoId("_j4yKAUGJEeyZG7AU5fJYtQ")]
    [Description(@"Information about the transaction.")]
    Notification = MessageFunctionCode.Notification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Informs of an action to be taken.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_kUU2gUGJEeyZG7AU5fJYtQ")]
    [Description(@"Informs of an action to be taken.")]
    Instructure = MessageFunctionCode.Instructure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_lxafkUGJEeyZG7AU5fJYtQ")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
}
