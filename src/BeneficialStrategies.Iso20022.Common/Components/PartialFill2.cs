// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_GY0N8TAjEeOUGqA1wUwNLA")]
[DisplayName("Partial Fill")]
public partial record PartialFill2
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument to be ordered.
    /// </summary>
    [IsoId("_GwK-BTAjEeOUGqA1wUwNLA")]
    [DisplayName("Confirmation Quantity")]
    [IsoXmlTag("ConfQty")]
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_GwK-DTAjEeOUGqA1wUwNLA")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price4 DealPrice { get; init; } 
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_GwK-DzAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate4Choice_? TradeDate { get; init; } 
    
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_GwK-FzAjEeOUGqA1wUwNLA")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification80? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_GwK-HzAjEeOUGqA1wUwNLA")]
    [DisplayName("Original Ordered Quantity")]
    [IsoXmlTag("OrgnlOrdrdQty")]
    public required QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// </summary>
    [IsoId("_GwK-JzAjEeOUGqA1wUwNLA")]
    [DisplayName("Previously Executed Quantity")]
    [IsoXmlTag("PrevslyExctdQty")]
    public required QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument that is remaining in order.
    /// </summary>
    [IsoId("_GwK-LzAjEeOUGqA1wUwNLA")]
    [DisplayName("Remaining Quantity")]
    [IsoXmlTag("RmngQty")]
    public required QuantityOrAmount1Choice_ RemainingQuantity { get; init; } 
    
    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// </summary>
    [IsoId("_GwK-NzAjEeOUGqA1wUwNLA")]
    [DisplayName("Match Increment Quantity")]
    [IsoXmlTag("MtchIncrmtQty")]
    public QuantityOrAmount1Choice_? MatchIncrementQuantity { get; init; } 
    
    
    #nullable disable
    
}
