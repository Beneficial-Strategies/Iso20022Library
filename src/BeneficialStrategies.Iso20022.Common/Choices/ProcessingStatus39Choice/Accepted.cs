// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus39Choice
{
    /// <summary>
    /// Instruction is accepted.
    /// </summary>
    [IsoId("_B_HTkCzSEeOsiuMH68so7Q")]
    [DisplayName("Accepted")]
    public record Accepted : ProcessingStatus39Choice_ { }
}
