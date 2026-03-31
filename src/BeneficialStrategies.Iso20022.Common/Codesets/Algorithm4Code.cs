// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wCmXsAiqEeKn9O5oyej_zw")]
[Description(@"Cryptographic algorithms for digital signatures.")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm4Code>))]
#endif
public enum Algorithm4Code
{
    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS2&quot;.
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_3MPT4QiqEeKn9O5oyej_zw")]
    [Description(
        @"Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption)."
    )]
    SHA256WithRSA = AlgorithmCode.SHA256WithRSA, // same ordinal as derivation source for type conversions
}
