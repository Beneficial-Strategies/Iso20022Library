// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party33Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_52fY8UzQEea8fovz_9xSTQ")]
    [DisplayName("Organisation")]
    [IsoXmlTag("Org")]
    public record Organisation : Party33Choice_
    {
        /// <summary>
        /// Name by which the organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_BFL0QUzREea8fovz_9xSTQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; }

        /// <summary>
        /// Name of the organisation in short form.
        /// </summary>
        [IsoId("_BFL0Q0zREea8fovz_9xSTQ")]
        [DisplayName("Short Name")]
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ShortName { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the organisation.
        /// </summary>
        [IsoId("_BFL0RUzREea8fovz_9xSTQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification72Choice_? Identification { get; init; }

        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_BFL0R0zREea8fovz_9xSTQ")]
        [DisplayName("Legal Entity Identifier")]
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

        /// <summary>
        /// Purpose of the organisation, for example, charity.
        /// </summary>
        [IsoId("_BFL0SUzREea8fovz_9xSTQ")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Purpose { get; init; }

        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_BFL0S0zREea8fovz_9xSTQ")]
        [DisplayName("Registration Country")]
        [IsoXmlTag("RegnCtry")]
        public CountryCode? RegistrationCountry { get; init; }

        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_BFL0TUzREea8fovz_9xSTQ")]
        [DisplayName("Registration Date")]
        [IsoXmlTag("RegnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? RegistrationDate { get; init; }

        /// <summary>
        /// Information related to an address to be inserted, updated or deleted.
        /// </summary>
        [IsoId("_BFL0T0zREea8fovz_9xSTQ")]
        [DisplayName("Modified Postal Address")]
        [IsoXmlTag("ModfdPstlAdr")]
        public ModificationScope34? ModifiedPostalAddress { get; init; }

        /// <summary>
        /// Type of organisation.
        /// </summary>
        [IsoId("_BFL0UUzREea8fovz_9xSTQ")]
        [DisplayName("Type Of Organisation")]
        [IsoXmlTag("TpOfOrg")]
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; }

        /// <summary>
        /// Place of listing for shares in the organisation.
        /// </summary>
        [IsoId("_Up6j4UzsEea8fovz_9xSTQ")]
        [DisplayName("Place Of Listing")]
        [IsoXmlTag("PlcOfListg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? PlaceOfListing { get; init; }
    }
}
