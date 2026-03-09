// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for the protection of transported keys.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lh7HEWi7EeS87LmvcA55sg")]
[Description(@"Cryptographic algorithms for the protection of transported keys.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm13Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA2C&quot;.
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_lu-EkWi7EeS87LmvcA55sg")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    AES128CBC = AlgorithmCode.AES128CBC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as &quot;E3DC&quot;.
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_lu-Ek2i7EeS87LmvcA55sg")]
    [Description(@"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).")]
    DES112CBC = AlgorithmCode.DES112CBC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_lu-ElWi7EeS87LmvcA55sg")]
    [Description(@"DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2009 Annex A.")]
    DUKPT2009 = AlgorithmCode.DUKPT2009, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap).
    /// Encoded/decoded by serializers as &quot;UKPT&quot;.
    /// </summary>
    [EnumMember(Value = "UKPT")]
    [IsoId("_lu-El2i7EeS87LmvcA55sg")]
    [Description(@"UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap).")]
    UKPT = AlgorithmCode.UKPT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;UKA1&quot;.
    /// </summary>
    [EnumMember(Value = "UKA1")]
    [IsoId("_lu-EmWi7EeS87LmvcA55sg")]
    [Description(@"UKPT (Unique Key Per Transaction) or Master Session Key key encryption, using Advanced Encryption Standard with a 128 bits cryptographic key, approved by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    UKPTwithAES128 = AlgorithmCode.UKPTwithAES128, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA9C&quot;.
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_TZJuYWi8EeS87LmvcA55sg")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES192CBC = AlgorithmCode.AES192CBC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;EA5C&quot;.
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_TfXrIWi8EeS87LmvcA55sg")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES256CBC = AlgorithmCode.AES256CBC, // same ordinal as derivation source for type conversions
    
}
