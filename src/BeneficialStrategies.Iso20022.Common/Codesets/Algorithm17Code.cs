// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for the MAC (Message Authentication Code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2ZJ5sdtjEee9e6xduATmQg")]
[Description(@"Cryptographic algorithms for the MAC (Message Authentication Code).")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm17Code>))]
#endif
public enum Algorithm17Code
{
    /// <summary>
    /// Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).
    /// Encoded/decoded by serializers as &quot;MACC&quot;.
    /// </summary>
    [EnumMember(Value = "MACC")]
    [IsoId("_2i6SodtjEee9e6xduATmQg")]
    [Description(
        @"Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac)."
    )]
    RetailCBCMAC = AlgorithmCode.RetailCBCMAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).
    /// Encoded/decoded by serializers as &quot;MCCS&quot;.
    /// </summary>
    [EnumMember(Value = "MCCS")]
    [IsoId("_2i6So9tjEee9e6xduATmQg")]
    [Description(
        @"Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256)."
    )]
    RetailSHA256MAC = AlgorithmCode.RetailSHA256MAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA1&quot;.
    /// </summary>
    [EnumMember(Value = "CMA1")]
    [IsoId("_2i6SpdtjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message."
    )]
    SHA256CMACwithAES128 = AlgorithmCode.SHA256CMACwithAES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The DEPRECATED Retail-CBC-MAC with SHA-1 (Secure Hash standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-1).
    /// Encoded/decoded by serializers as &quot;MCC1&quot;.
    /// </summary>
    [EnumMember(Value = "MCC1")]
    [IsoId("_2i6Sp9tjEee9e6xduATmQg")]
    [Description(
        @"The DEPRECATED Retail-CBC-MAC with SHA-1 (Secure Hash standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-1)."
    )]
    RetailSHA1MAC = AlgorithmCode.RetailSHA1MAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA9&quot;.
    /// </summary>
    [EnumMember(Value = "CMA9")]
    [IsoId("_2i6SqdtjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-384 digest of the message."
    )]
    SHA384CMACwithAES192 = AlgorithmCode.SHA384CMACwithAES192, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA5&quot;.
    /// </summary>
    [EnumMember(Value = "CMA5")]
    [IsoId("_2i6Sq9tjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-512 digest of the message."
    )]
    SHA512CMACwithAES256 = AlgorithmCode.SHA512CMACwithAES256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA2&quot;.
    /// </summary>
    [EnumMember(Value = "CMA2")]
    [IsoId("_4y3jEdtjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message."
    )]
    SHA256CMACWithAES256 = AlgorithmCode.SHA256CMACWithAES256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM31&quot;.
    /// </summary>
    [EnumMember(Value = "CM31")]
    [IsoId("_5fvQIdtjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-256 digest of the message."
    )]
    SHA3_256CMACWithAES128 = AlgorithmCode.SHA3_256CMACWithAES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM32&quot;.
    /// </summary>
    [EnumMember(Value = "CM32")]
    [IsoId("_6Sb4YdtjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-384 digest of the message."
    )]
    SHA3_384CMACWithAES192 = AlgorithmCode.SHA3_384CMACWithAES192, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM33&quot;.
    /// </summary>
    [EnumMember(Value = "CM33")]
    [IsoId("_6nW_gdtjEee9e6xduATmQg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA3-512 digest of the message."
    )]
    SHA3_512CMACWithAES256 = AlgorithmCode.SHA3_512CMACWithAES256, // same ordinal as derivation source for type conversions

    /// <summary>
    /// 3DES CBC-MAC with SHA3-256 (SecureHAsh standard) and ISO/IEC9797-1 method 2 padding.
    /// Encoded/decoded by serializers as &quot;MCS3&quot;.
    /// </summary>
    [EnumMember(Value = "MCS3")]
    [IsoId("_-SqMkdtjEee9e6xduATmQg")]
    [Description(
        @"3DES CBC-MAC with SHA3-256 (SecureHAsh standard) and ISO/IEC9797-1 method 2 padding."
    )]
    SHA3_256_3DESMAC = AlgorithmCode.SHA3_256_3DESMAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;CCA1&quot;.
    /// </summary>
    [EnumMember(Value = "CCA1")]
    [IsoId("_GRNCQd9bEeeNt9bWIs54cw")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    CMACAES128 = AlgorithmCode.CMACAES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;CCA2&quot;.
    /// </summary>
    [EnumMember(Value = "CCA2")]
    [IsoId("_GaUiAd9bEeeNt9bWIs54cw")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    CMACAES192 = AlgorithmCode.CMACAES192, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;CCA3&quot;.
    /// </summary>
    [EnumMember(Value = "CCA3")]
    [IsoId("_Gkd8gd9bEeeNt9bWIs54cw")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    CMACAES256 = AlgorithmCode.CMACAES256, // same ordinal as derivation source for type conversions
}
