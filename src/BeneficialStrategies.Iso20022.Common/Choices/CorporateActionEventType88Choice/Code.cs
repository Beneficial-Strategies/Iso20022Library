// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType88Choice
{
    /// <summary>
    /// Corporate action event type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_aG6ds-mrEemUgrefIx730g")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType88Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the corporate action event type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType33Code Value { get; init; }
    }
}
