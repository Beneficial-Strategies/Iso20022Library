// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security scheme on an ATM for the host manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zqg0kIr4EeSvuOJS0mmL0g")]
[Description(@"Key exchange security scheme on an ATM for the host manager.")]
[Derivations(typeof(ATMSecurityScheme2Code),typeof(ATMSecurityScheme1Code),typeof(ATMSecurityScheme3Code),typeof(ATMSecurityScheme4Code))]
public enum ATMSecuritySchemeCode
{
    /// <summary>
    /// Application key download protected by a share symmetric key.
    /// Encoded/decoded by serializers as &quot;APPK&quot;.
    /// </summary>
    [EnumMember(Value = "APPK")]
    [IsoId("_2y_BYIr4EeSvuOJS0mmL0g")]
    [Description(@"Application key download protected by a share symmetric key.")]
    ApplicationRemoteKeyLoading,
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a certificate.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_64v84Ir4EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a certificate.")]
    CertificateRemoteKeyLoading,
    
    /// <summary>
    /// Key download conform to the German ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_84iqYIr4EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the German ATM key download security scheme.")]
    GermanRemoteKeyLoading,
    
    /// <summary>
    /// Key download conform to the French ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;FRAN&quot;.
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_ADx3UIr5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the French ATM key download security scheme.")]
    FrenchRemoteKeyLoading,
    
    /// <summary>
    /// Key download conform to the Luxemburg ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;LUXG&quot;.
    /// </summary>
    [EnumMember(Value = "LUXG")]
    [IsoId("_B-nMUIr5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the Luxemburg ATM key download security scheme.")]
    LuxemburgRemoteKeyLoading,
    
    /// <summary>
    /// Manual key entry on the ATM.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_EboBUIr5EeSvuOJS0mmL0g")]
    [Description(@"Manual key entry on the ATM.")]
    ManualKeyEntry,
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).
    /// Encoded/decoded by serializers as &quot;PKIP&quot;.
    /// </summary>
    [EnumMember(Value = "PKIP")]
    [IsoId("_GVshUIr5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).")]
    PKIKeyDownload,
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a digital signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_I-nEUIr5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a digital signature.")]
    SignatureRemoteKeyLoading,
    
    /// <summary>
    /// No key exchange performed, no security scheme defined.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_K6-qYIr5EeSvuOJS0mmL0g")]
    [Description(@"No key exchange performed, no security scheme defined.")]
    Unitialised,
    
    /// <summary>
    /// ANSI X9 TR34 2012 scheme for the distribution of the symmetric public keys and the initial master key.
    /// Encoded/decoded by serializers as &quot;TR34&quot;.
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_NHQnoF2UEeekzJIz1JxYSQ")]
    [Description(@"ANSI X9 TR34 2012 scheme for the distribution of the symmetric public keys and the initial master key.")]
    TR34,
    
}
