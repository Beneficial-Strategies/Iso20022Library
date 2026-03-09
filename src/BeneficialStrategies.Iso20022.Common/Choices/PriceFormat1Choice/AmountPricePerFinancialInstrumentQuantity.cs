// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat1Choice
{
    /// <summary>
    /// Price expressed as an amount per a quantity of financial instruments.
    /// </summary>
    [IsoId("_QatkGNp-Ed-ak6NoX_4Aeg_-935448703")]
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AmountPricePerFinancialInstrumentQuantity : PriceFormat1Choice_
    #else
    public partial class AmountPricePerFinancialInstrumentQuantity : PriceFormat1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AmountPricePerFinancialInstrumentQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AmountPricePerFinancialInstrumentQuantity( AmountPriceType1FormatChoice_ reqAmountPriceType,ActiveCurrencyAnd13DecimalAmount reqPriceValue,UnitOrFaceAmount1Choice_ reqFinancialInstrumentQuantity )
        {
            AmountPriceType = reqAmountPriceType;
            PriceValue = reqPriceValue;
            FinancialInstrumentQuantity = reqFinancialInstrumentQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QbAfB9p-Ed-ak6NoX_4Aeg_-1342218248")]
        [DisplayName("Amount Price Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AmtPricTp")]
        #endif
        [IsoXmlTag("AmtPricTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
        #else
        public AmountPriceType1FormatChoice_ AmountPriceType { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QbJo8Np-Ed-ak6NoX_4Aeg_-1342218247")]
        [DisplayName("Price Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PricVal")]
        #endif
        [IsoXmlTag("PricVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        #else
        public ActiveCurrencyAnd13DecimalAmount PriceValue { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of financial instrument.
        /// </summary>
        [IsoId("_QbJo8dp-Ed-ak6NoX_4Aeg_-1312665173")]
        [DisplayName("Financial Instrument Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmQty")]
        #endif
        [IsoXmlTag("FinInstrmQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; init; } 
        #else
        public UnitOrFaceAmount1Choice_ FinancialInstrumentQuantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
