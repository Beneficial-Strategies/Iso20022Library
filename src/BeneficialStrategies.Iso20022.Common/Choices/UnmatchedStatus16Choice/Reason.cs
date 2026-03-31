// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus16Choice
{
    /// <summary>
    /// Specifies the reason of the unmatched status.
    /// </summary>
    [IsoId("_IMDHJTqOEeWyoP0PbocV1Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : UnmatchedStatus16Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_ItrNgTqOEeWyoP0PbocV1Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason21Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_ItrNhTqOEeWyoP0PbocV1Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
