// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the Cardholder verification address checks on the street number and the Postal Code from the Cardholder&apos;s Address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSXNegEcEeCQm6a_G2yO_w_859983869")]
[Description(
    @"Result of the Cardholder verification address checks on the street number and the Postal Code from the Cardholder's Address."
)]
[DerivedFrom(typeof(CardholderAddressVerificationResultCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardholderAddressVerificationResult1Code>))]
#endif
public enum CardholderAddressVerificationResult1Code
{
    /// <summary>
    /// Address numeric match.
    /// Encoded/decoded by serializers as &quot;AMCH&quot;.
    /// </summary>
    [EnumMember(Value = "AMCH")]
    [IsoId("_TSXNewEcEeCQm6a_G2yO_w_-1881917421")]
    [Description(@"Address numeric match.")]
    AddressMatch = CardholderAddressVerificationResultCode.AddressMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address numerics do not match.
    /// Encoded/decoded by serializers as &quot;ANMH&quot;.
    /// </summary>
    [EnumMember(Value = "ANMH")]
    [IsoId("_TSXNfAEcEeCQm6a_G2yO_w_-2071134870")]
    [Description(@"Address numerics do not match.")]
    AddressNotMatch = CardholderAddressVerificationResultCode.AddressNotMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address numeric not processed for technical reason.
    /// Encoded/decoded by serializers as &quot;ANMT&quot;.
    /// </summary>
    [EnumMember(Value = "ANMT")]
    [IsoId("_TSXNfQEcEeCQm6a_G2yO_w_-133909697")]
    [Description(@"Address numeric not processed for technical reason.")]
    AddressTechnical = CardholderAddressVerificationResultCode.AddressTechnical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address numeric not processed for non-technical reason.
    /// Encoded/decoded by serializers as &quot;ANMO&quot;.
    /// </summary>
    [EnumMember(Value = "ANMO")]
    [IsoId("_TSXNfgEcEeCQm6a_G2yO_w_-656898248")]
    [Description(@"Address numeric not processed for non-technical reason.")]
    AddressNotTechnical = CardholderAddressVerificationResultCode.AddressNotTechnical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address numeric missing in request.
    /// Encoded/decoded by serializers as &quot;AMSS&quot;.
    /// </summary>
    [EnumMember(Value = "AMSS")]
    [IsoId("_TSXNfwEcEeCQm6a_G2yO_w_1280326925")]
    [Description(@"Address numeric missing in request.")]
    AddressMissing = CardholderAddressVerificationResultCode.AddressMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address numeric not used by issuer.
    /// Encoded/decoded by serializers as &quot;ANUS&quot;.
    /// </summary>
    [EnumMember(Value = "ANUS")]
    [IsoId("_TSXNgAEcEeCQm6a_G2yO_w_-694884291")]
    [Description(@"Address numeric not used by issuer.")]
    AddressNotUsed = CardholderAddressVerificationResultCode.AddressNotUsed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal code matches.
    /// Encoded/decoded by serializers as &quot;PMCH&quot;.
    /// </summary>
    [EnumMember(Value = "PMCH")]
    [IsoId("_TSXNgQEcEeCQm6a_G2yO_w_1242340882")]
    [Description(@"Postal code matches.")]
    PostalMatch = CardholderAddressVerificationResultCode.PostalMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal code does not match.
    /// Encoded/decoded by serializers as &quot;PNMH&quot;.
    /// </summary>
    [EnumMember(Value = "PNMH")]
    [IsoId("_TSXNggEcEeCQm6a_G2yO_w_-1449634165")]
    [Description(@"Postal code does not match.")]
    PostalNotMatch = CardholderAddressVerificationResultCode.PostalNotMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal code not processed for technical reason.
    /// Encoded/decoded by serializers as &quot;PNMT&quot;.
    /// </summary>
    [EnumMember(Value = "PNMT")]
    [IsoId("_TSg-cAEcEeCQm6a_G2yO_w_487591008")]
    [Description(@"Postal code not processed for technical reason.")]
    PostalTechnical = CardholderAddressVerificationResultCode.PostalTechnical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal code not processed for non-technical reason.
    /// Encoded/decoded by serializers as &quot;PNMO&quot;.
    /// </summary>
    [EnumMember(Value = "PNMO")]
    [IsoId("_TSg-cQEcEeCQm6a_G2yO_w_-2084666011")]
    [Description(@"Postal code not processed for non-technical reason.")]
    PostalNotTechnical = CardholderAddressVerificationResultCode.PostalNotTechnical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal code missing in request.
    /// Encoded/decoded by serializers as &quot;PMSS&quot;.
    /// </summary>
    [EnumMember(Value = "PMSS")]
    [IsoId("_TSg-cgEcEeCQm6a_G2yO_w_-147440838")]
    [Description(@"Postal code missing in request.")]
    PostalMissing = CardholderAddressVerificationResultCode.PostalMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal code not used by issuer.
    /// Encoded/decoded by serializers as &quot;PNUS&quot;.
    /// </summary>
    [EnumMember(Value = "PNUS")]
    [IsoId("_TSg-cwEcEeCQm6a_G2yO_w_-1006645673")]
    [Description(@"Postal code not used by issuer.")]
    PostalNotUsed = CardholderAddressVerificationResultCode.PostalNotUsed, // same ordinal as derivation source for type conversions
}
