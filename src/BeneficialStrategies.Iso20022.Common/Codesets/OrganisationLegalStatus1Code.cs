// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a legal entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JqD2wH6rEeePx-IqKegQ8Q")]
[Description(@"Specifies the status of a legal entity.")]
[DerivedFrom(typeof(OrganisationLegalStatusCode))]
public enum OrganisationLegalStatus1Code
{
    /// <summary>
    /// Charitable incorporated organisation (CIO)
    /// Encoded/decoded by serializers as &quot;CIOC&quot;.
    /// </summary>
    [EnumMember(Value = "CIOC")]
    [IsoId("_TbNnwX6rEeePx-IqKegQ8Q")]
    [Description(@"Charitable incorporated organisation (CIO)")]
    CharitableIncorporatedOrganisation = OrganisationLegalStatusCode.CharitableIncorporatedOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charity
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_Ti8ncX6rEeePx-IqKegQ8Q")]
    [Description(@"Charity")]
    Charity = OrganisationLegalStatusCode.Charity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Community Interest Company (CIC)
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_To5ecX6rEeePx-IqKegQ8Q")]
    [Description(@"Community Interest Company (CIC)")]
    CommunityInterestCompany = OrganisationLegalStatusCode.CommunityInterestCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// General partnership
    /// Encoded/decoded by serializers as &quot;GENP&quot;.
    /// </summary>
    [EnumMember(Value = "GENP")]
    [IsoId("_T0zMcX6rEeePx-IqKegQ8Q")]
    [Description(@"General partnership")]
    GeneralPartnership = OrganisationLegalStatusCode.GeneralPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// For example a co-operative, which does include Ltd. or charity.
    /// Encoded/decoded by serializers as &quot;IAPS&quot;.
    /// </summary>
    [EnumMember(Value = "IAPS")]
    [IsoId("_T7fqUX6rEeePx-IqKegQ8Q")]
    [Description(@"For example a co-operative, which does include Ltd. or charity.")]
    IndustrialAndProvidentSociety = OrganisationLegalStatusCode.IndustrialAndProvidentSociety, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limited liability partnership (LLP)
    /// Encoded/decoded by serializers as &quot;LLPP&quot;.
    /// </summary>
    [EnumMember(Value = "LLPP")]
    [IsoId("_UDE5AX6rEeePx-IqKegQ8Q")]
    [Description(@"Limited liability partnership (LLP)")]
    LimitedLiabilityPartnership = OrganisationLegalStatusCode.LimitedLiabilityPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Private company limited by guarantee (Ltd.)
    /// Encoded/decoded by serializers as &quot;PCLG&quot;.
    /// </summary>
    [EnumMember(Value = "PCLG")]
    [IsoId("_UI4mEX6rEeePx-IqKegQ8Q")]
    [Description(@"Private company limited by guarantee (Ltd.)")]
    PrivateCompanyLimitedByGuarantee = OrganisationLegalStatusCode.PrivateCompanyLimitedByGuarantee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limited partnership (LP)
    /// Encoded/decoded by serializers as &quot;LIMP&quot;.
    /// </summary>
    [EnumMember(Value = "LIMP")]
    [IsoId("_UUCtMX6rEeePx-IqKegQ8Q")]
    [Description(@"Limited partnership (LP)")]
    LimitedPartnership = OrganisationLegalStatusCode.LimitedPartnership, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Private company limited by shares (Ltd.)
    /// Encoded/decoded by serializers as &quot;PCLS&quot;.
    /// </summary>
    [EnumMember(Value = "PCLS")]
    [IsoId("_UkQTcX6rEeePx-IqKegQ8Q")]
    [Description(@"Private company limited by shares (Ltd.)")]
    PrivateCompanyLimitedByShares = OrganisationLegalStatusCode.PrivateCompanyLimitedByShares, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Public limited company (Plc.)
    /// Encoded/decoded by serializers as &quot;PCLC&quot;.
    /// </summary>
    [EnumMember(Value = "PCLC")]
    [IsoId("_UqW7cX6rEeePx-IqKegQ8Q")]
    [Description(@"Public limited company (Plc.)")]
    PublicLimitedCompany = OrganisationLegalStatusCode.PublicLimitedCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sole proprietorship/Sole trader
    /// Encoded/decoded by serializers as &quot;SOLE&quot;.
    /// </summary>
    [EnumMember(Value = "SOLE")]
    [IsoId("_UxWUQX6rEeePx-IqKegQ8Q")]
    [Description(@"Sole proprietorship/Sole trader")]
    SoleProprietorship = OrganisationLegalStatusCode.SoleProprietorship, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unlimited company
    /// Encoded/decoded by serializers as &quot;UNLC&quot;.
    /// </summary>
    [EnumMember(Value = "UNLC")]
    [IsoId("_U3JaQX6rEeePx-IqKegQ8Q")]
    [Description(@"Unlimited company")]
    UnlimitedCompany = OrganisationLegalStatusCode.UnlimitedCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unlimited trust
    /// Encoded/decoded by serializers as &quot;UNLT&quot;.
    /// </summary>
    [EnumMember(Value = "UNLT")]
    [IsoId("_U89HUX6rEeePx-IqKegQ8Q")]
    [Description(@"Unlimited trust")]
    UnlimitedTrust = OrganisationLegalStatusCode.UnlimitedTrust, // same ordinal as derivation source for type conversions
    
}
