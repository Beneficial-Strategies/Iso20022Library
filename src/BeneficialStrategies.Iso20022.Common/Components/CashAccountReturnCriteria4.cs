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
[IsoId("_4OF9uZlaEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Account Return Criteria")]
public partial record CashAccountReturnCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the account name is requested.
    /// </summary>
    [IsoId("_4WGqM5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Name Indicator")]
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? NameIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_4WGqNZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency Indicator")]
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CurrencyIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_4WGqN5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_4WGqOZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Multilateral Limit Indicator")]
    [IsoXmlTag("MulLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MultilateralLimitIndicator { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_4WGqO5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Multilateral Balance Return Criteria")]
    [IsoXmlTag("MulBalRtrCrit")]
    public CashBalanceReturnCriteria1? MultilateralBalanceReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the bilateral limit is requested.
    /// </summary>
    [IsoId("_4WGqPZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Bilateral Limit Indicator")]
    [IsoXmlTag("BilLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? BilateralLimitIndicator { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on a bilateral balance.
    /// </summary>
    [IsoId("_4WGqP5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Bilateral Balance Return Criteria")]
    [IsoXmlTag("BilBalRtrCrit")]
    public CashBalanceReturnCriteria1? BilateralBalanceReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_4WGqQZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Standing Order Indicator")]
    [IsoXmlTag("StgOrdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StandingOrderIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_4WGqQ5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Owner Indicator")]
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountOwnerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account servicer information is requested.
    /// </summary>
    [IsoId("_4WGqRZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Servicer Indicator")]
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountServicerIndicator { get; init; } 
    
    
    #nullable disable
    
}
