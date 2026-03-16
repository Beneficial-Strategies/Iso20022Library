// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Message response awaited by the initiator of the Request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UvDdAFDiEeuzhPLt3qllKA")]
[Description(@"Message response awaited by the initiator of the Request.")]
[Derivations(typeof(ResponseMode2Code))]
public enum ResponseModeV2Code
{
    /// <summary>
    /// The Response is required at the end of play.
    /// Encoded/decoded by serializers as &quot;SEND&quot;.
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_wLmRtFDiEeuzhPLt3qllKA")]
    [Description(@"The Response is required at the end of play.")]
    EndOfPlay,

    /// <summary>
    /// The Message Response is immediate, after taking into account the request.
    /// Encoded/decoded by serializers as &quot;IMMD&quot;.
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_wLmRtVDiEeuzhPLt3qllKA")]
    [Description(@"The Message Response is immediate, after taking into account the request.")]
    Immediate,

    /// <summary>
    /// The Message Response is not required, except in case of error.
    /// Encoded/decoded by serializers as &quot;NREQ&quot;.
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_wLmRtlDiEeuzhPLt3qllKA")]
    [Description(@"The Message Response is not required, except in case of error.")]
    NotRequired,

    /// <summary>
    /// The Print Response is required at the end of print.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_wLmRt1DiEeuzhPLt3qllKA")]
    [Description(@"The Print Response is required at the end of print.")]
    PrintEnd,
}
