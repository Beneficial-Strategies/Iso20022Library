// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualifies the content of the subservice code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WgXpJqlEeGSON8vddiWzQ_-2011541661")]
[Description(@"Qualifies the content of the subservice code.")]
[DerivedFrom(typeof(BillingSubServiceQualifierCode))]
public enum BillingSubServiceQualifier1Code
{
    /// <summary>
    /// Subservice code contains a lockbox number which identifies the lockbox using the service.
    /// Encoded/decoded by serializers as &quot;LBOX&quot;.
    /// </summary>
    [EnumMember(Value = "LBOX")]
    [IsoId("_6WgXpZqlEeGSON8vddiWzQ_-1508305482")]
    [Description(
        @"Subservice code contains a lockbox number which identifies the lockbox using the service."
    )]
    Lockbox = BillingSubServiceQualifierCode.Lockbox, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subservice code contains a store number which identifies the store using the service.
    /// Encoded/decoded by serializers as &quot;STOR&quot;.
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_6WgXppqlEeGSON8vddiWzQ_-430285144")]
    [Description(
        @"Subservice code contains a store number which identifies the store using the service."
    )]
    Store = BillingSubServiceQualifierCode.Store, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meaning of the subservice code is established by the trading partners.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_6WgXp5qlEeGSON8vddiWzQ_1036863619")]
    [Description(@"Meaning of the subservice code is established by the trading partners.")]
    BilaterallyAgreed = BillingSubServiceQualifierCode.BilaterallyAgreed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subservice code is an arbitrary sequence number used to uniquely identify this Service and prevent duplicate services within this statement.
    /// Encoded/decoded by serializers as &quot;SEQN&quot;.
    /// </summary>
    [EnumMember(Value = "SEQN")]
    [IsoId("_6WgXqJqlEeGSON8vddiWzQ_620847928")]
    [Description(
        @"Subservice code is an arbitrary sequence number used to uniquely identify this Service and prevent duplicate services within this statement."
    )]
    SequenceNumber = BillingSubServiceQualifierCode.SequenceNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subservice code is the account number of a member of a relationship structure. This allows a parent statement to include the same service as rolled up from its member accounts and still avoid duplicate service identification within the statement.
    /// Encoded/decoded by serializers as &quot;MACT&quot;.
    /// </summary>
    [EnumMember(Value = "MACT")]
    [IsoId("_6WqIoJqlEeGSON8vddiWzQ_-1223021061")]
    [Description(
        @"Subservice code is the account number of a member of a relationship structure. This allows a parent statement to include the same service as rolled up from its member accounts and still avoid duplicate service identification within the statement."
    )]
    MemberAccount = BillingSubServiceQualifierCode.MemberAccount, // same ordinal as derivation source for type conversions
}
