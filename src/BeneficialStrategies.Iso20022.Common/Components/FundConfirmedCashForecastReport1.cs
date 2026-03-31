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
[IsoId("_Uuhio9p-Ed-ak6NoX_4Aeg_-748628095")]
[DisplayName("Fund Confirmed Cash Forecast Report")]
public record FundConfirmedCashForecastReport1
{
    /// <summary>
    /// Information related to the cash-in and cash-out flows for a specific trade date as a result of investment fund transactions, for example, subscriptions, redemptions or switches to/from a specified investment fund.
    /// </summary>
    [IsoId("_UuhipNp-Ed-ak6NoX_4Aeg_-861874046")]
    [DisplayName("Fund Cash Forecast Details")]
    [IsoXmlTag("FndCshFcstDtls")]
    public ValueList<FundCashForecast1> FundCashForecastDetails { get; init; } = [];

    // ID for the above is _UuhipNp-Ed-ak6NoX_4Aeg_-861874046

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Uuhipdp-Ed-ak6NoX_4Aeg_-786145834")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
