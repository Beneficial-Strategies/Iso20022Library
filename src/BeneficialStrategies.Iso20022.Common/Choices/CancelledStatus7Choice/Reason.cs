// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus7Choice
{
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_cqViq1hlEeSsH9MSoogb7Q")]
    [DisplayName("Reason")]
    public record Reason : CancelledStatus7Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
        /// </summary>
        [IsoId("_dHW11VhlEeSsH9MSoogb7Q")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required CancelledReason5Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_dHW13VhlEeSsH9MSoogb7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
