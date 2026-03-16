// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus81Choice
{
    /// <summary>
    /// Instruction/request is accepted but in repair.
    /// </summary>
    [IsoId("_qTGP-SAdEeuyDZ-ukt4YRg")]
    [DisplayName("Repair")]
    public record Repair : ProcessingStatus81Choice_ { }
}
