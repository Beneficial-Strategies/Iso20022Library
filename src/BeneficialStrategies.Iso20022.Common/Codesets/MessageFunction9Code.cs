// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the message function within a card payment exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4q5AcY0NEeWRYffwL7E13A")]
[Description(@"Identifies the message function within a card payment exchange.")]
[DerivedFrom(typeof(MessageFunctionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MessageFunction9Code>))]
#endif
public enum MessageFunction9Code
{
    /// <summary>
    /// Reject of a request or an advice message by an acquirer or an agent.
    /// Encoded/decoded by serializers as &quot;RJCQ&quot;.
    /// </summary>
    [EnumMember(Value = "RJCQ")]
    [IsoId("_XdFiUY0OEeWRYffwL7E13A")]
    [Description(@"Reject of a request or an advice message by an acquirer or an agent.")]
    AcceptorRequestReject = MessageFunctionCode.AcceptorRequestReject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reject of a response or an advice response message by a card acceptor or an agent.
    /// Encoded/decoded by serializers as &quot;RJCP&quot;.
    /// </summary>
    [EnumMember(Value = "RJCP")]
    [IsoId("_XmBb4Y0OEeWRYffwL7E13A")]
    [Description(
        @"Reject of a response or an advice response message by a card acceptor or an agent."
    )]
    AcceptorResponseReject = MessageFunctionCode.AcceptorResponseReject, // same ordinal as derivation source for type conversions
}
