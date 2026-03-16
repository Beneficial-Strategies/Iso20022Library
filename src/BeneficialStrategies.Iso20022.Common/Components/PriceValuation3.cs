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
[IsoId("_SbJx2tp-Ed-ak6NoX_4Aeg_-1025425136")]
[DisplayName("Price Valuation")]
public record PriceValuation3
{
    /// <summary>
    /// Unique technical identifier for an instance of a price valuation within a price report, as assigned by the issuer of the report.
    /// </summary>
    [IsoId("_SbJx29p-Ed-ak6NoX_4Aeg_-1024504079")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and time of the price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_SbJx3Np-Ed-ak6NoX_4Aeg_-1025425076")]
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus. The NAV date is also known as the trade date. The NAV date becomes the trade date in an order.
    /// </summary>
    [IsoId("_SbJx3dp-Ed-ak6NoX_4Aeg_-1025424733")]
    [DisplayName("NAV Date Time")]
    [IsoXmlTag("NAVDtTm")]
    public required DateAndDateTimeChoice_ NAVDateTime { get; init; }

    /// <summary>
    /// Investment fund class for which the net asset value is calculated.
    /// </summary>
    [IsoId("_SbJx3tp-Ed-ak6NoX_4Aeg_-1024503845")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument8 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Issuer of the fund.
    /// </summary>
    [IsoId("_SbTi0Np-Ed-ak6NoX_4Aeg_-691476443")]
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public PartyIdentification2Choice_? FundManagementCompany { get; init; }

    /// <summary>
    /// Value of all the holdings, less the fund&apos;s liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("_SbTi0dp-Ed-ak6NoX_4Aeg_-1025424673")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; }

    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("_SbTi0tp-Ed-ak6NoX_4Aeg_-1025424596")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Date and time of the next price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_SbTi09p-Ed-ak6NoX_4Aeg_-1025424517")]
    [DisplayName("Next Valuation Date Time")]
    [IsoXmlTag("NxtValtnDtTm")]
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; }

    /// <summary>
    /// Date and time of the previous price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("_SbTi1Np-Ed-ak6NoX_4Aeg_-1025424457")]
    [DisplayName("Previous Valuation Date Time")]
    [IsoXmlTag("PrvsValtnDtTm")]
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; }

    /// <summary>
    /// Specifies how the valuation is done, based on the schedule stated in the prospectus.
    /// </summary>
    [IsoId("_SbTi1dp-Ed-ak6NoX_4Aeg_-1025424170")]
    [DisplayName("Valuation Type")]
    [IsoXmlTag("ValtnTp")]
    public required ValuationTiming1Code ValuationType { get; init; }

    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("_SbTi1tp-Ed-ak6NoX_4Aeg_643321375")]
    [DisplayName("Valuation Frequency")]
    [IsoXmlTag("ValtnFrqcy")]
    public EventFrequency1Code? ValuationFrequency { get; init; }

    /// <summary>
    /// Indicates whether the valuation is an official valuation.
    /// </summary>
    [IsoId("_SbTi19p-Ed-ak6NoX_4Aeg_1135954512")]
    [DisplayName("Official Valuation Indicator")]
    [IsoXmlTag("OffclValtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator OfficialValuationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_SbTi2Np-Ed-ak6NoX_4Aeg_-1025424110")]
    [DisplayName("Suspended Indicator")]
    [IsoXmlTag("SspdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SuspendedIndicator { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_SbTi2dp-Ed-ak6NoX_4Aeg_-1024503551")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice15? PriceDetails { get; init; }

    /// <summary>
    /// Information related to the price variations of an investment fund class.
    /// </summary>
    [IsoId("_SbdT0Np-Ed-ak6NoX_4Aeg_-1024503940")]
    [DisplayName("Valuation Statistics")]
    [IsoXmlTag("ValtnSttstcs")]
    public ValuationStatistics3? ValuationStatistics { get; init; }

    /// <summary>
    /// Factors that give indications about the performance of a fund.
    /// </summary>
    [IsoId("_SbdT0dp-Ed-ak6NoX_4Aeg_-1837109466")]
    [DisplayName("Performance Details")]
    [IsoXmlTag("PrfrmncDtls")]
    public PerformanceFactors1? PerformanceDetails { get; init; }
}
