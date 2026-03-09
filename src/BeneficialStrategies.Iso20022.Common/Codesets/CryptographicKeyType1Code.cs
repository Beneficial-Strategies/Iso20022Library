// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of algorithm used by the cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KU0vhH1DEeCF8NjrBemJWQ_-221293967")]
[Description(@"Type of algorithm used by the cryptographic key.")]
[DerivedFrom(typeof(CryptographicKeyTypeCode))]
public enum CryptographicKeyType1Code
{
    /// <summary>
    /// Data encryption standard.
    /// Encoded/decoded by serializers as &quot;DESC&quot;.
    /// </summary>
    [EnumMember(Value = "DESC")]
    [IsoId("_KU0vhX1DEeCF8NjrBemJWQ_2128463419")]
    [Description(@"Data encryption standard.")]
    DES = CryptographicKeyTypeCode.DES, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advanced encryption standard.
    /// Encoded/decoded by serializers as &quot;AESC&quot;.
    /// </summary>
    [EnumMember(Value = "AESC")]
    [IsoId("_KU0vhn1DEeCF8NjrBemJWQ_-2088353466")]
    [Description(@"Advanced encryption standard.")]
    AES = CryptographicKeyTypeCode.AES, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rivest, Shamir and Adleman.
    /// Encoded/decoded by serializers as &quot;RSAC&quot;.
    /// </summary>
    [EnumMember(Value = "RSAC")]
    [IsoId("_KU0vh31DEeCF8NjrBemJWQ_-1222392590")]
    [Description(@"Rivest, Shamir and Adleman.")]
    RSA = CryptographicKeyTypeCode.RSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Elliptic-curve cryptography.
    /// Encoded/decoded by serializers as &quot;ECCC&quot;.
    /// </summary>
    [EnumMember(Value = "ECCC")]
    [IsoId("_KU0viH1DEeCF8NjrBemJWQ_-505240776")]
    [Description(@"Elliptic-curve cryptography.")]
    ECC = CryptographicKeyTypeCode.ECC, // same ordinal as derivation source for type conversions
    
}
