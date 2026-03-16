// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus25Choice
{
    /// <summary>
    /// Specifies the reason for the status.
    /// </summary>
    [IsoId("__kUpdUNHEeGHJ_bHJRPaIQ_394082859")]
    [DisplayName("Reason")]
    public record Reason : RejectionOrRepairStatus25Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("__j39h0NHEeGHJ_bHJRPaIQ_1963267973")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionAndRepairReason18Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("__j39iENHEeGHJ_bHJRPaIQ_966195620")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
