// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party48Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_nkkRcZQ_EemqYPWMBuVawg")]
    [DisplayName("Organisation")]
    public partial record Organisation : Party48Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which the organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_n3w6Q5Q_EemqYPWMBuVawg")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; } 
        
        /// <summary>
        /// Name of the organisation in short form.
        /// </summary>
        [IsoId("_n3w6RZQ_EemqYPWMBuVawg")]
        [DisplayName("Short Name")]
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ShortName { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier for the organisation.
        /// </summary>
        [IsoId("_n3w6R5Q_EemqYPWMBuVawg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification177Choice_? Identification { get; init; } 
        
        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_n3w6SZQ_EemqYPWMBuVawg")]
        [DisplayName("Legal Entity Identifier")]
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
        
        /// <summary>
        /// Purpose of the organisation, for example, charity.
        /// </summary>
        [IsoId("_n3w6S5Q_EemqYPWMBuVawg")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Purpose { get; init; } 
        
        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_n3w6TZQ_EemqYPWMBuVawg")]
        [DisplayName("Registration Country")]
        [IsoXmlTag("RegnCtry")]
        public CountryCode? RegistrationCountry { get; init; } 
        
        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_n3w6T5Q_EemqYPWMBuVawg")]
        [DisplayName("Registration Date")]
        [IsoXmlTag("RegnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? RegistrationDate { get; init; } 
        
        /// <summary>
        /// Information related to an address to be inserted, updated or deleted.
        /// </summary>
        [IsoId("_n3w6UZQ_EemqYPWMBuVawg")]
        [DisplayName("Modified Postal Address")]
        [IsoXmlTag("ModfdPstlAdr")]
        public ModificationScope34? ModifiedPostalAddress { get; init; } 
        
        /// <summary>
        /// Type of organisation.
        /// </summary>
        [IsoId("_n3w6U5Q_EemqYPWMBuVawg")]
        [DisplayName("Type Of Organisation")]
        [IsoXmlTag("TpOfOrg")]
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
        
        /// <summary>
        /// Place of listing for shares in the organisation.
        /// </summary>
        [IsoId("_n3w6VZQ_EemqYPWMBuVawg")]
        [DisplayName("Place Of Listing")]
        [IsoXmlTag("PlcOfListg")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? PlaceOfListing { get; init; } 
        
        
        #nullable disable
        
    }
}
