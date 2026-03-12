// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_ntOsvXg-Eeu3kecHd7QKUQ")]
[DisplayName("Counterparty")]
public partial record Counterparty34
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty of the contract.
    /// </summary>
    [IsoId("_n79FMXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required OrganisationIdentification10Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Indicates if the reporting counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_n79FM3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public CounterpartyTradeNature9Choice_? Nature { get; init; } 
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_n79FNXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Trading Capacity")]
    [IsoXmlTag("TradgCpcty")]
    public TradingCapacity7Code? TradingCapacity { get; init; } 
    
    /// <summary>
    /// Indicates the direction of the derivative transaction from the perspective of the reporting counterparty.
    /// Usage:
    /// DirectionOfTheFirstLeg should be used for most swaps and swap-like contracts including interest rate swaps, credit total return swaps, and equity swaps (except for credit default swaps, variance, volatility, and correlation swaps) as well as for the foreign exchange swaps, forwards and non-deliverable forwards.
    /// CounterpartySide should be used for the instruments such as most forwards and forward-like contracts (except for foreign exchange forwards and foreign exchange non-deliverable forwards); most options and option-like contracts including swaptions, caps and floors; credit default swaps; variance, volatility and correlation swaps; contracts for difference and spreadbets.
    /// </summary>
    [IsoId("_n79FN3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Direction")]
    [IsoXmlTag("Drctn")]
    public Direction2Choice_? Direction { get; init; } 
    
    
    #nullable disable
    
}
