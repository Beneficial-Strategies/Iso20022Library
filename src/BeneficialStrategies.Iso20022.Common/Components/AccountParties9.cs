// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party related to an investment account.
/// </summary>
[IsoId("_cYUqsRRiEeOKWo1NF21OVw")]
[DisplayName("Account Parties")]
public partial record AccountParties9
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_cvYf2RRiEeOKWo1NF21OVw")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public required AccountParties4Choice_ PrincipalAccountParty { get; init; } 
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_cvYf2xRiEeOKWo1NF21OVw")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public InvestmentAccountOwnershipInformation9? SecondaryOwner { get; init; } 
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_cvYf3RRiEeOKWo1NF21OVw")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public InvestmentAccountOwnershipInformation9? Beneficiary { get; init; } 
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_cvYf3xRiEeOKWo1NF21OVw")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public InvestmentAccountOwnershipInformation9? PowerOfAttorney { get; init; } 
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_cvYf4RRiEeOKWo1NF21OVw")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public InvestmentAccountOwnershipInformation9? LegalGuardian { get; init; } 
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_cvYf4xRiEeOKWo1NF21OVw")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation9> SuccessorOnDeath { get; init; } = [];
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_cvYf5RRiEeOKWo1NF21OVw")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation9? Administrator { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_cvYf5xRiEeOKWo1NF21OVw")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ExtendedParty6? OtherParty { get; init; } 
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_cvYf6RRiEeOKWo1NF21OVw")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation9> Granter { get; init; } = [];
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_cvYf6xRiEeOKWo1NF21OVw")]
    [DisplayName("Settler")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation9> Settler { get; init; } = [];
    
    
    #nullable disable
    
}
