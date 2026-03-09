// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Asymmetric encryption algorithm of a transport key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FLfa8AmFEeKKaIHo7gv4XA")]
[Description(@"Asymmetric encryption algorithm of a transport key.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm7Code
{
    /// <summary>
    /// RSA encryption algorithm - (ASN.1 Object Identifier: rsaEncryption).
    /// Encoded/decoded by serializers as &quot;ERSA&quot;.
    /// </summary>
    [EnumMember(Value = "ERSA")]
    [IsoId("_NyQccQmFEeKKaIHo7gv4XA")]
    [Description(@"RSA encryption algorithm - (ASN.1 Object Identifier: rsaEncryption).")]
    RSAEncryption = AlgorithmCode.RSAEncryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RSA encryption scheme based on Optimal Asymmetric Encryption scheme (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-RSAES-OAEP).
    /// Encoded/decoded by serializers as &quot;RSAO&quot;.
    /// </summary>
    [EnumMember(Value = "RSAO")]
    [IsoId("_OC6uoQmFEeKKaIHo7gv4XA")]
    [Description(@"RSA encryption scheme based on Optimal Asymmetric Encryption scheme (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-RSAES-OAEP).")]
    RSAES_OAEP = AlgorithmCode.RSAES_OAEP, // same ordinal as derivation source for type conversions
    
}
