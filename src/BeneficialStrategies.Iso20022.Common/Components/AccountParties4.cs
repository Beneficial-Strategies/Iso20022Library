// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Any party who is related to an investment account.
/// </summary>
[IsoId("_RSvYTdp-Ed-ak6NoX_4Aeg_-1282825194")]
[DisplayName("Account Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties4( DataModification1Code reqModificationScopeIndication )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RSvYTtp-Ed-ak6NoX_4Aeg_-1282825039")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification1Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification1Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_RSvYT9p-Ed-ak6NoX_4Aeg_-1282823196")]
    [DisplayName("Primary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryOwnr")]
    #endif
    [IsoXmlTag("PmryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? PrimaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? PrimaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? PrimaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_RSvYUNp-Ed-ak6NoX_4Aeg_-1282822789")]
    [DisplayName("Trustee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trstee")]
    #endif
    [IsoXmlTag("Trstee")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> Trustee { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_RSvYUdp-Ed-ak6NoX_4Aeg_-1282822307")]
    [DisplayName("Custodian For Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnForMnr")]
    #endif
    [IsoXmlTag("CtdnForMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? CustodianForMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? CustodianForMinor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? CustodianForMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [IsoId("_RS4iMNp-Ed-ak6NoX_4Aeg_-1282822170")]
    [DisplayName("Nominee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nmnee")]
    #endif
    [IsoXmlTag("Nmnee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? Nominee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? Nominee { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? Nominee { get; set; } 
    #endif
    
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    [IsoId("_RS4iMdp-Ed-ak6NoX_4Aeg_-1282824126")]
    [DisplayName("Joint Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JntOwnr")]
    #endif
    [IsoXmlTag("JntOwnr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> JointOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_RS4iMtp-Ed-ak6NoX_4Aeg_-1281901162")]
    [DisplayName("Secondary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOwnr")]
    #endif
    [IsoXmlTag("ScndryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? SecondaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? SecondaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? SecondaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_RS4iM9p-Ed-ak6NoX_4Aeg_-1281901654")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? Beneficiary { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_RS4iNNp-Ed-ak6NoX_4Aeg_-1281900706")]
    [DisplayName("Power Of Attorney")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttny")]
    #endif
    [IsoXmlTag("PwrOfAttny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? PowerOfAttorney { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? PowerOfAttorney { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? PowerOfAttorney { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_RS4iNdp-Ed-ak6NoX_4Aeg_-1281900231")]
    [DisplayName("Legal Guardian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglGuardn")]
    #endif
    [IsoXmlTag("LglGuardn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? LegalGuardian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? LegalGuardian { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? LegalGuardian { get; set; } 
    #endif
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_RS4iNtp-Ed-ak6NoX_4Aeg_-1282821816")]
    [DisplayName("Successor On Death")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SucssrOnDth")]
    #endif
    [IsoXmlTag("SucssrOnDth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? SuccessorOnDeath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? SuccessorOnDeath { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? SuccessorOnDeath { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_RS4iN9p-Ed-ak6NoX_4Aeg_-1282823641")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation4? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation4? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation4? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_RS4iONp-Ed-ak6NoX_4Aeg_2104893208")]
    [DisplayName("Granter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grntr")]
    #endif
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_RTCTMNp-Ed-ak6NoX_4Aeg_-1816047834")]
    [DisplayName("Settler")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttlr")]
    #endif
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> Settler { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// An other type of party.
    /// </summary>
    [IsoId("_RTCTMdp-Ed-ak6NoX_4Aeg_344725489")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ExtendedParty1> OtherParty { get; init; } = new ValueList<ExtendedParty1>(){};
    
    
    #nullable disable
    
}
