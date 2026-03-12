// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of collateral agreement between counterparties.
/// </summary>
[IsoId("_NACgIPP5EeS_qLctCs2aRQ")]
[DisplayName("Trade Collateral Report")]
public partial record TradeCollateralReport1
{
    #nullable enable
    
    /// <summary>
    /// Information indicating the type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_UqGo0PP5EeS_qLctCs2aRQ")]
    [DisplayName("Collateralisation")]
    [IsoXmlTag("Collstn")]
    public required CollateralisationType1Code Collateralisation { get; init; } 
    
    /// <summary>
    /// A unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_YX2F4PP5EeS_qLctCs2aRQ")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    public IsoMax52Text? Portfolio { get; init; } 
    
    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty. 
    /// Usage: Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// </summary>
    [IsoId("_6mj8gPP6EeS_qLctCs2aRQ")]
    [DisplayName("Initial Margin Posted")]
    [IsoXmlTag("InitlMrgnPstd")]
    public ActiveCurrencyAnd20Amount? InitialMarginPosted { get; init; } 
    
    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty. 
    /// Usage: Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_GvA8EPP7EeS_qLctCs2aRQ")]
    [DisplayName("Variation Margin Posted")]
    [IsoXmlTag("VartnMrgnPstd")]
    public ActiveCurrencyAnd20Amount? VariationMarginPosted { get; init; } 
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty. 
    /// Usage: Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_i9s_YvP7EeS_qLctCs2aRQ")]
    [DisplayName("Initial Margin Received")]
    [IsoXmlTag("InitlMrgnRcvd")]
    public ActiveCurrencyAnd20Amount? InitialMarginReceived { get; init; } 
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Usage: Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_i9s_Y_P7EeS_qLctCs2aRQ")]
    [DisplayName("Variation Margin Received")]
    [IsoXmlTag("VartnMrgnRcvd")]
    public ActiveCurrencyAnd20Amount? VariationMarginReceived { get; init; } 
    
    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_EdKPUAN_EeWs3sTa9Sj6Lg")]
    [DisplayName("Excess Collateral Posted")]
    [IsoXmlTag("XcssCollPstd")]
    public ActiveCurrencyAnd20Amount? ExcessCollateralPosted { get; init; } 
    
    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_LBAW0gN_EeWs3sTa9Sj6Lg")]
    [DisplayName("Excess Collateral Received")]
    [IsoXmlTag("XcssCollRcvd")]
    public ActiveCurrencyAnd20Amount? ExcessCollateralReceived { get; init; } 
    
    
    #nullable disable
    
}
