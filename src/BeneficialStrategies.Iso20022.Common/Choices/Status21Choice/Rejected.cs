// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status21Choice
{
    /// <summary>
    /// Status of the transfer cancellation is rejected.
    /// </summary>
    [IsoId("_MHhOUSYuEeW_ZNn8gbfY7Q")]
    [DisplayName("Rejected")]
    public record Rejected : Status21Choice_
    {
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_oNxuYSYuEeW_ZNn8gbfY7Q")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectedReason17Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the rejected status reason.
        /// </summary>
        [IsoId("_oNxuaSYuEeW_ZNn8gbfY7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; }
    }
}
