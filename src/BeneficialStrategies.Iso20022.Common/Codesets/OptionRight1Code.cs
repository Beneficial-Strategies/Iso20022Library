// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the option rights.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__vPcotojEeC60axPepSq7g_-921943396")]
[Description(@"Specifies the option rights.")]
[DerivedFrom(typeof(OptionRightCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionRight1Code>))]
#endif
public enum OptionRight1Code
{
    /// <summary>
    /// Exercise option right.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("__vPco9ojEeC60axPepSq7g_-581695193")]
    [Description(@"Exercise option right.")]
    Exercise = OptionRightCode.Exercise, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option right assignment.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("__vPcpNojEeC60axPepSq7g_-1981917652")]
    [Description(@"Option right assignment.")]
    Assignment = OptionRightCode.Assignment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The option right is renounced.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("__vPcpdojEeC60axPepSq7g_-1993016429")]
    [Description(@"The option right is renounced.")]
    Renouncement = OptionRightCode.Renouncement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option right expires.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("__vYmkNojEeC60axPepSq7g_-525867666")]
    [Description(@"Option right expires.")]
    Expiration = OptionRightCode.Expiration, // same ordinal as derivation source for type conversions
}
