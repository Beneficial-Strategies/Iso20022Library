// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the posted margin or collateral of the transaction.
/// </summary>
[IsoId("_6UHOsayGEem81-uIvTF5rQ")]
[DisplayName("Posted Margin Or Collateral")]
public record PostedMarginOrCollateral3
{
    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty.
    /// Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// </summary>
    [IsoId("_6YIzEayGEem81-uIvTF5rQ")]
    [DisplayName("Initial Margin Posted")]
    [IsoXmlTag("InitlMrgnPstd")]
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginPosted { get; init; }

    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_6YIzE6yGEem81-uIvTF5rQ")]
    [DisplayName("Variation Margin Posted")]
    [IsoXmlTag("VartnMrgnPstd")]
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginPosted { get; init; }

    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_6YIzFayGEem81-uIvTF5rQ")]
    [DisplayName("Excess Collateral Posted")]
    [IsoXmlTag("XcssCollPstd")]
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralPosted { get; init; }
}
