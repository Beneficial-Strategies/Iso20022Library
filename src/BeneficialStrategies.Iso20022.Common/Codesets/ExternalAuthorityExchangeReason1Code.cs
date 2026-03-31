// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority, as published in an external category purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_M_Hh4J26Eeuwmdq0KtnICg")]
[Description(
    @"Specifies the reason for the exchange with the national competent authority, as published in an external category purpose code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalAuthorityExchangeReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAuthorityExchangeReason1Code>))]
#endif
public enum ExternalAuthorityExchangeReason1Code
{
    /// <summary>
    /// Ad hoc request.
    /// Encoded/decoded by serializers as &quot;ADHR&quot;.
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_uzf8hfRYEeuLhpyIdtJzwg")]
    [Description(@"Ad hoc request.")]
    AdHocRequest = ExternalAuthorityExchangeReasonCode.AdHocRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as &quot;CABB&quot;.
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_uzf8iPRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForBuyerBranch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Basket Constituant.
    /// Encoded/decoded by serializers as &quot;CABC&quot;.
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_uzf8i_RYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Basket Constituant.")]
    CompetentAuthorityForBasketConstituant =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForBasketConstituant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Buyer Transmitting Firm.
    /// Encoded/decoded by serializers as &quot;CABT&quot;.
    /// </summary>
    [EnumMember(Value = "CABT")]
    [IsoId("_uzpGcvRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Buyer Transmitting Firm.")]
    CompetentAuthorityForBuyerTransmittingFirm =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForBuyerTransmittingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_uzpGdfRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForDecisionMakingBranch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as &quot;CADU&quot;.
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_uzpGePRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForDirectUnderlying, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as &quot;CAEB&quot;.
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_uzpGe_RYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForExecutingBranch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Instrument.
    /// Encoded/decoded by serializers as &quot;CAFI&quot;.
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_uzy3cvRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as &quot;CAIX&quot;.
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_uzy3dfRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex = ExternalAuthorityExchangeReasonCode.CompetentAuthorityForIndex, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as &quot;CAMB&quot;.
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_uz8ocvRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForMembershipBranch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as &quot;CASB&quot;.
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_uz8odfRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForSellerBranch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Seller Transmitting Firm.
    /// Encoded/decoded by serializers as &quot;CAST&quot;.
    /// </summary>
    [EnumMember(Value = "CAST")]
    [IsoId("_uz8oePRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Seller Transmitting Firm.")]
    CompetentAuthorityForSellerTransmittingFirm =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForSellerTransmittingFirm, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as &quot;CATV&quot;.
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_uz8oe_RYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue =
        ExternalAuthorityExchangeReasonCode.CompetentAuthorityForTradingVenue, // same ordinal as derivation source for type conversions
}
