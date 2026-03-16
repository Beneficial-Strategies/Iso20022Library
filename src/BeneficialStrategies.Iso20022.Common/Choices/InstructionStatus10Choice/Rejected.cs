// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus10Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction and on the reason for the rejection.
    /// </summary>
    [IsoId("_cBRCRfNfEeqRfth943bvEA")]
    [DisplayName("Rejected")]
    public record Rejected : InstructionStatus10Choice_ { }
}
