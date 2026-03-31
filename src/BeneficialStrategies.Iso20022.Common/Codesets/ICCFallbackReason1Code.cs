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
[IsoId("_CIijUDHKEeyTT91yHXSlSQ")]
[Description(@"A code that provides the reason of ICC fallback.")]
[DerivedFrom(typeof(ICCFallbackReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ICCFallbackReason1Code>))]
#endif
public enum ICCFallbackReason1Code
{
    /// <summary>
    /// Choosing incorrect IC application.
    /// Encoded/decoded by serializers as &quot;CIIA&quot;.
    /// </summary>
    [EnumMember(Value = "CIIA")]
    [IsoId("_P4yAATxSEeyuG4d2lhAp-w")]
    [Description(@"Choosing incorrect IC application.")]
    ChoosingIncorrectICApplication = ICCFallbackReasonCode.ChoosingIncorrectICApplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error during IC app processing.
    /// Encoded/decoded by serializers as &quot;EDIP&quot;.
    /// </summary>
    [EnumMember(Value = "EDIP")]
    [IsoId("_P96-sTxSEeyuG4d2lhAp-w")]
    [Description(@"Error during IC app processing.|")]
    ErrorDuringICAppProcessing = ICCFallbackReasonCode.ErrorDuringICAppProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other ICC fallback reason defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_QCJXYTxSEeyuG4d2lhAp-w")]
    [Description(@"Other ICC fallback reason defined at national level.")]
    OtherNational = ICCFallbackReasonCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other ICC fallback reason defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_QJDQoTxSEeyuG4d2lhAp-w")]
    [Description(@"Other ICC fallback reason defined at private level.")]
    OtherPrivate = ICCFallbackReasonCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal error reading IC data.
    /// Encoded/decoded by serializers as &quot;TERI&quot;.
    /// </summary>
    [EnumMember(Value = "TERI")]
    [IsoId("_QPGOQTxSEeyuG4d2lhAp-w")]
    [Description(@"Terminal error reading IC data.|")]
    TerminalErrorReadingICData = ICCFallbackReasonCode.TerminalErrorReadingICData, // same ordinal as derivation source for type conversions
}
