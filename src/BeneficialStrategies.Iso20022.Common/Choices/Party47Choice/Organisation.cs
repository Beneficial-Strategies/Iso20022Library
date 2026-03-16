// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party47Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_mDHs0ZQ_EemqYPWMBuVawg")]
    [DisplayName("Organisation")]
    public record Organisation : Party47Choice_
    {
        /// <summary>
        /// Name by which the organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_mWdfk5Q_EemqYPWMBuVawg")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; }

        /// <summary>
        /// Name of the organisation in short form.
        /// </summary>
        [IsoId("_mWdflZQ_EemqYPWMBuVawg")]
        [DisplayName("Short Name")]
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ShortName { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier for the organisation.
        /// </summary>
        [IsoId("_mWdfl5Q_EemqYPWMBuVawg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification177Choice_? Identification { get; init; }

        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_mWdfmZQ_EemqYPWMBuVawg")]
        [DisplayName("Legal Entity Identifier")]
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

        /// <summary>
        /// Purpose of the organisation, for example, charity.
        /// </summary>
        [IsoId("_mWdfm5Q_EemqYPWMBuVawg")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Purpose { get; init; }

        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_mWdfnZQ_EemqYPWMBuVawg")]
        [DisplayName("Registration Country")]
        [IsoXmlTag("RegnCtry")]
        public CountryCode? RegistrationCountry { get; init; }

        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_mWdfn5Q_EemqYPWMBuVawg")]
        [DisplayName("Registration Date")]
        [IsoXmlTag("RegnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? RegistrationDate { get; init; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_mWdfoZQ_EemqYPWMBuVawg")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<PostalAddress21> PostalAddress { get; init; } = [];

        /// <summary>
        /// Type of organisation.
        /// </summary>
        [IsoId("_mWdfo5Q_EemqYPWMBuVawg")]
        [DisplayName("Type Of Organisation")]
        [IsoXmlTag("TpOfOrg")]
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; }

        /// <summary>
        /// Place of listing for shares in the organisation.
        /// </summary>
        [IsoId("_mWdfpZQ_EemqYPWMBuVawg")]
        [DisplayName("Place Of Listing")]
        [IsoXmlTag("PlcOfListg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? PlaceOfListing { get; init; }
    }
}
