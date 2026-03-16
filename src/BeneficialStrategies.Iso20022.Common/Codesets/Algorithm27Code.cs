// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for the MAC (Message Authentication Code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Algorithm27Code")]
[Description(@"Cryptographic algorithms for the MAC (Message Authentication Code).")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm27Code
{
    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;CCA1&quot;.
    /// </summary>
    [EnumMember(Value = "CCA1")]
    [IsoId("_Algorithm27Code_CMACAES128")]
    [Description(@"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 128 bits cryptographic key.")]
    CMACAES128 = AlgorithmCode.CMACAES128,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;CCA2&quot;.
    /// </summary>
    [EnumMember(Value = "CCA2")]
    [IsoId("_Algorithm27Code_CMACAES192")]
    [Description(@"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 192 bits cryptographic key.")]
    CMACAES192 = AlgorithmCode.CMACAES192,

    /// <summary>
    /// CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;CCA3&quot;.
    /// </summary>
    [EnumMember(Value = "CCA3")]
    [IsoId("_Algorithm27Code_CMACAES256")]
    [Description(@"CMAC (Cipher based Message Authentication Code) defined by the National Institute of Standards and Technology (NIST 800-38B - May 2005), using the block cipher Advanced Encryption Standard with a 256 bits cryptographic key.")]
    CMACAES256 = AlgorithmCode.CMACAES256,

    /// <summary>
    /// CMAC using AES-128 computed on the SHA3-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM31&quot;.
    /// </summary>
    [EnumMember(Value = "CM31")]
    [IsoId("_Algorithm27Code_SHA3_256CMACWithAES128")]
    [Description(@"CMAC using AES-128 computed on the SHA3-256 digest of the message.")]
    SHA3_256CMACWithAES128 = AlgorithmCode.SHA3_256CMACWithAES128,

    /// <summary>
    /// CMAC using AES-192 computed on the SHA3-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM32&quot;.
    /// </summary>
    [EnumMember(Value = "CM32")]
    [IsoId("_Algorithm27Code_SHA3_384CMACWithAES192")]
    [Description(@"CMAC using AES-192 computed on the SHA3-384 digest of the message.")]
    SHA3_384CMACWithAES192 = AlgorithmCode.SHA3_384CMACWithAES192,

    /// <summary>
    /// CMAC using AES-256 computed on the SHA3-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CM33&quot;.
    /// </summary>
    [EnumMember(Value = "CM33")]
    [IsoId("_Algorithm27Code_SHA3_512CMACWithAES256")]
    [Description(@"CMAC using AES-256 computed on the SHA3-512 digest of the message.")]
    SHA3_512CMACWithAES256 = AlgorithmCode.SHA3_512CMACWithAES256,

    /// <summary>
    /// CMAC using AES-128 computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA1&quot;.
    /// </summary>
    [EnumMember(Value = "CMA1")]
    [IsoId("_Algorithm27Code_SHA256CMACwithAES128")]
    [Description(@"CMAC using AES-128 computed on the SHA-256 digest of the message.")]
    SHA256CMACwithAES128 = AlgorithmCode.SHA256CMACwithAES128,

    /// <summary>
    /// CMAC using AES-256 computed on the SHA-256 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA2&quot;.
    /// </summary>
    [EnumMember(Value = "CMA2")]
    [IsoId("_Algorithm27Code_SHA256CMACWithAES256")]
    [Description(@"CMAC using AES-256 computed on the SHA-256 digest of the message.")]
    SHA256CMACWithAES256 = AlgorithmCode.SHA256CMACWithAES256,

    /// <summary>
    /// CMAC using AES-256 computed on the SHA-512 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA5&quot;.
    /// </summary>
    [EnumMember(Value = "CMA5")]
    [IsoId("_Algorithm27Code_SHA512CMACwithAES256")]
    [Description(@"CMAC using AES-256 computed on the SHA-512 digest of the message.")]
    SHA512CMACwithAES256 = AlgorithmCode.SHA512CMACwithAES256,

    /// <summary>
    /// CMAC using AES-192 computed on the SHA-384 digest of the message.
    /// Encoded/decoded by serializers as &quot;CMA9&quot;.
    /// </summary>
    [EnumMember(Value = "CMA9")]
    [IsoId("_Algorithm27Code_SHA384CMACwithAES192")]
    [Description(@"CMAC using AES-192 computed on the SHA-384 digest of the message.")]
    SHA384CMACwithAES192 = AlgorithmCode.SHA384CMACwithAES192,

    /// <summary>
    /// Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19).
    /// Encoded/decoded by serializers as &quot;MACC&quot;.
    /// </summary>
    [EnumMember(Value = "MACC")]
    [IsoId("_Algorithm27Code_RetailCBCMAC")]
    [Description(@"Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19).")]
    RetailCBCMAC = AlgorithmCode.RetailCBCMAC,

    /// <summary>
    /// The DEPRECATED Retail-CBC-MAC with SHA-1.
    /// Encoded/decoded by serializers as &quot;MCC1&quot;.
    /// </summary>
    [EnumMember(Value = "MCC1")]
    [IsoId("_Algorithm27Code_RetailSHA1MAC")]
    [Description(@"The DEPRECATED Retail-CBC-MAC with SHA-1.")]
    RetailSHA1MAC = AlgorithmCode.RetailSHA1MAC,

    /// <summary>
    /// Retail-CBC-MAC with SHA-256.
    /// Encoded/decoded by serializers as &quot;MCCS&quot;.
    /// </summary>
    [EnumMember(Value = "MCCS")]
    [IsoId("_Algorithm27Code_RetailSHA256MAC")]
    [Description(@"Retail-CBC-MAC with SHA-256.")]
    RetailSHA256MAC = AlgorithmCode.RetailSHA256MAC,

    /// <summary>
    /// 3DES CBC-MAC with SHA3-256 and ISO/IEC9797-1 method 2 padding.
    /// Encoded/decoded by serializers as &quot;MCS3&quot;.
    /// </summary>
    [EnumMember(Value = "MCS3")]
    [IsoId("_Algorithm27Code_SHA3_256_3DESMAC")]
    [Description(@"3DES CBC-MAC with SHA3-256 and ISO/IEC9797-1 method 2 padding.")]
    SHA3_256_3DESMAC = AlgorithmCode.SHA3_256_3DESMAC,

    /// <summary>
    /// ShangMi 4 enciphering method used in CBC mode coupled with ShangMi 3 hash function.
    /// Encoded/decoded by serializers as &quot;S34C&quot;.
    /// </summary>
    [EnumMember(Value = "S34C")]
    [IsoId("_Algorithm27Code_SM3SM4CBC")]
    [Description(@"ShangMi 4 enciphering method used in CBC mode coupled with ShangMi 3 hash function.")]
    SM3SM4CBC,

    /// <summary>
    /// ShangMi 4 enciphering method used in CTR mode coupled with ShangMi 3 hash function.
    /// Encoded/decoded by serializers as &quot;S34R&quot;.
    /// </summary>
    [EnumMember(Value = "S34R")]
    [IsoId("_Algorithm27Code_SM3SM4CTR")]
    [Description(@"ShangMi 4 enciphering method used in CTR mode coupled with ShangMi 3 hash function.")]
    SM3SM4CTR,

}
