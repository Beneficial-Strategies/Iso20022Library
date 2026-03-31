// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash-in and cash-out flows by party.
/// </summary>
[IsoId("_LVijGQatEeS3lpTattq7hg")]
[DisplayName("Breakdown By Party")]
public record BreakdownByParty3
{
    /// <summary>
    /// Party, for example, fund management company, for which the cash flow is being reported.
    /// </summary>
    [IsoId("_LvuksQatEeS3lpTattq7hg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required InvestmentAccount42 Party { get; init; }

    /// <summary>
    /// Additional parameter/s applied to the cash flow by party.
    /// </summary>
    [IsoId("_LvukswatEeS3lpTattq7hg")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters1? AdditionalParameters { get; init; }

    /// <summary>
    /// Cash movement into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    [IsoId("_LvuktQatEeS3lpTattq7hg")]
    [DisplayName("Cash In Forecast")]
    [IsoXmlTag("CshInFcst")]
    public ValueList<CashInForecast5> CashInForecast { get; init; } = [];

    /// <summary>
    /// Cash movement out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    [IsoId("_LvuktwatEeS3lpTattq7hg")]
    [DisplayName("Cash Out Forecast")]
    [IsoXmlTag("CshOutFcst")]
    public ValueList<CashOutForecast5> CashOutForecast { get; init; } = [];

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the party.
    /// </summary>
    [IsoId("_LvukuQatEeS3lpTattq7hg")]
    [DisplayName("Net Cash Forecast")]
    [IsoXmlTag("NetCshFcst")]
    public ValueList<NetCashForecast4> NetCashForecast { get; init; } = [];
}
