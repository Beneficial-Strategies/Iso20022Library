// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus5Choice
{
    /// <summary>
    /// Status of the transfer is rejected.
    /// </summary>
    [IsoId("_WY1VSeijEeuLe8v4JEtDDg")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public record Rejected : TransferStatus5Choice_
    {
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_WtjBA-ijEeuLe8v4JEtDDg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required RejectedReason45Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the rejected status reason.
        /// </summary>
        [IsoId("_WtjBC-ijEeuLe8v4JEtDDg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; }
    }
}
