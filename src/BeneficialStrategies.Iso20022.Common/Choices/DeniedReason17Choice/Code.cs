// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason17Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_ArzhgTw-EeW3QqUkIQtIUA")]
    [DisplayName("Code")]
    public record Code : DeniedReason17Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the denied reason.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DeniedReason3Code Value { get; init; }
    }
}
