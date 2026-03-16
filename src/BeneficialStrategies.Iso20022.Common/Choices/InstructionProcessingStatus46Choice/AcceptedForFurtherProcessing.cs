// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus46Choice
{
    /// <summary>
    /// Provides status information related to an instruction request that is accepted. This means that the instruction has been received, is processable and has been validated for further processing.
    /// </summary>
    [IsoId("_dxaPexnyEeyroI8qKgB7Mg")]
    [DisplayName("Accepted For Further Processing")]
    public record AcceptedForFurtherProcessing : InstructionProcessingStatus46Choice_ { }
}
