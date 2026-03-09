// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security scheme in activation on the ATM for the host manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SATuUIr5EeSvuOJS0mmL0g")]
[Description(@"Key exchange security scheme in activation on the ATM for the host manager.")]
[DerivedFrom(typeof(ATMSecuritySchemeCode))]
public enum ATMSecurityScheme1Code
{
    /// <summary>
    /// Application key download protected by a share symmetric key.
    /// Encoded/decoded by serializers as &quot;APPK&quot;.
    /// </summary>
    [EnumMember(Value = "APPK")]
    [IsoId("_YwVQoYr5EeSvuOJS0mmL0g")]
    [Description(@"Application key download protected by a share symmetric key.")]
    ApplicationRemoteKeyLoading = ATMSecuritySchemeCode.ApplicationRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a certificate.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_Y5_i84r5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a certificate.")]
    CertificateRemoteKeyLoading = ATMSecuritySchemeCode.CertificateRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the French ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;FRAN&quot;.
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_Y_cDoYr5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the French ATM key download security scheme.")]
    FrenchRemoteKeyLoading = ATMSecuritySchemeCode.FrenchRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the German ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_ZF9iY4r5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the German ATM key download security scheme.")]
    GermanRemoteKeyLoading = ATMSecuritySchemeCode.GermanRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the Luxemburg ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;LUXG&quot;.
    /// </summary>
    [EnumMember(Value = "LUXG")]
    [IsoId("_ZK00QYr5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the Luxemburg ATM key download security scheme.")]
    LuxemburgRemoteKeyLoading = ATMSecuritySchemeCode.LuxemburgRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual key entry on the ATM.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_ZQxEMYr5EeSvuOJS0mmL0g")]
    [Description(@"Manual key entry on the ATM.")]
    ManualKeyEntry = ATMSecuritySchemeCode.ManualKeyEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).
    /// Encoded/decoded by serializers as &quot;PKIP&quot;.
    /// </summary>
    [EnumMember(Value = "PKIP")]
    [IsoId("_ZZuy84r5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).")]
    PKIKeyDownload = ATMSecuritySchemeCode.PKIKeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a digital signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_ZfmKY4r5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a digital signature.")]
    SignatureRemoteKeyLoading = ATMSecuritySchemeCode.SignatureRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No key exchange performed, no security scheme defined.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ZinCIYr5EeSvuOJS0mmL0g")]
    [Description(@"No key exchange performed, no security scheme defined.")]
    Unitialised = ATMSecuritySchemeCode.Unitialised, // same ordinal as derivation source for type conversions
    
}
