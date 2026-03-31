// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus43Choice
{
    /// <summary>
    /// Status of the standing settlement instruction, cancellation or deletion is rejected.
    /// </summary>
    [IsoId("_fDHA9VhFEeOMYfRGLS0NbA")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public record Rejected : ProcessingStatus43Choice_
    {
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_qopCAFj7EeOgwYxfAV02bg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectedReason8Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the processed instruction.
        /// </summary>
        [IsoId("_qopB-1j7EeOgwYxfAV02bg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
