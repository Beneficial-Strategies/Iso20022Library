// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat10Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_Q4z1WNp-Ed-ak6NoX_4Aeg_-1792370793")]
    [DisplayName("Not Specified Price")]
    public partial record NotSpecifiedPrice : PriceFormat10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a price.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
