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
[IsoId("_RKZUk9p-Ed-ak6NoX_4Aeg_352927777")]
[DisplayName("Cash Account Return Criteria")]
public partial record CashAccountReturnCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the account name is requested.
    /// </summary>
    [IsoId("_RKZUlNp-Ed-ak6NoX_4Aeg_352927820")]
    [DisplayName("Name Indicator")]
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? NameIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_RKZUldp-Ed-ak6NoX_4Aeg_353848413")]
    [DisplayName("Currency Indicator")]
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CurrencyIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_RKZUltp-Ed-ak6NoX_4Aeg_352927787")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_RKZUl9p-Ed-ak6NoX_4Aeg_353848491")]
    [DisplayName("Multilateral Limit Indicator")]
    [IsoXmlTag("MulLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MultilateralLimitIndicator { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_RKZUmNp-Ed-ak6NoX_4Aeg_353848925")]
    [DisplayName("Multilateral Balance Return Criteria")]
    [IsoXmlTag("MulBalRtrCrit")]
    public CashBalanceReturnCriteria? MultilateralBalanceReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the bilateral limit is requested.
    /// </summary>
    [IsoId("_RKiegNp-Ed-ak6NoX_4Aeg_353848508")]
    [DisplayName("Bilateral Limit Indicator")]
    [IsoXmlTag("BilLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? BilateralLimitIndicator { get; init; } 
    
    /// <summary>
    /// Defines the criteria used to report on a bilateral balance.
    /// </summary>
    [IsoId("_RKiegdp-Ed-ak6NoX_4Aeg_353848829")]
    [DisplayName("Bilateral Balance Return Criteria")]
    [IsoXmlTag("BilBalRtrCrit")]
    public CashBalanceReturnCriteria? BilateralBalanceReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_RKiegtp-Ed-ak6NoX_4Aeg_353848551")]
    [DisplayName("Standing Order Indicator")]
    [IsoXmlTag("StgOrdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StandingOrderIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_RKieg9p-Ed-ak6NoX_4Aeg_683547475")]
    [DisplayName("Account Owner Indicator")]
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccountOwnerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the account servicer information is requested.
    /// </summary>
    [IsoId("_RKiehNp-Ed-ak6NoX_4Aeg_-873944402")]
    [DisplayName("Account Servicer Indicator")]
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccountServicerIndicator { get; init; } 
    
    
    #nullable disable
    
}
