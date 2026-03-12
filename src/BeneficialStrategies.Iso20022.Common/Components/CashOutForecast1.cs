// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[IsoId("_VCMsk9p-Ed-ak6NoX_4Aeg_1696035871")]
[DisplayName("Cash Out Forecast")]
public partial record CashOutForecast1
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_VCMslNp-Ed-ak6NoX_4Aeg_1696035896")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; } 
    
    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_VCMsldp-Ed-ak6NoX_4Aeg_1696035966")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    
    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_VCMsltp-Ed-ak6NoX_4Aeg_1696035931")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether the estimated cash flow out is exceptional.
    /// </summary>
    [IsoId("_VCMsl9p-Ed-ak6NoX_4Aeg_1696036299")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    
    /// <summary>
    /// Breakdown of cash out amounts, eg, by transaction or order type.
    /// </summary>
    [IsoId("_VCMsmNp-Ed-ak6NoX_4Aeg_182095879")]
    [DisplayName("Cash Out Breakdown Details")]
    [IsoXmlTag("CshOutBrkdwnDtls")]
    public FundCashOutBreakdown1? CashOutBreakdownDetails { get; init; } 
    
    
    #nullable disable
    
}
