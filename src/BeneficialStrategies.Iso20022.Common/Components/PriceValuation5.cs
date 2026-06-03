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
[IsoId("c71c897c-8454-4285-9f1a-3dd64cd508cd")]
[DisplayName("Price Valuation5")]
public record PriceValuation5
{
    /// <summary>
    /// Unique technical identifier for an instance of a price valuation within a price report.
    /// </summary>
    [IsoId("87c2cbcf-bfc9-4f39-8104-b2c033c72ca8")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Date and time of the price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("1097744d-3cfe-4bd9-98dc-5829dd7aac8a")]
    [DisplayName("Valuation Date Time")]
    [IsoXmlTag("ValtnDtTm")]
    public DateAndDateTime2Choice? ValuationDateTime { get; init; }

    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    [IsoId("69bd7606-11c3-4cb6-a94b-f785c40aa615")]
    [DisplayName("NAV Date Time")]
    [IsoXmlTag("NAVDtTm")]
    public required DateAndDateTime2Choice NAVDateTime { get; init; }

    /// <summary>
    /// Investment fund class for which the net asset value is calculated.
    /// </summary>
    [IsoId("41098e20-098e-4bca-a5f0-ae370dfddf3d")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument106 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Issuer of the fund.
    /// </summary>
    [IsoId("9516b535-817d-4cba-8d0a-c82ef1e724f7")]
    [DisplayName("Fund Management Company")]
    [IsoXmlTag("FndMgmtCpny")]
    public PartyIdentification125Choice? FundManagementCompany { get; init; }

    /// <summary>
    /// Value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    [IsoId("be103699-329a-40b5-84f3-27eb7b23ee91")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> TotalNAV { get; init; } = [];

    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    [IsoId("93e7a4ee-bb6b-44cc-860d-379966bbc87f")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; }

    /// <summary>
    /// Date and time of the next price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("1d09731f-4140-4f1c-9dda-8e83881c9d27")]
    [DisplayName("Next Valuation Date Time")]
    [IsoXmlTag("NxtValtnDtTm")]
    public DateAndDateTime2Choice? NextValuationDateTime { get; init; }

    /// <summary>
    /// Date and time of the previous price valuation for the investment fund/fund class.
    /// </summary>
    [IsoId("d0aaaae0-156f-49eb-aca1-0acd6c148e39")]
    [DisplayName("Previous Valuation Date Time")]
    [IsoXmlTag("PrvsValtnDtTm")]
    public DateAndDateTime2Choice? PreviousValuationDateTime { get; init; }

    /// <summary>
    /// Specifies how the valuation is done, based on the schedule stated in the prospectus.
    /// </summary>
    [IsoId("2876aeb9-c4c3-467c-b7e1-23eca585367a")]
    [DisplayName("Valuation Type")]
    [IsoXmlTag("ValtnTp")]
    public required ValuationTiming1Code ValuationType { get; init; }

    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("5444f42c-e7e0-4945-937b-03ba100ce327")]
    [DisplayName("Valuation Frequency")]
    [IsoXmlTag("ValtnFrqcy")]
    public EventFrequency1Code? ValuationFrequency { get; init; }

    /// <summary>
    /// Indicates whether the valuation is an official valuation.
    /// </summary>
    [IsoId("49936174-9fd1-4585-ab5b-7665ddd5ab41")]
    [DisplayName("Official Valuation Indicator")]
    [IsoXmlTag("OffclValtnInd")]
    public required IsoYesNoIndicator OfficialValuationIndicator { get; init; }

    /// <summary>
    /// Indicates whether the valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("b41dfbde-2459-4c20-bee8-954c6a1ce0c4")]
    [DisplayName("Suspended Indicator")]
    [IsoXmlTag("SspdInd")]
    public required IsoYesNoIndicator SuspendedIndicator { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("e6cb24d6-b2de-421c-84f9-ccc8e2b26f02")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<UnitPrice24> PriceDetails { get; init; } = [];

    /// <summary>
    /// Information related to the price variations of an investment fund class.
    /// </summary>
    [IsoId("0ad89090-a822-4920-b163-356999cde7d8")]
    [DisplayName("Valuation Statistics")]
    [IsoXmlTag("ValtnSttstcs")]
    public ValueList<ValuationStatistics4> ValuationStatistics { get; init; } = [];

    /// <summary>
    /// Factors that give indications about the performance of a fund.
    /// </summary>
    [IsoId("c39862ef-2737-4d66-b78a-d6a4f02fc46e")]
    [DisplayName("Performance Details")]
    [IsoXmlTag("PrfrmncDtls")]
    public PerformanceFactors5? PerformanceDetails { get; init; }
}
