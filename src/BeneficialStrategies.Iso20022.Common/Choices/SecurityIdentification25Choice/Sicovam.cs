// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Identifier for French securities assigned by the Societe Interprofessionnelle Pour La Compensation des Valeurs Mobilieres in France. The Sicovam is composed of 5-digits.
    /// </summary>
    [IsoId("_cH-V0znxEeabspMEjqY5TQ")]
    [DisplayName("Sicovam")]
    public record Sicovam : SecurityIdentification25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for French securities assigned by the Societe Interprofessionnelle Pour La Compensation des Valeurs Mobilieres in France. The Sicovam is composed of 5-digits.
        /// </summary>
        [IsoXmlTag("SCVM")]
        [IsoSimpleType(IsoSimpleType.SicovamIdentifier)]
        public required IsoSicovamIdentifier Value { get; init; }
    }
}
