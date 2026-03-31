// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus15Choice
{
    /// <summary>
    /// Provides status information related to a pending instruction.
    /// </summary>
    [IsoId("_R-pFKydxEeOXAt_43VmZGw")]
    [DisplayName("Pending")]
    public record Pending : InstructionProcessingStatus15Choice_ { }
}
