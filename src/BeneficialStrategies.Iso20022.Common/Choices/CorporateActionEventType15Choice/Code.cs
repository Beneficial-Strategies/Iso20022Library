// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType15Choice
{
    /// <summary>
    /// Corporate action event type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_6xlPtRG6EeKHC-9MYSJwtQ")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType14Code Value { get; init; }
    }
}
