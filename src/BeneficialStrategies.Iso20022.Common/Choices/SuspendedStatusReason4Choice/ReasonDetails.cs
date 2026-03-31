// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SuspendedStatusReason4Choice
{
    /// <summary>
    /// Reason for the suspended status, expressed as a code.
    /// </summary>
    [IsoId("_aSlPVUHlEea8I67lh6qdSQ")]
    [DisplayName("Reason Details")]
    [IsoXmlTag("RsnDtls")]
    public record ReasonDetails : SuspendedStatusReason4Choice_
    {
        /// <summary>
        /// Reason for the conditionally accepted status expressed as a code.
        /// </summary>
        [IsoId("_eO6skUHmEea8I67lh6qdSQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required SuspendedStatusReason5Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the suspended reason.
        /// </summary>
        [IsoId("_eO6sk0HmEea8I67lh6qdSQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
