// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentStatus2Choice
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_0jhc8wlIEeGATtfOBToyew_-2036388967")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : ConsentStatus2Choice_
    {
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_0jYTBQlIEeGATtfOBToyew_248390057")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ConsentOrRejectionReason2Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_0jhc8AlIEeGATtfOBToyew_2073838808")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
