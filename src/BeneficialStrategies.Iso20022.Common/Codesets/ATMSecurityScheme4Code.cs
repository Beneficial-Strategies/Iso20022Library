// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security schemes implemented in the hardware security module of the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bbRtkV2ZEeekzJIz1JxYSQ")]
[Description(
    @"Key exchange security schemes implemented in the hardware security module of the ATM."
)]
[DerivedFrom(typeof(ATMSecuritySchemeCode))]
public enum ATMSecurityScheme4Code
{
    /// <summary>
    /// Application key download protected by a share symmetric key.
    /// Encoded/decoded by serializers as &quot;APPK&quot;.
    /// </summary>
    [EnumMember(Value = "APPK")]
    [IsoId("_bkJVsV2ZEeekzJIz1JxYSQ")]
    [Description(@"Application key download protected by a share symmetric key.")]
    ApplicationRemoteKeyLoading = ATMSecuritySchemeCode.ApplicationRemoteKeyLoading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a certificate.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bkJVs12ZEeekzJIz1JxYSQ")]
    [Description(@"Key download protected by asymmetric keys authenticated by a certificate.")]
    CertificateRemoteKeyLoading = ATMSecuritySchemeCode.CertificateRemoteKeyLoading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key download conform to the French ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;FRAN&quot;.
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_bkJVtV2ZEeekzJIz1JxYSQ")]
    [Description(@"Key download conform to the French ATM key download security scheme.")]
    FrenchRemoteKeyLoading = ATMSecuritySchemeCode.FrenchRemoteKeyLoading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key download conform to the German ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;DTCH&quot;.
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_bkJVt12ZEeekzJIz1JxYSQ")]
    [Description(@"Key download conform to the German ATM key download security scheme.")]
    GermanRemoteKeyLoading = ATMSecuritySchemeCode.GermanRemoteKeyLoading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key download conform to the Luxemburg ATM key download security scheme.
    /// Encoded/decoded by serializers as &quot;LUXG&quot;.
    /// </summary>
    [EnumMember(Value = "LUXG")]
    [IsoId("_bkJVuV2ZEeekzJIz1JxYSQ")]
    [Description(@"Key download conform to the Luxemburg ATM key download security scheme.")]
    LuxemburgRemoteKeyLoading = ATMSecuritySchemeCode.LuxemburgRemoteKeyLoading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manual key entry on the ATM.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_bkJVu12ZEeekzJIz1JxYSQ")]
    [Description(@"Manual key entry on the ATM.")]
    ManualKeyEntry = ATMSecuritySchemeCode.ManualKeyEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).
    /// Encoded/decoded by serializers as &quot;PKIP&quot;.
    /// </summary>
    [EnumMember(Value = "PKIP")]
    [IsoId("_bkJVvV2ZEeekzJIz1JxYSQ")]
    [Description(
        @"Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure)."
    )]
    PKIKeyDownload = ATMSecuritySchemeCode.PKIKeyDownload, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a digital signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_bkJVv12ZEeekzJIz1JxYSQ")]
    [Description(
        @"Key download protected by asymmetric keys authenticated by a digital signature."
    )]
    SignatureRemoteKeyLoading = ATMSecuritySchemeCode.SignatureRemoteKeyLoading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ANSI X9 TR34 2012 scheme for the distribution of the symmetric public keys and the initial master key.
    /// Encoded/decoded by serializers as &quot;TR34&quot;.
    /// </summary>
    [EnumMember(Value = "TR34")]
    [IsoId("_c68wkV2ZEeekzJIz1JxYSQ")]
    [Description(
        @"ANSI X9 TR34 2012 scheme for the distribution of the symmetric public keys and the initial master key."
    )]
    TR34 = ATMSecuritySchemeCode.TR34, // same ordinal as derivation source for type conversions
}
