// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for the MAC (Message Authentication Code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MxVe8AipEeKn9O5oyej_zw")]
[Description(@"Cryptographic algorithms for the MAC (Message Authentication Code).")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm3Code
{
    /// <summary>
    /// Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).
    /// Encoded/decoded by serializers as &quot;MACC&quot;.
    /// </summary>
    [EnumMember(Value = "MACC")]
    [IsoId("_hzcm0QipEeKn9O5oyej_zw")]
    [Description(@"Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).")]
    RetailCBCMAC = AlgorithmCode.RetailCBCMAC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).
    /// Encoded/decoded by serializers as &quot;MCCS&quot;.
    /// </summary>
    [EnumMember(Value = "MCCS")]
    [IsoId("_iOhZQwipEeKn9O5oyej_zw")]
    [Description(@"Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).")]
    RetailSHA256MAC = AlgorithmCode.RetailSHA256MAC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA1&quot;.
    /// </summary>
    [EnumMember(Value = "CMA1")]
    [IsoId("_inEcIQipEeKn9O5oyej_zw")]
    [Description(@"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.")]
    SHA256CMACwithAES128 = AlgorithmCode.SHA256CMACwithAES128, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Triple DES with a double length key (112 Bit) as defined in FIPS PUB 46-3. The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMD1&quot;.
    /// </summary>
    [EnumMember(Value = "CMD1")]
    [IsoId("_izknEQipEeKn9O5oyej_zw")]
    [Description(@"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Triple DES with a double length key (112 Bit) as defined in FIPS PUB 46-3. The CMAC algorithm is computed on the SHA-256 digest of the message.")]
    SHA256CMACwithDES112 = AlgorithmCode.SHA256CMACwithDES112, // same ordinal as derivation source for type conversions
    
}
