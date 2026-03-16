// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an investment fund.
/// </summary>
[IsoId("_gBHmkQc3EeSyIPzOZ6VzBQ")]
[DisplayName("Fund")]
public record Fund2
{
    /// <summary>
    /// Name of the fund/sub fund.
    /// </summary>
    [IsoId("_q2spl1-KEeS7xuKaq75oiQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Identification of the fund/sub fund with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_q2spmF-KEeS7xuKaq75oiQ")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for the fund/sub fund, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_q2spll-KEeS7xuKaq75oiQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OtherIdentification4? Identification { get; init; }

    /// <summary>
    /// Currency of the fund/sub fund.
    /// </summary>
    [IsoId("_gcNAFQc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    [IsoId("_SUxNomATEeSkSfzdpzkxXg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public DateAndDateTimeChoice_? TradeDateTime { get; init; }

    /// <summary>
    /// Previous date and time at which the price was applied.
    /// </summary>
    [IsoId("_ASuQY2AGEeSkSfzdpzkxXg")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; }

    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_gcNAFwc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; }

    /// <summary>
    /// Previous total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_gcNAGQc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; }

    /// <summary>
    /// Total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_gcNAGwc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Previous total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_gcNAHQc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; }

    /// <summary>
    /// Consolidated net cash flow expressed as a percentage of the total NAV for the fund/sub fund.
    /// </summary>
    [IsoId("_gcNAHwc3EeSyIPzOZ6VzBQ")]
    [DisplayName("Percentage Of Fund Total NAV")]
    [IsoXmlTag("PctgOfFndTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfFundTotalNAV { get; init; }

    /// <summary>
    /// Cash movement into the fund/sub fund.
    /// </summary>
    [IsoId("_benuE2ATEeSkSfzdpzkxXg")]
    [DisplayName("Cash In Forecast Details")]
    [IsoXmlTag("CshInFcstDtls")]
    public CashInOutForecast7? CashInForecastDetails { get; init; }

    /// <summary>
    /// Cash movement out of the fund/sub fund.
    /// </summary>
    [IsoId("_benuFGATEeSkSfzdpzkxXg")]
    [DisplayName("Cash Out Forecast Details")]
    [IsoXmlTag("CshOutFcstDtls")]
    public CashInOutForecast7? CashOutForecastDetails { get; init; }

    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_benuFWATEeSkSfzdpzkxXg")]
    [DisplayName("Net Cash Forecast Details")]
    [IsoXmlTag("NetCshFcstDtls")]
    public NetCashForecast5? NetCashForecastDetails { get; init; }
}
