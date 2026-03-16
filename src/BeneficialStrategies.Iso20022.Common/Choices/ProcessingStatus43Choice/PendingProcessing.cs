// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice
{
    /// <summary>
    /// Status of the standing settlement instruction, cancellation or deletion is pending.
    /// </summary>
    [IsoId("_fDHA81hFEeOMYfRGLS0NbA")]
    [DisplayName("Pending Processing")]
    public record PendingProcessing : ProcessingStatus43Choice_
    {
        /// <summary>
        /// Reason for the pending status.
        /// </summary>
        [IsoId("_1vFkNFj2EeOnqqBHs8Gasw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required PendingProcessingReason9Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the processed instruction.
        /// </summary>
        [IsoId("_1vE9K1j2EeOnqqBHs8Gasw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
