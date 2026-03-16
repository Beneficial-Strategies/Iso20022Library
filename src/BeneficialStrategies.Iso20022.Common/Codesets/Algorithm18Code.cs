// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for the protection of transported keys.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dLAZwdtkEee9e6xduATmQg")]
[Description(@"Cryptographic algorithms for the protection of transported keys.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm18Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_dUAkwdtkEee9e6xduATmQg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CBC = AlgorithmCode.AES128CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_dUAkw9tkEee9e6xduATmQg")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES112CBC = AlgorithmCode.DES112CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_dUAkxdtkEee9e6xduATmQg")]
    [Description(
        @"DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A."
    )]
    DUKPT2009 = AlgorithmCode.DUKPT2009, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap).
    /// Encoded/decoded by serializers as &quot;UKPT&quot;.
    /// </summary>
    [EnumMember(Value = "UKPT")]
    [IsoId("_dUAkx9tkEee9e6xduATmQg")]
    [Description(
        @"UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap)."
    )]
    UKPT = AlgorithmCode.UKPT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;UKA1&quot;.
    /// </summary>
    [EnumMember(Value = "UKA1")]
    [IsoId("_dUAkydtkEee9e6xduATmQg")]
    [Description(
        @"UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    UKPTwithAES128 = AlgorithmCode.UKPTwithAES128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9C&quot;.
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_dUAky9tkEee9e6xduATmQg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192CBC = AlgorithmCode.AES192CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5C&quot;.
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_dUAkzdtkEee9e6xduATmQg")]
    [Description(
        @"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256CBC = AlgorithmCode.AES256CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A, With key length of 128 bits.
    /// Encoded/decoded by serializers as &quot;DA12&quot;.
    /// </summary>
    [EnumMember(Value = "DA12")]
    [IsoId("_fY4mkdtkEee9e6xduATmQg")]
    [Description(
        @"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A, With key length of 128 bits."
    )]
    AESDUKPT128ECB = AlgorithmCode.AESDUKPT128ECB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 192 bits.
    /// Encoded/decoded by serializers as &quot;DA19&quot;.
    /// </summary>
    [EnumMember(Value = "DA19")]
    [IsoId("_wW-DoNv5EeeKpa-yxjuKzQ")]
    [Description(
        @"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 192 bits."
    )]
    AESDUKPT192ECB = AlgorithmCode.AESDUKPT192ECB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 256 bits.
    /// Encoded/decoded by serializers as &quot;DA25&quot;.
    /// </summary>
    [EnumMember(Value = "DA25")]
    [IsoId("_wdNOgdv5EeeKpa-yxjuKzQ")]
    [Description(
        @"AES DUKPT (Derived Unique Key Per Transaction) ECB algorithm, as specified in ANSI X9.24-3-2017 Annex A.With key length of 256 bits."
    )]
    AESDUKPT256ECB = AlgorithmCode.AESDUKPT256ECB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key Derivation according to the Special Publication from the NIST entitled 800-108.
    /// Encoded/decoded by serializers as &quot;N108&quot;.
    /// </summary>
    [EnumMember(Value = "N108")]
    [IsoId("_VU5MUd6JEeeCre2qFaLC2A")]
    [Description(
        @"Key Derivation according to the Special Publication from the NIST entitled 800-108."
    )]
    Nist800_108KeyDerivation = AlgorithmCode.Nist800_108KeyDerivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5R&quot;.
    /// </summary>
    [EnumMember(Value = "EA5R")]
    [IsoId("_vSZlQd6LEeeCre2qFaLC2A")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES256CTR = AlgorithmCode.AES256CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9R&quot;.
    /// </summary>
    [EnumMember(Value = "EA9R")]
    [IsoId("_voa4kd6LEeeCre2qFaLC2A")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES192CTR = AlgorithmCode.AES192CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AES (Advanced Encryption Standard) CTR (Counter) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2R&quot;.
    /// </summary>
    [EnumMember(Value = "EA2R")]
    [IsoId("_v0vdUd6LEeeCre2qFaLC2A")]
    [Description(
        @"AES (Advanced Encryption Standard) CTR (Counter) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard)."
    )]
    AES128CTR = AlgorithmCode.AES128CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CTR (Counter) encryption with double length key (112 Bit) as defined in FIPS SP 800-38a.
    /// Encoded/decoded by serializers as &quot;E3DR&quot;.
    /// </summary>
    [EnumMember(Value = "E3DR")]
    [IsoId("_1zhdwd8sEeeNt9bWIs54cw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CTR (Counter) encryption with double length key (112 Bit) as defined in FIPS SP 800-38a."
    )]
    DES112CTR = AlgorithmCode.DES112CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with triple length key (168 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E36C&quot;.
    /// </summary>
    [EnumMember(Value = "E36C")]
    [IsoId("_15eUwd8sEeeNt9bWIs54cw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with triple length key (168 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc)."
    )]
    DES168CBC = AlgorithmCode.DES168CBC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Triple DES (Data Encryption Standard) CTR (Counter) encryption with triple length key (168 Bit) as defined in FIPS SP 800-38a.
    /// Encoded/decoded by serializers as &quot;E36R&quot;.
    /// </summary>
    [EnumMember(Value = "E36R")]
    [IsoId("_1-uBId8sEeeNt9bWIs54cw")]
    [Description(
        @"Triple DES (Data Encryption Standard) CTR (Counter) encryption with triple length key (168 Bit) as defined in FIPS SP 800-38a."
    )]
    DES168CTR = AlgorithmCode.DES168CTR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The DEPRECATED Simple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with simple length key (56 Bit) as defined in FIPS PUB 81 - (ASN.1 Object Identifier: des-cbc).
    /// Encoded/decoded by serializers as &quot;SD5C&quot;.
    /// </summary>
    [EnumMember(Value = "SD5C")]
    [IsoId("_3ps8Qd8sEeeNt9bWIs54cw")]
    [Description(
        @"The DEPRECATED Simple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with simple length key (56 Bit) as defined in FIPS PUB 81 - (ASN.1 Object Identifier: des-cbc)."
    )]
    SDE056CBC = AlgorithmCode.SDE056CBC, // same ordinal as derivation source for type conversions
}
