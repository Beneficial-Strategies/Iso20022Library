// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RateFormat24Choice
{
    /// <summary>
    /// Not Specified Rate.
    /// </summary>
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : RateFormat24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
