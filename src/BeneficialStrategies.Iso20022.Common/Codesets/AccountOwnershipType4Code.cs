// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o23nwL-GEeWfsa741pI6WA")]
[Description(@"Specifies the type of account ownership.")]
[DerivedFrom(typeof(AccountOwnershipTypeCode))]
public enum AccountOwnershipType4Code
{
    /// <summary>
    /// Account owner is an unincorporated partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as &quot;UNCO&quot;.
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_rwGesb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is an unincorporated partnership or is of sole proprietorship.")]
    Unincorporated = AccountOwnershipTypeCode.Unincorporated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a limited partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as &quot;LIPA&quot;.
    /// </summary>
    [EnumMember(Value = "LIPA")]
    [IsoId("_sGHyAb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a limited partnership or is of sole proprietorship.")]
    LimitedPartnership = AccountOwnershipTypeCode.LimitedPartnership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entrepreneurial account.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_tFMpYb-GEeWfsa741pI6WA")]
    [Description(@"Entrepreneurial account.")]
    Entrepreneurial = AccountOwnershipTypeCode.Entrepreneurial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a corporate.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_u-TgEb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a corporate.")]
    Corporation = AccountOwnershipTypeCode.Corporation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minor&apos;s account, registered in the minor&apos;s name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_vLsb0b-GEeWfsa741pI6WA")]
    [Description(
        @"Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account."
    )]
    CustodialAccount = AccountOwnershipTypeCode.CustodialAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.
    /// Encoded/decoded by serializers as &quot;EURE&quot;.
    /// </summary>
    [EnumMember(Value = "EURE")]
    [IsoId("_vczZ8b-GEeWfsa741pI6WA")]
    [Description(
        @"Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund."
    )]
    EUResidualEntity = AccountOwnershipTypeCode.EUResidualEntity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_vrO3gb-GEeWfsa741pI6WA")]
    [Description(
        @"Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business."
    )]
    FormalPartnership = AccountOwnershipTypeCode.FormalPartnership, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.
    /// Encoded/decoded by serializers as &quot;TRUS&quot;.
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_v7dE0b-GEeWfsa741pI6WA")]
    [Description(
        @"Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds."
    )]
    FormalTrust = AccountOwnershipTypeCode.FormalTrust, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a government organisation.
    /// Encoded/decoded by serializers as &quot;GOVO&quot;.
    /// </summary>
    [EnumMember(Value = "GOVO")]
    [IsoId("_wJ4iYb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a government organisation.")]
    GovernmentOrganisation = AccountOwnershipTypeCode.GovernmentOrganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two or more individuals of legal age own shares of the same account.
    /// Encoded/decoded by serializers as &quot;JOIT&quot;.
    /// </summary>
    [EnumMember(Value = "JOIT")]
    [IsoId("_wYdw8b-GEeWfsa741pI6WA")]
    [Description(@"Two or more individuals of legal age own shares of the same account.")]
    JointAccount = AccountOwnershipTypeCode.JointAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased&apos;s estate.
    /// Encoded/decoded by serializers as &quot;COMO&quot;.
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_whi0cb-GEeWfsa741pI6WA")]
    [Description(
        @"Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate."
    )]
    JointAccountInCommon = AccountOwnershipTypeCode.JointAccountInCommon, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.
    /// Encoded/decoded by serializers as &quot;JOIN&quot;.
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_w4mpkb-GEeWfsa741pI6WA")]
    [Description(
        @"Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners."
    )]
    JointAccountWithSurvivorshipRights =
        AccountOwnershipTypeCode.JointAccountWithSurvivorshipRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a limited liability company.
    /// Encoded/decoded by serializers as &quot;LLCO&quot;.
    /// </summary>
    [EnumMember(Value = "LLCO")]
    [IsoId("_ybsM8b-GEeWfsa741pI6WA")]
    [Description(@"Account is for a limited liability company.")]
    LimitedLiabilityCompany = AccountOwnershipTypeCode.LimitedLiabilityCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_yu4Osb-GEeWfsa741pI6WA")]
    [Description(
        @"Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner."
    )]
    Nominee = AccountOwnershipTypeCode.Nominee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.
    /// Encoded/decoded by serializers as &quot;NFPO&quot;.
    /// </summary>
    [EnumMember(Value = "NFPO")]
    [IsoId("_y7Ooob-GEeWfsa741pI6WA")]
    [Description(
        @"Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation."
    )]
    NonProfitOrganisation = AccountOwnershipTypeCode.NonProfitOrganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owner is another type of non individual organisation.
    /// Encoded/decoded by serializers as &quot;ONIS&quot;.
    /// </summary>
    [EnumMember(Value = "ONIS")]
    [IsoId("_zUhSYb-GEeWfsa741pI6WA")]
    [Description(@"Account owner is another type of non individual organisation.")]
    OtherNonIndividual = AccountOwnershipTypeCode.OtherNonIndividual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a registered investment company.
    /// Encoded/decoded by serializers as &quot;RGIC&quot;.
    /// </summary>
    [EnumMember(Value = "RGIC")]
    [IsoId("_zjjM4b-GEeWfsa741pI6WA")]
    [Description(@"Account is for a registered investment company.")]
    RegisteredInvestmentCompany = AccountOwnershipTypeCode.RegisteredInvestmentCompany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account has only one individual owner.
    /// Encoded/decoded by serializers as &quot;SIGL&quot;.
    /// </summary>
    [EnumMember(Value = "SIGL")]
    [IsoId("_zvv10b-GEeWfsa741pI6WA")]
    [Description(@"Account has only one individual owner.")]
    SingleOwnerAccount = AccountOwnershipTypeCode.SingleOwnerAccount, // same ordinal as derivation source for type conversions
}
