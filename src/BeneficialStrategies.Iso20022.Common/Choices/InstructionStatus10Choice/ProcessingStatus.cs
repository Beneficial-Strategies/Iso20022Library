// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus10Choice
{
    /// <summary>
    /// Status advising on the processing of the instruction.
    /// </summary>
    [IsoId("_cBRCQ_NfEeqRfth943bvEA")]
    [DisplayName("Processing Status")]
    public record ProcessingStatus : InstructionStatus10Choice_
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [IsoId("_M57j0fNsEeqRfth943bvEA")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required Status9Code Status { get; init; }

        /// <summary>
        /// Number of the admission ticket that has been granted by the custodian or the issuer.
        /// </summary>
        [IsoId("_f1l8kPNsEeqRfth943bvEA")]
        [DisplayName("Attendance Card Number")]
        [IsoXmlTag("AttndncCardNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? AttendanceCardNumber { get; init; }

        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_M57j0_NsEeqRfth943bvEA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
