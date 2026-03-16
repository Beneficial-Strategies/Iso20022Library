// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to protect the sensitive data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QaPzMJyBEeuo7tDc4CDHXg")]
[Description(@"Method used to protect the sensitive data.")]
[DerivedFrom(typeof(ProtectionMethodCode))]
public enum ProtectionMethod1Code
{
    /// <summary>
    /// Other code assigned by national organisation.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_UuoZgZyBEeuo7tDc4CDHXg")]
    [Description(@"Other code assigned by national organisation.")]
    OtherNational = ProtectionMethodCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_U3W3sZyBEeuo7tDc4CDHXg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate = ProtectionMethodCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure element method.
    /// Encoded/decoded by serializers as &quot;SELM&quot;.
    /// </summary>
    [EnumMember(Value = "SELM")]
    [IsoId("_VdBJgZyBEeuo7tDc4CDHXg")]
    [Description(@"Secure element method.")]
    SecureElement = ProtectionMethodCode.SecureElement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure enclave method.
    /// Encoded/decoded by serializers as &quot;SNCL&quot;.
    /// </summary>
    [EnumMember(Value = "SNCL")]
    [IsoId("_VdwJUZyBEeuo7tDc4CDHXg")]
    [Description(@"Secure enclave method.")]
    SecureEnclave = ProtectionMethodCode.SecureEnclave, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software protection method.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_VegXQZyBEeuo7tDc4CDHXg")]
    [Description(@"Software protection method.")]
    Software = ProtectionMethodCode.Software, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trusted execution environment method.
    /// Encoded/decoded by serializers as &quot;TEEN&quot;.
    /// </summary>
    [EnumMember(Value = "TEEN")]
    [IsoId("_VfMTwZyBEeuo7tDc4CDHXg")]
    [Description(@"Trusted execution environment method.")]
    TrustedExectutionEnvironment = ProtectionMethodCode.TrustedExectutionEnvironment, // same ordinal as derivation source for type conversions
}
