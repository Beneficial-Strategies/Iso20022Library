// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YchP0B5REeWc9bJOIIhUUw")]
[Description(@"Specifies the reason for the exchange with the national competent authority.")]
[Derivations(typeof(AuthorityExchangeReason1Code))]
public enum AuthorityExchangeReasonCode
{
    /// <summary>
    /// Competent Authority for Instrument.
    /// Encoded/decoded by serializers as &quot;CAFI&quot;.
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_bi05cB5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument,

    /// <summary>
    /// Competent Authority for Headquarter.
    /// Encoded/decoded by serializers as &quot;CAFH&quot;.
    /// </summary>
    [EnumMember(Value = "CAFH")]
    [IsoId("_fYwCIB5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Headquarter.")]
    CompetentAuthorityForHeadquarter,

    /// <summary>
    /// Ad Hoc Request.
    /// Encoded/decoded by serializers as &quot;ADHR&quot;.
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_jtnwoB5REeWc9bJOIIhUUw")]
    [Description(@"Ad Hoc Request.")]
    AdHocRequest,

    /// <summary>
    /// Where reason code is not previously defined.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_o3J2QB5REeWc9bJOIIhUUw")]
    [Description(@"Where reason code is not previously defined.")]
    Other,

    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as &quot;CADU&quot;.
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_YdD3IDCAEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying,

    /// <summary>
    /// Competent Authority for Basket Constituent.
    /// Encoded/decoded by serializers as &quot;CABC&quot;.
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_5DU-sDCAEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Basket Constituent.")]
    CompetentAuthorityForBasketConstituent,

    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as &quot;CABB&quot;.
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_CjK9QDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch,

    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as &quot;CASB&quot;.
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_IT9QIDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch,

    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as &quot;CAMB&quot;.
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_L6n00DCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch,

    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_P67okDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch,

    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as &quot;CAEB&quot;.
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_VJYDYDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch,

    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as &quot;CATV&quot;.
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_fTfuADCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue,

    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as &quot;CAIX&quot;.
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_kv9WsDCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex,
}
