// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus2Choice
{
    /// <summary>
    /// Specifies the reason of the RejectionOrRepairStatus.
    /// </summary>
    [IsoId("_UW1bZ9p-Ed-ak6NoX_4Aeg_805322045")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectionOrRepairStatus2Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_UW1bY9p-Ed-ak6NoX_4Aeg_-268700611")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public RejectionAndRepairReason4Choice_? Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UW1bZNp-Ed-ak6NoX_4Aeg_-1009685629")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
