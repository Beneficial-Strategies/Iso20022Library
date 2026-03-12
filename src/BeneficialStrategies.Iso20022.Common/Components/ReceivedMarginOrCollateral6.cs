// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the received margin or collateral of the transaction.
/// </summary>
[IsoId("_lgGRIYmKEeybbN9emGqfiw")]
[DisplayName("Received Margin Or Collateral")]
public partial record ReceivedMarginOrCollateral6
{
    #nullable enable
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_lhNEYYmKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Received Pre Haircut")]
    [IsoXmlTag("InitlMrgnRcvdPreHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginReceivedPreHaircut { get; init; } 
    
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_lhNEY4mKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Received Post Haircut")]
    [IsoXmlTag("InitlMrgnRcvdPstHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginReceivedPostHaircut { get; init; } 
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_lhNEZYmKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Received Pre Haircut")]
    [IsoXmlTag("VartnMrgnRcvdPreHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginReceivedPreHaircut { get; init; } 
    
    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty. 
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_lhNEZ4mKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Received Post Haircut")]
    [IsoXmlTag("VartnMrgnRcvdPstHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginReceivedPostHaircut { get; init; } 
    
    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_lhNEaYmKEeybbN9emGqfiw")]
    [DisplayName("Excess Collateral Received")]
    [IsoXmlTag("XcssCollRcvd")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? ExcessCollateralReceived { get; init; } 
    
    
    #nullable disable
    
}
