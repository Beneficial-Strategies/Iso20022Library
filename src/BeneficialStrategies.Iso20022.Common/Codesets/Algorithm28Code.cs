// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for the protection of transported keys.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Algorithm28Code")]
[Description(@"Cryptographic algorithms for the protection of transported keys.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm28Code
{
    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A, With key length of 128 bits.
    /// Encoded/decoded by serializers as &quot;DA12&quot;.
    /// </summary>
    [EnumMember(Value = "DA12")]
    [IsoId("_Algorithm28Code_AESDUKPT128ECB")]
    [Description(@"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A, With key length of 128 bits.")]
    AESDUKPT128ECB = AlgorithmCode.AESDUKPT128ECB,

    /// <summary>
    /// AES DUKPT ECB algorithm with key length of 192 bits.
    /// Encoded/decoded by serializers as &quot;DA19&quot;.
    /// </summary>
    [EnumMember(Value = "DA19")]
    [IsoId("_Algorithm28Code_AESDUKPT192ECB")]
    [Description(@"AES DUKPT ECB algorithm with key length of 192 bits.")]
    AESDUKPT192ECB = AlgorithmCode.AESDUKPT192ECB,

    /// <summary>
    /// AES DUKPT ECB algorithm with key length of 256 bits.
    /// Encoded/decoded by serializers as &quot;DA25&quot;.
    /// </summary>
    [EnumMember(Value = "DA25")]
    [IsoId("_Algorithm28Code_AESDUKPT256ECB")]
    [Description(@"AES DUKPT ECB algorithm with key length of 256 bits.")]
    AESDUKPT256ECB = AlgorithmCode.AESDUKPT256ECB,

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_Algorithm28Code_DUKPT2009")]
    [Description(@"DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.")]
    DUKPT2009 = AlgorithmCode.DUKPT2009,

    /// <summary>
    /// Triple DES CBC encryption with triple length key (168 Bit).
    /// Encoded/decoded by serializers as &quot;E36C&quot;.
    /// </summary>
    [EnumMember(Value = "E36C")]
    [IsoId("_Algorithm28Code_DES168CBC")]
    [Description(@"Triple DES CBC encryption with triple length key (168 Bit).")]
    DES168CBC = AlgorithmCode.DES168CBC,

    /// <summary>
    /// Triple DES CTR encryption with triple length key (168 Bit).
    /// Encoded/decoded by serializers as &quot;E36R&quot;.
    /// </summary>
    [EnumMember(Value = "E36R")]
    [IsoId("_Algorithm28Code_DES168CTR")]
    [Description(@"Triple DES CTR encryption with triple length key (168 Bit).")]
    DES168CTR = AlgorithmCode.DES168CTR,

    /// <summary>
    /// Triple DES CBC encryption with double length key (112 Bit).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_Algorithm28Code_DES112CBC")]
    [Description(@"Triple DES CBC encryption with double length key (112 Bit).")]
    DES112CBC = AlgorithmCode.DES112CBC,

    /// <summary>
    /// Triple DES CTR encryption with double length key (112 Bit).
    /// Encoded/decoded by serializers as &quot;E3DR&quot;.
    /// </summary>
    [EnumMember(Value = "E3DR")]
    [IsoId("_Algorithm28Code_DES112CTR")]
    [Description(@"Triple DES CTR encryption with double length key (112 Bit).")]
    DES112CTR = AlgorithmCode.DES112CTR,

    /// <summary>
    /// AES CBC encryption with a 128 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_Algorithm28Code_AES128CBC")]
    [Description(@"AES CBC encryption with a 128 bits cryptographic key.")]
    AES128CBC = AlgorithmCode.AES128CBC,

    /// <summary>
    /// AES CTR encryption with a 128 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;EA2R&quot;.
    /// </summary>
    [EnumMember(Value = "EA2R")]
    [IsoId("_Algorithm28Code_AES128CTR")]
    [Description(@"AES CTR encryption with a 128 bits cryptographic key.")]
    AES128CTR = AlgorithmCode.AES128CTR,

    /// <summary>
    /// AES CBC encryption with a 256 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;EA5C&quot;.
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_Algorithm28Code_AES256CBC")]
    [Description(@"AES CBC encryption with a 256 bits cryptographic key.")]
    AES256CBC = AlgorithmCode.AES256CBC,

    /// <summary>
    /// AES CTR encryption with a 256 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;EA5R&quot;.
    /// </summary>
    [EnumMember(Value = "EA5R")]
    [IsoId("_Algorithm28Code_AES256CTR")]
    [Description(@"AES CTR encryption with a 256 bits cryptographic key.")]
    AES256CTR = AlgorithmCode.AES256CTR,

    /// <summary>
    /// AES CBC encryption with a 192 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;EA9C&quot;.
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_Algorithm28Code_AES192CBC")]
    [Description(@"AES CBC encryption with a 192 bits cryptographic key.")]
    AES192CBC = AlgorithmCode.AES192CBC,

    /// <summary>
    /// AES CTR encryption with a 192 bits cryptographic key.
    /// Encoded/decoded by serializers as &quot;EA9R&quot;.
    /// </summary>
    [EnumMember(Value = "EA9R")]
    [IsoId("_Algorithm28Code_AES192CTR")]
    [Description(@"AES CTR encryption with a 192 bits cryptographic key.")]
    AES192CTR = AlgorithmCode.AES192CTR,

    /// <summary>
    /// Key Derivation according to the Special Publication from the NIST entitled 800-108.
    /// Encoded/decoded by serializers as &quot;N108&quot;.
    /// </summary>
    [EnumMember(Value = "N108")]
    [IsoId("_Algorithm28Code_Nist800_108KeyDerivation")]
    [Description(@"Key Derivation according to the Special Publication from the NIST entitled 800-108.")]
    Nist800_108KeyDerivation = AlgorithmCode.Nist800_108KeyDerivation,

    /// <summary>
    /// The DEPRECATED Simple DES CBC encryption with simple length key (56 Bit).
    /// Encoded/decoded by serializers as &quot;SD5C&quot;.
    /// </summary>
    [EnumMember(Value = "SD5C")]
    [IsoId("_Algorithm28Code_SDE056CBC")]
    [Description(@"The DEPRECATED Simple DES CBC encryption with simple length key (56 Bit).")]
    SDE056CBC = AlgorithmCode.SDE056CBC,

    /// <summary>
    /// ShangMi 4 enciphering method used in CBC mode.
    /// Encoded/decoded by serializers as &quot;SM4C&quot;.
    /// </summary>
    [EnumMember(Value = "SM4C")]
    [IsoId("_Algorithm28Code_SM4CBC")]
    [Description(@"ShangMi 4 enciphering method used in CBC mode.")]
    SM4CBC,

    /// <summary>
    /// ShangMi 4 enciphering method used in CTR mode.
    /// Encoded/decoded by serializers as &quot;SM4R&quot;.
    /// </summary>
    [EnumMember(Value = "SM4R")]
    [IsoId("_Algorithm28Code_SM4CTR")]
    [Description(@"ShangMi 4 enciphering method used in CTR mode.")]
    SM4CTR,

    /// <summary>
    /// UKPT or Master Session Key key encryption using AES-128.
    /// Encoded/decoded by serializers as &quot;UKA1&quot;.
    /// </summary>
    [EnumMember(Value = "UKA1")]
    [IsoId("_Algorithm28Code_UKPTwithAES128")]
    [Description(@"UKPT or Master Session Key key encryption using AES-128.")]
    UKPTwithAES128 = AlgorithmCode.UKPTwithAES128,

    /// <summary>
    /// UKPT or Master Session Key key encryption using AES-192.
    /// Encoded/decoded by serializers as &quot;UKA2&quot;.
    /// </summary>
    [EnumMember(Value = "UKA2")]
    [IsoId("_Algorithm28Code_UKPTwithAES192")]
    [Description(@"UKPT or Master Session Key key encryption using AES-192.")]
    UKPTwithAES192 = AlgorithmCode.UKPTwithAES192,

    /// <summary>
    /// UKPT or Master Session Key key encryption using AES-256.
    /// Encoded/decoded by serializers as &quot;UKA3&quot;.
    /// </summary>
    [EnumMember(Value = "UKA3")]
    [IsoId("_Algorithm28Code_UKPTwithAES256")]
    [Description(@"UKPT or Master Session Key key encryption using AES-256.")]
    UKPTwithAES256 = AlgorithmCode.UKPTwithAES256,

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption.
    /// Encoded/decoded by serializers as &quot;UKPT&quot;.
    /// </summary>
    [EnumMember(Value = "UKPT")]
    [IsoId("_Algorithm28Code_UKPT")]
    [Description(@"UKPT (Unique Key Per Transaction) or Master Session Key key encryption.")]
    UKPT = AlgorithmCode.UKPT,

}
