// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus40Choice
{
    /// <summary>
    /// Specifies the reason of the rejection status.
    /// </summary>
    [IsoId("_ddA4lzi8Eeydid5dcNPKvg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectionStatus40Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_ddA4oTi8Eeydid5dcNPKvg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason46Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_ddA4pTi8Eeydid5dcNPKvg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
