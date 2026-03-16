// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus2Choice
{
    /// <summary>
    /// Status advising on the rejection of the instruction.
    /// </summary>
    [IsoId("_RWwVkdp-Ed-ak6NoX_4Aeg_-1258577092")]
    [DisplayName("Rejection Status")]
    public record RejectionStatus : InstructionStatus2Choice_
    {
        /// <summary>
        /// Reason advising the rejection of the instruction.
        /// </summary>
        [IsoId("_RWwVltp-Ed-ak6NoX_4Aeg_-151657309")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectionReason1Code Reason { get; init; }

        /// <summary>
        /// This code can be used in case another reason is required.
        /// </summary>
        [IsoId("_RWwVl9p-Ed-ak6NoX_4Aeg_-1485291083")]
        [DisplayName("Extended Reason")]
        [IsoXmlTag("XtndedRsn")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoExtended350Code ExtendedReason { get; init; }

        /// <summary>
        /// Additional information about the reason.
        /// </summary>
        [IsoId("_RWwVmNp-Ed-ak6NoX_4Aeg_-151657294")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
