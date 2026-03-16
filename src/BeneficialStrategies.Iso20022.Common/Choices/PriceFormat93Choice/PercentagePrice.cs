// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat93Choice
{
    /// <summary>
    /// Percentage Price.
    /// </summary>
    [DisplayName("Percentage Price")]
    public partial record PercentagePrice : PriceFormat93Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PctgPric")]
        public required PercentagePrice3 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
