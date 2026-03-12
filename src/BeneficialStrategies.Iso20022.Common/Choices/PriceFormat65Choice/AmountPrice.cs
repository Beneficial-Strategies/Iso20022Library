// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat65Choice
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_MVDyyxuyEeyhRdHRjakS2w")]
    [DisplayName("Amount Price")]
    public partial record AmountPrice : PriceFormat65Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of amount price.
        /// </summary>
        [IsoId("_QaQ4KNp-Ed-ak6NoX_4Aeg_-1667090318")]
        [DisplayName("Amount Price Type")]
        [IsoXmlTag("AmtPricTp")]
        public required AmountPriceType1Code AmountPriceType { get; init; } 
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_QaQ4Kdp-Ed-ak6NoX_4Aeg_-1667090300")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        public required ActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
        
        
        #nullable disable
        
    }
}
