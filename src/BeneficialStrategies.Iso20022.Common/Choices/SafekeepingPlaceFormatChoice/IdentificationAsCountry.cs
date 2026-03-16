// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormatChoice
{
    /// <summary>
    /// Place of safekeeping expressed with a country code.
    /// </summary>
    [IsoId("_RB5f59p-Ed-ak6NoX_4Aeg_-308128679")]
    [DisplayName("Identification As Country")]
    public record IdentificationAsCountry : SafekeepingPlaceFormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("IdAsCtry")]
        public required CountryCode Value { get; init; }
    }
}
