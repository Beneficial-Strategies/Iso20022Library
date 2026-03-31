// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType14Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_1HEXsBEwEeKp2ZN13DI_pA")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType14Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType13Code Value { get; init; }
    }
}
