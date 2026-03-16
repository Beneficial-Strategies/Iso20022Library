// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus13Choice
{
    /// <summary>
    /// Specifies the reason of the UnmatchedStatus.
    /// </summary>
    [IsoId("_OBbpeSwjEeOEV5XHD-BKpw")]
    [DisplayName("Reason")]
    public record Reason : UnmatchedStatus13Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_BbEl4SwjEeOEV5XHD-BKpw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason15Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_BbEl6SwjEeOEV5XHD-BKpw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
