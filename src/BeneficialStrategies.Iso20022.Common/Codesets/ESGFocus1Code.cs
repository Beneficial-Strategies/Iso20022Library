// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if focus will be Environmental, Social or Governance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j5Q-8NA6EeuSBa1PsnseFg")]
[Description(@"Specifies if focus will be Environmental, Social or Governance.")]
[DerivedFrom(typeof(ESGFocusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ESGFocus1Code>))]
#endif
public enum ESGFocus1Code
{
    /// <summary>
    /// Main focus will be environmental.
    /// Encoded/decoded by serializers as &quot;ENVR&quot;.
    /// </summary>
    [EnumMember(Value = "ENVR")]
    [IsoId("_RHqrsdA7EeuSBa1PsnseFg")]
    [Description(@"Main focus will be environmental.")]
    Environmental = ESGFocusCode.Environmental, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Main focus will be governance.
    /// Encoded/decoded by serializers as &quot;GOVR&quot;.
    /// </summary>
    [EnumMember(Value = "GOVR")]
    [IsoId("_RN7EsdA7EeuSBa1PsnseFg")]
    [Description(@"Main focus will be governance.")]
    Governance = ESGFocusCode.Governance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Main focus will be social.
    /// Encoded/decoded by serializers as &quot;SOCL&quot;.
    /// </summary>
    [EnumMember(Value = "SOCL")]
    [IsoId("_RW2-QdA7EeuSBa1PsnseFg")]
    [Description(@"Main focus will be social.")]
    Social = ESGFocusCode.Social, // same ordinal as derivation source for type conversions
}
