// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status23Choice
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_8VHUQZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Status")]
    public record InstructionProcessingStatus : Status23Choice_ { }
}
