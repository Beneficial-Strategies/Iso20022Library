// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Allowed usages of the key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KSJO8H1DEeCF8NjrBemJWQ_1886720027")]
[Description(@"Allowed usages of the key.")]
[DerivedFrom(typeof(KeyUsageCode))]
public enum KeyUsage1Code
{
    /// <summary>
    /// Key may encrypt.
    /// Encoded/decoded by serializers as &quot;ENCR&quot;.
    /// </summary>
    [EnumMember(Value = "ENCR")]
    [IsoId("_KSJO8X1DEeCF8NjrBemJWQ_952269426")]
    [Description(@"Key may encrypt.")]
    Encryption = KeyUsageCode.Encryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may decrypt.
    /// Encoded/decoded by serializers as &quot;DCPT&quot;.
    /// </summary>
    [EnumMember(Value = "DCPT")]
    [IsoId("_KSJO8n1DEeCF8NjrBemJWQ_119194564")]
    [Description(@"Key may decrypt.")]
    Decryption = KeyUsageCode.Decryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may encrypt data.
    /// Encoded/decoded by serializers as &quot;DENC&quot;.
    /// </summary>
    [EnumMember(Value = "DENC")]
    [IsoId("_KSJO831DEeCF8NjrBemJWQ_1538814257")]
    [Description(@"Key may encrypt data.")]
    DataEncryption = KeyUsageCode.DataEncryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may decrypt data.
    /// Encoded/decoded by serializers as &quot;DDEC&quot;.
    /// </summary>
    [EnumMember(Value = "DDEC")]
    [IsoId("_KSJO9H1DEeCF8NjrBemJWQ_-1258974949")]
    [Description(@"Key may decrypt data.")]
    DataDecryption = KeyUsageCode.DataDecryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may encrypt information before translation.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_KSJO9X1DEeCF8NjrBemJWQ_1013497304")]
    [Description(@"Key may encrypt information before translation.")]
    TranslateInput = KeyUsageCode.TranslateInput, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may encrypt information after translation.
    /// Encoded/decoded by serializers as &quot;TRNX&quot;.
    /// </summary>
    [EnumMember(Value = "TRNX")]
    [IsoId("_KSJO9n1DEeCF8NjrBemJWQ_940936689")]
    [Description(@"Key may encrypt information after translation.")]
    TranslateOutput = KeyUsageCode.TranslateOutput, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may generate message authentication codes (MAC).
    /// Encoded/decoded by serializers as &quot;MACG&quot;.
    /// </summary>
    [EnumMember(Value = "MACG")]
    [IsoId("_KSJO931DEeCF8NjrBemJWQ_1560885913")]
    [Description(@"Key may generate message authentication codes (MAC).")]
    MessageAuthenticationCodeGeneration = KeyUsageCode.MessageAuthenticationCodeGeneration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may verify message authentication codes (MAC).
    /// Encoded/decoded by serializers as &quot;MACV&quot;.
    /// </summary>
    [EnumMember(Value = "MACV")]
    [IsoId("_KSJO-H1DEeCF8NjrBemJWQ_584260954")]
    [Description(@"Key may verify message authentication codes (MAC).")]
    MessageAuthenticationCodeVerification = KeyUsageCode.MessageAuthenticationCodeVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may generate digital signatures.
    /// Encoded/decoded by serializers as &quot;SIGG&quot;.
    /// </summary>
    [EnumMember(Value = "SIGG")]
    [IsoId("_KSJO-X1DEeCF8NjrBemJWQ_-918308253")]
    [Description(@"Key may generate digital signatures.")]
    SignatureGeneration = KeyUsageCode.SignatureGeneration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may verify digital signatures.
    /// Encoded/decoded by serializers as &quot;SUGV&quot;.
    /// </summary>
    [EnumMember(Value = "SUGV")]
    [IsoId("_KSSY4H1DEeCF8NjrBemJWQ_951000548")]
    [Description(@"Key may verify digital signatures.")]
    SignatureVerification = KeyUsageCode.SignatureVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may encrypt personal identification numbers (PIN).
    /// Encoded/decoded by serializers as &quot;PINE&quot;.
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_KSSY4X1DEeCF8NjrBemJWQ_-1604204545")]
    [Description(@"Key may encrypt personal identification numbers (PIN).")]
    PINEncryption = KeyUsageCode.PINEncryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may decrypt personal identification numbers (PIN).
    /// Encoded/decoded by serializers as &quot;PIND&quot;.
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_KSSY4n1DEeCF8NjrBemJWQ_-108961006")]
    [Description(@"Key may decrypt personal identification numbers (PIN).")]
    PINDecryption = KeyUsageCode.PINDecryption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may verify personal identification numbers (PIN).
    /// Encoded/decoded by serializers as &quot;PINV&quot;.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_KSSY431DEeCF8NjrBemJWQ_596427236")]
    [Description(@"Key may verify personal identification numbers (PIN).")]
    PINVerification = KeyUsageCode.PINVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may generate keys.
    /// Encoded/decoded by serializers as &quot;KEYG&quot;.
    /// </summary>
    [EnumMember(Value = "KEYG")]
    [IsoId("_KSSY5H1DEeCF8NjrBemJWQ_1055922580")]
    [Description(@"Key may generate keys.")]
    KeyGeneration = KeyUsageCode.KeyGeneration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may import keys.
    /// Encoded/decoded by serializers as &quot;KEYI&quot;.
    /// </summary>
    [EnumMember(Value = "KEYI")]
    [IsoId("_KSSY5X1DEeCF8NjrBemJWQ_-1633900113")]
    [Description(@"Key may import keys.")]
    KeyImport = KeyUsageCode.KeyImport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may export keys.
    /// Encoded/decoded by serializers as &quot;KEYX&quot;.
    /// </summary>
    [EnumMember(Value = "KEYX")]
    [IsoId("_KSSY5n1DEeCF8NjrBemJWQ_-204001317")]
    [Description(@"Key may export keys.")]
    KeyExport = KeyUsageCode.KeyExport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key may derive keys.
    /// Encoded/decoded by serializers as &quot;KEYD&quot;.
    /// </summary>
    [EnumMember(Value = "KEYD")]
    [IsoId("_KSSY531DEeCF8NjrBemJWQ_1499653549")]
    [Description(@"Key may derive keys.")]
    KeyDerivation = KeyUsageCode.KeyDerivation, // same ordinal as derivation source for type conversions
    
}
