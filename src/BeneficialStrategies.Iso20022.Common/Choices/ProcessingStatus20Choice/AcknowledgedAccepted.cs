// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus20Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_Mx8yd_4xEeClUvPNHKL9Zw")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ProcessingStatus20Choice_ { }
}
