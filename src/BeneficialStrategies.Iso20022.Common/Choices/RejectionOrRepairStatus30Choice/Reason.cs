// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus30Choice
{
    /// <summary>
    /// Specifies the reason for the status.
    /// </summary>
    [IsoId("_VWn4-zq4EeWyoP0PbocV1Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectionOrRepairStatus30Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_V2KUozq4EeWyoP0PbocV1Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionAndRepairReason24Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_V2KUqzq4EeWyoP0PbocV1Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
