// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat29Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_i3ZHB_o1EeCqjOT-vUu2sQ")]
    [DisplayName("Amount Price")]
    public partial record AmountPrice : PriceFormat29Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QaHHI9p-Ed-ak6NoX_4Aeg_141257751")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType2Code AmountPriceType { get; init; } 
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QaHHJNp-Ed-ak6NoX_4Aeg_94966020")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        
        
        #nullable disable
        
    }
}
