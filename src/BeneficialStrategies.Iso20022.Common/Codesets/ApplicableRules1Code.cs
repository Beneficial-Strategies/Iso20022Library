// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies applicable rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MZLBYFNfEeijdq8ilaxyOA")]
[Description(@"Specifies applicable rules.")]
[DerivedFrom(typeof(ApplicableRulesCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ApplicableRules1Code>))]
#endif
public enum ApplicableRules1Code
{
    /// <summary>
    /// Pre A Day rules do not apply.
    /// Encoded/decoded by serializers as &quot;NPRE&quot;.
    /// </summary>
    [EnumMember(Value = "NPRE")]
    [IsoId("_NhLLQVNfEeijdq8ilaxyOA")]
    [Description(@"Pre A Day rules do not apply.")]
    NotPreADay = ApplicableRulesCode.NotPreADay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre A Day rules applies.
    /// Encoded/decoded by serializers as &quot;YPRE&quot;.
    /// </summary>
    [EnumMember(Value = "YPRE")]
    [IsoId("_NlylgVNfEeijdq8ilaxyOA")]
    [Description(@"Pre A Day rules applies.")]
    PreADay = ApplicableRulesCode.PreADay, // same ordinal as derivation source for type conversions
}
