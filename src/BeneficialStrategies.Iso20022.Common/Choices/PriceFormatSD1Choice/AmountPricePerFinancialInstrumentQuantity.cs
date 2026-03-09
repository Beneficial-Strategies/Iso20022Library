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
namespace BeneficialStrategies.Iso20022.Choices.PriceFormatSD1Choice
{
    /// <summary>
    /// Price expressed as a ratio: amount price per financial instrument quantity.
    /// </summary>
    [IsoId("_1lQORDL3EeKU9IrkkToqcw_1686025671")]
    [DisplayName("Amount Price Per Financial Instrument Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AmountPricePerFinancialInstrumentQuantity : PriceFormatSD1Choice_
    #else
    public partial class AmountPricePerFinancialInstrumentQuantity : PriceFormatSD1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AmountPricePerFinancialInstrumentQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AmountPricePerFinancialInstrumentQuantity( AmountPriceType1Code reqAmountPriceType,RestrictedFINActiveCurrencyAnd13DecimalAmount reqPriceValue,FinancialInstrumentQuantity15Choice_ reqFinancialInstrumentQuantity )
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
        [IsoId("_WjDbUNp-Ed-ak6NoX_4Aeg_613105185")]
        [DisplayName("Amount Price Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AmtPricTp")]
        #endif
        [IsoXmlTag("AmtPricTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AmountPriceType1Code AmountPriceType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AmountPriceType1Code AmountPriceType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountPriceType1Code AmountPriceType { get; init; } 
        #else
        public AmountPriceType1Code AmountPriceType { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_WjDbUdp-Ed-ak6NoX_4Aeg_-1381039521")]
        [DisplayName("Price Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PricVal")]
        #endif
        [IsoXmlTag("PricVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        #else
        public RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of financial instrument.
        /// </summary>
        [IsoId("_WjDbUtp-Ed-ak6NoX_4Aeg_1787125323")]
        [DisplayName("Financial Instrument Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmQty")]
        #endif
        [IsoXmlTag("FinInstrmQty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; init; } 
        #else
        public FinancialInstrumentQuantity15Choice_ FinancialInstrumentQuantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
