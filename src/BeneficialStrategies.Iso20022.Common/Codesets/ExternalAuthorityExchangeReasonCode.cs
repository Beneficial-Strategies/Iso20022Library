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
[IsoId("_DkNtsJ26Eeuwmdq0KtnICg")]
[Description(
    @"Specifies the reason for the exchange with the national competent authority, as published in an external category purpose code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalAuthorityExchangeReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAuthorityExchangeReasonCode>))]
#endif
public enum ExternalAuthorityExchangeReasonCode
{
    /// <summary>
    /// Ad hoc request.
    /// Encoded/decoded by serializers as &quot;ADHR&quot;.
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_uzf8g_RYEeuLhpyIdtJzwg")]
    [Description(@"Ad hoc request.")]
    AdHocRequest,

    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as &quot;CABB&quot;.
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_uzf8hvRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch,

    /// <summary>
    /// Competent Authority for Basket Constituant.
    /// Encoded/decoded by serializers as &quot;CABC&quot;.
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_uzf8ifRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Basket Constituant.")]
    CompetentAuthorityForBasketConstituant,

    /// <summary>
    /// Competent Authority for Buyer Transmitting Firm.
    /// Encoded/decoded by serializers as &quot;CABT&quot;.
    /// </summary>
    [EnumMember(Value = "CABT")]
    [IsoId("_uzpGcPRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Buyer Transmitting Firm.")]
    CompetentAuthorityForBuyerTransmittingFirm,

    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_uzpGc_RYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch,

    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as &quot;CADU&quot;.
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_uzpGdvRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying,

    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as &quot;CAEB&quot;.
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_uzpGefRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch,

    /// <summary>
    /// Competent Authority for Instrument.
    /// Encoded/decoded by serializers as &quot;CAFI&quot;.
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_uzy3cPRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument,

    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as &quot;CAIX&quot;.
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_uzy3c_RYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex,

    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as &quot;CAMB&quot;.
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_uz8ocPRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch,

    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as &quot;CASB&quot;.
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_uz8oc_RYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch,

    /// <summary>
    /// Competent Authority for Seller Transmitting Firm.
    /// Encoded/decoded by serializers as &quot;CAST&quot;.
    /// </summary>
    [EnumMember(Value = "CAST")]
    [IsoId("_uz8odvRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Seller Transmitting Firm.")]
    CompetentAuthorityForSellerTransmittingFirm,

    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as &quot;CATV&quot;.
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_uz8oefRYEeuLhpyIdtJzwg")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue,
}
