// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party16Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_l9lC0RRkEeOKWo1NF21OVw")]
    [DisplayName("Organisation")]
    public partial record Organisation : Party16Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_LRpywRQLEeKCyZtSz_i3FA")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public required IsoMax140Text Name { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
        /// </summary>
        [IsoId("_LRpyxRQLEeKCyZtSz_i3FA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification4Choice_? Identification { get; init; } 
        
        /// <summary>
        /// Purpose of the organisation, eg, charity.
        /// </summary>
        [IsoId("_LRpyyRQLEeKCyZtSz_i3FA")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Purpose { get; init; } 
        
        /// <summary>
        /// Country of taxation of an organisation.
        /// </summary>
        [IsoId("_LRpyzRQLEeKCyZtSz_i3FA")]
        [DisplayName("Taxation Country")]
        [IsoXmlTag("TaxtnCtry")]
        public CountryCode? TaxationCountry { get; init; } 
        
        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_LRpy0RQLEeKCyZtSz_i3FA")]
        [DisplayName("Registration Country")]
        [IsoXmlTag("RegnCtry")]
        public CountryCode? RegistrationCountry { get; init; } 
        
        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_LRpy1RQLEeKCyZtSz_i3FA")]
        [DisplayName("Registration Date")]
        [IsoXmlTag("RegnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? RegistrationDate { get; init; } 
        
        /// <summary>
        /// Number assigned by a tax authority to an entity.
        /// </summary>
        [IsoId("_LRpy2RQLEeKCyZtSz_i3FA")]
        [DisplayName("Tax Identification Number")]
        [IsoXmlTag("TaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? TaxIdentificationNumber { get; init; } 
        
        /// <summary>
        /// Number assigned by a national registration authority to an entity.
        /// </summary>
        [IsoId("_LRpy3RQLEeKCyZtSz_i3FA")]
        [DisplayName("National Registration Number")]
        [IsoXmlTag("NtlRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NationalRegistrationNumber { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_LRpy4RQLEeKCyZtSz_i3FA")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(5)]
        public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_LRpy5RQLEeKCyZtSz_i3FA")]
        [DisplayName("Primary Communication Address")]
        [IsoXmlTag("PmryComAdr")]
        public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_LRpy6RQLEeKCyZtSz_i3FA")]
        [DisplayName("Secondary Communication Address")]
        [IsoXmlTag("ScndryComAdr")]
        public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
        
        /// <summary>
        /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_mQL1xRQLEeKCyZtSz_i3FA")]
        [DisplayName("Additional Regulatory Information")]
        [IsoXmlTag("AddtlRgltryInf")]
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
