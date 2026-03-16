// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the MAC algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVpK_AEcEeCQm6a_G2yO_w_454879121")]
[Description(@"Identification of the MAC algorithm.")]
[Derivations(
    typeof(Algorithm8Code),
    typeof(Algorithm7Code),
    typeof(Algorithm25Code),
    typeof(Algorithm11Code),
    typeof(Algorithm3Code),
    typeof(Algorithm9Code),
    typeof(Algorithm5Code),
    typeof(Algorithm18Code),
    typeof(Algorithm17Code),
    typeof(Algorithm2Code),
    typeof(Algorithm15Code),
    typeof(Algorithm13Code),
    typeof(Algorithm24Code),
    typeof(Algorithm20Code),
    typeof(Algorithm4Code),
    typeof(Algorithm23Code),
    typeof(Algorithm1Code),
    typeof(Algorithm19Code),
    typeof(Algorithm6Code),
    typeof(Algorithm12Code),
    typeof(Algorithm10Code),
    typeof(Algorithm14Code),
    typeof(Algorithm16Code)
)]
public enum AlgorithmCode
{
    /// <summary>
    /// Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).
    /// Encoded/decoded by serializers as &quot;MACC&quot;.
    /// </summary>
    [EnumMember(Value = "MACC")]
    [IsoId("_TVpK_QEcEeCQm6a_G2yO_w_-27681287")]
    [Description(
        @"Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac)."
    )]
    RetailCBCMAC,

