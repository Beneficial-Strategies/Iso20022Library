// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus33Choice
{
    /// <summary>
    /// Further information about the reason of the acknowledged accepted status.
    /// </summary>
    [IsoId("_HwRDeZwZEeqtp-LOti013g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : AcknowledgedAcceptedStatus33Choice_
    {
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_H2g1YZwZEeqtp-LOti013g")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason24Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_H2g1aZwZEeqtp-LOti013g")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
