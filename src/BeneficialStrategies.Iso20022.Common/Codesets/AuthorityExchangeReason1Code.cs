// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the exchange with the national competent authority.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nq1NEB5REeWc9bJOIIhUUw")]
[Description(@"Specifies the reason for the exchange with the national competent authority.")]
[DerivedFrom(typeof(AuthorityExchangeReasonCode))]
public enum AuthorityExchangeReason1Code
{
    /// <summary>
    /// Competent Authority for Instrument.
    /// Encoded/decoded by serializers as &quot;CAFI&quot;.
    /// </summary>
    [EnumMember(Value = "CAFI")]
    [IsoId("_rlz04R5REeWc9bJOIIhUUw")]
    [Description(@"Competent Authority for Instrument.")]
    CompetentAuthorityForInstrument = AuthorityExchangeReasonCode.CompetentAuthorityForInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ad Hoc Request.
    /// Encoded/decoded by serializers as &quot;ADHR&quot;.
    /// </summary>
    [EnumMember(Value = "ADHR")]
    [IsoId("_5imKETB_EeWZkK_S04LJWA")]
    [Description(@"Ad Hoc Request.")]
    AdHocRequest = AuthorityExchangeReasonCode.AdHocRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Basket Constituent.
    /// Encoded/decoded by serializers as &quot;CABC&quot;.
    /// </summary>
    [EnumMember(Value = "CABC")]
    [IsoId("_0HVJUTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Basket Constituent.")]
    CompetentAuthorityForBasketConstituent = AuthorityExchangeReasonCode.CompetentAuthorityForBasketConstituent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Buyer Branch.
    /// Encoded/decoded by serializers as &quot;CABB&quot;.
    /// </summary>
    [EnumMember(Value = "CABB")]
    [IsoId("_0P8SwTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Buyer Branch.")]
    CompetentAuthorityForBuyerBranch = AuthorityExchangeReasonCode.CompetentAuthorityForBuyerBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Decision Making Branch.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_0UjtATCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Decision Making Branch.")]
    CompetentAuthorityForDecisionMakingBranch = AuthorityExchangeReasonCode.CompetentAuthorityForDecisionMakingBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Direct Underlying.
    /// Encoded/decoded by serializers as &quot;CADU&quot;.
    /// </summary>
    [EnumMember(Value = "CADU")]
    [IsoId("_0Z4R4TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Direct Underlying.")]
    CompetentAuthorityForDirectUnderlying = AuthorityExchangeReasonCode.CompetentAuthorityForDirectUnderlying, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Executing Branch.
    /// Encoded/decoded by serializers as &quot;CAEB&quot;.
    /// </summary>
    [EnumMember(Value = "CAEB")]
    [IsoId("_0eg6QTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Executing Branch.")]
    CompetentAuthorityForExecutingBranch = AuthorityExchangeReasonCode.CompetentAuthorityForExecutingBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Index.
    /// Encoded/decoded by serializers as &quot;CAIX&quot;.
    /// </summary>
    [EnumMember(Value = "CAIX")]
    [IsoId("_09euMTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Index.")]
    CompetentAuthorityForIndex = AuthorityExchangeReasonCode.CompetentAuthorityForIndex, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Membership Branch.
    /// Encoded/decoded by serializers as &quot;CAMB&quot;.
    /// </summary>
    [EnumMember(Value = "CAMB")]
    [IsoId("_1I3e0TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Membership Branch.")]
    CompetentAuthorityForMembershipBranch = AuthorityExchangeReasonCode.CompetentAuthorityForMembershipBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Seller Branch.
    /// Encoded/decoded by serializers as &quot;CASB&quot;.
    /// </summary>
    [EnumMember(Value = "CASB")]
    [IsoId("_1NgHMTCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Seller Branch.")]
    CompetentAuthorityForSellerBranch = AuthorityExchangeReasonCode.CompetentAuthorityForSellerBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Competent Authority for Trading Venue.
    /// Encoded/decoded by serializers as &quot;CATV&quot;.
    /// </summary>
    [EnumMember(Value = "CATV")]
    [IsoId("_1UxM0TCBEeWCk5pWnqPoYw")]
    [Description(@"Competent Authority for Trading Venue.")]
    CompetentAuthorityForTradingVenue = AuthorityExchangeReasonCode.CompetentAuthorityForTradingVenue, // same ordinal as derivation source for type conversions
    
}
