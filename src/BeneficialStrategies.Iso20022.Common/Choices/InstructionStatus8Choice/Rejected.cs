// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus8Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction and on the reason for the rejection.
    /// </summary>
    [IsoId("_9DhyVa-nEemJ1NnLPsTFaw")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionStatus8Choice_ { }
}
