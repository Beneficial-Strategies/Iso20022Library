// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus1Choice
{
    /// <summary>
    /// Status advising on the rejection of the cancellation request.
    /// </summary>
    [IsoId("_RVa419p-Ed-ak6NoX_4Aeg_-538392797")]
    [DisplayName("Rejection Status")]
    [IsoXmlTag("RjctnSts")]
    public record RejectionStatus : CancellationStatus1Choice_
    {
        /// <summary>
        /// Reason advising the rejection of the instruction cancellation request.
        /// </summary>
        [IsoId("_RVkCwNp-Ed-ak6NoX_4Aeg_-1615487184")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectionReason2Code Reason { get; init; }

        /// <summary>
        /// This code can be used in case another reason is required.
        /// </summary>
        [IsoId("_RVkCwdp-Ed-ak6NoX_4Aeg_1990577179")]
        [DisplayName("Extended Reason")]
        [IsoXmlTag("XtndedRsn")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoExtended350Code ExtendedReason { get; init; }

        /// <summary>
        /// Additional information about the reason.
        /// </summary>
        [IsoId("_RVkCwtp-Ed-ak6NoX_4Aeg_218041376")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
