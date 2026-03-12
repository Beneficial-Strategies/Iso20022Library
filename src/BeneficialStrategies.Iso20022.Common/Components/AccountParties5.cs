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
[IsoId("_RSb2Sdp-Ed-ak6NoX_4Aeg_-1122306786")]
[DisplayName("Account Parties")]
public partial record AccountParties5
{
    #nullable enable
    
    /// <summary>
    /// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_RSb2Stp-Ed-ak6NoX_4Aeg_-1120460595")]
    [DisplayName("Primary Owner")]
    [IsoXmlTag("PmryOwnr")]
    public required InvestmentAccountOwnershipInformation5 PrimaryOwner { get; init; } 
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_RSb2S9p-Ed-ak6NoX_4Aeg_-1120460019")]
    [DisplayName("Trustee")]
    [IsoXmlTag("Trstee")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> Trustee { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_RSb2TNp-Ed-ak6NoX_4Aeg_-1120459200")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public required InvestmentAccountOwnershipInformation5 CustodianForMinor { get; init; } 
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [IsoId("_RSlnQNp-Ed-ak6NoX_4Aeg_-1120459063")]
    [DisplayName("Nominee")]
    [IsoXmlTag("Nmnee")]
    public required InvestmentAccountOwnershipInformation5 Nominee { get; init; } 
    
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    [IsoId("_RSlnQdp-Ed-ak6NoX_4Aeg_-1121381248")]
    [DisplayName("Joint Owner")]
    [IsoXmlTag("JntOwnr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> JointOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_RSlnQtp-Ed-ak6NoX_4Aeg_-1120458211")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentAccountOwnershipInformation5> SecondaryOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_RSlnQ9p-Ed-ak6NoX_4Aeg_-1119537652")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentAccountOwnershipInformation5> Beneficiary { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_RSlnRNp-Ed-ak6NoX_4Aeg_-1119536566")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> PowerOfAttorney { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_RSlnRdp-Ed-ak6NoX_4Aeg_-1119535739")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> LegalGuardian { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_RSlnRtp-Ed-ak6NoX_4Aeg_-1119535566")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_RSlnR9p-Ed-ak6NoX_4Aeg_-1121382569")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation5? Administrator { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_RSlnSNp-Ed-ak6NoX_4Aeg_1473925855")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ExtendedParty2> OtherParty { get; init; } = new ValueList<ExtendedParty2>(){};
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_RSlnSdp-Ed-ak6NoX_4Aeg_1444245145")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_RSvYQNp-Ed-ak6NoX_4Aeg_1605862687")]
    [DisplayName("Settler")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> Settler { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    
    #nullable disable
    
}
