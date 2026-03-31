// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationStatus4Choice
{
    /// <summary>
    /// Specifies the reason of the modification status.
    /// </summary>
    [IsoId("_C9XfKTq3EeWyoP0PbocV1Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : ModificationStatus4Choice_
    {
        /// <summary>
        /// Specifies the reason why the transaction is modified.
        /// </summary>
        [IsoId("_DdDr0Tq3EeWyoP0PbocV1Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ModificationReason4Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_DdDr0zq3EeWyoP0PbocV1Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