    /// <summary>
    /// Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).
    /// Encoded/decoded by serializers as &quot;MCCS&quot;.
    /// </summary>
    [EnumMember(Value = "MCCS")]
    [IsoId("_TVpK_gEcEeCQm6a_G2yO_w_-1521917968")]
    [Description(
        @"Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256)."
    )]
    RetailSHA256MAC,

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap).
    /// Encoded/decoded by serializers as &quot;UKPT&quot;.
    /// </summary>
    [EnumMember(Value = "UKPT")]
    [IsoId("_TVpK_wEcEeCQm6a_G2yO_w_153148173")]
    [Description(
        @"UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap)."
    )]
    UKPT,

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2004, Annex A, and ISO/DIS 13492-2006. - (ASN.1 Object Identifier: id-dukpt-wrap).
    /// Encoded/decoded by serializers as &quot;DKPT&quot;.
    /// </summary>
    [EnumMember(Value = "DKPT")]
    [IsoId("_TVpLAAEcEeCQm6a_G2yO_w_-243182563")]
    [Description(
        @"DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2004, Annex A, and ISO/DIS 13492-2006. - (ASN.1 Object Identifier: id-dukpt-wrap)."
    )]
    DUKPT,

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_TVpLAQEcEeCQm6a_G2yO_w_-949389184")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES112CBC,

    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as &quot;HS25&quot;.
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_TVpLAgEcEeCQm6a_G2yO_w_-1559123583")]
    [Description(
        @"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256)."
    )]
    SHA256,

    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS2&quot;.
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_TVyU4AEcEeCQm6a_G2yO_w_-620239758")]
    [Description(
        @"Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption)."
    )]
    SHA256WithRSA,

    /// <summary>
    /// RSA encryption algorithm - (ASN.1 Object Identifier: rsaEncryption).
    /// Encoded/decoded by serializers as &quot;ERSA&quot;.
    /// </summary>
    [EnumMember(Value = "ERSA")]
    [IsoId("_TVyU4QEcEeCQm6a_G2yO_w_-1591094347")]
    [Description(@"RSA encryption algorithm - (ASN.1 Object Identifier: rsaEncryption).")]
    RSAEncryption,

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_sP2PBL4pEeKkGaJ0UrThyA_939221047")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CBC,

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_sP_Y8L4pEeKkGaJ0UrThyA_-1776030303")]
    [Description(
        @"DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A."
    )]
    DUKPT2009,

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;UKA1&quot;.
    /// </summary>
    [EnumMember(Value = "UKA1")]
    [IsoId("_sP_Y8b4pEeKkGaJ0UrThyA_-1585323256")]
    [Description(
        @"UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    UKPTwithAES128,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA1&quot;.
    /// </summary>
    [EnumMember(Value = "CMA1")]
    [IsoId("_sP_Y8r4pEeKkGaJ0UrThyA_-330576525")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message."
    )]
    SHA256CMACwithAES128,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Triple DES with a double length key (112 Bit) as defined in FIPS PUB 46-3. The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMD1&quot;.
    /// </summary>
    [EnumMember(Value = "CMD1")]
    [IsoId("_sP_Y874pEeKkGaJ0UrThyA_1872704111")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Triple DES with a double length key (112 Bit) as defined in FIPS PUB 46-3. The CMAC algorithm is computed on the SHA-256 digest of the message."
    )]
    SHA256CMACwithDES112,

    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as &quot;HS38&quot;.
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_sP_Y9L4pEeKkGaJ0UrThyA_-765279908")]
    [Description(
        @"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384)."
    )]
    SHA384,

    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as &quot;HS51&quot;.
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_sP_Y9b4pEeKkGaJ0UrThyA_-1618206578")]
    [Description(
        @"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512)."
    )]
    SHA512,

    /// <summary>
    /// RSA encryption scheme based on Optimal Asymmetric Encryption scheme (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-RSAES-OAEP).
    /// Encoded/decoded by serializers as &quot;RSAO&quot;.
    /// </summary>
    [EnumMember(Value = "RSAO")]
    [IsoId("_sP_Y9r4pEeKkGaJ0UrThyA_-1307190367")]
    [Description(
        @"RSA encryption scheme based on Optimal Asymmetric Encryption scheme (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-RSAES-OAEP)."
    )]
    RSAES_OAEP,

    /// <summary>
    /// Generator Function, used for RSA encryption and RSA igital signature (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-mgf1).
    /// Encoded/decoded by serializers as &quot;MGF1&quot;.
    /// </summary>
    [EnumMember(Value = "MGF1")]
    [IsoId("_sQJJ8L4pEeKkGaJ0UrThyA_-32024890")]
    [Description(
        @"Generator Function, used for RSA encryption and RSA igital signature (PKCS #1 version 2.1) - (ASN.1 Object Identifier: id-mgf1)."
    )]
    MGF1,

    /// <summary>
    /// The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1).
    /// Encoded/decoded by serializers as &quot;HS01&quot;.
    /// </summary>
    [EnumMember(Value = "HS01")]
    [IsoId("_CbPjIGi5EeS87LmvcA55sg")]
    [Description(
        @"The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1)."
    )]
    SHA1,

    /// <summary>
    /// The DEPRECATED Retail-CBC-MAC with SHA-1 (Secure Hash standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-1).
    /// Encoded/decoded by serializers as &quot;MCC1&quot;.
    /// </summary>
    [EnumMember(Value = "MCC1")]
    [IsoId("_rcfBAGi7EeS87LmvcA55sg")]
    [Description(
        @"The DEPRECATED Retail-CBC-MAC with SHA-1 (Secure Hash standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-1)."
    )]
    RetailSHA1MAC,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA9&quot;.
    /// </summary>
    [EnumMember(Value = "CMA9")]
    [IsoId("_0eQjgGi7EeS87LmvcA55sg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-384 digest of the message."
    )]
    SHA384CMACwithAES192,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA5&quot;.
    /// </summary>
    [EnumMember(Value = "CMA5")]
    [IsoId("_5hDvAGi7EeS87LmvcA55sg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-512 digest of the message."
    )]
    SHA512CMACwithAES256,

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5C&quot;.
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_KdqaEGi8EeS87LmvcA55sg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256CBC,

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9C&quot;.
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_OMQLsGi8EeS87LmvcA55sg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192CBC,

    /// <summary>
    /// The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption).
    /// Encoded/decoded by serializers as &quot;ERS1&quot;.
    /// </summary>
    [EnumMember(Value = "ERS1")]
    [IsoId("_odAwcGjBEeSP8Z8nx8HTuQ")]
    [Description(
        @"The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption)."
    )]
    SHA1WithRSA,

    /// <summary>
    /// Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS).
    /// Encoded/decoded by serializers as &quot;RPSS&quot;.
    /// </summary>
    [EnumMember(Value = "RPSS")]
    [IsoId("_rtMu0GjBEeSP8Z8nx8HTuQ")]
    [Description(
        @"Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS)."
    )]
    RSASSA_PSS,

    /// <summary>
    /// First Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC1&quot;.
    /// </summary>
    [EnumMember(Value = "ECC1")]
    [IsoId("_eWjSkNsyEee9e6xduATmQg")]
    [Description(@"First Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveFirstAlgorithm,

    /// <summary>
    /// Second Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC2&quot;.
    /// </summary>
    [EnumMember(Value = "ECC2")]
    [IsoId("_iyGQ0NsyEee9e6xduATmQg")]
    [Description(@"Second Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveSecondAlgorithm,

    /// <summary>
    /// Third Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC3&quot;.
    /// </summary>
    [EnumMember(Value = "ECC3")]
    [IsoId("_lqk50NsyEee9e6xduATmQg")]
    [Description(@"Third Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveThirdAlgorithm,

    /// <summary>
    /// Fourth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC4&quot;.
    /// </summary>
    [EnumMember(Value = "ECC4")]
    [IsoId("_zkUQ0NsyEee9e6xduATmQg")]
    [Description(@"Fourth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveFourthAlgorithm,

    /// <summary>
    /// Fifth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.
    /// Encoded/decoded by serializers as &quot;ECC5&quot;.
    /// </summary>
    [EnumMember(Value = "ECC5")]
    [IsoId("_311wYNsyEee9e6xduATmQg")]
    [Description(@"Fifth Elliptic Cryptographic Curve Algorithm identified by EMVCo Nextgen.")]
    EllipticCryptographicCurveFifthAlgortihm,

    /// <summary>
    /// Message digest algorithm SHA3-224 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-224).
    /// Encoded/decoded by serializers as &quot;SH31&quot;.
    /// </summary>
    [EnumMember(Value = "SH31")]
    [IsoId("_8ZQ4QNsyEee9e6xduATmQg")]
    [Description(
        @"Message digest algorithm SHA3-224 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-224)."
    )]
    SHA3_224,

    /// <summary>
    /// Message digest algorithm SHA3-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-256).
    /// Encoded/decoded by serializers as &quot;SH32&quot;.
    /// </summary>
    [EnumMember(Value = "SH32")]
    [IsoId("__yVs4NsyEee9e6xduATmQg")]
    [Description(
        @"Message digest algorithm SHA3-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-256)."
    )]
    SHA3_256,

    /// <summary>
    /// Message digest algorithm SHA3-384 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-384).
    /// Encoded/decoded by serializers as &quot;SH33&quot;.
    /// </summary>
    [EnumMember(Value = "SH33")]
    [IsoId("_IUJV4NszEee9e6xduATmQg")]
    [Description(
        @"Message digest algorithm SHA3-384 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-384)."
    )]
    SHA3_384,

    /// <summary>
    /// Message digest algorithm SHA3-512 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-512).
    /// Encoded/decoded by serializers as &quot;SH35&quot;.
    /// </summary>
    [EnumMember(Value = "SH35")]
    [IsoId("_L8OP0NszEee9e6xduATmQg")]
    [Description(
        @"Message digest algorithm SHA3-512 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-512)."
    )]
    SHA3_512,

    /// <summary>
    /// Message digest algorithm SHAKE-128 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake128).
    /// Encoded/decoded by serializers as &quot;SHK1&quot;.
    /// </summary>
    [EnumMember(Value = "SHK1")]
    [IsoId("_QHy4YNszEee9e6xduATmQg")]
    [Description(
        @"Message digest algorithm SHAKE-128 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake128)."
    )]
    SHAKE128,

    /// <summary>
    /// Message digest algorithm SHAKE-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake256).
    /// Encoded/decoded by serializers as &quot;SHK2&quot;.
    /// </summary>
    [EnumMember(Value = "SHK2")]
    [IsoId("_TlfuUNszEee9e6xduATmQg")]
    [Description(
        @"Message digest algorithm SHAKE-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake256)."
    )]
    SHAKE256,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA2&quot;.
    /// </summary>
    [EnumMember(Value = "CMA2")]
    [IsoId("_Za9F0NszEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message."
    )]
    SHA256CMACWithAES256,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM31&quot;.
    /// </summary>
    [EnumMember(Value = "CM31")]
    [IsoId("_dFUewNszEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-256 digest of the message."
    )]
    SHA3_256CMACWithAES128,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM32&quot;.
    /// </summary>
    [EnumMember(Value = "CM32")]
    [IsoId("_iMo94NszEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-384 digest of the message."
    )]
    SHA3_384CMACWithAES192,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM33&quot;.
    /// </summary>
    [EnumMember(Value = "CM33")]
    [IsoId("_qnlJ4NszEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-512 digest of the message."
    )]
    SHA3_512CMACWithAES256,

    /// <summary>
    /// Signature algorithms with RSA, using SHA3-256 digest algorithm. (ASN.1 Object Identifier: id-rsassa-pkcs1-v1-5-with-sha3-256).
    /// Encoded/decoded by serializers as &quot;ERS3&quot;.
    /// </summary>
    [EnumMember(Value = "ERS3")]
    [IsoId("_t_jyUNszEee9e6xduATmQg")]
    [Description(
        @"Signature algorithms with RSA, using SHA3-256 digest algorithm. (ASN.1 Object Identifier: id-rsassa-pkcs1-v1-5-with-sha3-256)."
    )]
    SHA3_256WithRSA,

    /// <summary>
    /// 3DES CBC-MAC with SHA3-256 (SecureHAsh standard) and ISO/IEC9797-1 method 2 padding.
    /// Encoded/decoded by serializers as &quot;MCS3&quot;.
    /// </summary>
    [EnumMember(Value = "MCS3")]
    [IsoId("_x44NQNszEee9e6xduATmQg")]
    [Description(
        @"3DES CBC-MAC with SHA3-256 (SecureHAsh standard) and ISO/IEC9797-1 method 2 padding."
    )]
    SHA3_256_3DESMAC,

    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A, With key length of 128 bits.
    /// Encoded/decoded by serializers as &quot;DA12&quot;.
    /// </summary>
    [EnumMember(Value = "DA12")]
    [IsoId("_3AbV4NszEee9e6xduATmQg")]
    [Description(
        @"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A, With key length of 128 bits."
    )]
    AESDUKPT128ECB,

    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 256 bits.
    /// Encoded/decoded by serializers as &quot;DA25&quot;.
    /// </summary>
    [EnumMember(Value = "DA25")]
    [IsoId("_rttO8Nv4EeeKpa-yxjuKzQ")]
    [Description(
        @"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 256 bits."
    )]
    AESDUKPT256ECB,

    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 192 bits.
    /// Encoded/decoded by serializers as &quot;DA19&quot;.
    /// </summary>
    [EnumMember(Value = "DA19")]
    [IsoId("_KcZw4Nv5EeeKpa-yxjuKzQ")]
    [Description(
        @"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 192 bits."
    )]
    AESDUKPT192ECB,

    /// <summary>
    /// Key Derivation according to the Special Publication from the NIST entitled 800-108.
    /// Encoded/decoded by serializers as &quot;N108&quot;.
    /// </summary>
    [EnumMember(Value = "N108")]
    [IsoId("_2ItdIN6IEeeCre2qFaLC2A")]
    [Description(
        @"Key Derivation according to the Special Publication from the NIST entitled 800-108."
    )]
    Nist800_108KeyDerivation,

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2R&quot;.
    /// </summary>
    [EnumMember(Value = "EA2R")]
    [IsoId("_TfSDoN6LEeeCre2qFaLC2A")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CTR,

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9R&quot;.
    /// </summary>
    [EnumMember(Value = "EA9R")]
    [IsoId("_WnbgUN6LEeeCre2qFaLC2A")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192CTR,

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5R&quot;.
    /// </summary>
    [EnumMember(Value = "EA5R")]
    [IsoId("_ZkJwIN6LEeeCre2qFaLC2A")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256CTR,

    /// <summary>
    /// Elliptic Curve Signature with the Curve P-256 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard).
    /// Encoded/decoded by serializers as &quot;ECP2&quot;.
    /// </summary>
    [EnumMember(Value = "ECP2")]
    [IsoId("_MBR5oN6OEeeCre2qFaLC2A")]
    [Description(
        @"Elliptic Curve Signature with the Curve P-256 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard)."
    )]
    SignatureWithEllipticCurveP_256,

    /// <summary>
    /// Elliptic Curve Signature with the Curve P-384 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard).
    /// Encoded/decoded by serializers as &quot;ECP3&quot;.
    /// </summary>
    [EnumMember(Value = "ECP3")]
    [IsoId("_O2xgEN6OEeeCre2qFaLC2A")]
    [Description(
        @"Elliptic Curve Signature with the Curve P-384 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard)."
    )]
    SignatureWithEllipticCurveP_384,

    /// <summary>
    /// Elliptic Curve Signature with the Curve P-512 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard).
    /// Encoded/decoded by serializers as &quot;ECP5&quot;.
    /// </summary>
    [EnumMember(Value = "ECP5")]
    [IsoId("_RsXNIN6OEeeCre2qFaLC2A")]
    [Description(
        @"Elliptic Curve Signature with the Curve P-512 as defined by the Federal Information Processing Standards (FIPS 186-4 - July, 2013 - Digital Signature Standard)."
    )]
    SignatureWithEllipticCurveP_512,

    /// <summary>
    /// Triple DES (Data Encryption Standard) CTR (Counter) encryption with double length key (112 Bit) as defined in FIPS SP 800-38a.
    /// Encoded/decoded by serializers as &quot;E3DR&quot;.
    /// </summary>
    [EnumMember(Value = "E3DR")]
    [IsoId("_JLDlEN8rEeeNt9bWIs54cw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CTR (Counter) encryption with double length key (112 Bit) as defined in FIPS SP 800-38a."
    )]
    DES112CTR,

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with triple length key (168 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E36C&quot;.
    /// </summary>
    [EnumMember(Value = "E36C")]
    [IsoId("_Sg5TEN8rEeeNt9bWIs54cw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with triple length key (168 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES168CBC,

    /// <summary>
    /// Triple DES (Data Encryption Standard) CTR (Counter) encryption with triple length key (168 Bit) as defined in FIPS SP 800-38a.
    /// Encoded/decoded by serializers as &quot;E36R&quot;.
    /// </summary>
    [EnumMember(Value = "E36R")]
    [IsoId("_tQPqkN8rEeeNt9bWIs54cw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CTR (Counter) encryption with triple length key (168 Bit) as defined in FIPS SP 800-38a."
    )]
    DES168CTR,

    /// <summary>
    /// The DEPRECATED Simple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with simple length key (56 Bit) as defined in FIPS PUB 81 - (ASN.1 Object Identifier: des-cbc).
    /// Encoded/decoded by serializers as &quot;SD5C&quot;.
    /// </summary>
    [EnumMember(Value = "SD5C")]
    [IsoId("_2G9MkN8rEeeNt9bWIs54cw")]
    [Description(
        @"The DEPRECATED Simple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with simple length key (56 Bit) as defined in FIPS PUB 81 - (ASN.1 Object Identifier: des-cbc)."
    )]
    SDE056CBC,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;CCA1&quot;.
    /// </summary>
    [EnumMember(Value = "CCA1")]
    [IsoId("_7fOGYN9aEeeNt9bWIs54cw")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    CMACAES128,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;CCA2&quot;.
    /// </summary>
    [EnumMember(Value = "CCA2")]
    [IsoId("_-V1uMN9aEeeNt9bWIs54cw")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    CMACAES192,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;CCA3&quot;.
    /// </summary>
    [EnumMember(Value = "CCA3")]
    [IsoId("_BXMmYN9bEeeNt9bWIs54cw")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    CMACAES256,

    /// <summary>
    /// Reatil SHA3 256 length MAC
    /// Encoded/decoded by serializers as &quot;MC3S&quot;.
    /// </summary>
    [EnumMember(Value = "MC3S")]
    [IsoId("_dG0hIXyOEemHsOqJOzMVfg")]
    [Description(@"Reatil SHA3 256 length MAC")]
    RetailSHA3_256MAC,

    /// <summary>
    /// AES with DUKPT
    /// Encoded/decoded by serializers as &quot;DAES&quot;.
    /// </summary>
    [EnumMember(Value = "DAES")]
    [IsoId("_r9JcMXyOEemHsOqJOzMVfg")]
    [Description(@"AES with DUKPT")]
    AESDUKPT,

    /// <summary>
    /// Single DES CBC mode
    /// Encoded/decoded by serializers as &quot;SDES&quot;.
    /// </summary>
    [EnumMember(Value = "SDES")]
    [IsoId("_zZqREXyOEemHsOqJOzMVfg")]
    [Description(@"Single DES CBC mode")]
    DES56CBC,

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;UKA2&quot;.
    /// </summary>
    [EnumMember(Value = "UKA2")]
    [IsoId("_tc-qUAxkEeqEbo60f0v6aw")]
    [Description(
        @"UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    UKPTwithAES192,

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;UKA3&quot;.
    /// </summary>
    [EnumMember(Value = "UKA3")]
    [IsoId("_uW8_QQxkEeqEbo60f0v6aw")]
    [Description(
        @"UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    UKPTwithAES256,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES23&quot;.
    /// </summary>
    [EnumMember(Value = "ES23")]
    [IsoId("_H5JIkC_HEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm."
    )]
    EcsdsaSha384,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES22&quot;.
    /// </summary>
    [EnumMember(Value = "ES22")]
    [IsoId("_Ijz2MC_HEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm."
    )]
    EcsdsaSha256,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES25&quot;.
    /// </summary>
    [EnumMember(Value = "ES25")]
    [IsoId("_iNHLoC_HEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm."
    )]
    EcsdsaSha512,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES32&quot;.
    /// </summary>
    [EnumMember(Value = "ES32")]
    [IsoId("_0gVrYC_HEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm."
    )]
    EcsdaSha3_256,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES33&quot;.
    /// </summary>
    [EnumMember(Value = "ES33")]
    [IsoId("_9kZF0C_HEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm."
    )]
    EcsdsaSha3_384,

    /// <summary>
    /// Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ES35&quot;.
    /// </summary>
    [EnumMember(Value = "ES35")]
    [IsoId("_DusE4C_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Schnorr Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm."
    )]
    EcsdsaSha3_512,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED35&quot;.
    /// </summary>
    [EnumMember(Value = "ED35")]
    [IsoId("_UdSJJi_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm."
    )]
    EcdsaSha3_512,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED22&quot;.
    /// </summary>
    [EnumMember(Value = "ED22")]
    [IsoId("_UdSJJy_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Digital Signature Algorithm coupled with SHA2-256 Digest Algorithm."
    )]
    EcdsaSha256,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED32&quot;.
    /// </summary>
    [EnumMember(Value = "ED32")]
    [IsoId("_UdbTEC_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Digital Signature Algorithm coupled with SHA3-256 Digest Algorithm."
    )]
    EcdsaSha3_256,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED33&quot;.
    /// </summary>
    [EnumMember(Value = "ED33")]
    [IsoId("_UdbTES_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Digital Signature Algorithm coupled with SHA3-384 Digest Algorithm."
    )]
    EcdsaSha3_384,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED23&quot;.
    /// </summary>
    [EnumMember(Value = "ED23")]
    [IsoId("_UdbTEi_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Digital Signature Algorithm coupled with SHA2-384 Digest Algorithm."
    )]
    EcdsaSha384,

    /// <summary>
    /// Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm.
    /// Encoded/decoded by serializers as &quot;ED25&quot;.
    /// </summary>
    [EnumMember(Value = "ED25")]
    [IsoId("_UdbTEy_IEeugIJ3Gvoevmg")]
    [Description(
        @"Elliptic Curve Digital Signature Algorithm coupled with SHA2-512 Digest Algorithm."
    )]
    EcdsaSha512,
}
