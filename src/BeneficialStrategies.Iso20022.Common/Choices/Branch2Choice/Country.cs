// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Branch2Choice
{
    /// <summary>
    /// Code of a country where the registered office of the branch counterparty is located or country of residence in case that the branch counterparty is a natural person.
    /// </summary>
    [IsoId("_6YyU40qQEeeLKviVB0vAnA")]
    [DisplayName("Country")]
    public record Country : Branch2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("Ctry")]
        public required CountryCode Value { get; init; }
    }
}
