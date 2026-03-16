// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the received margin or collateral of the transaction.
/// </summary>
[IsoId("_Gw_uEa2lEeujnrmCqLd8pg")]
[DisplayName("Received Margin Or Collateral")]
public record ReceivedMarginOrCollateral4
{
    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_HAfioa2lEeujnrmCqLd8pg")]
    [DisplayName("Initial Margin Received")]
    [IsoXmlTag("InitlMrgnRcvd")]
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginReceived { get; init; }

    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty.
    /// Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_HAfio62lEeujnrmCqLd8pg")]
    [DisplayName("Variation Margin Received")]
    [IsoXmlTag("VartnMrgnRcvd")]
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginReceived { get; init; }

    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_HAfipa2lEeujnrmCqLd8pg")]
    [DisplayName("Excess Collateral Received")]
    [IsoXmlTag("XcssCollRcvd")]
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralReceived { get; init; }
}
