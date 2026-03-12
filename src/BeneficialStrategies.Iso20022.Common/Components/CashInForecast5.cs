// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
[IsoId("_JvLpTQatEeS3lpTattq7hg")]
[DisplayName("Cash In Forecast")]
public partial record CashInForecast5
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_KIxN8watEeS3lpTattq7hg")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as an amount of money.
    /// </summary>
    [IsoId("_KIxN9QatEeS3lpTattq7hg")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as a number of units.
    /// </summary>
    [IsoId("_KIxN9watEeS3lpTattq7hg")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the estimated cash flow in is exceptional.
    /// </summary>
    [IsoId("_KIxN-QatEeS3lpTattq7hg")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Breakdown of cash in amounts by transaction and order type.
    /// </summary>
    [IsoId("_KIxN-watEeS3lpTattq7hg")]
    [DisplayName("Cash In Breakdown Details")]
    [IsoXmlTag("CshInBrkdwnDtls")]
    public FundCashInBreakdown3? CashInBreakdownDetails { get; init; } 
    
    /// <summary>
    /// Additional balances for cash amounts and number of units. 
    /// In an estimated report, the total cash derived from orders placed as a number of units is an estimated cash amount and the total number of units derived from orders placed as a cash amount is an estimated number of units.
    /// </summary>
    [IsoId("_px_-4QdEEeSyIPzOZ6VzBQ")]
    [DisplayName("Additional Balance")]
    [IsoXmlTag("AddtlBal")]
    public FundBalance1? AdditionalBalance { get; init; } 
    
    
    #nullable disable
    
}
