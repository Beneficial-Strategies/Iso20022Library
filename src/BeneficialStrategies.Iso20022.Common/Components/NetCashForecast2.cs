// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net cash movement to a fund as a result of investment funds transactions.
/// </summary>
[IsoId("_Si5_qdp-Ed-ak6NoX_4Aeg_1576231276")]
[DisplayName("Net Cash Forecast")]
public partial record NetCashForecast2
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SjDJkNp-Ed-ak6NoX_4Aeg_1576231733")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_SjDJkdp-Ed-ak6NoX_4Aeg_1576232604")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [IsoId("_SjDJktp-Ed-ak6NoX_4Aeg_1576233646")]
    [DisplayName("Net Units Number")]
    [IsoXmlTag("NetUnitsNb")]
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; } 
    
    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [IsoId("_SjDJk9p-Ed-ak6NoX_4Aeg_1576234067")]
    [DisplayName("Flow Direction")]
    [IsoXmlTag("FlowDrctn")]
    public required FlowDirectionType1Code FlowDirection { get; init; } 
    
    
    #nullable disable
    
}
