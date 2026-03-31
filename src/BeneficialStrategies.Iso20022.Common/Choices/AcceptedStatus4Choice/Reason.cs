// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus4Choice
{
    /// <summary>
    /// Reason for the accepted status.
    /// </summary>
    [IsoId("_faqnAEh7EeOUboEk24drjw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : AcceptedStatus4Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has been accepted.
        /// </summary>
        [IsoId("_h2QWYyz1EeOsiuMH68so7Q")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required AcceptedReason4Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_h2QWayz1EeOsiuMH68so7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
