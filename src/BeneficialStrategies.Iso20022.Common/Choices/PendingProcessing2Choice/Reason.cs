// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessing2Choice
{
    /// <summary>
    /// Specifies the reason of the Pending Processing Status.
    /// </summary>
    [IsoId("_mYKdGwd3Ee2fOITqoTnSLQ")]
    [DisplayName("Reason")]
    public record Reason : PendingProcessing2Choice_
    {
        /// <summary>
        /// Specifies the reason why the trade is wainting the affirmation.
        /// </summary>
        [IsoId("_mpdBYQd3Ee2fOITqoTnSLQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AwaitingAffirmationReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_mpdBYwd3Ee2fOITqoTnSLQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
