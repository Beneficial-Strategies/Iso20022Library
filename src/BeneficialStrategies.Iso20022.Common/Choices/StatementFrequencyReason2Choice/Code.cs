// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StatementFrequencyReason2Choice
{
    /// <summary>
    /// Statement frequency expressed as a code.
    /// </summary>
    [IsoId("_sGXPISDAEeWPMvNwVtiMsA")]
    [DisplayName("Code")]
    public partial record Code : StatementFrequencyReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required EventFrequency9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
