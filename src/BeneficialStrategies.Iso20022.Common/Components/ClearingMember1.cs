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
/// Legal counterpart to trades cleared through a central counterparty.
/// </summary>
[IsoId("_l_0jkJXZEeaEh9L5Y0ZaKQ")]
[DisplayName("Clearing Member")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingMember1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingMember1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingMember1( PartyIdentification118Choice_ reqIdentification,CreditQuality1Code reqCreditQuality,System.String reqFuturesCommissionMerchantIndicator,System.DateOnly reqMembershipValidFrom )
    {
        Identification = reqIdentification;
        CreditQuality = reqCreditQuality;
        FuturesCommissionMerchantIndicator = reqFuturesCommissionMerchantIndicator;
        MembershipValidFrom = reqMembershipValidFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the clearing member.
    /// </summary>
    [IsoId("_iY7AcJX8EeaEh9L5Y0ZaKQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification118Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification118Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification118Choice_ Identification { get; init; } 
    #else
    public PartyIdentification118Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Credit quality for the clearing member.
    /// </summary>
    [IsoId("_2Q8osJXZEeaEh9L5Y0ZaKQ")]
    [DisplayName("Credit Quality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtQlty")]
    #endif
    [IsoXmlTag("CdtQlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditQuality1Code CreditQuality { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditQuality1Code CreditQuality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditQuality1Code CreditQuality { get; init; } 
    #else
    public CreditQuality1Code CreditQuality { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the ultimate parent of a clearing member if it is not the parent company itself.
    /// </summary>
    [IsoId("_X4el4KcmEeaGcf8_qtd8Yw")]
    [DisplayName("Ultimate Parent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtPrntId")]
    #endif
    [IsoXmlTag("UltmtPrntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification118Choice_? UltimateParentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification118Choice_? UltimateParentIdentification { get; init; } 
    #else
    public PartyIdentification118Choice_? UltimateParentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the clearing member is registered under the Commodity Exchange Act.
    /// </summary>
    [IsoId("_YuOVMJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Futures Commission Merchant Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FutrsComssnMrchntInd")]
    #endif
    [IsoXmlTag("FutrsComssnMrchntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator FuturesCommissionMerchantIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FuturesCommissionMerchantIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FuturesCommissionMerchantIndicator { get; init; } 
    #else
    public System.String FuturesCommissionMerchantIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the entity becomes a clearing member contractually subject to the CCP’s Rulebook.
    /// </summary>
    [IsoId("_CMTncJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Membership Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbshVldFr")]
    #endif
    [IsoXmlTag("MmbshVldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate MembershipValidFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly MembershipValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly MembershipValidFrom { get; init; } 
    #else
    public System.DateOnly MembershipValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the clearing member is no longer a member in any clearing services protected by the default waterfall as defined by the CCP’s rules. Typically this will be the day the clearing member’s default fund contribution is repaid or they are no longer contractually subject to rights of assessment.
    /// </summary>
    [IsoId("_F264AJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Membership Valid To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbshVldTo")]
    #endif
    [IsoXmlTag("MmbshVldTo")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MembershipValidTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MembershipValidTo { get; init; } 
    #else
    public System.DateOnly? MembershipValidTo { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of another clearing member or institution that acts as sponsor to the clearing member, undertaking certain of its obligations at the central counterparty on its behalf. These obligations typically include, but are not limited to, making default fund contributions and participating in default auctions.
    /// </summary>
    [IsoId("_lc6OUJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Sponsoring Clearing Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpnsrgClrMmbId")]
    #endif
    [IsoXmlTag("SpnsrgClrMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification118Choice_? SponsoringClearingMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification118Choice_? SponsoringClearingMemberIdentification { get; init; } 
    #else
    public PartyIdentification118Choice_? SponsoringClearingMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Operational construct of a central counterparty that defines the relationship between collateral, margin and position accounts and upon default of a clearing member defines the segregation of losses on positions and assets held in that account.
    /// </summary>
    [IsoId("__bi88KclEeaGcf8_qtd8Yw")]
    [DisplayName("Clearing Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcctOwnr")]
    #endif
    [IsoXmlTag("ClrAcctOwnr")]
    public ValueList<ClearingAccount1> ClearingAccountOwner { get; init; } = new ValueList<ClearingAccount1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is __bi88KclEeaGcf8_qtd8Yw
    
    
    #nullable disable
    
}
