// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Message response awaited by the initiator of the Request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8F7HcN6qEeiwsev40qZGEQ")]
[Description(@"Message response awaited by the initiator of the Request.")]
[Derivations(typeof(ResponseMode1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResponseModeCode>))]
#endif
public enum ResponseModeCode
{
    /// <summary>
    /// The Message Response is not required, except in case of error.
    /// Encoded/decoded by serializers as &quot;NREQ&quot;.
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_BRnwQN6rEeiwsev40qZGEQ")]
    [Description(@"The Message Response is not required, except in case of error.")]
    NotRequired,

    /// <summary>
    /// The Message Response is immediate, after taking into account the request.
    /// Encoded/decoded by serializers as &quot;IMMD&quot;.
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_DhWXMN6rEeiwsev40qZGEQ")]
    [Description(@"The Message Response is immediate, after taking into account the request.")]
    Immediate,

    /// <summary>
    /// The Print Response is required at the end of print.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_I-7aMN6rEeiwsev40qZGEQ")]
    [Description(@"The Print Response is required at the end of print.")]
    PrintEnd,

    /// <summary>
    /// The Sound Response is required at the end of play.
    /// Encoded/decoded by serializers as &quot;SEND&quot;.
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_LY_o4N6rEeiwsev40qZGEQ")]
    [Description(@"The Sound Response is required at the end of play.")]
    SoundEnd,
}
