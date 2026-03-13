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
[IsoId("_GmcvUUzPEeafiMTDrtSnyw")]
[DisplayName("Account Parties")]
public partial record AccountParties16
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_HAMFBUzPEeafiMTDrtSnyw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_HAMFB0zPEeafiMTDrtSnyw")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public AccountParties11Choice_? PrincipalAccountParty { get; init; } 
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_HAMFCUzPEeafiMTDrtSnyw")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public InvestmentAccountOwnershipInformation15? SecondaryOwner { get; init; } 
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_HAMFC0zPEeafiMTDrtSnyw")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public InvestmentAccountOwnershipInformation15? Beneficiary { get; init; } 
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_HAMFDUzPEeafiMTDrtSnyw")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public InvestmentAccountOwnershipInformation15? PowerOfAttorney { get; init; } 
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_HAMFD0zPEeafiMTDrtSnyw")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public InvestmentAccountOwnershipInformation15? LegalGuardian { get; init; } 
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_HAMFEUzPEeafiMTDrtSnyw")]
    [DisplayName("Custodian For Minor")]
    [IsoXmlTag("CtdnForMnr")]
    public InvestmentAccountOwnershipInformation15? CustodianForMinor { get; init; } 
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_HAMFE0zPEeafiMTDrtSnyw")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation15> SuccessorOnDeath { get; init; } = [];
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_HAMFFUzPEeafiMTDrtSnyw")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation15? Administrator { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_HAMFF0zPEeafiMTDrtSnyw")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ExtendedParty12? OtherParty { get; init; } 
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_HAMFGUzPEeafiMTDrtSnyw")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation15> Granter { get; init; } = [];
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_HAMFG0zPEeafiMTDrtSnyw")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation15> Settlor { get; init; } = [];
    
    /// <summary>
    /// Party that makes, or participates in the making of, decisions that affect the whole, or a substantial part, of the business of a customer of a reporting entity or that has the capacity to affect significantly the financial standing of a customer of a reporting entity. Typically, this is a controlling person of a corporate (ownership type CORP).
    /// </summary>
    [IsoId("_OyS58EzQEea8fovz_9xSTQ")]
    [DisplayName("Senior Managing Official")]
    [IsoXmlTag("SnrMggOffcl")]
    public InvestmentAccountOwnershipInformation15? SeniorManagingOfficial { get; init; } 
    
    /// <summary>
    /// Person appointed under the trust instrument to direct or restrain the trustees in relation to their administration of the trust. Typically, this is a controlling person of a trust (ownership type TRUS) or other non-individual organisation (ownership type ONIS).
    /// </summary>
    [IsoId("_OyThAEzQEea8fovz_9xSTQ")]
    [DisplayName("Protector")]
    [IsoXmlTag("Prtctr")]
    public InvestmentAccountOwnershipInformation15? Protector { get; init; } 
    
    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    [IsoId("_HAMFHUzPEeafiMTDrtSnyw")]
    [DisplayName("Registered Shareholder Name")]
    [IsoXmlTag("RegdShrhldrNm")]
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; } 
    
    
    #nullable disable
    
}
