// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Any party who is related to an investment account.
/// </summary>
[IsoId("_RSvYTdp-Ed-ak6NoX_4Aeg_-1282825194")]
[DisplayName("Account Parties")]
public partial record AccountParties4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RSvYTtp-Ed-ak6NoX_4Aeg_-1282825039")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_RSvYT9p-Ed-ak6NoX_4Aeg_-1282823196")]
    [DisplayName("Primary Owner")]
    [IsoXmlTag("PmryOwnr")]
    public InvestmentAccountOwnershipInformation4? PrimaryOwner { get; init; } 
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_RSvYUNp-Ed-ak6NoX_4Aeg_-1282822789")]
    [DisplayName("Trustee")]
    [IsoXmlTag("Trstee")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> Trustee { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_RSvYUdp-Ed-ak6NoX_4Aeg_-1282822307")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public InvestmentAccountOwnershipInformation4? CustodianForMinor { get; init; } 
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [IsoId("_RS4iMNp-Ed-ak6NoX_4Aeg_-1282822170")]
    [DisplayName("Nominee")]
    [IsoXmlTag("Nmnee")]
    public InvestmentAccountOwnershipInformation4? Nominee { get; init; } 
    
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    [IsoId("_RS4iMdp-Ed-ak6NoX_4Aeg_-1282824126")]
    [DisplayName("Joint Owner")]
    [IsoXmlTag("JntOwnr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> JointOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_RS4iMtp-Ed-ak6NoX_4Aeg_-1281901162")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public InvestmentAccountOwnershipInformation4? SecondaryOwner { get; init; } 
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_RS4iM9p-Ed-ak6NoX_4Aeg_-1281901654")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public InvestmentAccountOwnershipInformation4? Beneficiary { get; init; } 
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_RS4iNNp-Ed-ak6NoX_4Aeg_-1281900706")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public InvestmentAccountOwnershipInformation4? PowerOfAttorney { get; init; } 
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_RS4iNdp-Ed-ak6NoX_4Aeg_-1281900231")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public InvestmentAccountOwnershipInformation4? LegalGuardian { get; init; } 
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_RS4iNtp-Ed-ak6NoX_4Aeg_-1282821816")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    public InvestmentAccountOwnershipInformation4? SuccessorOnDeath { get; init; } 
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_RS4iN9p-Ed-ak6NoX_4Aeg_-1282823641")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation4? Administrator { get; init; } 
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_RS4iONp-Ed-ak6NoX_4Aeg_2104893208")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_RTCTMNp-Ed-ak6NoX_4Aeg_-1816047834")]
    [DisplayName("Settler")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation4> Settler { get; init; } = new ValueList<InvestmentAccountOwnershipInformation4>(){};
    
    /// <summary>
    /// An other type of party.
    /// </summary>
    [IsoId("_RTCTMdp-Ed-ak6NoX_4Aeg_344725489")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ExtendedParty1> OtherParty { get; init; } = new ValueList<ExtendedParty1>(){};
    
    
    #nullable disable
    
}
