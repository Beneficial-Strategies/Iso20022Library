// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of algorithm used by the cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KU0viX1DEeCF8NjrBemJWQ_1699573944")]
[Description(@"Type of algorithm used by the cryptographic key.")]
[Derivations(typeof(CryptographicKeyType1Code),typeof(CryptographicKeyType2Code),typeof(CryptographicKeyType3Code),typeof(CryptographicKeyType4Code))]
public enum CryptographicKeyTypeCode
{
    /// <summary>
    /// Data encryption standard.
    /// Encoded/decoded by serializers as &quot;DESC&quot;.
    /// </summary>
    [EnumMember(Value = "DESC")]
    [IsoId("_KU95cH1DEeCF8NjrBemJWQ_84198797")]
    [Description(@"Data encryption standard.")]
    DES,
    
    /// <summary>
    /// Advanced encryption standard.
    /// Encoded/decoded by serializers as &quot;AESC&quot;.
    /// </summary>
    [EnumMember(Value = "AESC")]
    [IsoId("_KU95cX1DEeCF8NjrBemJWQ_198037863")]
    [Description(@"Advanced encryption standard.")]
    AES,
    
    /// <summary>
    /// Rivest, Shamir and Adleman.
    /// Encoded/decoded by serializers as &quot;RSAC&quot;.
    /// </summary>
    [EnumMember(Value = "RSAC")]
    [IsoId("_KU95cn1DEeCF8NjrBemJWQ_262317469")]
    [Description(@"Rivest, Shamir and Adleman.")]
    RSA,
    
    /// <summary>
    /// Elliptic-curve cryptography.
    /// Encoded/decoded by serializers as &quot;ECCC&quot;.
    /// </summary>
    [EnumMember(Value = "ECCC")]
    [IsoId("_KU95c31DEeCF8NjrBemJWQ_376156535")]
    [Description(@"Elliptic-curve cryptography.")]
    ECC,
    
