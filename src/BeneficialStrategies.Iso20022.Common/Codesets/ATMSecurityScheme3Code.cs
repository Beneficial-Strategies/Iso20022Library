// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security scheme in activation on the ATM for the host manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ps-QMV2VEeekzJIz1JxYSQ")]
[Description(@"Key exchange security scheme in activation on the ATM for the host manager.")]
[DerivedFrom(typeof(ATMSecuritySchemeCode))]
public enum ATMSecurityScheme3Code
{
    /// <summary>
    /// Application key download protected by a share symmetric key.
    /// Encoded/decoded by serializers as &quot;APPK&quot;.
    /// </summary>
    [EnumMember(Value = "APPK")]
    [IsoId("_P2UZcV2VEeekzJIz1JxYSQ")]
    [Description(@"Application key download protected by a share symmetric key.")]
    ApplicationRemoteKeyLoading = ATMSecuritySchemeCode.ApplicationRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a certificate.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_P2UZc12VEeekzJIz1JxYSQ")]
    [Description(@"Key download protected by asymmetric keys authenticated by a certificate.")]
    CertificateRemoteKeyLoading = ATMSecuritySchemeCode.CertificateRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the French ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;FRAN&quot;.
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_P2UZdV2VEeekzJIz1JxYSQ")]
    [Description(@"Key download conform to the French ATM key download security scheme.")]
    FrenchRemoteKeyLoading = ATMSecuritySchemeCode.FrenchRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the German ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_P2UZd12VEeekzJIz1JxYSQ")]
    [Description(@"Key download conform to the German ATM key download security scheme.")]
    GermanRemoteKeyLoading = ATMSecuritySchemeCode.GermanRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the Luxemburg ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;LUXG&quot;.
    /// </summary>
    [EnumMember(Value = "LUXG")]
    [IsoId("_P2UZeV2VEeekzJIz1JxYSQ")]
    [Description(@"Key download conform to the Luxemburg ATM key download security scheme.")]
    LuxemburgRemoteKeyLoading = ATMSecuritySchemeCode.LuxemburgRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual key entry on the ATM.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_P2UZe12VEeekzJIz1JxYSQ")]
    [Description(@"Manual key entry on the ATM.")]
    ManualKeyEntry = ATMSecuritySchemeCode.ManualKeyEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).
    /// Encoded/decoded by serializers as &quot;PKIP&quot;.
    /// </summary>
    [EnumMember(Value = "PKIP")]
    [IsoId("_P2UZfV2VEeekzJIz1JxYSQ")]
    [Description(@"Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).")]
    PKIKeyDownload = ATMSecuritySchemeCode.PKIKeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a digital signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_P2UZf12VEeekzJIz1JxYSQ")]
    [Description(@"Key download protected by asymmetric keys authenticated by a digital signature.")]
    SignatureRemoteKeyLoading = ATMSecuritySchemeCode.SignatureRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No key exchange performed, no security scheme defined.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_P2UZgV2VEeekzJIz1JxYSQ")]
    [Description(@"No key exchange performed, no security scheme defined.")]
    Unitialised = ATMSecuritySchemeCode.Unitialised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ANSI X9 TR34 2012 scheme for the distribution of the symmetric public keys and the initial master key.
    /// Encoded/decoded by serializers as &quot;TR34&quot;.
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_RJAJUV2VEeekzJIz1JxYSQ")]
    [Description(@"ANSI X9 TR34 2012 scheme for the distribution of the symmetric public keys and the initial master key.")]
    TR34 = ATMSecuritySchemeCode.TR34, // same ordinal as derivation source for type conversions
    
}
