// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a party&apos;s account.
/// </summary>
[IsoId("_vGjQYUNMEeamLdeYEZm56w")]
[DisplayName("Account Parties")]
public partial record AccountParties15
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_vgcXFUNMEeamLdeYEZm56w")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public required AccountParties10Choice_ PrincipalAccountParty { get; init; } 
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_vgcXF0NMEeamLdeYEZm56w")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public InvestmentAccountOwnershipInformation14? SecondaryOwner { get; init; } 
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_vgcXGUNMEeamLdeYEZm56w")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public InvestmentAccountOwnershipInformation14? Beneficiary { get; init; } 
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_vgcXG0NMEeamLdeYEZm56w")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public InvestmentAccountOwnershipInformation14? PowerOfAttorney { get; init; } 
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_vgcXHUNMEeamLdeYEZm56w")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public InvestmentAccountOwnershipInformation14? LegalGuardian { get; init; } 
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_vgcXH0NMEeamLdeYEZm56w")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public InvestmentAccountOwnershipInformation14? CustodianForMinor { get; init; } 
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_vgcXIUNMEeamLdeYEZm56w")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation14> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation14>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_vgcXI0NMEeamLdeYEZm56w")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation14? Administrator { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_vgcXJUNMEeamLdeYEZm56w")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ExtendedParty11? OtherParty { get; init; } 
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_vgcXJ0NMEeamLdeYEZm56w")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation14> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation14>(){};
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_vgcXKUNMEeamLdeYEZm56w")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation14> Settlor { get; init; } = new ValueList<InvestmentAccountOwnershipInformation14>(){};
    
    /// <summary>
    /// Party that makes, or participates in the making of, decisions that affect the whole, or a substantial part, of the business of a customer of a reporting entity or that has the capacity to affect significantly the financial standing of a customer of a reporting entity. Typically, this is a controlling person of a corporate (ownership type CORP).
    /// </summary>
    [IsoId("_vpQ3UEzNEeafiMTDrtSnyw")]
    [DisplayName("Senior Managing Official")]
    [IsoXmlTag("SnrMggOffcl")]
    public InvestmentAccountOwnershipInformation14? SeniorManagingOfficial { get; init; } 
    
    /// <summary>
    /// Person appointed under the trust instrument to direct or restrain the trustees in relation to their administration of the trust. Typically, this is a controlling person of a trust (ownership type TRUS) or other non-individual organisation (ownership type ONIS).
    /// </summary>
    [IsoId("_JhA4cEzOEeafiMTDrtSnyw")]
    [DisplayName("Protector")]
    [IsoXmlTag("Prtctr")]
    public InvestmentAccountOwnershipInformation14? Protector { get; init; } 
    
    /// <summary>
    /// Party that registers its name with the issuer and the name used for the registration.
    /// </summary>
    [IsoId("_vgcXK0NMEeamLdeYEZm56w")]
    [DisplayName("Registered Shareholder Name")]
    [IsoXmlTag("RegdShrhldrNm")]
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; } 
    
    
    #nullable disable
    
}
