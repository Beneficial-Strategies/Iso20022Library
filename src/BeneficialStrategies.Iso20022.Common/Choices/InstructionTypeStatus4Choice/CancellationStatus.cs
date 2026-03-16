// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionTypeStatus4Choice
{
    /// <summary>
    /// Status of the meeting instruction cancellation request message or of the individual meeting instruction cancellation request(s). The message is identified in InstructionType/InstructionCancellationIdentification.
    /// </summary>
    [IsoId("_bGDXM_NfEeqRfth943bvEA")]
    [DisplayName("Cancellation Status")]
    public record CancellationStatus : InstructionTypeStatus4Choice_ { }
}
