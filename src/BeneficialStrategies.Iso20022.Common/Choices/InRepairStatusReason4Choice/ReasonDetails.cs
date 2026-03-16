// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InRepairStatusReason4Choice
{
    /// <summary>
    /// Reason for the in repair status, expressed as a code.
    /// </summary>
    [IsoId("_Bptp5UHqEea8I67lh6qdSQ")]
    [DisplayName("Reason Details")]
    [IsoXmlTag("RsnDtls")]
    public record ReasonDetails : InRepairStatusReason4Choice_
    {
        /// <summary>
        /// Reason for the in repair status expressed as a code.
        /// </summary>
        [IsoId("_Hxv_IUHqEea8I67lh6qdSQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required InRepairStatusReason5Choice_ Reason { get; init; }

        /// <summary>
        /// Additional information about the in repair reason.
        /// </summary>
        [IsoId("_Hxv_I0HqEea8I67lh6qdSQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
