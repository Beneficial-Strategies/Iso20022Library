// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus2Choice
{
    /// <summary>
    /// Status of the transfer is rejected.
    /// </summary>
    [IsoId("_aQ-GOSY3EeW_ZNn8gbfY7Q")]
    [DisplayName("Rejected")]
    public record Rejected : TransferStatus2Choice_
    {
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_AMuhMSY3EeW_ZNn8gbfY7Q")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectedReason15Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the rejected status reason.
        /// </summary>
        [IsoId("_AMuhOSY3EeW_ZNn8gbfY7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; }
    }
}
