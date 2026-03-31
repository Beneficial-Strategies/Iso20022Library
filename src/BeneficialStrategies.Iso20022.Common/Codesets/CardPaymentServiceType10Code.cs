// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Requested certificate management service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sFQTwI4MEeW6h7rGyYlyTg")]
[Description(@"Requested certificate management service.")]
[DerivedFrom(typeof(CardPaymentServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardPaymentServiceType10Code>))]
#endif
public enum CardPaymentServiceType10Code
{
    /// <summary>
    /// Creation of an X.509 certificate with the public key and the information of the owner of the asymmetric key provided by the requestor.
    /// Encoded/decoded by serializers as &quot;CRTC&quot;.
    /// </summary>
    [EnumMember(Value = "CRTC")]
    [IsoId("_wguZgY4MEeW6h7rGyYlyTg")]
    [Description(
        @"Creation of an X.509 certificate with the public key and the information of the owner of the asymmetric key provided by the requestor."
    )]
    CreateCertificate = CardPaymentServiceTypeCode.CreateCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Renewal of an X.509 certificate, protected by the certificate to renew.
    /// Encoded/decoded by serializers as &quot;CRTR&quot;.
    /// </summary>
    [EnumMember(Value = "CRTR")]
    [IsoId("_xQaKA44MEeW6h7rGyYlyTg")]
    [Description(@"Renewal of an X.509 certificate, protected by the certificate to renew.")]
    RenewCerificate = CardPaymentServiceTypeCode.RenewCerificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Revocation of an active X.509 certificate.
    /// Encoded/decoded by serializers as &quot;CRTK&quot;.
    /// </summary>
    [EnumMember(Value = "CRTK")]
    [IsoId("_yQQdc44MEeW6h7rGyYlyTg")]
    [Description(@"Revocation of an active X.509 certificate.")]
    RevokeCertificate = CardPaymentServiceTypeCode.RevokeCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Remove a POI from the white list of the terminal manager.
    /// Encoded/decoded by serializers as &quot;WLSR&quot;.
    /// </summary>
    [EnumMember(Value = "WLSR")]
    [IsoId("_zIS4s44MEeW6h7rGyYlyTg")]
    [Description(@"Remove a POI from the white list of the terminal manager.")]
    RemoveWhiteList = CardPaymentServiceTypeCode.RemoveWhiteList, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Add a POI in the white list of the terminal manager.
    /// Encoded/decoded by serializers as &quot;WLSA&quot;.
    /// </summary>
    [EnumMember(Value = "WLSA")]
    [IsoId("_znLNE44MEeW6h7rGyYlyTg")]
    [Description(@"Add a POI in the white list of the terminal manager.")]
    AddWhiteList = CardPaymentServiceTypeCode.AddWhiteList, // same ordinal as derivation source for type conversions
}
