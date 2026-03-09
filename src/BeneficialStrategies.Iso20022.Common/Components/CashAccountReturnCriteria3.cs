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
[IsoId("_71ydIaMgEeCJ6YNENx4h-w_1757739430")]
[DisplayName("Cash Account Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountReturnCriteria3
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
    [IsoId("_71ydIqMgEeCJ6YNENx4h-w_72900079")]
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
    [IsoId("_71ydI6MgEeCJ6YNENx4h-w_368889736")]
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
    [IsoId("_71ydJKMgEeCJ6YNENx4h-w_1291053046")]
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
    [IsoId("_71ydJaMgEeCJ6YNENx4h-w_536303172")]
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
    [IsoId("_71ydJqMgEeCJ6YNENx4h-w_698432703")]
    [DisplayName("Multilateral Balance Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MulBalRtrCrit")]
    #endif
    [IsoXmlTag("MulBalRtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceReturnCriteria? MultilateralBalanceReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceReturnCriteria? MultilateralBalanceReturnCriteria { get; init; } 
    #else
    public CashBalanceReturnCriteria? MultilateralBalanceReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the bilateral limit is requested.
    /// </summary>
    [IsoId("_71ydJ6MgEeCJ6YNENx4h-w_515299923")]
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
    [IsoId("_717nEKMgEeCJ6YNENx4h-w_212243408")]
    [DisplayName("Bilateral Balance Return Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BilBalRtrCrit")]
    #endif
    [IsoXmlTag("BilBalRtrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceReturnCriteria? BilateralBalanceReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceReturnCriteria? BilateralBalanceReturnCriteria { get; init; } 
    #else
    public CashBalanceReturnCriteria? BilateralBalanceReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_717nEaMgEeCJ6YNENx4h-w_1264966299")]
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
    [IsoId("_717nEqMgEeCJ6YNENx4h-w_472230382")]
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
    [IsoId("_717nE6MgEeCJ6YNENx4h-w_797347889")]
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
