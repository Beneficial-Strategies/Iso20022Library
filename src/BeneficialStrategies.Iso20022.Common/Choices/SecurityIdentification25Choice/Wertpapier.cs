// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice
{
    /// <summary>
    /// Wertpapier Kenn-nummer. A number issued in Germany by the Wertpapier Mitteilungen. The Wertpapier Kenn-nummer, sometimes called WPK, contains 6-digits, but no check digit. There are different ranges of numbers representing different classes of securities.
    /// </summary>
    [IsoId("_cH1L8znxEeabspMEjqY5TQ")]
    [DisplayName("Wertpapier")]
    public record Wertpapier : SecurityIdentification25Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Wertpapier Kenn-nummer. A number issued in Germany by the Wertpapier Mitteilungen. The Wertpapier Kenn-nummer, sometimes called WPK, contains 6-digits, but no check digit. There are different ranges of numbers representing different classes of securities.
        /// </summary>
        [IsoXmlTag("Wrtppr")]
        [IsoSimpleType(IsoSimpleType.WertpapierIdentifier)]
        public required IsoWertpapierIdentifier Value { get; init; }
    }
}
