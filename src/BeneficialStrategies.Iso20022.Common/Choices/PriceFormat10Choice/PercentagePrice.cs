// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat10Choice
{
    /// <summary>
    /// Price expressed as a percentage.
    /// </summary>
    [IsoId("_Q4z1Vtp-Ed-ak6NoX_4Aeg_-1792370446")]
    [DisplayName("Percentage Price")]
    public partial record PercentagePrice : PriceFormat10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the type of percentage price.
        /// </summary>
        [IsoId("_QaaCENp-Ed-ak6NoX_4Aeg_724274055")]
        [DisplayName("Percentage Price Type")]
        [IsoXmlTag("PctgPricTp")]
        public required PriceRateType3Code PercentagePriceType { get; init; } 
        
        /// <summary>
        /// Specifies the value of price.
        /// </summary>
        [IsoId("_QaaCEdp-Ed-ak6NoX_4Aeg_724274080")]
        [DisplayName("Price Value")]
        [IsoXmlTag("PricVal")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public required IsoPercentageRate PriceValue { get; init; } 
        
        
        #nullable disable
        
    }
}
