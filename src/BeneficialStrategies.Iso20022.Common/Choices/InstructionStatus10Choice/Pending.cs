// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus10Choice
{
    /// <summary>
    /// Status advising that the instruction is pending and advising on the reason for the pending status.
    /// </summary>
    [IsoId("_cBRCR_NfEeqRfth943bvEA")]
    [DisplayName("Pending")]
    public record Pending : InstructionStatus10Choice_ { }
}
