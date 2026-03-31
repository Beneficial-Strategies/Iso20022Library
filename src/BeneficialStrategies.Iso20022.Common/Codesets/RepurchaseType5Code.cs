// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_P6sH4duJEd-RF5yaMAVhAw")]
[Description(@"Specifies the type of repurchase process.")]
[DerivedFrom(typeof(RepurchaseTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepurchaseType5Code>))]
#endif
public enum RepurchaseType5Code
{
    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_q5t_IWtdEeCY4-KZ9JEyUQ_-410922395")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall = RepurchaseTypeCode.RepurchaseCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_q5t_ImtdEeCY4-KZ9JEyUQ_114905717")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeCode.RepoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_q5t_I2tdEeCY4-KZ9JEyUQ_-882166636")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Rollover = RepurchaseTypeCode.Rollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_q5t_JGtdEeCY4-KZ9JEyUQ_568992986")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment = RepurchaseTypeCode.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions
}
