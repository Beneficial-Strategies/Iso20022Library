// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Allowed usages of the key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KSSY6H1DEeCF8NjrBemJWQ_-383369433")]
[Description(@"Allowed usages of the key.")]
[Derivations(typeof(KeyUsage1Code))]
public enum KeyUsageCode
{
    /// <summary>
    /// Key may encrypt.
    /// Encoded/decoded by serializers as &quot;ENCR&quot;.
    /// </summary>
    [EnumMember(Value = "ENCR")]
    [IsoId("_KSSY6X1DEeCF8NjrBemJWQ_-430910960")]
    [Description(@"Key may encrypt.")]
    Encryption,

    /// <summary>
    /// Key may decrypt.
    /// Encoded/decoded by serializers as &quot;DCPT&quot;.
    /// </summary>
    [EnumMember(Value = "DCPT")]
    [IsoId("_KScJ4H1DEeCF8NjrBemJWQ_744280065")]
    [Description(@"Key may decrypt.")]
    Decryption,

    /// <summary>
    /// Key may encrypt data.
    /// Encoded/decoded by serializers as &quot;DENC&quot;.
    /// </summary>
    [EnumMember(Value = "DENC")]
    [IsoId("_KScJ4X1DEeCF8NjrBemJWQ_858119131")]
    [Description(@"Key may encrypt data.")]
    DataEncryption,

    /// <summary>
    /// Key may decrypt data.
    /// Encoded/decoded by serializers as &quot;DDEC&quot;.
    /// </summary>
    [EnumMember(Value = "DDEC")]
    [IsoId("_KScJ4n1DEeCF8NjrBemJWQ_-1427983313")]
    [Description(@"Key may decrypt data.")]
    DataDecryption,

    /// <summary>
    /// Key may encrypt information after translation.
    /// Encoded/decoded by serializers as &quot;TRNX&quot;.
    /// </summary>
    [EnumMember(Value = "TRNX")]
    [IsoId("_KScJ431DEeCF8NjrBemJWQ_319261856")]
    [Description(@"Key may encrypt information after translation.")]
    TranslateOutput,

    /// <summary>
    /// Key may encrypt information before translation.
    /// Encoded/decoded by serializers as &quot;TRNI&quot;.
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_KScJ5H1DEeCF8NjrBemJWQ_-252792288")]
    [Description(@"Key may encrypt information before translation.")]
    TranslateInput,

    /// <summary>
    /// Key may generate message authentication codes (MAC).
    /// Encoded/decoded by serializers as &quot;MACG&quot;.
    /// </summary>
    [EnumMember(Value = "MACG")]
    [IsoId("_KScJ5X1DEeCF8NjrBemJWQ_-1314144247")]
    [Description(@"Key may generate message authentication codes (MAC).")]
    MessageAuthenticationCodeGeneration,

    /// <summary>
    /// Key may verify message authentication codes (MAC).
    /// Encoded/decoded by serializers as &quot;MACV&quot;.
    /// </summary>
    [EnumMember(Value = "MACV")]
    [IsoId("_KScJ5n1DEeCF8NjrBemJWQ_1563233746")]
    [Description(@"Key may verify message authentication codes (MAC).")]
    MessageAuthenticationCodeVerification,

    /// <summary>
    /// Key may generate digital signatures.
    /// Encoded/decoded by serializers as &quot;SIGG&quot;.
    /// </summary>
    [EnumMember(Value = "SIGG")]
    [IsoId("_KScJ531DEeCF8NjrBemJWQ_566161393")]
    [Description(@"Key may generate digital signatures.")]
    SignatureGeneration,

    /// <summary>
    /// Key may verify digital signatures.
    /// Encoded/decoded by serializers as &quot;SUGV&quot;.
    /// </summary>
    [EnumMember(Value = "SUGV")]
    [IsoId("_KScJ6H1DEeCF8NjrBemJWQ_1741352418")]
    [Description(@"Key may verify digital signatures.")]
    SignatureVerification,

    /// <summary>
    /// Key may encrypt personal identification numbers (PIN).
    /// Encoded/decoded by serializers as &quot;PINE&quot;.
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_KScJ6X1DEeCF8NjrBemJWQ_-317071894")]
    [Description(@"Key may encrypt personal identification numbers (PIN).")]
    PINEncryption,

    /// <summary>
    /// Key may decrypt personal identification numbers (PIN).
    /// Encoded/decoded by serializers as &quot;PIND&quot;.
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_KSlT0H1DEeCF8NjrBemJWQ_1677072812")]
    [Description(@"Key may decrypt personal identification numbers (PIN).")]
    PINDecryption,

    /// <summary>
    /// Key may verify personal identification numbers (PIN).
    /// Encoded/decoded by serializers as &quot;PINV&quot;.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_KSlT0X1DEeCF8NjrBemJWQ_680000459")]
    [Description(@"Key may verify personal identification numbers (PIN).")]
    PINVerification,

    /// <summary>
    /// Key may generate keys.
    /// Encoded/decoded by serializers as &quot;KEYG&quot;.
    /// </summary>
    [EnumMember(Value = "KEYG")]
    [IsoId("_KSlT0n1DEeCF8NjrBemJWQ_-1136025575")]
    [Description(@"Key may generate keys.")]
    KeyGeneration,

    /// <summary>
    /// Key may import keys.
    /// Encoded/decoded by serializers as &quot;KEYI&quot;.
    /// </summary>
    [EnumMember(Value = "KEYI")]
    [IsoId("_KSlT031DEeCF8NjrBemJWQ_-138953222")]
    [Description(@"Key may import keys.")]
    KeyImport,

    /// <summary>
    /// Key may export keys.
    /// Encoded/decoded by serializers as &quot;KEYX&quot;.
    /// </summary>
    [EnumMember(Value = "KEYX")]
    [IsoId("_KSlT1H1DEeCF8NjrBemJWQ_497380528")]
    [Description(@"Key may export keys.")]
    KeyExport,

    /// <summary>
    /// Key may derive keys.
    /// Encoded/decoded by serializers as &quot;KEYD&quot;.
    /// </summary>
    [EnumMember(Value = "KEYD")]
    [IsoId("_KSlT1X1DEeCF8NjrBemJWQ_1855191484")]
    [Description(@"Key may derive keys.")]
    KeyDerivation,
}
