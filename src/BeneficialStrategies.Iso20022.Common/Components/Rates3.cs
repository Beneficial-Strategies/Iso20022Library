// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Interest rate of the loan.
/// </summary>
[IsoId("_0_3dUc-nEeufOvGsyZiDWA")]
[DisplayName("Rates")]
public record Rates3
{
    /// <summary>
    /// Details of the fixed rate.
    /// </summary>
    [IsoId("_1CZz88-nEeufOvGsyZiDWA")]
    [DisplayName("Fixed")]
    [IsoXmlTag("Fxd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Fixed { get; init; }

    /// <summary>
    /// Details about the variable rate.
    /// </summary>
    [IsoId("_1CZz9c-nEeufOvGsyZiDWA")]
    [DisplayName("Floating")]
    [IsoXmlTag("Fltg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Floating { get; init; }

    /// <summary>
    /// Transaction by which a counterparty buys or sells securities, commodities, or guaranteed rights relating to title to securities or commodities, agreeing, respectively, to sell or to buy back securities, commodities or such guaranteed rights of the same description at a specified price on a future date, that transaction being a buy-sell back transaction for the counterparty buying the securities, commodities or guaranteed rights, and a sell-buy back transaction for the counterparty selling them, such buy-sell back transaction or sell-buy back transaction not being governed by a repurchase agreement or by a reverse-repurchase agreement.
    /// </summary>
    [IsoId("_1CZz98-nEeufOvGsyZiDWA")]
    [DisplayName("Buy Sell Back")]
    [IsoXmlTag("BuySellBck")]
    public SecuritiesTransactionPrice18Choice_? BuySellBack { get; init; }
}
