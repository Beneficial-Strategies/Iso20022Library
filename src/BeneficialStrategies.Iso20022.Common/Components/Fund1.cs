// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an investment fund.
/// </summary>
[IsoId("_pEbB0QcxEeSuMrNEGTimoA")]
[DisplayName("Fund")]
public partial record Fund1
{
    #nullable enable
    
    /// <summary>
    /// Name of the fund/sub fund.
    /// </summary>
    [IsoId("_pUqPF1-KEeS7xuKaq75oiQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Identification of the fund/sub fund with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_pUqPGF-KEeS7xuKaq75oiQ")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the fund/sub fund, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_pUqPFl-KEeS7xuKaq75oiQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OtherIdentification4? Identification { get; init; } 
    
    /// <summary>
    /// Currency of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWLwcxEeSuMrNEGTimoA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    [IsoId("__EBBkmAFEeSkSfzdpzkxXg")]
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("TradDtTm")]
    public DateAndDateTimeChoice_? TradeDateTime { get; init; } 
    
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [IsoId("__EBBk2AFEeSkSfzdpzkxXg")]
    [DisplayName("Previous Trade Date Time")]
    [IsoXmlTag("PrvsTradDtTm")]
    public DateAndDateTimeChoice_? PreviousTradeDateTime { get; init; } 
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWHQcxEeSuMrNEGTimoA")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    
    /// <summary>
    /// Previous total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWHwcxEeSuMrNEGTimoA")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Estimated total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWIQcxEeSuMrNEGTimoA")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_pgiWIwcxEeSuMrNEGTimoA")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Estimated consolidated net cash flow expressed as a percentage of the previous total NAV for the fund/sub fund.
    /// </summary>
    [IsoId("_2qUxoQdDEeSyIPzOZ6VzBQ")]
    [DisplayName("Estimated Percentage Of Fund Total NAV")]
    [IsoXmlTag("EstmtdPctgOfFndTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedPercentageOfFundTotalNAV { get; init; } 
    
    /// <summary>
    /// Estimated cash movement into the fund/sub fund.
    /// </summary>
    [IsoId("_wzHsEF-HEeS7xuKaq75oiQ")]
    [DisplayName("Estimated Cash In Forecast Details")]
    [IsoXmlTag("EstmtdCshInFcstDtls")]
    public CashInOutForecast7? EstimatedCashInForecastDetails { get; init; } 
    
    /// <summary>
    /// Estimated cash movement out of the fund/sub fund.
    /// </summary>
    [IsoId("_wzHsEV-HEeS7xuKaq75oiQ")]
    [DisplayName("Estimated Cash Out Forecast Details")]
    [IsoXmlTag("EstmtdCshOutFcstDtls")]
    public CashInOutForecast7? EstimatedCashOutForecastDetails { get; init; } 
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    [IsoId("_wzHsEl-HEeS7xuKaq75oiQ")]
    [DisplayName("Estimated Net Cash Forecast Details")]
    [IsoXmlTag("EstmtdNetCshFcstDtls")]
    public NetCashForecast5? EstimatedNetCashForecastDetails { get; init; } 
    
    
    #nullable disable
    
}
