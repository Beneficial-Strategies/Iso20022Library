// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OptionAvailabilityStatus4Choice
{
    /// <summary>
    /// Standard code to specify the status of the option availability.
    /// </summary>
    [IsoId("_cta-LZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : OptionAvailabilityStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the option availability.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OptionAvailabilityStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
