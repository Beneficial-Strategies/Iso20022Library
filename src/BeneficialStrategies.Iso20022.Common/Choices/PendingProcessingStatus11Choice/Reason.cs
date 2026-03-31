// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus11Choice
{
    /// <summary>
    /// Specifies the reason of the pending processing status.
    /// </summary>
    [IsoId("_MJ7UKTqdEeWyoP0PbocV1Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingProcessingStatus11Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a pending processing status.
        /// </summary>
        [IsoId("_MpK04TqdEeWyoP0PbocV1Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingProcessingReason10Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_MpK06TqdEeWyoP0PbocV1Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
