// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a legal entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_L3FkYBE4EeafpqhYGpTDnw")]
[Description(@"Specifies the status of a legal entity.")]
[Derivations(typeof(OrganisationLegalStatus1Code))]
public enum OrganisationLegalStatusCode
{
    /// <summary>
    /// Unlimited trust
    /// Encoded/decoded by serializers as &quot;UNLT&quot;.
    /// </summary>
    [EnumMember(Value = "UNLT")]
    [IsoId("_T3gXkBE4EeafpqhYGpTDnw")]
    [Description(@"Unlimited trust")]
    UnlimitedTrust,

    /// <summary>
    /// Unlimited company
    /// Encoded/decoded by serializers as &quot;UNLC&quot;.
    /// </summary>
    [EnumMember(Value = "UNLC")]
    [IsoId("_WLVbYBE4EeafpqhYGpTDnw")]
    [Description(@"Unlimited company")]
    UnlimitedCompany,

    /// <summary>
    /// Sole proprietorship/Sole trader
    /// Encoded/decoded by serializers as &quot;SOLE&quot;.
    /// </summary>
    [EnumMember(Value = "SOLE")]
    [IsoId("_YLFFkBE4EeafpqhYGpTDnw")]
    [Description(@"Sole proprietorship/Sole trader")]
    SoleProprietorship,

    /// <summary>
    /// Public limited company (Plc.)
    /// Encoded/decoded by serializers as &quot;PCLC&quot;.
    /// </summary>
    [EnumMember(Value = "PCLC")]
    [IsoId("_bjMQ4BE4EeafpqhYGpTDnw")]
    [Description(@"Public limited company (Plc.)")]
    PublicLimitedCompany,

    /// <summary>
    /// Private company limited by shares (Ltd.)
    /// Encoded/decoded by serializers as &quot;PCLS&quot;.
    /// </summary>
    [EnumMember(Value = "PCLS")]
    [IsoId("_eVINABE4EeafpqhYGpTDnw")]
    [Description(@"Private company limited by shares (Ltd.)")]
    PrivateCompanyLimitedByShares,

    /// <summary>
    /// Private company limited by guarantee (Ltd.)
    /// Encoded/decoded by serializers as &quot;PCLG&quot;.
    /// </summary>
    [EnumMember(Value = "PCLG")]
    [IsoId("_gidAMBE4EeafpqhYGpTDnw")]
    [Description(@"Private company limited by guarantee (Ltd.)")]
    PrivateCompanyLimitedByGuarantee,

    /// <summary>
    /// Limited partnership (LP)
    /// Encoded/decoded by serializers as &quot;LIMP&quot;.
    /// </summary>
    [EnumMember(Value = "LIMP")]
    [IsoId("_jHB1wBE4EeafpqhYGpTDnw")]
    [Description(@"Limited partnership (LP)")]
    LimitedPartnership,

    /// <summary>
    /// Limited liability partnership (LLP)
    /// Encoded/decoded by serializers as &quot;LLPP&quot;.
    /// </summary>
    [EnumMember(Value = "LLPP")]
    [IsoId("_lpZr4BE4EeafpqhYGpTDnw")]
    [Description(@"Limited liability partnership (LLP)")]
    LimitedLiabilityPartnership,

    /// <summary>
    /// For example a co-operative, which does include Ltd. or charity.
    /// Encoded/decoded by serializers as &quot;IAPS&quot;.
    /// </summary>
    [EnumMember(Value = "IAPS")]
    [IsoId("_uHxmYBE4EeafpqhYGpTDnw")]
    [Description(@"For example a co-operative, which does include Ltd. or charity.")]
    IndustrialAndProvidentSociety,

    /// <summary>
    /// General partnership
    /// Encoded/decoded by serializers as &quot;GENP&quot;.
    /// </summary>
    [EnumMember(Value = "GENP")]
    [IsoId("_woAHcBE4EeafpqhYGpTDnw")]
    [Description(@"General partnership")]
    GeneralPartnership,

    /// <summary>
    /// Community Interest Company (CIC)
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_yyykABE4EeafpqhYGpTDnw")]
    [Description(@"Community Interest Company (CIC)")]
    CommunityInterestCompany,

    /// <summary>
    /// Charity
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_4ZcqgBE4EeafpqhYGpTDnw")]
    [Description(@"Charity")]
    Charity,

    /// <summary>
    /// Charitable incorporated organisation (CIO)
    /// Encoded/decoded by serializers as &quot;CIOC&quot;.
    /// </summary>
    [EnumMember(Value = "CIOC")]
    [IsoId("_6sK7EBE4EeafpqhYGpTDnw")]
    [Description(@"Charitable incorporated organisation (CIO)")]
    CharitableIncorporatedOrganisation,
}
