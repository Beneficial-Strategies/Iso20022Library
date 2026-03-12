// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat1Choice
{
    /// <summary>
    /// Price expressed as an amount per another amount.
    /// </summary>
    [IsoId("_QatkGdp-Ed-ak6NoX_4Aeg_-935448702")]
    [DisplayName("Amount Price Per Amount")]
    public partial record AmountPricePerAmount : PriceFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QbAfA9p-Ed-ak6NoX_4Aeg_-512832907")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1FormatChoice_ AmountPriceType { get; init; } 
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QbAfBNp-Ed-ak6NoX_4Aeg_-512832899")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        
        /// <summary>
        /// The amount.
        /// </summary>
        [IsoId("_QbAfBdp-Ed-ak6NoX_4Aeg_-510984913")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        
        
        #nullable disable
        
    }
}
