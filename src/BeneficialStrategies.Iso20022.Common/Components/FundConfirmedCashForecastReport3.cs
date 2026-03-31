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
[IsoId("_Q8jO0QdxEeSPHJIdUs1USg")]
[DisplayName("Fund Confirmed Cash Forecast Report")]
public record FundConfirmedCashForecastReport3
{
    /// <summary>
    /// Information about the fund/sub fund when the report either specifies cash flow for the fund/sub fund or for a share class of the fund/sub fund.
    /// </summary>
    [IsoId("_ac6KwQdxEeSPHJIdUs1USg")]
    [DisplayName("Fund Or Sub Fund Details")]
    [IsoXmlTag("FndOrSubFndDtls")]
    public ValueList<Fund2> FundOrSubFundDetails { get; init; } = [];

    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund.
    /// </summary>
    [IsoId("_RXVGUwdxEeSPHJIdUs1USg")]
    [DisplayName("Fund Cash Forecast Details")]
    [IsoXmlTag("FndCshFcstDtls")]
    public ValueList<FundCashForecast7> FundCashForecastDetails { get; init; } = [];

    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_RXVGVQdxEeSPHJIdUs1USg")]
    [DisplayName("Consolidated Net Cash Forecast")]
    [IsoXmlTag("CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RXVGVwdxEeSPHJIdUs1USg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
