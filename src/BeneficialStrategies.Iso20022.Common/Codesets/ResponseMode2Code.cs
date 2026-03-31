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
[IsoId("_eaMsoFDiEeuzhPLt3qllKA")]
[Description(@"Message response awaited by the initiator of the Request.")]
[DerivedFrom(typeof(ResponseModeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResponseMode2Code>))]
#endif
public enum ResponseMode2Code
{
    /// <summary>
    /// The Response is required at the end of play.
    /// Encoded/decoded by serializers as &quot;SEND&quot;.
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_25zPEVDiEeuzhPLt3qllKA")]
    [Description(@"The Response is required at the end of play.")]
    EndOfPlay = ResponseModeV2Code.EndOfPlay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Message Response is immediate, after taking into account the request.
    /// Encoded/decoded by serializers as &quot;IMMD&quot;.
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_3A8_8VDiEeuzhPLt3qllKA")]
    [Description(@"The Message Response is immediate, after taking into account the request.")]
    Immediate = ResponseModeV2Code.Immediate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Message Response is not required, except in case of error.
    /// Encoded/decoded by serializers as &quot;NREQ&quot;.
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_3W2XcVDiEeuzhPLt3qllKA")]
    [Description(@"The Message Response is not required, except in case of error.")]
    NotRequired = ResponseModeV2Code.NotRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Print Response is required at the end of print.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_3qhhYVDiEeuzhPLt3qllKA")]
    [Description(@"The Print Response is required at the end of print.")]
    PrintEnd = ResponseModeV2Code.PrintEnd, // same ordinal as derivation source for type conversions
}
