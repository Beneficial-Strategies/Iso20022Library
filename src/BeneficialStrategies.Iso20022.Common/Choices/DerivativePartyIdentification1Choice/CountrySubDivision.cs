// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DerivativePartyIdentification1Choice
{
    /// <summary>
    /// Country and country sub-division of the reference entity.
    /// </summary>
    [IsoId("_sN3rEEW8EeWaZZ6gWK8UVw")]
    [DisplayName("Country Sub Division")]
    public record CountrySubDivision : DerivativePartyIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a name of a unit resulting from the division of a country, dependency, or other area of special geopolitical interest contained in ISO 3166-1, on the basis of country names obtained from the United Nations (ISO 3166-2: Country subdivision code).
        /// </summary>
        [IsoXmlTag("CtrySubDvsn")]
        public required CountrySubDivisionCode Value { get; init; }
    }
}
