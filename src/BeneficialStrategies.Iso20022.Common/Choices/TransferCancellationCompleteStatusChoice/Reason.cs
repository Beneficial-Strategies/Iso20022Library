// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferCancellationCompleteStatusChoice
{
    /// <summary>
    /// Reason of the complete status.
    /// </summary>
    [IsoId("_U0C70tp-Ed-ak6NoX_4Aeg_-1208524222")]
    [DisplayName("Reason")]
    public record Reason : TransferCancellationCompleteStatusChoice_
    {
        /// <summary>
        /// Reason for a complete status in structured form.
        /// </summary>
        [IsoId("_U0fAsNp-Ed-ak6NoX_4Aeg_109339586")]
        [DisplayName("Structured")]
        [IsoXmlTag("Strd")]
        public required CancellationCompleteStatusReason1Code Structured { get; init; }

        /// <summary>
        /// Additional information about the reason for the complete status in textual form.
        /// </summary>
        [IsoId("_U0fAsdp-Ed-ak6NoX_4Aeg_551704444")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
