// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus10Choice
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_Y2L8gCzTEeOsiuMH68so7Q")]
    [DisplayName("Reason")]
    public record Reason : RejectedStatus10Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected status.
        /// </summary>
        [IsoId("_yF4CoCzUEeOsiuMH68so7Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason17Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_1b1R0CzUEeOsiuMH68so7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