    /// <summary>
    /// AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES2&quot;.
    /// </summary>
    [EnumMember(Value = "AES2")]
    [IsoId("_sPGoIL4pEeKkGaJ0UrThyA_-1893704868")]
    [Description(@"AES (Advanced Encryption Standard) 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    AES128,
    
    /// <summary>
    /// Data encryption standard key of 112 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE3&quot;.
    /// </summary>
    [EnumMember(Value = "EDE3")]
    [IsoId("_sPGoIb4pEeKkGaJ0UrThyA_23175295")]
    [Description(@"Data encryption standard key of 112 bits (without the parity bits).")]
    DES112,
    
    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A.
    /// Encoded/decoded by serializers as &quot;DKP9&quot;.
    /// </summary>
    [EnumMember(Value = "DKP9")]
    [IsoId("_sPGoIr4pEeKkGaJ0UrThyA_-604710375")]
    [Description(@"DUKPT (Derived Unique Key Per Transaction) key, as specified in ANSI X9.24-2009 Annex A.")]
    DUKPT2009,
    
    /// <summary>
    /// AES (Advanced Encryption Standard) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES9&quot;.
    /// </summary>
    [EnumMember(Value = "AES9")]
    [IsoId("_xwLywGpzEeSMqvBfBY1c9A")]
    [Description(@"AES (Advanced Encryption Standard) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES192,
    
    /// <summary>
    /// AES (Advanced Encryption Standard) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as &quot;AES5&quot;.
    /// </summary>
    [EnumMember(Value = "AES5")]
    [IsoId("_1cQb4GpzEeSMqvBfBY1c9A")]
    [Description(@"AES (Advanced Encryption Standard) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES256,
    
    /// <summary>
    /// Data encryption standard key of 168 bits (without the parity bits).
    /// Encoded/decoded by serializers as &quot;EDE4&quot;.
    /// </summary>
    [EnumMember(Value = "EDE4")]
    [IsoId("_453yQGpzEeSMqvBfBY1c9A")]
    [Description(@"Data encryption standard key of 168 bits (without the parity bits).")]
    DES168,
    
    /// <summary>
    /// Key used to protect application information.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_39e3QItIEeSxlKlAGYErFg")]
    [Description(@"Key used to protect application information.")]
    Application,
    
    /// <summary>
    /// Any cryptographic key that can be downloaded.
    /// Encoded/decoded by serializers as &quot;DYNC&quot;.
    /// </summary>
    [EnumMember(Value = "DYNC")]
    [IsoId("_52p_YItIEeSxlKlAGYErFg")]
    [Description(@"Any cryptographic key that can be downloaded.")]
    Dynamic,
    
    /// <summary>
    /// Key used to protect data in the messages.
    /// Encoded/decoded by serializers as &quot;DATA&quot;.
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_8xq_AItIEeSxlKlAGYErFg")]
    [Description(@"Key used to protect data in the messages.")]
    Data,
    
    /// <summary>
    /// Key used to encrypt other keys.
    /// Encoded/decoded by serializers as &quot;KENC&quot;.
    /// </summary>
    [EnumMember(Value = "KENC")]
    [IsoId("__GF4sItIEeSxlKlAGYErFg")]
    [Description(@"Key used to encrypt other keys.")]
    KeyEncryption,
    
    /// <summary>
    /// Temporary key used to download keys.
    /// Encoded/decoded by serializers as &quot;WRKG&quot;.
    /// </summary>
    [EnumMember(Value = "WRKG")]
    [IsoId("_BCqTEItJEeSxlKlAGYErFg")]
    [Description(@"Temporary key used to download keys.")]
    Working,
    
    /// <summary>
    /// Key used to encrypt a PIN.
    /// Encoded/decoded by serializers as &quot;PINK&quot;.
    /// </summary>
    [EnumMember(Value = "PINK")]
    [IsoId("_DZdyYItJEeSxlKlAGYErFg")]
    [Description(@"Key used to encrypt a PIN.")]
    PIN,
    
    /// <summary>
    /// Key used to generate the MAC of a message.
    /// Encoded/decoded by serializers as &quot;MACK&quot;.
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("_GTSfMItJEeSxlKlAGYErFg")]
    [Description(@"Key used to generate the MAC of a message.")]
    MAC,
    
    /// <summary>
    /// DUKPT AES (Derived Unique Key Per Transaction) algorithm.
    /// Encoded/decoded by serializers as &quot;DKAE&quot;.
    /// </summary>
    [EnumMember(Value = "DKAE")]
    [IsoId("_ZIEoAFWaEeeiG_nL4vgKnQ")]
    [Description(@"DUKPT AES (Derived Unique Key Per Transaction) algorithm.")]
    DUKPTAES,
    
    /// <summary>
    /// UKPT (Unique Key Per Transaction). Encryption key using Triple DES for encryption with a double length key (112 bits). FIPS PUB 46-3.
    /// Encoded/decoded by serializers as &quot;UKPT&quot;.
    /// </summary>
    [EnumMember(Value = "UKPT")]
    [IsoId("_lPyAsFWaEeeiG_nL4vgKnQ")]
    [Description(@"UKPT (Unique Key Per Transaction). Encryption key using Triple DES for encryption with a double length key (112 bits). FIPS PUB 46-3.")]
    UKPT,
    
    /// <summary>
    /// UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a 128 bits length key. 
    /// FIPS 197 - 6 November 2001).
    /// Encoded/decoded by serializers as &quot;UKA8&quot;.
    /// </summary>
    [EnumMember(Value = "UKA8")]
    [IsoId("_5CcS4FWaEeeiG_nL4vgKnQ")]
    [Description(@"UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a 128 bits length key. |FIPS 197 - 6 November 2001).")]
    UKPTAES128,
    
    /// <summary>
    /// UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a  256 bits length key. 
    /// FIPS 197 - 6 November 2001).
    /// Encoded/decoded by serializers as &quot;UKA6&quot;.
    /// </summary>
    [EnumMember(Value = "UKA6")]
    [IsoId("_ZVWZkFWbEeeiG_nL4vgKnQ")]
    [Description(@"UKPT (Unique Key Per Transaction). Encryption key using AES (Advanced Encryption Standard) with a  256 bits length key. |FIPS 197 - 6 November 2001).")]
    UKPTAES256,
    
    /// <summary>
    /// ISO 20038 - Banking and related financial services - Key wrap using symmetric keys. Method using symmetric keys as the wrapping algorithm.
    /// Encoded/decoded by serializers as &quot;ISKW&quot;.
    /// </summary>
    [EnumMember(Value = "ISKW")]
    [IsoId("_T5QsINaDEeeA4_YxLuyJaA")]
    [Description(@"ISO 20038 - Banking and related financial services - Key wrap using symmetric keys. Method using symmetric keys as the wrapping algorithm.")]
    ISO20038KeyWrap,
    
}
