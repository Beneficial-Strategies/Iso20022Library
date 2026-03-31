// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of collateral agreement between counterparties.
/// </summary>
[IsoId("_Sh7OIS-_EeWvZpCvNOLJLQ")]
[DisplayName("Trade Collateral Report")]
public record TradeCollateralReport2
{
    /// <summary>
    /// Information indicating the type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_Su5TIS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Collateralisation")]
    [IsoXmlTag("Collstn")]
    public CollateralisationType1Code? Collateralisation { get; init; }

    /// <summary>
    /// A unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_Su5TIy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public IsoMax52Text? Portfolio { get; init; }

    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty.
    /// Usage: Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// </summary>
    [IsoId("_Su5TJS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Initial Margin Posted")]
    [IsoXmlTag("InitlMrgnPstd")]
    public ActiveCurrencyAnd20Amount? InitialMarginPosted { get; init; }

    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Usage: Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_Su5TJy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Variation Margin Posted")]
    [IsoXmlTag("VartnMrgnPstd")]
    public ActiveCurrencyAnd20Amount? VariationMarginPosted { get; init; }

    /// <summary>
    /// Value of the initial margin received by the reporting counterparty from the other counterparty.
    /// Usage: Where initial margin is received on a portfolio basis, this field should include the overall value of initial margin received for the portfolio.
    /// </summary>
    [IsoId("_Su5TKS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Initial Margin Received")]
    [IsoXmlTag("InitlMrgnRcvd")]
    public ActiveCurrencyAnd20Amount? InitialMarginReceived { get; init; }

    /// <summary>
    /// Value of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty.
    /// Usage: Where variation margin is received on a portfolio basis, this field should include the overall value of variation margin received for the portfolio.
    /// </summary>
    [IsoId("_Su5TKy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Variation Margin Received")]
    [IsoXmlTag("VartnMrgnRcvd")]
    public ActiveCurrencyAnd20Amount? VariationMarginReceived { get; init; }

    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_Su5TLS-_EeWvZpCvNOLJLQ")]
    [DisplayName("Excess Collateral Posted")]
    [IsoXmlTag("XcssCollPstd")]
    public ActiveCurrencyAnd20Amount? ExcessCollateralPosted { get; init; }

    /// <summary>
    /// Value of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_Su5TLy-_EeWvZpCvNOLJLQ")]
    [DisplayName("Excess Collateral Received")]
    [IsoXmlTag("XcssCollRcvd")]
    public ActiveCurrencyAnd20Amount? ExcessCollateralReceived { get; init; }
}
