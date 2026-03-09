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
[IsoId("_mp9DWZQ_EemqYPWMBuVawg")]
[DisplayName("Account Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties18( DataModification1Code reqModificationScopeIndication )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_m9viBZQ_EemqYPWMBuVawg")]
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
    [IsoId("_m9viB5Q_EemqYPWMBuVawg")]
    [DisplayName("Principal Account Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAcctPty")]
    #endif
    [IsoXmlTag("PrncplAcctPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountParties13Choice_? PrincipalAccountParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountParties13Choice_? PrincipalAccountParty { get; init; } 
    #else
    public AccountParties13Choice_? PrincipalAccountParty { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_m9viCZQ_EemqYPWMBuVawg")]
    [DisplayName("Secondary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOwnr")]
    #endif
    [IsoXmlTag("ScndryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? SecondaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? SecondaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? SecondaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_m9viC5Q_EemqYPWMBuVawg")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? Beneficiary { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? Beneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_m9viDZQ_EemqYPWMBuVawg")]
    [DisplayName("Power Of Attorney")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttny")]
    #endif
    [IsoXmlTag("PwrOfAttny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? PowerOfAttorney { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? PowerOfAttorney { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? PowerOfAttorney { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_m9viD5Q_EemqYPWMBuVawg")]
    [DisplayName("Legal Guardian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglGuardn")]
    #endif
    [IsoXmlTag("LglGuardn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? LegalGuardian { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? LegalGuardian { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? LegalGuardian { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_m9viEZQ_EemqYPWMBuVawg")]
    [DisplayName("Custodian For Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnForMnr")]
    #endif
    [IsoXmlTag("CtdnForMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? CustodianForMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? CustodianForMinor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? CustodianForMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_m9viE5Q_EemqYPWMBuVawg")]
    [DisplayName("Successor On Death")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SucssrOnDth")]
    #endif
    [IsoXmlTag("SucssrOnDth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? SuccessorOnDeath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? SuccessorOnDeath { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? SuccessorOnDeath { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_m9viFZQ_EemqYPWMBuVawg")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_m9viF5Q_EemqYPWMBuVawg")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedParty15? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedParty15? OtherParty { get; init; } 
    #else
    public ExtendedParty15? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_m9viGZQ_EemqYPWMBuVawg")]
    [DisplayName("Granter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grntr")]
    #endif
    [IsoXmlTag("Grntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? Granter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? Granter { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? Granter { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that creates a trust or contributes assets to the trust.
    /// </summary>
    [IsoId("_m9viG5Q_EemqYPWMBuVawg")]
    [DisplayName("Settlor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttlr")]
    #endif
    [IsoXmlTag("Sttlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? Settlor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? Settlor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? Settlor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that makes, or participates in the making of, decisions that affect the whole, or a substantial part, of the business of a customer of a reporting entity or that has the capacity to affect significantly the financial standing of a customer of a reporting entity. Typically, this is a controlling person of a corporate (ownership type CORP).
    /// </summary>
    [IsoId("_m9viHZQ_EemqYPWMBuVawg")]
    [DisplayName("Senior Managing Official")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnrMggOffcl")]
    #endif
    [IsoXmlTag("SnrMggOffcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? SeniorManagingOfficial { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? SeniorManagingOfficial { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? SeniorManagingOfficial { get; set; } 
    #endif
    
    /// <summary>
    /// Person appointed under the trust instrument to direct or restrain the trustees in relation to their administration of the trust. Typically, this is a controlling person of a trust (ownership type TRUS) or other non-individual organisation (ownership type ONIS).
    /// </summary>
    [IsoId("_m9viH5Q_EemqYPWMBuVawg")]
    [DisplayName("Protector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtctr")]
    #endif
    [IsoXmlTag("Prtctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation17? Protector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation17? Protector { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation17? Protector { get; set; } 
    #endif
    
    /// <summary>
    /// Party for which shares are to be registered.
    /// </summary>
    [IsoId("_m9viIZQ_EemqYPWMBuVawg")]
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
