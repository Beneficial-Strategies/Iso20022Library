// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus61Choice
{
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_FHgJWe6KEeqc-LCjwLsUVg")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus61Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction&apos;s processing is pending.
        /// </summary>
        [IsoId("_FxTUQ-6KEeqc-LCjwLsUVg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingReason57Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_FxTUS-6KEeqc-LCjwLsUVg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
