// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uTRSAGjpEeSDR-pyia6Xtg")]
[Description(@"Result of the verification.")]
[DerivedFrom(typeof(VerificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Verification1Code>))]
#endif
public enum Verification1Code
{
    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_xPkEAWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification failed.")]
    Failed = VerificationCode.Failed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_xVtvUWjpEeSDR-pyia6Xtg")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing = VerificationCode.Missing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_xdGwwWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification has not been performed.")]
    NotPerformed = VerificationCode.NotPerformed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_xib8sWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification was partially successful.")]
    PartialMatch = VerificationCode.PartialMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_xpMsAWjpEeSDR-pyia6Xtg")]
    [Description(@"Verification was successful.")]
    Successful = VerificationCode.Successful, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as &quot;ERRR&quot;.
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_xwe_wWjpEeSDR-pyia6Xtg")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError = VerificationCode.TechnicalError, // same ordinal as derivation source for type conversions
}
