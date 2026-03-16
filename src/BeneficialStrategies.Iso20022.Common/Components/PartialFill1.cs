// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_ApW7idokEeC60axPepSq7g_-431538170")]
[DisplayName("Partial Fill")]
public record PartialFill1
{
    /// <summary>
    /// Quantity of financial instrument to be ordered.
    /// </summary>
    [IsoId("_ApW7itokEeC60axPepSq7g_-545377236")]
    [DisplayName("Confirmation Quantity")]
    [IsoXmlTag("ConfQty")]
    public required Quantity6Choice_ ConfirmationQuantity { get; init; }

    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_ApW7i9okEeC60axPepSq7g_-1594835659")]
    [DisplayName("Deal Price")]
    [IsoXmlTag("DealPric")]
    public required Price4 DealPrice { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_ApW7jNokEeC60axPepSq7g_-947027177")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate4Choice_? TradeDate { get; init; }

    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_ApgFcNokEeC60axPepSq7g_-1944099530")]
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification13? PlaceOfTrade { get; init; }

    /// <summary>
    /// Quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_ApgFcdokEeC60axPepSq7g_-1186616405")]
    [DisplayName("Original Ordered Quantity")]
    [IsoXmlTag("OrgnlOrdrdQty")]
    public required QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// </summary>
    [IsoId("_ApgFctokEeC60axPepSq7g_925191254")]
    [DisplayName("Previously Executed Quantity")]
    [IsoXmlTag("PrevslyExctdQty")]
    public required QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; init; }

    /// <summary>
    /// Quantity of financial instrument that is remaining in order.
    /// </summary>
    [IsoId("_ApgFc9okEeC60axPepSq7g_-1434963979")]
    [DisplayName("Remaining Quantity")]
    [IsoXmlTag("RmngQty")]
    public required QuantityOrAmount1Choice_ RemainingQuantity { get; init; }

    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// </summary>
    [IsoId("_ApgFdNokEeC60axPepSq7g_-1983425373")]
    [DisplayName("Match Increment Quantity")]
    [IsoXmlTag("MtchIncrmtQty")]
    public QuantityOrAmount1Choice_? MatchIncrementQuantity { get; init; }
}
