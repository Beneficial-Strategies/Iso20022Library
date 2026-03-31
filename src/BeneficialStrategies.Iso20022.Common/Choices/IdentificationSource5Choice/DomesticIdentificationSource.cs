// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationSource5Choice
{
    /// <summary>
    /// Country of the proprietary identification scheme.
    /// </summary>
    [IsoId("_n7S8IV9NEeS7xuKaq75oiQ")]
    [DisplayName("Domestic Identification Source")]
    public record DomesticIdentificationSource : IdentificationSource5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("DmstIdSrc")]
        public required CountryCode Value { get; init; }
    }
}
