// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies applicable rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8kBGkFNeEeijdq8ilaxyOA")]
[Description(@"Specifies applicable rules.")]
[Derivations(typeof(ApplicableRules1Code))]
public enum ApplicableRulesCode
{
    /// <summary>
    /// Pre A Day rules applies.
    /// Encoded/decoded by serializers as &quot;YPRE&quot;.
    /// </summary>
    [EnumMember(Value = "YPRE")]
    [IsoId("_ALp7oFNfEeijdq8ilaxyOA")]
    [Description(@"Pre A Day rules applies.")]
    PreADay,

    /// <summary>
    /// Pre A Day rules do not apply.
    /// Encoded/decoded by serializers as &quot;NPRE&quot;.
    /// </summary>
    [EnumMember(Value = "NPRE")]
    [IsoId("_EeJrkFNfEeijdq8ilaxyOA")]
    [Description(@"Pre A Day rules do not apply.")]
    NotPreADay,
}
