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
/// Specifies a ratio: amount price and price fixing date per financial instrument quantity.
/// </summary>
[IsoId("_zuw0oTpyEemk2e6qGBk8IQ")]
[DisplayName("Amount Price Per Financial Instrument Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountPricePerFinancialInstrumentQuantity9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountPricePerFinancialInstrumentQuantity9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountPricePerFinancialInstrumentQuantity9( YieldedOrValueType1Choice_ reqAmountPriceType,PriceRateOrAmount3Choice_ reqPriceValue,FinancialInstrumentQuantity1Choice_ reqFinancialInstrumentQuantity,System.DateOnly reqPriceFixingDate )
    {
        AmountPriceType = reqAmountPriceType;
        PriceValue = reqPriceValue;
        FinancialInstrumentQuantity = reqFinancialInstrumentQuantity;
        PriceFixingDate = reqPriceFixingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_z5pO8TpyEemk2e6qGBk8IQ")]
    [DisplayName("Amount Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtPricTp")]
    #endif
    [IsoXmlTag("AmtPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required YieldedOrValueType1Choice_ AmountPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required YieldedOrValueType1Choice_ AmountPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public YieldedOrValueType1Choice_ AmountPriceType { get; init; } 
    #else
    public YieldedOrValueType1Choice_ AmountPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// Value given to a price.
    /// </summary>
    [IsoId("_z5pO-TpyEemk2e6qGBk8IQ")]
    [DisplayName("Price Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricVal")]
    #endif
    [IsoXmlTag("PricVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmount3Choice_ PriceValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceRateOrAmount3Choice_ PriceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmount3Choice_ PriceValue { get; init; } 
    #else
    public PriceRateOrAmount3Choice_ PriceValue { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument.
    /// </summary>
    [IsoId("_z5pPATpyEemk2e6qGBk8IQ")]
    [DisplayName("Financial Instrument Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmQty")]
    #endif
    [IsoXmlTag("FinInstrmQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ FinancialInstrumentQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the actual price for a financial instrument is fixed.
    /// </summary>
    [IsoId("_z5pPCTpyEemk2e6qGBk8IQ")]
    [DisplayName("Price Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricFxgDt")]
    #endif
    [IsoXmlTag("PricFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate PriceFixingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly PriceFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly PriceFixingDate { get; init; } 
    #else
    public System.DateOnly PriceFixingDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
