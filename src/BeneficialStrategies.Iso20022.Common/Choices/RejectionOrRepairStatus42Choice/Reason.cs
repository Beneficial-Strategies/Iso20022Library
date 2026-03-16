// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus42Choice
{
    /// <summary>
    /// Specifies the reason for the status.
    /// </summary>
    [IsoId("_m0oR6ytVEeyhipY4f42fZQ")]
    [DisplayName("Reason")]
    public record Reason : RejectionOrRepairStatus42Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_nOHI4ytVEeyhipY4f42fZQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionAndRepairReason37Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_nOHI6ytVEeyhipY4f42fZQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
