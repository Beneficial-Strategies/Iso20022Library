// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DefaultProcessingOrStandingInstruction2Choice
{
    /// <summary>
    /// Standing Instruction Indicator.
    /// </summary>
    [DisplayName("Standing Instruction Indicator")]
    public partial record StandingInstructionIndicator : DefaultProcessingOrStandingInstruction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StgInstrInd")]
        public required IsoYesNoIndicator Value { get; init; } 
        
        
        #nullable disable
        
    }
}
