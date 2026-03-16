// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party35Choice
{
    /// <summary>
    /// Identification of a person or an organisation.
    /// </summary>
    [IsoId("_mm7Z07TREeeyuKckOGlwuA")]
    [DisplayName("Party")]
    public record Party : Party35Choice_
    {
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_jzRC069UEeeJJK1oRb-jTw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? Name { get; init; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_jzRp4a9UEeeJJK1oRb-jTw")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public PostalAddress6? PostalAddress { get; init; }

        /// <summary>
        /// Unique and unambiguous identification of a party.
        /// </summary>
        [IsoId("_jzRp469UEeeJJK1oRb-jTw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public Party34Choice_? Identification { get; init; }

        /// <summary>
        /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
        /// </summary>
        [IsoId("_jzRp5a9UEeeJJK1oRb-jTw")]
        [DisplayName("Country Of Residence")]
        [IsoXmlTag("CtryOfRes")]
        public CountryCode? CountryOfResidence { get; init; }

        /// <summary>
        /// Set of elements used to indicate how to contact the party.
        /// </summary>
        [IsoId("_jzRp569UEeeJJK1oRb-jTw")]
        [DisplayName("Contact Details")]
        [IsoXmlTag("CtctDtls")]
        public ContactDetails2? ContactDetails { get; init; }
    }
}
