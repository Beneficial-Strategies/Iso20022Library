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
[IsoId("_RKZUk9p-Ed-ak6NoX_4Aeg_352927777")]
[DisplayName("Cash Account Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountReturnCriteria2
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
    [IsoId("_RKZUlNp-Ed-ak6NoX_4Aeg_352927820")]
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
    [IsoId("_RKZUldp-Ed-ak6NoX_4Aeg_353848413")]
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
    [IsoId("_RKZUltp-Ed-ak6NoX_4Aeg_352927787")]
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
    [IsoId("_RKZUl9p-Ed-ak6NoX_4Aeg_353848491")]
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
    [IsoId("_RKZUmNp-Ed-ak6NoX_4Aeg_353848925")]
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
    [IsoId("_RKiegNp-Ed-ak6NoX_4Aeg_353848508")]
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
    [IsoId("_RKiegdp-Ed-ak6NoX_4Aeg_353848829")]
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
    [IsoId("_RKiegtp-Ed-ak6NoX_4Aeg_353848551")]
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
    [IsoId("_RKieg9p-Ed-ak6NoX_4Aeg_683547475")]
    [DisplayName("Account Owner Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrInd")]
    #endif
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AccountOwnerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountOwnerIndicator { get; init; } 
    #else
    public System.String? AccountOwnerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account servicer information is requested.
    /// </summary>
    [IsoId("_RKiehNp-Ed-ak6NoX_4Aeg_-873944402")]
    [DisplayName("Account Servicer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrInd")]
    #endif
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AccountServicerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountServicerIndicator { get; init; } 
    #else
    public System.String? AccountServicerIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
