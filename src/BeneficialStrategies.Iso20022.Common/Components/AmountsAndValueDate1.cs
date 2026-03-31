// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value date and the amounts traded in a foreign exchange transaction.
/// </summary>
[IsoId("_TITy0tp-Ed-ak6NoX_4Aeg_290674075")]
[DisplayName("Amounts And Value Date")]
public record AmountsAndValueDate1
{
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade.
    /// </summary>
    [IsoId("_TITy09p-Ed-ak6NoX_4Aeg_290674076")]
    [DisplayName("Trading Side Buy Amount")]
    [IsoXmlTag("TradgSdBuyAmt")]
    public required ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; }

    /// <summary>
    /// Currency and amount sold in a foreign exchange trade.
    /// </summary>
    [IsoId("_TIc8sNp-Ed-ak6NoX_4Aeg_438409417")]
    [DisplayName("Trading Side Sell Amount")]
    [IsoXmlTag("TradgSdSellAmt")]
    public required ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; }

    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TIc8sdp-Ed-ak6NoX_4Aeg_290674077")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; }
}
