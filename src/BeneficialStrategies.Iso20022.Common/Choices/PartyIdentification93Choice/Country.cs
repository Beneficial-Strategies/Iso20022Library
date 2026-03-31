// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification93Choice
{
    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_blbCyTqmEeWyoP0PbocV1Q")]
    [DisplayName("Country")]
    public record Country : PartyIdentification93Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("Ctry")]
        public required CountryCode Value { get; init; }
    }
}
