// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus66Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_BvN4ceFUEeWIA4E9cYSxxQ")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ProcessingStatus66Choice_ { }
}
