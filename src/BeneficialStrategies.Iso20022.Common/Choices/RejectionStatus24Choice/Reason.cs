// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus24Choice
{
    /// <summary>
    /// Specifies the reason of the rejection status.
    /// </summary>
    [IsoId("_6QDEj5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectionStatus24Choice_
    {
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_6QDEnZNLEeWGlc8L7oPDIg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason31Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_6QDEpZNLEeWGlc8L7oPDIg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
