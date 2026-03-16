// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingReason5Choice
{
    /// <summary>
    /// Specifies the reason of the MatchedAlleged Status.
    /// </summary>
    [IsoId("_2-L0Iwd3Ee2fOITqoTnSLQ")]
    [DisplayName("Reason")]
    public record Reason : MatchingReason5Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has been alleged.
        /// </summary>
        [IsoId("_3TyQsQd3Ee2fOITqoTnSLQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AllegementReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_3TyQswd3Ee2fOITqoTnSLQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
