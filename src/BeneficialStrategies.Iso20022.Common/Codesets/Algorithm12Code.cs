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
[IsoId("_h6npMWi7EeS87LmvcA55sg")]
[Description(@"Cryptographic algorithms for the MAC (Message Authentication Code).")]
[DerivedFrom(typeof(AlgorithmCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Algorithm12Code>))]
#endif
public enum Algorithm12Code
{
    /// <summary>
    /// Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).
    /// Encoded/decoded by serializers as &quot;MACC&quot;.
    /// </summary>
    [EnumMember(Value = "MACC")]
    [IsoId("_iHlHIWi7EeS87LmvcA55sg")]
    [Description(
        @"Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac)."
    )]
    RetailCBCMAC = AlgorithmCode.RetailCBCMAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).
    /// Encoded/decoded by serializers as &quot;MCCS&quot;.
    /// </summary>
    [EnumMember(Value = "MCCS")]
    [IsoId("_iHlHI2i7EeS87LmvcA55sg")]
    [Description(
        @"Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256)."
    )]
    RetailSHA256MAC = AlgorithmCode.RetailSHA256MAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA1&quot;.
    /// </summary>
    [EnumMember(Value = "CMA1")]
    [IsoId("_iHlHJWi7EeS87LmvcA55sg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-256 digest of the message."
    )]
    SHA256CMACwithAES128 = AlgorithmCode.SHA256CMACwithAES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The DEPRECATED Retail-CBC-MAC with SHA-1 (Secure Hash standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-1).
    /// Encoded/decoded by serializers as &quot;MCC1&quot;.
    /// </summary>
    [EnumMember(Value = "MCC1")]
    [IsoId("_BK51QWi8EeS87LmvcA55sg")]
    [Description(
        @"The DEPRECATED Retail-CBC-MAC with SHA-1 (Secure Hash standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-1)."
    )]
    RetailSHA1MAC = AlgorithmCode.RetailSHA1MAC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA9&quot;.
    /// </summary>
    [EnumMember(Value = "CMA9")]
    [IsoId("_DoWIEWi8EeS87LmvcA55sg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-384 digest of the message."
    )]
    SHA384CMACwithAES192 = AlgorithmCode.SHA384CMACwithAES192, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA5&quot;.
    /// </summary>
    [EnumMember(Value = "CMA5")]
    [IsoId("_Ew-kEWi8EeS87LmvcA55sg")]
    [Description(
        @"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard). The CMAC algorithm is computed on the SHA-512 digest of the message."
    )]
    SHA512CMACwithAES256 = AlgorithmCode.SHA512CMACwithAES256, // same ordinal as derivation source for type conversions
}
