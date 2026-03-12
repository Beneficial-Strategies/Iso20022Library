// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceValueType5FormatChoice
{
    /// <summary>
    /// Standard code to specify the value of a price.
    /// </summary>
    [IsoId("_RnAYF9p-Ed-ak6NoX_4Aeg_-121428172")]
    [DisplayName("Code")]
    public partial record Code : PriceValueType5FormatChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a price.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PriceValueType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
