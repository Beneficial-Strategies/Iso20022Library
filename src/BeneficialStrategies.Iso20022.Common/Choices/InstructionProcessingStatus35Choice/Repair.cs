// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus35Choice
{
    /// <summary>
    /// Instruction/request is accepted but in repair.
    /// </summary>
    [IsoId("_iE4OkffZEeiNZp_PtLohLw")]
    [DisplayName("Repair")]
    public record Repair : InstructionProcessingStatus35Choice_ { }
}
