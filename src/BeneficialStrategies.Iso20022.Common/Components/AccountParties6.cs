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
[IsoId("_vypW0ROEEeKjmvxNCObNeQ")]
[DisplayName("Account Parties")]
public partial record AccountParties6
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_0-VsMBdAEeK5g-3oYI0_9Q")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public required AccountParties1Choice_ PrincipalAccountParty { get; init; } 
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_wJABfROEEeKjmvxNCObNeQ")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentAccountOwnershipInformation6> SecondaryOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_wJABgROEEeKjmvxNCObNeQ")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentAccountOwnershipInformation6> Beneficiary { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_wJABhROEEeKjmvxNCObNeQ")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation6> PowerOfAttorney { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_wJABiROEEeKjmvxNCObNeQ")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation6> LegalGuardian { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_wJABjROEEeKjmvxNCObNeQ")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation6> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_wJABkROEEeKjmvxNCObNeQ")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation6? Administrator { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_wJABlROEEeKjmvxNCObNeQ")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ExtendedParty3> OtherParty { get; init; } = new ValueList<ExtendedParty3>(){};
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_wJABmROEEeKjmvxNCObNeQ")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation6> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_wJABnROEEeKjmvxNCObNeQ")]
    [DisplayName("Settler")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation6> Settler { get; init; } = new ValueList<InvestmentAccountOwnershipInformation6>(){};
    
    
    #nullable disable
    
}
