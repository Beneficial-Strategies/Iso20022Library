// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the result of the service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_koClUJ1JEeublrfU-wN95w")]
[Description(@"Identifies the result of the service.")]
[Derivations(typeof(AdditionalServiceResult1Code))]
public enum AdditionalServiceResultCode
{
    /// <summary>
    /// The service was performed.
    /// Encoded/decoded by serializers as &quot;PERF&quot;.
    /// </summary>
    [EnumMember(Value = "PERF")]
    [IsoId("_2ed0UJ1JEeublrfU-wN95w")]
    [Description(@"The service was performed.")]
    Performed,

    /// <summary>
    /// The service was not performed.
    /// Encoded/decoded by serializers as &quot;NOPF&quot;.
    /// </summary>
    [EnumMember(Value = "NOPF")]
    [IsoId("_6ZF20J1JEeublrfU-wN95w")]
    [Description(@"The service was not performed.")]
    NotPerformed,

    /// <summary>
    /// The service is not supported and could not be performed.
    /// Encoded/decoded by serializers as &quot;NOSP&quot;.
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_-u4LUJ1JEeublrfU-wN95w")]
    [Description(@"The service is not supported and could not be performed.")]
    NotSupported,

    /// <summary>
    /// Other nationally defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Ea8WQJ1KEeublrfU-wN95w")]
    [Description(@"Other nationally defined code.")]
    OtherNational,

    /// <summary>
    /// Other privately defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_HxzkYJ1KEeublrfU-wN95w")]
    [Description(@"Other privately defined code.")]
    OtherPrivate,
}
