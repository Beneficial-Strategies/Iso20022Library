// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account ownership.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_brLLsNp-Ed-ak6NoX_4Aeg_1487774282")]
[Description(@"Specifies the type of account ownership.")]
[Derivations(typeof(AccountOwnershipType5Code),typeof(AccountOwnershipType3Code),typeof(AccountOwnershipType6Code),typeof(AccountOwnershipType4Code))]
public enum AccountOwnershipTypeCode
{
    /// <summary>
    /// Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.
    /// Encoded/decoded by serializers as &quot;JOIN&quot;.
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_brLLsdp-Ed-ak6NoX_4Aeg_-1582732153")]
    [Description(@"Two or more individuals own shares of the same account. Upon the death of one of the account owners, the entire account ownership is passed onto the surviving owners.")]
    JointAccountWithSurvivorshipRights,
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased&apos;s estate.
    /// Encoded/decoded by serializers as &quot;COMO&quot;.
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_brLLstp-Ed-ak6NoX_4Aeg_-1582732152")]
    [Description(@"Two or more individuals of legal age own shares of the same account. Upon the death of one of the account owners, the respective percentage of the ownership is transferred to the deceased's estate.")]
    JointAccountInCommon,
    
    /// <summary>
    /// Minor&apos;s account, registered in the minor&apos;s name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_brLLs9p-Ed-ak6NoX_4Aeg_-1582732151")]
    [Description(@"Minor's account, registered in the minor's name. Since the minor cannot legally own property, the custodian of the account maintains control of the account.")]
    CustodialAccount,
    
    /// <summary>
    /// Account has only one individual owner.
    /// Encoded/decoded by serializers as &quot;SIGL&quot;.
    /// </summary>
    [EnumMember(Value = "SIGL")]
    [IsoId("_brLLtNp-Ed-ak6NoX_4Aeg_-1582732150")]
    [Description(@"Account has only one individual owner.")]
    SingleOwnerAccount,
    
    /// <summary>
    /// Two or more individuals of legal age own shares of the same account.
    /// Encoded/decoded by serializers as &quot;JOIT&quot;.
    /// </summary>
    [EnumMember(Value = "JOIT")]
    [IsoId("_brLLtdp-Ed-ak6NoX_4Aeg_312463497")]
    [Description(@"Two or more individuals of legal age own shares of the same account.")]
    JointAccount,
    
    /// <summary>
    /// Account owner is a corporate.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_brLLttp-Ed-ak6NoX_4Aeg_641236913")]
    [Description(@"Account owner is a corporate.")]
    Corporation,
    
    /// <summary>
    /// Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_brLLt9p-Ed-ak6NoX_4Aeg_660630019")]
    [Description(@"Account owner is a contractual business organisation in which two or more individuals agree to pool their funds to manage and operate a business.")]
    FormalPartnership,
    
    /// <summary>
    /// Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.
    /// Encoded/decoded by serializers as &quot;TRUS&quot;.
    /// </summary>
    [EnumMember(Value = "TRUS")]
    [IsoId("_brLLuNp-Ed-ak6NoX_4Aeg_689260466")]
    [Description(@"Account owner is an organisation which is engaged as a trustee for individuals or businesses in the administration of services such as stock transfer, registration, trust funds.")]
    FormalTrust,
    
    /// <summary>
    /// Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_brU8sNp-Ed-ak6NoX_4Aeg_1647872307")]
    [Description(@"Account owner is a person or firm into whose name securities or other properties are transferred in order to facilitate transactions whilst leaving the customer as the actual owner.")]
    Nominee,
    
    /// <summary>
    /// Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.
    /// Encoded/decoded by serializers as &quot;NFPO&quot;.
    /// </summary>
    [EnumMember(Value = "NFPO")]
    [IsoId("_brU8sdp-Ed-ak6NoX_4Aeg_1671883451")]
    [Description(@"Account owner is an association that is given tax-free status due to the nature of their activities such as charity organisation.")]
    NonProfitOrganisation,
    
