// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus64Choice
{
    /// <summary>
    /// Specifies the reason of the pending status.
    /// </summary>
    [IsoId("_qTHeQSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus64Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a pending status.
        /// </summary>
        [IsoId("_qTHeTyAdEeuyDZ-ukt4YRg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingReason60Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_qTHeVyAdEeuyDZ-ukt4YRg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
