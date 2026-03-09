// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_GY0N8TAjEeOUGqA1wUwNLA")]
[DisplayName("Partial Fill")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartialFill2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartialFill2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartialFill2( Quantity6Choice_ reqConfirmationQuantity,Price4 reqDealPrice,QuantityOrAmount1Choice_ reqOriginalOrderedQuantity,QuantityOrAmount1Choice_ reqPreviouslyExecutedQuantity,QuantityOrAmount1Choice_ reqRemainingQuantity )
    {
        ConfirmationQuantity = reqConfirmationQuantity;
        DealPrice = reqDealPrice;
        OriginalOrderedQuantity = reqOriginalOrderedQuantity;
        PreviouslyExecutedQuantity = reqPreviouslyExecutedQuantity;
        RemainingQuantity = reqRemainingQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument to be ordered.
    /// </summary>
    [IsoId("_GwK-BTAjEeOUGqA1wUwNLA")]
    [DisplayName("Confirmation Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfQty")]
    #endif
    [IsoXmlTag("ConfQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #else
    public Quantity6Choice_ ConfirmationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_GwK-DTAjEeOUGqA1wUwNLA")]
    [DisplayName("Deal Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealPric")]
    #endif
    [IsoXmlTag("DealPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Price4 DealPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Price4 DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4 DealPrice { get; init; } 
    #else
    public Price4 DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_GwK-DzAjEeOUGqA1wUwNLA")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate4Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate4Choice_? TradeDate { get; init; } 
    #else
    public TradeDate4Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_GwK-FzAjEeOUGqA1wUwNLA")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification80? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification80? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification80? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_GwK-HzAjEeOUGqA1wUwNLA")]
    [DisplayName("Original Ordered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlOrdrdQty")]
    #endif
    [IsoXmlTag("OrgnlOrdrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; init; } 
    #else
    public QuantityOrAmount1Choice_ OriginalOrderedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// </summary>
    [IsoId("_GwK-JzAjEeOUGqA1wUwNLA")]
    [DisplayName("Previously Executed Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrevslyExctdQty")]
    #endif
    [IsoXmlTag("PrevslyExctdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; init; } 
    #else
    public QuantityOrAmount1Choice_ PreviouslyExecutedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument that is remaining in order.
    /// </summary>
    [IsoId("_GwK-LzAjEeOUGqA1wUwNLA")]
    [DisplayName("Remaining Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngQty")]
    #endif
    [IsoXmlTag("RmngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityOrAmount1Choice_ RemainingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityOrAmount1Choice_ RemainingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount1Choice_ RemainingQuantity { get; init; } 
    #else
    public QuantityOrAmount1Choice_ RemainingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// </summary>
    [IsoId("_GwK-NzAjEeOUGqA1wUwNLA")]
    [DisplayName("Match Increment Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchIncrmtQty")]
    #endif
    [IsoXmlTag("MtchIncrmtQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityOrAmount1Choice_? MatchIncrementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityOrAmount1Choice_? MatchIncrementQuantity { get; init; } 
    #else
    public QuantityOrAmount1Choice_? MatchIncrementQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
