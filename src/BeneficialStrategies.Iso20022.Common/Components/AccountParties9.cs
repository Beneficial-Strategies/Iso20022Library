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
/// Party related to an investment account.
/// </summary>
[IsoId("_cYUqsRRiEeOKWo1NF21OVw")]
[DisplayName("Account Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties9( AccountParties4Choice_ reqPrincipalAccountParty )
    {
        PrincipalAccountParty = reqPrincipalAccountParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_cvYf2RRiEeOKWo1NF21OVw")]
    [DisplayName("Principal Account Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAcctPty")]
    #endif
    [IsoXmlTag("PrncplAcctPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountParties4Choice_ PrincipalAccountParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountParties4Choice_ PrincipalAccountParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties4Choice_ PrincipalAccountParty { get; init; } 
    #else
    public AccountParties4Choice_ PrincipalAccountParty { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_cvYf2xRiEeOKWo1NF21OVw")]
    [DisplayName("Secondary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOwnr")]
    #endif
    [IsoXmlTag("ScndryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation9? SecondaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation9? SecondaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation9? SecondaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_cvYf3RRiEeOKWo1NF21OVw")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation9? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation9? Beneficiary { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation9? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_cvYf3xRiEeOKWo1NF21OVw")]
    [DisplayName("Power Of Attorney")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttny")]
    #endif
    [IsoXmlTag("PwrOfAttny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation9? PowerOfAttorney { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation9? PowerOfAttorney { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation9? PowerOfAttorney { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_cvYf4RRiEeOKWo1NF21OVw")]
    [DisplayName("Legal Guardian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglGuardn")]
    #endif
    [IsoXmlTag("LglGuardn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation9? LegalGuardian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation9? LegalGuardian { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation9? LegalGuardian { get; set; } 
    #endif
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_cvYf4xRiEeOKWo1NF21OVw")]
    [DisplayName("Successor On Death")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SucssrOnDth")]
    #endif
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation9> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation9>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_cvYf5RRiEeOKWo1NF21OVw")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation9? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation9? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation9? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_cvYf5xRiEeOKWo1NF21OVw")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedParty6? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedParty6? OtherParty { get; init; } 
    #else
    public ExtendedParty6? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_cvYf6RRiEeOKWo1NF21OVw")]
    [DisplayName("Granter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grntr")]
    #endif
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation9> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation9>(){};
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_cvYf6xRiEeOKWo1NF21OVw")]
    [DisplayName("Settler")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttlr")]
    #endif
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation9> Settler { get; init; } = new ValueList<InvestmentAccountOwnershipInformation9>(){};
    
    
    #nullable disable
    
}
