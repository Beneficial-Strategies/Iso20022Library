// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Subc8GjpEeSDR-pyia6Xtg")]
[Description(@"Result of a verification.")]
[Derivations(typeof(Verification1Code), typeof(Verification2Code), typeof(Verification3Code))]
public enum VerificationCode
{
    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as &quot;ERRR&quot;.
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_XGJrIGjpEeSDR-pyia6Xtg")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError,

    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_b05SMGjpEeSDR-pyia6Xtg")]
    [Description(@"Verification was successful.")]
    Successful,

    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_fI-5IGjpEeSDR-pyia6Xtg")]
    [Description(@"Verification was partially successful.")]
    PartialMatch,

    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_jJWXQGjpEeSDR-pyia6Xtg")]
    [Description(@"Verification has not been performed.")]
    NotPerformed,

    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_l-YDoGjpEeSDR-pyia6Xtg")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing,

    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_pexBMGjpEeSDR-pyia6Xtg")]
    [Description(@"Verification failed.")]
    Failed,

    /// <summary>
    /// Further action required.
    /// Encoded/decoded by serializers as &quot;FUTA&quot;.
    /// </summary>
    [EnumMember(Value = "FUTA")]
    [IsoId("_B25Bk3yNEemHsOqJOzMVfg")]
    [Description(@"Further action required.")]
    FurtherAction,

    /// <summary>
    /// Other result of verification defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_B25BlHyNEemHsOqJOzMVfg")]
    [Description(@"Other result of verification defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other result of verification defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_B25BlXyNEemHsOqJOzMVfg")]
    [Description(@"Other result of verification defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Not support the verification type
    /// Encoded/decoded by serializers as &quot;NOSP&quot;.
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_WfcoECYDEeym0KcvJF9aDQ")]
    [Description(@"Not support the verification type")]
    NotSupported,
}
