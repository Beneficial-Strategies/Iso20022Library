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
[IsoId("_Y75JsYmKEeybbN9emGqfiw")]
[DisplayName("Posted Margin Or Collateral")]
public record PostedMarginOrCollateral6
{
    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty.
    /// Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// </summary>
    [IsoId("_Y8_88YmKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Posted Pre Haircut")]
    [IsoXmlTag("InitlMrgnPstdPreHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPreHaircut { get; init; }

    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty.
    /// Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_Y8_884mKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Posted Post Haircut")]
    [IsoXmlTag("InitlMrgnPstdPstHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPostHaircut { get; init; }

    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_Y8_89YmKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Posted Pre Haircut")]
    [IsoXmlTag("VartnMrgnPstdPreHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPreHaircut { get; init; }

    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_Y8_894mKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Posted Post Haircut")]
    [IsoXmlTag("VartnMrgnPstdPstHrcut")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPostHaircut { get; init; }

    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_Y8_8-YmKEeybbN9emGqfiw")]
    [DisplayName("Excess Collateral Posted")]
    [IsoXmlTag("XcssCollPstd")]
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? ExcessCollateralPosted { get; init; }
}
