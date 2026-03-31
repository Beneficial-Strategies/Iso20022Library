// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters used to report cash movements,eg, country code, currency code, BIC or a user defined parameter.
/// </summary>
[IsoId("_UuOnttp-Ed-ak6NoX_4Aeg_215969786")]
[DisplayName("Forecast Parameter")]
public record ForecastParameter2
{
    /// <summary>
    /// Type of parameter used for grouping the information in a report, eg, country code, currency code, BIC or a user defined parameter.
    /// </summary>
    [IsoId("_UuOnt9p-Ed-ak6NoX_4Aeg_215969829")]
    [DisplayName("Report Parameter")]
    [IsoXmlTag("RptParam")]
    public required ReportParameter2Choice_ ReportParameter { get; init; }

    /// <summary>
    /// Cash movement in to of a fund as a result of investment funds transactions, eg, subscriptions or switch-out.
    /// </summary>
    [IsoId("_UuOnuNp-Ed-ak6NoX_4Aeg_215969960")]
    [DisplayName("Cash In Forecast Details")]
    [IsoXmlTag("CshInFcstDtls")]
    public ValueList<CashInForecast1> CashInForecastDetails { get; init; } = [];

    /// <summary>
    /// Cash movement out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_UuYYsNp-Ed-ak6NoX_4Aeg_215969925")]
    [DisplayName("Cash Out Forecast Details")]
    [IsoXmlTag("CshOutFcstDtls")]
    public ValueList<CashOutForecast1> CashOutForecastDetails { get; init; } = [];

    /// <summary>
    /// Net cash movements to a fund as a result of investment funds transactions.
    /// </summary>
    [IsoId("_UuYYsdp-Ed-ak6NoX_4Aeg_215969865")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public ValueList<NetCashForecast1> NetCashForecastDetails { get; init; } = [];
}
