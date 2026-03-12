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
[IsoId("_3k2WFQd4Ee2fOITqoTnSLQ")]
[DisplayName("Partial Fill")]
public partial record PartialFill4
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument to be ordered.
    /// </summary>
    [IsoId("_34ENBQd4Ee2fOITqoTnSLQ")]
    [DisplayName("Confirmation Quantity")]
    [IsoXmlTag("ConfQty")]
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_34ENDQd4Ee2fOITqoTnSLQ")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price14 DealPrice { get; init; } 
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_34ENDwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate7Choice_? TradeDate { get; init; } 
    
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_34ENFwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification97? PlaceOfTrade { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_34ENHwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Original Ordered Quantity")]
    [IsoXmlTag("OrgnlOrdrdQty")]
    public required QuantityOrAmount2Choice_ OriginalOrderedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// </summary>
    [IsoId("_34ENJwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Previously Executed Quantity")]
    [IsoXmlTag("PrevslyExctdQty")]
    public required QuantityOrAmount2Choice_ PreviouslyExecutedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of financial instrument that is remaining in order.
    /// </summary>
    [IsoId("_34ENLwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Remaining Quantity")]
    [IsoXmlTag("RmngQty")]
    public required QuantityOrAmount2Choice_ RemainingQuantity { get; init; } 
    
    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// </summary>
    [IsoId("_34ENNwd4Ee2fOITqoTnSLQ")]
    [DisplayName("Match Increment Quantity")]
    [IsoXmlTag("MtchIncrmtQty")]
    public QuantityOrAmount2Choice_? MatchIncrementQuantity { get; init; } 
    
    
    #nullable disable
    
}
