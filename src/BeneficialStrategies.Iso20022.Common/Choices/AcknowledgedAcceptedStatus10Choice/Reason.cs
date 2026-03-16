// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus10Choice
{
    /// <summary>
    /// Specifies the reason of the AcknowledgedAcceptedStatus.
    /// </summary>
    [IsoId("_fHQhZ_7rEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : AcknowledgedAcceptedStatus10Choice_
    {
        /// <summary>
        /// Specifies additional information about the processed instruction.
        /// </summary>
        [IsoId("_UWPlhtp-Ed-ak6NoX_4Aeg_1506505459")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason3Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UWPlh9p-Ed-ak6NoX_4Aeg_331314434")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
