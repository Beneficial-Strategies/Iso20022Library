// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus22Choice
{
    /// <summary>
    /// Status of the order cancellation request is rejected.
    /// </summary>
    [IsoId("_0syLA0gsEeaD2L_hzZaE0w")]
    [DisplayName("Rejected")]
    public record Rejected : CancellationStatus22Choice_
    {
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_GjZx00guEeazC43Xuh-e6w")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public RejectedReason21Choice_? Reason { get; init; }

        /// <summary>
        /// Additional information about the rejected reason.
        /// </summary>
        [IsoId("_GjZx1UguEeazC43Xuh-e6w")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
