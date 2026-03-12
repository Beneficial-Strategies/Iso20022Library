// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value date and the amounts traded in a foreign exchange transaction.
/// </summary>
[IsoId("_c87_EQNhEe2-vqzwMUAewg")]
[DisplayName("Amounts And Value Date")]
public partial record AmountsAndValueDate6
{
    #nullable enable
    
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade.
    /// </summary>
    [IsoId("_dCcxMQNhEe2-vqzwMUAewg")]
    [DisplayName("Trading Side Buy Amount")]
    [IsoXmlTag("TradgSdBuyAmt")]
    public required CurrencyOrDigitalTokenAmount1Choice_ TradingSideBuyAmount { get; init; } 
    
    /// <summary>
    /// Currency and amount sold in a foreign exchange trade.
    /// </summary>
    [IsoId("_dCcxMwNhEe2-vqzwMUAewg")]
    [DisplayName("Trading Side Sell Amount")]
    [IsoXmlTag("TradgSdSellAmt")]
    public required CurrencyOrDigitalTokenAmount1Choice_ TradingSideSellAmount { get; init; } 
    
    /// <summary>
    /// Date on which the trade is settled, for example, the amounts are due.
    /// </summary>
    [IsoId("_dCcxNQNhEe2-vqzwMUAewg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SettlementDate { get; init; } 
    
    
    #nullable disable
    
}
