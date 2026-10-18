// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a verification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VDS_4T1wEfCQAqQ9lolFUg")]
[Description(@"Result of a verification.")]
[DerivedFrom(typeof(VerificationCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<Verification4Code>))]
public enum Verification4Code
{
    /// <summary>
    /// Device or entity to perform the verification was unavailable.
    /// Encoded/decoded by serializers as &quot;ERRR&quot;.
    /// </summary>
    [EnumMember(Value = "ERRR")]
    [IsoId("_VFqXcz1wEfCQAqQ9lolFUg")]
    [Description(@"Device or entity to perform the verification was unavailable.")]
    TechnicalError = VerificationCode.TechnicalError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_VFqXYT1wEfCQAqQ9lolFUg")]
    [Description(@"Verification failed.")]
    Failed = VerificationCode.Failed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further action required.
    /// Encoded/decoded by serializers as &quot;FUTA&quot;.
    /// </summary>
    [EnumMember(Value = "FUTA")]
    [IsoId("_VFqXYz1wEfCQAqQ9lolFUg")]
    [Description(@"Further action required.")]
    FurtherAction = VerificationCode.FurtherAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information required to perform the verification was missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_VFqXZT1wEfCQAqQ9lolFUg")]
    [Description(@"Information required to perform the verification was missing.")]
    Missing = VerificationCode.Missing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not support the verification type
    /// Encoded/decoded by serializers as &quot;NOSP&quot;.
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_VFqXZz1wEfCQAqQ9lolFUg")]
    [Description(@"Not support the verification type")]
    NotSupported = VerificationCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification has not been performed.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_VFqXaT1wEfCQAqQ9lolFUg")]
    [Description(@"Verification has not been performed.")]
    NotPerformed = VerificationCode.NotPerformed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification was partially successful.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_VFqXbz1wEfCQAqQ9lolFUg")]
    [Description(@"Verification was partially successful.")]
    PartialMatch = VerificationCode.PartialMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification was successful.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_VFqXcT1wEfCQAqQ9lolFUg")]
    [Description(@"Verification was successful.")]
    Successful = VerificationCode.Successful, // same ordinal as derivation source for type conversions
}
