// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat15Choice
{
    /// <summary>
    /// Standard code to specify the additional business process linked to a corporate action event.
    /// </summary>
    [IsoId("_0qhVAZcEEee8S7xwGG7Veg")]
    [DisplayName("Code")]
    public record Code : AdditionalBusinessProcessFormat15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the additional business process linked to a corporate action event such as an automatic market claim.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdditionalBusinessProcess8Code Value { get; init; }
    }
}
