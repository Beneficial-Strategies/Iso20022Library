// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus21Choice
{
    /// <summary>
    /// Specifies the reason of the unmatched status.
    /// </summary>
    [IsoId("_6d89e5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : UnmatchedStatus21Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_6d89hZNLEeWGlc8L7oPDIg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason27Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_6d89iZNLEeWGlc8L7oPDIg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