    /// <summary>
    /// Account owner is another type of non individual organisation.
    /// Encoded/decoded by serializers as &quot;ONIS&quot;.
    /// </summary>
    [EnumMember(Value = "ONIS")]
    [IsoId("_brU8stp-Ed-ak6NoX_4Aeg_1833434537")]
    [Description(@"Account owner is another type of non individual organisation.")]
    OtherNonIndividual,
    
    /// <summary>
    /// Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.
    /// Encoded/decoded by serializers as &quot;EURE&quot;.
    /// </summary>
    [EnumMember(Value = "EURE")]
    [IsoId("_brU8s9p-Ed-ak6NoX_4Aeg_1469402090")]
    [Description(@"Account owner is an entity located in the European Union which can be considered neither as a legal entity (for example, company, corporate), nor as an individual person, nor as a UCITS (Undertakings for Collective Investment of Transferable Securities) fund.")]
    EUResidualEntity,
    
    /// <summary>
    /// Account owner is a government organisation.
    /// Encoded/decoded by serializers as &quot;GOVO&quot;.
    /// </summary>
    [EnumMember(Value = "GOVO")]
    [IsoId("_brU8tNp-Ed-ak6NoX_4Aeg_1553769901")]
    [Description(@"Account owner is a government organisation.")]
    GovernmentOrganisation,
    
    /// <summary>
    /// Account is for a limited liability company.
    /// Encoded/decoded by serializers as &quot;LLCO&quot;.
    /// </summary>
    [EnumMember(Value = "LLCO")]
    [IsoId("_brU8tdp-Ed-ak6NoX_4Aeg_-1469860903")]
    [Description(@"Account is for a limited liability company.")]
    LimitedLiabilityCompany,
    
    /// <summary>
    /// Account is for a registered investment company.
    /// Encoded/decoded by serializers as &quot;RGIC&quot;.
    /// </summary>
    [EnumMember(Value = "RGIC")]
    [IsoId("_brU8ttp-Ed-ak6NoX_4Aeg_-1469860471")]
    [Description(@"Account is for a registered investment company.")]
    RegisteredInvestmentCompany,
    
    /// <summary>
    /// Entrepreneurial account.
    /// Encoded/decoded by serializers as &quot;ENTR&quot;.
    /// </summary>
    [EnumMember(Value = "ENTR")]
    [IsoId("_FI4hUL-GEeWfsa741pI6WA")]
    [Description(@"Entrepreneurial account.")]
    Entrepreneurial,
    
    /// <summary>
    /// Account owner is an unincorporated partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as &quot;UNCO&quot;.
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_FO-iQL-GEeWfsa741pI6WA")]
    [Description(@"Account owner is an unincorporated partnership or is of sole proprietorship.")]
    Unincorporated,
    
    /// <summary>
    /// Account owner is a limited partnership or is of sole proprietorship.
    /// Encoded/decoded by serializers as &quot;LIPA&quot;.
    /// </summary>
    [EnumMember(Value = "LIPA")]
    [IsoId("_FoICEL-GEeWfsa741pI6WA")]
    [Description(@"Account owner is a limited partnership or is of sole proprietorship.")]
    LimitedPartnership,
    
    /// <summary>
    /// A person has bare ownership on the asset.
    /// Encoded/decoded by serializers as &quot;BOWN&quot;.
    /// </summary>
    [EnumMember(Value = "BOWN")]
    [IsoId("_MP7lA5NiEem9mu_a5rvrBw")]
    [Description(@"A person has bare ownership on the asset.")]
    BareOwner,
    
    /// <summary>
    /// A person has full ownership on the asset. 
    /// Encoded/decoded by serializers as &quot;OWNR&quot;.
    /// </summary>
    [EnumMember(Value = "OWNR")]
    [IsoId("_MP7lBJNiEem9mu_a5rvrBw")]
    [Description(@"A person has full ownership on the asset. ")]
    Owner,
    
    /// <summary>
    /// The person is ...
    /// Encoded/decoded by serializers as &quot;USUF&quot;.
    /// </summary>
    [EnumMember(Value = "USUF")]
    [IsoId("_MP7lBZNiEem9mu_a5rvrBw")]
    [Description(@"The person is ...")]
    Usufructuary,
    
}
