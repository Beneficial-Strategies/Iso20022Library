// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus5Choice
{
    /// <summary>
    /// Specifies the reason of the RejectionStatus.
    /// </summary>
    [IsoId("__qYfi_4wEeClUvPNHKL9Zw")]
    [DisplayName("Reason")]
    public record Reason : RejectionStatus5Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("__qYfmf4wEeClUvPNHKL9Zw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason10Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("__qYfo_4wEeClUvPNHKL9Zw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
