// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net cash movements to a fund as a result of investment funds transactions.
/// </summary>
[IsoId("_VB5xptp-Ed-ak6NoX_4Aeg_906159660")]
[DisplayName("Net Cash Forecast")]
public partial record NetCashForecast1
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_VB5xp9p-Ed-ak6NoX_4Aeg_870568569")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_VB5xqNp-Ed-ak6NoX_4Aeg_906159679")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [IsoId("_VB5xqdp-Ed-ak6NoX_4Aeg_-189402816")]
    [DisplayName("Net Units Number")]
    [IsoXmlTag("NetUnitsNb")]
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; } 
    
    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [IsoId("_VCC7kNp-Ed-ak6NoX_4Aeg_906159720")]
    [DisplayName("Flow Direction")]
    [IsoXmlTag("FlowDrctn")]
    public required FlowDirectionType1Code FlowDirection { get; init; } 
    
    
    #nullable disable
    
}
