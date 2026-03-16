// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification248Choice
{
    /// <summary>
    /// Party is a legal person.
    /// </summary>
    [IsoId("_WAhpkT3YEe2uHKhHp3bXyA")]
    [DisplayName("Legal")]
    [IsoXmlTag("Lgl")]
    public record Legal : PartyIdentification248Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of the legal person.
        /// </summary>
        [IsoId("_bCTr8D3ZEe2uHKhHp3bXyA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required OrganisationIdentification15Choice_ Identification { get; init; }

        /// <summary>
        /// Code of country where the registered office of the organisation is located.
        /// </summary>
        [IsoId("_YXhgsD3ZEe2uHKhHp3bXyA")]
        [DisplayName("Country")]
        [IsoXmlTag("Ctry")]
        public CountryCode? Country { get; init; }
    }
}
