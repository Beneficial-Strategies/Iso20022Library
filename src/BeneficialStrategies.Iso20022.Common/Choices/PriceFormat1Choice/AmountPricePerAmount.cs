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
    /// Price expressed as an amount per another amount.
    /// </summary>
    [IsoId("_QatkGdp-Ed-ak6NoX_4Aeg_-935448702")]
    [DisplayName("Amount Price Per Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AmountPricePerAmount : PriceFormat1Choice_
    #else
    public partial class AmountPricePerAmount : PriceFormat1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AmountPricePerAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AmountPricePerAmount( AmountPriceType1FormatChoice_ reqAmountPriceType,ActiveCurrencyAnd13DecimalAmount reqPriceValue,ActiveCurrencyAnd13DecimalAmount reqAmount )
        {
            AmountPriceType = reqAmountPriceType;
            PriceValue = reqPriceValue;
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QbAfA9p-Ed-ak6NoX_4Aeg_-512832907")]
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
        [IsoId("_QbAfBNp-Ed-ak6NoX_4Aeg_-512832899")]
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
        /// The amount.
        /// </summary>
        [IsoId("_QbAfBdp-Ed-ak6NoX_4Aeg_-510984913")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #else
        public ActiveCurrencyAnd13DecimalAmount Amount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
