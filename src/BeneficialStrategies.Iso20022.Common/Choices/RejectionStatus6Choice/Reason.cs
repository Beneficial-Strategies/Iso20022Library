// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus6Choice
{
    /// <summary>
    /// Specifies the reason of the RejectionStatus.
    /// </summary>
    [IsoId("_UCsAkf7rEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : RejectionStatus6Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_UVy5kdp-Ed-ak6NoX_4Aeg_-1173856121")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UVy5ktp-Ed-ak6NoX_4Aeg_1194869738")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
