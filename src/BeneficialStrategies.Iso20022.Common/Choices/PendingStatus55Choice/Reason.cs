// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus55Choice
{
    /// <summary>
    /// Reason why the meeting instruction message or the individual meeting instruction is pending.
    /// </summary>
    [IsoId("_Tfp1KrKdEemux5trsZcCpw")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus55Choice_
    {
        /// <summary>
        /// Reason for the pending status.
        /// </summary>
        [IsoId("_wz3WHbKdEemux5trsZcCpw")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingReason51Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Additional information about the pending status.
        /// </summary>
        [IsoId("_wz3WHLKdEemux5trsZcCpw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; }
    }
}
