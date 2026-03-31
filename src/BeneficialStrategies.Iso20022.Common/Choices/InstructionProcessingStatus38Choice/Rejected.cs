// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus38Choice
{
    /// <summary>
    /// Provides status information related to an instruction request rejected for further processing due to system reasons.
    /// </summary>
    [IsoId("_lrrtg-XyEemEj48jhmlA0Q")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionProcessingStatus38Choice_ { }
}
