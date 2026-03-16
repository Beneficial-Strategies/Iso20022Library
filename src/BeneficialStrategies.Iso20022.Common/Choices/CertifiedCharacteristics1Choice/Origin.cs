// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice
{
    /// <summary>
    /// Country of origin of the goods, as proven by the certificate.
    /// </summary>
    [IsoId("_TnJq6dp-Ed-ak6NoX_4Aeg_568642879")]
    [DisplayName("Origin")]
    public record Origin : CertifiedCharacteristics1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a country, a dependency, or another area of particular geopolitical interest, on the basis of country names obtained from the United Nations (ISO 3166, Alpha-2 code).
        /// </summary>
        [IsoXmlTag("Orgn")]
        public required CountryCode Value { get; init; }
    }
}
