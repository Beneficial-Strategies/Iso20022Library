// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification3Choice
{
    /// <summary>
    /// Identification of the counterparty through the name and the location.
    /// </summary>
    [IsoId("_mcwKscEcEea7jLfvGi1PDw")]
    [DisplayName("Name And Location")]
    public record NameAndLocation : CounterpartyIdentification3Choice_
    {
        /// <summary>
        /// Internal name of the counterparty of the reporting agent used by the reporting agent.
        /// </summary>
        [IsoId("_x2XHQcEcEea7jLfvGi1PDw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public required IsoMax70Text Name { get; init; }

        /// <summary>
        /// Location of the country in which the counterparty is incorporated.
        /// </summary>
        [IsoId("_Z6PFU8EcEea7jLfvGi1PDw")]
        [DisplayName("Location")]
        [IsoXmlTag("Lctn")]
        public required CountryCode Location { get; init; }
    }
}
