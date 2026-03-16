// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus10Choice
{
    /// <summary>
    /// Reason why the meeting instruction cancellation request message or the individual meeting instruction cancellation request is pending.
    /// </summary>
    [IsoId("__KUE-7KiEemux5trsZcCpw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingCancellationStatus10Choice_
    {
        /// <summary>
        /// Reason for the pending status.
        /// </summary>
        [IsoId("_cHKOxbKjEemux5trsZcCpw")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingCancellationReason7Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Additional information about the pending status.
        /// </summary>
        [IsoId("_cHKOzbKjEemux5trsZcCpw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; }
    }
}
