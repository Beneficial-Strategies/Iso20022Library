// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus45Choice
{
    /// <summary>
    /// Instruction has been acknowledged by the account servicer.
    /// </summary>
    [IsoId("_i0ct21hgEeS8HfHHd4stCA")]
    [DisplayName("Acknowledged Accepted")]
    public record AcknowledgedAccepted : ProcessingStatus45Choice_ { }
}
