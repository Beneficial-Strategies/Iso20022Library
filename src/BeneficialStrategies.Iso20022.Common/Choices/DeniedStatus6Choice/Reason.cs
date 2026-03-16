// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus6Choice
{
    /// <summary>
    /// Specifies the reason of the DeniedStatus.
    /// </summary>
    [IsoId("_p91CMf7rEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : DeniedStatus6Choice_
    {
        /// <summary>
        /// Specifies the reason why the request has a denied status.
        /// </summary>
        [IsoId("_UUc1wtp-Ed-ak6NoX_4Aeg_2123107552")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required DeniedReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UUc1w9p-Ed-ak6NoX_4Aeg_947916527")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
