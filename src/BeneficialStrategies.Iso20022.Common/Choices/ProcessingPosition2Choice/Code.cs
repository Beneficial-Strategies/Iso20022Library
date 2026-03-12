// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition2Choice
{
    /// <summary>
    /// Processing position expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QtogENp-Ed-ak6NoX_4Aeg_-730269399")]
    [DisplayName("Code")]
    public partial record Code : ProcessingPosition2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates when an instruction is to be executed relative to a linked instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingPosition1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
