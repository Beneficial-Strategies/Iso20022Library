// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition5Choice
{
    /// <summary>
    /// Processing position expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_hlli2Q4AEeKN_Y-2Awiamw")]
    [DisplayName("Code")]
    public partial record Code : ProcessingPosition5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProcessingPosition4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
