// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus45Choice
{
    /// <summary>
    /// Processing of the instruction/request is pending.
    /// </summary>
    [IsoId("_waWtlyAeEeuyDZ-ukt4YRg")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : InstructionProcessingStatus45Choice_ { }
}
