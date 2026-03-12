// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of the financial instrument subscribed.
/// </summary>
[IsoId("_SGABM9p-Ed-ak6NoX_4Aeg_345752631")]
[DisplayName("Financial Instrument Quantity")]
public partial record FinancialInstrumentQuantity2
{
    #nullable enable
    
    /// <summary>
    /// Quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_SGABNNp-Ed-ak6NoX_4Aeg_345752649")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    
    /// <summary>
    /// Amount of money to be invested.
    /// </summary>
    [IsoId("_SGABNdp-Ed-ak6NoX_4Aeg_345752726")]
    [DisplayName("Ordered Amount")]
    [IsoXmlTag("OrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OrderedAmount { get; init; } 
    
    /// <summary>
    /// Amount of money invested after deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SGABNtp-Ed-ak6NoX_4Aeg_345753034")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    
    /// <summary>
    /// Amount of money invested before deduction of charges, commissions and taxes.
    /// </summary>
    [IsoId("_SGABN9p-Ed-ak6NoX_4Aeg_345753284")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    
    /// <summary>
    /// Amount of money invested.
    /// </summary>
    [IsoId("_SGABONp-Ed-ak6NoX_4Aeg_1692243831")]
    [DisplayName("Executed Amount")]
    [IsoXmlTag("ExctdAmt")]
    public ActiveCurrencyAndAmount? ExecutedAmount { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SGABOdp-Ed-ak6NoX_4Aeg_1448437730")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    
    #nullable disable
    
}
