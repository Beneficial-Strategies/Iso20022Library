// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus13Choice
{
    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    public partial record ProcessingStatus : InstructionStatus13Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PrcgSts")]
        public required InstructionProcessingStatus6 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
