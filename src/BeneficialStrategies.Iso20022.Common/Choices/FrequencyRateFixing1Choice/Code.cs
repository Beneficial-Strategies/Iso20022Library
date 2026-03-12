// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FrequencyRateFixing1Choice
{
    /// <summary>
    /// Frequency rate fixing expressed as a code.
    /// </summary>
    [IsoId("_p0WokI9PEeqMo4JxiuZGSw")]
    [DisplayName("Code")]
    public partial record Code : FrequencyRateFixing1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Defines the frequency rate fixing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FrequencyRateFixing1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
