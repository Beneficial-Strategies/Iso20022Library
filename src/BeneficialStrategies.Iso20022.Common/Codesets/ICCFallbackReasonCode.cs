// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code that provides the reason of ICC fallback.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Hq2KwDHJEeyTT91yHXSlSQ")]
[Description(@"A code that provides the reason of ICC fallback.")]
[Derivations(typeof(ICCFallbackReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ICCFallbackReasonCode>))]
#endif
public enum ICCFallbackReasonCode
{
    /// <summary>
    /// Choosing incorrect IC application.
    /// Encoded/decoded by serializers as &quot;CIIA&quot;.
    /// </summary>
    [EnumMember(Value = "CIIA")]
    [IsoId("_UmgI4DHJEeyTT91yHXSlSQ")]
    [Description(@"Choosing incorrect IC application.")]
    ChoosingIncorrectICApplication,

    /// <summary>
    /// Error during IC app processing.
    /// Encoded/decoded by serializers as &quot;EDIP&quot;.
    /// </summary>
    [EnumMember(Value = "EDIP")]
    [IsoId("_c46rADHJEeyTT91yHXSlSQ")]
    [Description(@"Error during IC app processing.|")]
    ErrorDuringICAppProcessing,

    /// <summary>
    /// Terminal error reading IC data.
    /// Encoded/decoded by serializers as &quot;TERI&quot;.
    /// </summary>
    [EnumMember(Value = "TERI")]
    [IsoId("_tJRUEDHJEeyTT91yHXSlSQ")]
    [Description(@"Terminal error reading IC data.|")]
    TerminalErrorReadingICData,

    /// <summary>
    /// Other ICC fallback reason defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_0dWlsDHJEeyTT91yHXSlSQ")]
    [Description(@"Other ICC fallback reason defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other ICC fallback reason defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_67REUDHJEeyTT91yHXSlSQ")]
    [Description(@"Other ICC fallback reason defined at private level.")]
    OtherPrivate,
}
