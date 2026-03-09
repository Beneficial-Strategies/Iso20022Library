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
/// Defines the criteria used to report on an account.
/// </summary>
[IsoId("_t-nrYXX4Eei3jO6riKEVXg")]
[DisplayName("Cash Account Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountReturnCriteria5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the account name is requested.
    /// </summary>
    [IsoId("_uIKB43X4Eei3jO6riKEVXg")]
    [DisplayName("Name Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmInd")]
    #endif
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? NameIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameIndicator { get; init; } 
    #else
    public System.String? NameIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_uIKB5XX4Eei3jO6riKEVXg")]
    [DisplayName("Currency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyInd")]
    #endif
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CurrencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrencyIndicator { get; init; } 
    #else
    public System.String? CurrencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_uIKB53X4Eei3jO6riKEVXg")]
    [DisplayName("Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpInd")]
    #endif
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TypeIndicator { get; init; } 
    #else
    public System.String? TypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_uIKB6XX4Eei3jO6riKEVXg")]
    [DisplayName("Multilateral Limit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MulLmtInd")]
    #endif
    [IsoXmlTag("MulLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? MultilateralLimitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MultilateralLimitIndicator { get; init; } 
    #else
    public System.String? MultilateralLimitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_uIKB63X4Eei3jO6riKEVXg")]
    [DisplayName("Multilateral Balance Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MulBalRtrCrit")]
    #endif
    [IsoXmlTag("MulBalRtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceReturnCriteria2? MultilateralBalanceReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceReturnCriteria2? MultilateralBalanceReturnCriteria { get; init; } 
    #else
    public CashBalanceReturnCriteria2? MultilateralBalanceReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the bilateral limit is requested.
    /// </summary>
    [IsoId("_uIKB7XX4Eei3jO6riKEVXg")]
    [DisplayName("Bilateral Limit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilLmtInd")]
    #endif
    [IsoXmlTag("BilLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? BilateralLimitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BilateralLimitIndicator { get; init; } 
    #else
    public System.String? BilateralLimitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria used to report on a bilateral balance.
    /// </summary>
    [IsoId("_uIKB73X4Eei3jO6riKEVXg")]
    [DisplayName("Bilateral Balance Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilBalRtrCrit")]
    #endif
    [IsoXmlTag("BilBalRtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceReturnCriteria2? BilateralBalanceReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceReturnCriteria2? BilateralBalanceReturnCriteria { get; init; } 
    #else
    public CashBalanceReturnCriteria2? BilateralBalanceReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_uIKB8XX4Eei3jO6riKEVXg")]
    [DisplayName("Standing Order Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgOrdrInd")]
    #endif
    [IsoXmlTag("StgOrdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StandingOrderIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandingOrderIndicator { get; init; } 
    #else
    public System.String? StandingOrderIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_uIKB83X4Eei3jO6riKEVXg")]
    [DisplayName("Account Owner Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrInd")]
    #endif
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountOwnerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerIndicator { get; init; } 
    #else
    public System.String? AccountOwnerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account servicer information is requested.
    /// </summary>
    [IsoId("_uIKB9XX4Eei3jO6riKEVXg")]
    [DisplayName("Account Servicer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrInd")]
    #endif
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountServicerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerIndicator { get; init; } 
    #else
    public System.String? AccountServicerIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
