// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus2Choice
{
    /// <summary>
    /// Specifies the reason of the UnmatchedStatus.
    /// </summary>
    [IsoId("_UWF0g9p-Ed-ak6NoX_4Aeg_-1896445885")]
    [DisplayName("Reason")]
    public record Reason : UnmatchedStatus2Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_UV8Didp-Ed-ak6NoX_4Aeg_1761896727")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason3Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UWF0gNp-Ed-ak6NoX_4Aeg_-958089829")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
