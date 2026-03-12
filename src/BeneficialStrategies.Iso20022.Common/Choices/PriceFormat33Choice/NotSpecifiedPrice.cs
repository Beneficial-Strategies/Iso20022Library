// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat33Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_sNHAdyXtEeO4bIO_HtGo9Q")]
    [DisplayName("Not Specified Price")]
    public partial record NotSpecifiedPrice : PriceFormat33Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of price value.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
