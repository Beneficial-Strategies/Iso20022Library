// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus39Choice
{
    /// <summary>
    /// Instruction is cancelled.
    /// </summary>
    [IsoId("_A29YsCzSEeOsiuMH68so7Q")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus39Choice_ { }
}
