// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a cash forecast report.
/// </summary>
[IsoId("_HSgygQatEeS3lpTattq7hg")]
[DisplayName("Fund Detailed Confirmed Cash Forecast Report")]
public record FundDetailedConfirmedCashForecastReport3
{
    /// <summary>
    /// Information about the fund/sub fund when the report either specifies cash flow for the fund/sub fund or for a share class of the fund/sub fund.
    /// </summary>
    [IsoId("_xJVEsQc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Fund Or Sub Fund Details")]
    [IsoXmlTag("FndOrSubFndDtls")]
    public Fund4? FundOrSubFundDetails { get; init; }

    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of transactions in shares in an investment fund, for example, subscriptions, redemptions or switches. The information provided is sorted by pre-defined criteria such as country, institution, currency or user defined criteria.
    /// </summary>
    [IsoId("_Hss0IQatEeS3lpTattq7hg")]
    [DisplayName("Fund Cash Forecast Details")]
    [IsoXmlTag("FndCshFcstDtls")]
    public ValueList<FundCashForecast6> FundCashForecastDetails { get; init; } = [];

    // ID for the above is _Hss0IQatEeS3lpTattq7hg

    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_Hss0IwatEeS3lpTattq7hg")]
    [DisplayName("Consolidated Net Cash Forecast")]
    [IsoXmlTag("CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Hss0JQatEeS3lpTattq7hg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
