// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to protect the sensitive data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XgPDIRRBEfC_aaedwHHlmw")]
[Description(@"Method used to protect the sensitive data.")]
[DerivedFrom(typeof(ProtectionMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ProtectionMethod2Code>))]
public enum ProtectionMethod2Code
{
    /// <summary>
    /// Secure element method.
    /// Encoded/decoded by serializers as &quot;SELM&quot;.
    /// </summary>
    [EnumMember(Value = "SELM")]
    [IsoId("_XnW-1RRBEfC_aaedwHHlmw")]
    [Description(@"Secure element method.")]
    SecureElement = ProtectionMethodCode.SecureElement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure enclave method.
    /// Encoded/decoded by serializers as &quot;SNCL&quot;.
    /// </summary>
    [EnumMember(Value = "SNCL")]
    [IsoId("_XnW-1xRBEfC_aaedwHHlmw")]
    [Description(@"Secure enclave method.")]
    SecureEnclave = ProtectionMethodCode.SecureEnclave, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Software protection method.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_XnW-2RRBEfC_aaedwHHlmw")]
    [Description(@"Software protection method.")]
    Software = ProtectionMethodCode.Software, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trusted execution environment method.
    /// Encoded/decoded by serializers as &quot;TEEN&quot;.
    /// </summary>
    [EnumMember(Value = "TEEN")]
    [IsoId("_XnW-2xRBEfC_aaedwHHlmw")]
    [Description(@"Trusted execution environment method.")]
    TrustedExectutionEnvironment = ProtectionMethodCode.TrustedExectutionEnvironment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trusted Platform Module (TPM).
    /// Encoded/decoded by serializers as &quot;TPMD&quot;.
    /// </summary>
    [EnumMember(Value = "TPMD")]
    [IsoId("_Z0Xo8RRBEfC_aaedwHHlmw")]
    [Description(@"Trusted Platform Module (TPM).")]
    TrustedPlatformModule = ProtectionMethodCode.TrustedPlatformModule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Virtual trusted execution environment.
    /// Encoded/decoded by serializers as &quot;VTEE&quot;.
    /// </summary>
    [EnumMember(Value = "VTEE")]
    [IsoId("_aBv9oRRBEfC_aaedwHHlmw")]
    [Description(@"Virtual trusted execution environment.")]
    VirtualTrustedExecutionEnvironment = ProtectionMethodCode.VirtualTrustedExecutionEnvironment, // same ordinal as derivation source for type conversions
}
