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
[IsoId("_I9Ac_QhDEeSUPbC7DbLJpQ")]
[DisplayName("Account Parties")]
public partial record AccountParties12
{
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_JYYKVwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Principal Account Party")]
    [IsoXmlTag("PrncplAcctPty")]
    public required AccountParties7Choice_ PrincipalAccountParty { get; init; } 
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_JYYKWQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Secondary Owner")]
    [IsoXmlTag("ScndryOwnr")]
    public InvestmentAccountOwnershipInformation10? SecondaryOwner { get; init; } 
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_JYYKWwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Beneficiary")]
    [IsoXmlTag("Bnfcry")]
    public InvestmentAccountOwnershipInformation10? Beneficiary { get; init; } 
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_JYYKXQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Power Of Attorney")]
    [IsoXmlTag("PwrOfAttny")]
    public InvestmentAccountOwnershipInformation10? PowerOfAttorney { get; init; } 
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_JYYKXwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Legal Guardian")]
    [IsoXmlTag("LglGuardn")]
    public InvestmentAccountOwnershipInformation10? LegalGuardian { get; init; } 
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_JYYKYQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Successor On Death")]
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation10> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation10>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_JYYKYwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public InvestmentAccountOwnershipInformation10? Administrator { get; init; } 
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_JYYKZQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Other Party")]
    [IsoXmlTag("OthrPty")]
    public ExtendedParty7? OtherParty { get; init; } 
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_JYYKZwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Granter")]
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation10> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation10>(){};
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_JYYKaQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Settlor")]
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation10> Settlor { get; init; } = new ValueList<InvestmentAccountOwnershipInformation10>(){};
    
    
    #nullable disable
    
}
