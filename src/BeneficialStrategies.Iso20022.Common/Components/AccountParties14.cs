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
[IsoId("_M3J_wSCBEeWhHbfCMWc1cw")]
[DisplayName("Account Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties14( DataModification1Code reqModificationScopeIndication )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_NTyRZyCBEeWhHbfCMWc1cw")]
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
    /// Main party associated with the account.
    /// </summary>
    [IsoId("_NTyRaSCBEeWhHbfCMWc1cw")]
    [DisplayName("Principal Account Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAcctPty")]
    #endif
    [IsoXmlTag("PrncplAcctPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountParties9Choice_? PrincipalAccountParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties9Choice_? PrincipalAccountParty { get; init; } 
    #else
    public AccountParties9Choice_? PrincipalAccountParty { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_NTyRayCBEeWhHbfCMWc1cw")]
    [DisplayName("Secondary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOwnr")]
    #endif
    [IsoXmlTag("ScndryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? SecondaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? SecondaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? SecondaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_NTyRbSCBEeWhHbfCMWc1cw")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? Beneficiary { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_NTyRbyCBEeWhHbfCMWc1cw")]
    [DisplayName("Power Of Attorney")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttny")]
    #endif
    [IsoXmlTag("PwrOfAttny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? PowerOfAttorney { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? PowerOfAttorney { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? PowerOfAttorney { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_NTyRcSCBEeWhHbfCMWc1cw")]
    [DisplayName("Legal Guardian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglGuardn")]
    #endif
    [IsoXmlTag("LglGuardn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? LegalGuardian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? LegalGuardian { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? LegalGuardian { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_b2UvcVxmEeW0RaYpOo325g")]
    [DisplayName("Custodian For Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnForMnr")]
    #endif
    [IsoXmlTag("CtdnForMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? CustodianForMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? CustodianForMinor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? CustodianForMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_NTyRcyCBEeWhHbfCMWc1cw")]
    [DisplayName("Successor On Death")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SucssrOnDth")]
    #endif
    [IsoXmlTag("SucssrOnDth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? SuccessorOnDeath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? SuccessorOnDeath { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? SuccessorOnDeath { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_NTyRdSCBEeWhHbfCMWc1cw")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// An other type of party.
    /// </summary>
    [IsoId("_NTyRdyCBEeWhHbfCMWc1cw")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedParty10? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedParty10? OtherParty { get; init; } 
    #else
    public ExtendedParty10? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_NTyReSCBEeWhHbfCMWc1cw")]
    [DisplayName("Granter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grntr")]
    #endif
    [IsoXmlTag("Grntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? Granter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? Granter { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? Granter { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_NTyReyCBEeWhHbfCMWc1cw")]
    [DisplayName("Settlor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttlr")]
    #endif
    [IsoXmlTag("Sttlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation13? Settlor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation13? Settlor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation13? Settlor { get; set; } 
    #endif
    
    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    [IsoId("_tKPW8TYJEeWxoIK_IhudJg")]
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
