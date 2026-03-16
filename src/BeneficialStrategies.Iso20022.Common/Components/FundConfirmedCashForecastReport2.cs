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
[IsoId("_RPwVsdp-Ed-ak6NoX_4Aeg_148169077")]
[DisplayName("Fund Confirmed Cash Forecast Report")]
public record FundConfirmedCashForecastReport2
{
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund.
    /// </summary>
    [IsoId("_RPwVstp-Ed-ak6NoX_4Aeg_148169138")]
    [DisplayName("Fund Cash Forecast Details")]
    [IsoXmlTag("FndCshFcstDtls")]
    public ValueList<FundCashForecast3> FundCashForecastDetails { get; init; } = [];

    // ID for the above is _RPwVstp-Ed-ak6NoX_4Aeg_148169138

    /// <summary>
    /// Estimated net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_RPwVs9p-Ed-ak6NoX_4Aeg_-1683705527")]
    [DisplayName("Consolidated Net Cash Forecast")]
    [IsoXmlTag("CnsltdNetCshFcst")]
    public NetCashForecast3? ConsolidatedNetCashForecast { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RPwVtNp-Ed-ak6NoX_4Aeg_148169096")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
