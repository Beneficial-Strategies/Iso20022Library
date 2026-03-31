// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the net asset value for an investment fund/fund class.
/// </summary>
[IsoId("_Vbrjn9p-Ed-ak6NoX_4Aeg_-213723155")]
[DisplayName("Price Valuation")]
public record PriceValuation2
{
    /// <summary>
    /// Unique technical identifier for an instance of a price valuation within a price report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_VbrjoNp-Ed-ak6NoX_4Aeg_-213722734")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and time of the price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_Vb0tgNp-Ed-ak6NoX_4Aeg_-213723153")]
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("_Vb0tgdp-Ed-ak6NoX_4Aeg_-213723138")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; }

    /// <summary>
    /// Investment fund class for which the net asset value is calculated.
    /// </summary>
    [IsoId("_Vb0tgtp-Ed-ak6NoX_4Aeg_-1249708823")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_Vb0tg9p-Ed-ak6NoX_4Aeg_-213723102")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> TotalNAV { get; init; } = [];

    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_Vb0thNp-Ed-ak6NoX_4Aeg_-213722836")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Date and time of the next price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_Vb0thdp-Ed-ak6NoX_4Aeg_-213722811")]
    [DisplayName("Next Valuation Date Time")]
    [IsoXmlTag("NxtValtnDtTm")]
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; }

    /// <summary>
    /// Date and time of the previous price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_Vb0thtp-Ed-ak6NoX_4Aeg_-213722794")]
    [DisplayName("Previous Valuation Date Time")]
    [IsoXmlTag("PrvsValtnDtTm")]
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; }

    /// <summary>
    /// Specifies how the valuation is done, based on the schedule stated in the prospectus.
    /// </summary>
    [IsoId("_Vb0th9p-Ed-ak6NoX_4Aeg_-213722776")]
    [DisplayName("Valuation Cycle")]
    [IsoXmlTag("ValtnCycl")]
    public required ValuationTiming1Code ValuationCycle { get; init; }

    /// <summary>
    /// Indicates whether the valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_Vb0tiNp-Ed-ak6NoX_4Aeg_-213722751")]
    [DisplayName("Suspended Indicator")]
    [IsoXmlTag("SspdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SuspendedIndicator { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_Vb0tidp-Ed-ak6NoX_4Aeg_-213722690")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<UnitPrice6> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information related to the price variations of an investment fund class.
    /// </summary>
    [IsoId("_Vb-egNp-Ed-ak6NoX_4Aeg_1507402268")]
    [DisplayName("Valuation Statistics")]
    [IsoXmlTag("ValtnSttstcs")]
    public ValueList<ValuationStatistics2> ValuationStatistics { get; init; } = [];
}
