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
[IsoId("_EYWw0V-JEeS7xuKaq75oiQ")]
[DisplayName("Net Cash Forecast")]
public partial record NetCashForecast5
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_EzlUQ1-JEeS7xuKaq75oiQ")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_EzlURV-JEeS7xuKaq75oiQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [IsoId("_EzlUR1-JEeS7xuKaq75oiQ")]
    [DisplayName("Net Units Number")]
    [IsoXmlTag("NetUnitsNb")]
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; } 
    
    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [IsoId("_EzlUSV-JEeS7xuKaq75oiQ")]
    [DisplayName("Flow Direction")]
    [IsoXmlTag("FlowDrctn")]
    public required FlowDirectionType1Code FlowDirection { get; init; } 
    
    
    #nullable disable
    
}
