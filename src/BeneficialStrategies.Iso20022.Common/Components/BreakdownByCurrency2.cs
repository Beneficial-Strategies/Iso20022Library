// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by currency.
/// </summary>
[IsoId("_IG415QatEeS3lpTattq7hg")]
[DisplayName("Breakdown By Currency")]
public record BreakdownByCurrency2
{
    /// <summary>
    /// Currency for which the cash flow is being reported.
    /// </summary>
    [IsoId("_IhEQUQatEeS3lpTattq7hg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }

    /// <summary>
    /// Cash movement out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_IhEQUwatEeS3lpTattq7hg")]
    [DisplayName("Cash Out Forecast")]
    [IsoXmlTag("CshOutFcst")]
    public CashOutForecast5? CashOutForecast { get; init; }

    /// <summary>
    /// Cash movement into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_IhEQVQatEeS3lpTattq7hg")]
    [DisplayName("Cash In Forecast")]
    [IsoXmlTag("CshInFcst")]
    public CashInForecast5? CashInForecast { get; init; }

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the currency.
    /// </summary>
    [IsoId("_IhEQVwatEeS3lpTattq7hg")]
    [DisplayName("Net Cash Forecast")]
    [IsoXmlTag("NetCshFcst")]
    public NetCashForecast4? NetCashForecast { get; init; }
}
