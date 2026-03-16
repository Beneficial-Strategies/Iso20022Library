// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
    /// </summary>
    [IsoId("_cH-V0TnxEeabspMEjqY5TQ")]
    [DisplayName("Valoren")]
    public record Valoren : SecurityIdentification25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
        /// </summary>
        [IsoXmlTag("Vlrn")]
        [IsoSimpleType(IsoSimpleType.ValorenIdentifier)]
        public required IsoValorenIdentifier Value { get; init; }
    }
}
