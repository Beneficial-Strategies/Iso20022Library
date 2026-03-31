// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Mask generator functions of the RSAES-OAEP encryption algorithm (RSA Encryption Scheme: Optimal Asymmetric Encryption Padding).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TdaocAmFEeKKaIHo7gv4XA")]
[Description(
    @"Mask generator functions of the RSAES-OAEP encryption algorithm (RSA Encryption Scheme: Optimal Asymmetric Encryption Padding)."
)]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm8Code>))]
#endif
public enum Algorithm8Code
{
    /// <summary>
    /// Generator Function, used for RSA encryption and RSA igital signature (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-mgf1).
    /// Encoded/decoded by serializers as &quot;MGF1&quot;.
    /// </summary>
    [EnumMember(Value = "MGF1")]
    [IsoId("_Z4B7cQmFEeKKaIHo7gv4XA")]
    [Description(
        @"Generator Function, used for RSA encryption and RSA igital signature (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-mgf1)."
    )]
    MGF1 = AlgorithmCode.MGF1, // same ordinal as derivation source for type conversions
}
