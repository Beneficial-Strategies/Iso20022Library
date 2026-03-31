// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus81Choice
{
    /// <summary>
    /// Instruction/request has been cancelled.
    /// </summary>
    [IsoId("_qTGP_SAdEeuyDZ-ukt4YRg")]
    [DisplayName("Cancelled")]
    public record Cancelled : ProcessingStatus81Choice_ { }
}
