// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on collateral.
/// </summary>
[IsoId("__7yZ5zpsEemk2e6qGBk8IQ")]
[DisplayName("Collateral Value Return Criteria")]
public partial record CollateralValueReturnCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the cash account owner information is requested.
    /// </summary>
    [IsoId("_AF6mUTptEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Owner Indicator")]
    [IsoXmlTag("CshAcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CashAccountOwnerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the cash account servicer information is requested.
    /// </summary>
    [IsoId("_AF6mUzptEemk2e6qGBk8IQ")]
    [DisplayName("Cash Account Servicer Indicator")]
    [IsoXmlTag("CshAcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CashAccountServicerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account owner information is requested.
    /// </summary>
    [IsoId("_LCkhFTptEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Owner Indicator")]
    [IsoXmlTag("SctiesAcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SecuritiesAccountOwnerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account servicer information is requested.
    /// </summary>
    [IsoId("_LCkhFjptEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Servicer Indicator")]
    [IsoXmlTag("SctiesAcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SecuritiesAccountServicerIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the total value of the collateral valuation information is requested..
    /// </summary>
    [IsoId("_LCkhFzptEemk2e6qGBk8IQ")]
    [DisplayName("Total Collateral Valuation Indicator")]
    [IsoXmlTag("TtlCollValtnInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TotalCollateralValuationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account information is requested.
    /// </summary>
    [IsoId("_LCkhGDptEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Indicator")]
    [IsoXmlTag("SctiesAcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? SecuritiesAccountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities account information is requested.
    /// </summary>
    [IsoId("_LCkhGTptEemk2e6qGBk8IQ")]
    [DisplayName("Securities")]
    [IsoXmlTag("Scties")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Securities { get; init; } 
    
    
    #nullable disable
    
}
