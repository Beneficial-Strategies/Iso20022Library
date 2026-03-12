// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormatSD2Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_ssO__aFWEeSK_vfd3NHBGg")]
    [DisplayName("Not Specified Price")]
    public partial record NotSpecifiedPrice : PriceFormatSD2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a price.
        /// </summary>
        [IsoXmlTag("NotSpcfdPric")]
        public required PriceValueType10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
