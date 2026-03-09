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
/// Information about a party&apos;s account.
/// </summary>
[IsoId("_GY8mMSCBEeWhHbfCMWc1cw")]
[DisplayName("Account Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties13( AccountParties8Choice_ reqPrincipalAccountParty )
    {
        PrincipalAccountParty = reqPrincipalAccountParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_G1n7JSCBEeWhHbfCMWc1cw")]
    [DisplayName("Principal Account Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAcctPty")]
    #endif
    [IsoXmlTag("PrncplAcctPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountParties8Choice_ PrincipalAccountParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountParties8Choice_ PrincipalAccountParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties8Choice_ PrincipalAccountParty { get; init; } 
    #else
    public AccountParties8Choice_ PrincipalAccountParty { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_G1n7JyCBEeWhHbfCMWc1cw")]
    [DisplayName("Secondary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOwnr")]
    #endif
    [IsoXmlTag("ScndryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation12? SecondaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation12? SecondaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation12? SecondaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_G1n7KSCBEeWhHbfCMWc1cw")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation12? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation12? Beneficiary { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation12? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_G1n7KyCBEeWhHbfCMWc1cw")]
    [DisplayName("Power Of Attorney")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttny")]
    #endif
    [IsoXmlTag("PwrOfAttny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation12? PowerOfAttorney { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation12? PowerOfAttorney { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation12? PowerOfAttorney { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_G1n7LSCBEeWhHbfCMWc1cw")]
    [DisplayName("Legal Guardian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglGuardn")]
    #endif
    [IsoXmlTag("LglGuardn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation12? LegalGuardian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation12? LegalGuardian { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation12? LegalGuardian { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_Yo7mYVxmEeW0RaYpOo325g")]
    [DisplayName("Custodian For Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnForMnr")]
    #endif
    [IsoXmlTag("CtdnForMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation12? CustodianForMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation12? CustodianForMinor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation12? CustodianForMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_G1n7LyCBEeWhHbfCMWc1cw")]
    [DisplayName("Successor On Death")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SucssrOnDth")]
    #endif
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation12> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation12>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_G1n7MSCBEeWhHbfCMWc1cw")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation12? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation12? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation12? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_G1n7MyCBEeWhHbfCMWc1cw")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedParty9? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedParty9? OtherParty { get; init; } 
    #else
    public ExtendedParty9? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_G1n7NSCBEeWhHbfCMWc1cw")]
    [DisplayName("Granter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grntr")]
    #endif
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation12> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation12>(){};
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_G1n7NyCBEeWhHbfCMWc1cw")]
    [DisplayName("Settlor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttlr")]
    #endif
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation12> Settlor { get; init; } = new ValueList<InvestmentAccountOwnershipInformation12>(){};
    
    /// <summary>
    /// Party that registers its name with the issuer and the name used for the registration.
    /// </summary>
    [IsoId("_fPhIgDYJEeWxoIK_IhudJg")]
    [DisplayName("Registered Shareholder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdShrhldrNm")]
    #endif
    [IsoXmlTag("RegdShrhldrNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; init; } 
    #else
    public RegisteredShareholderName1Choice_? RegisteredShareholderName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
