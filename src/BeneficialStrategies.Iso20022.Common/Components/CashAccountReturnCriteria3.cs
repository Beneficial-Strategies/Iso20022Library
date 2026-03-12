// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on an account.
/// </summary>
[IsoId("_71ydIaMgEeCJ6YNENx4h-w_1757739430")]
[DisplayName("Cash Account Return Criteria")]
public partial record CashAccountReturnCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the account name is requested.
    /// </summary>
    [IsoId("_71ydIqMgEeCJ6YNENx4h-w_72900079")]
    [DisplayName("Name Indicator")]
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? NameIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_71ydI6MgEeCJ6YNENx4h-w_368889736")]
    [DisplayName("Currency Indicator")]
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CurrencyIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_71ydJKMgEeCJ6YNENx4h-w_1291053046")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_71ydJaMgEeCJ6YNENx4h-w_536303172")]
    [DisplayName("Multilateral Limit Indicator")]
    [IsoXmlTag("MulLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MultilateralLimitIndicator { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_71ydJqMgEeCJ6YNENx4h-w_698432703")]
    [DisplayName("Multilateral Balance Return Criteria")]
    [IsoXmlTag("MulBalRtrCrit")]
    public CashBalanceReturnCriteria? MultilateralBalanceReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the bilateral limit is requested.
    /// </summary>
    [IsoId("_71ydJ6MgEeCJ6YNENx4h-w_515299923")]
    [DisplayName("Bilateral Limit Indicator")]
    [IsoXmlTag("BilLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? BilateralLimitIndicator { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on a bilateral balance.
    /// </summary>
    [IsoId("_717nEKMgEeCJ6YNENx4h-w_212243408")]
    [DisplayName("Bilateral Balance Return Criteria")]
    [IsoXmlTag("BilBalRtrCrit")]
    public CashBalanceReturnCriteria? BilateralBalanceReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_717nEaMgEeCJ6YNENx4h-w_1264966299")]
    [DisplayName("Standing Order Indicator")]
    [IsoXmlTag("StgOrdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StandingOrderIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_717nEqMgEeCJ6YNENx4h-w_472230382")]
    [DisplayName("Account Owner Indicator")]
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountOwnerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account servicer information is requested.
    /// </summary>
    [IsoId("_717nE6MgEeCJ6YNENx4h-w_797347889")]
    [DisplayName("Account Servicer Indicator")]
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountServicerIndicator { get; init; } 
    
    
    #nullable disable
    
}
