// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the option rights.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__vYmkdojEeC60axPepSq7g_-720567481")]
[Description(@"Specifies the option rights.")]
[Derivations(typeof(OptionRight1Code))]
public enum OptionRightCode
{
    /// <summary>
    /// Exercise option right.
    /// Encoded/decoded by serializers as &quot;EXER&quot;.
    /// </summary>
    [EnumMember(Value = "EXER")]
    [IsoId("__vYmktojEeC60axPepSq7g_1129606095")]
    [Description(@"Exercise option right.")]
    Exercise,

    /// <summary>
    /// Option right assignment.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("__vYmk9ojEeC60axPepSq7g_1685806667")]
    [Description(@"Option right assignment.")]
    Assignment,

    /// <summary>
    /// The option right is renounced.
    /// Encoded/decoded by serializers as &quot;RENO&quot;.
    /// </summary>
    [EnumMember(Value = "RENO")]
    [IsoId("__vYmlNojEeC60axPepSq7g_-1347774066")]
    [Description(@"The option right is renounced.")]
    Renouncement,

    /// <summary>
    /// Option right expires.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("__vYmldojEeC60axPepSq7g_764314845")]
    [Description(@"Option right expires.")]
    Expiration,
}
