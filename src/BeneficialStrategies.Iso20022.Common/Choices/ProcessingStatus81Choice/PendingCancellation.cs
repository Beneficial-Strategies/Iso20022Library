// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus81Choice
{
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending, waiting for further processing.
    /// </summary>
    [IsoId("_qTGQASAdEeuyDZ-ukt4YRg")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : ProcessingStatus81Choice_ { }
}
