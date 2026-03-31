// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus45Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_pf-JXzi7Eeydid5dcNPKvg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectedStatus45Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been rejected.
        /// </summary>
        [IsoId("_pf-Jbzi7Eeydid5dcNPKvg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason47Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_pf-Jdzi7Eeydid5dcNPKvg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINMax210Text? AdditionalReasonInformation { get; init; }
    }
}
