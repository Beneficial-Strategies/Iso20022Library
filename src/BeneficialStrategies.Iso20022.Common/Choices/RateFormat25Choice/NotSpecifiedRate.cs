// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateFormat25Choice
{
    /// <summary>
    /// Not Specified Rate.
    /// </summary>
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : RateFormat25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType10Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
