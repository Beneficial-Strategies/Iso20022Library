// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if focus will be Environmental, Social or Governance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tYWj0M2uEeuAE-cYsQdwHQ")]
[Description(@"Specifies if focus will be Environmental, Social or Governance.")]
[Derivations(typeof(ESGFocus1Code))]
public enum ESGFocusCode
{
    /// <summary>
    /// Main focus will be environmental.
    /// Encoded/decoded by serializers as &quot;ENVR&quot;.
    /// </summary>
    [EnumMember(Value = "ENVR")]
    [IsoId("_3oVl4M2uEeuAE-cYsQdwHQ")]
    [Description(@"Main focus will be environmental.")]
    Environmental,

    /// <summary>
    /// Main focus will be social.
    /// Encoded/decoded by serializers as &quot;SOCL&quot;.
    /// </summary>
    [EnumMember(Value = "SOCL")]
    [IsoId("_7WLJkM2uEeuAE-cYsQdwHQ")]
    [Description(@"Main focus will be social.")]
    Social,

    /// <summary>
    /// Main focus will be governance.
    /// Encoded/decoded by serializers as &quot;GOVR&quot;.
    /// </summary>
    [EnumMember(Value = "GOVR")]
    [IsoId("_-n9DYM2uEeuAE-cYsQdwHQ")]
    [Description(@"Main focus will be governance.")]
    Governance,
}
