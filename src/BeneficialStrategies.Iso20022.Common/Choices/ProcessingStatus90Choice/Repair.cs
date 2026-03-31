// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus90Choice
{
    /// <summary>
    /// Instruction/Request is accepted but in repair.
    /// </summary>
    [IsoId("_ddARbDi8Eeydid5dcNPKvg")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus90Choice_ { }
}
