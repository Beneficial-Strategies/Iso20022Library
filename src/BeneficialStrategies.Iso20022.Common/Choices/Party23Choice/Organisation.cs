// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party23Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_BkkfcWW8EeSHcOWXSsMhqw")]
    [DisplayName("Organisation")]
    public partial record Organisation : Party23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_xflo4QhFEeSUPbC7DbLJpQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public required IsoMax140Text Name { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier for an organisation that is allocated by an institution, for example, Dun &amp; Bradstreet Identification.
        /// </summary>
        [IsoId("_xflo4whFEeSUPbC7DbLJpQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PartyIdentification4Choice_? Identification { get; init; } 
        
        /// <summary>
        /// Purpose of the organisation, for example, charity.
        /// </summary>
        [IsoId("_xflo5QhFEeSUPbC7DbLJpQ")]
        [DisplayName("Purpose")]
        [IsoXmlTag("Purp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Purpose { get; init; } 
        
        /// <summary>
        /// Country of taxation of an organisation.
        /// </summary>
        [IsoId("_xflo5whFEeSUPbC7DbLJpQ")]
        [DisplayName("Taxation Country")]
        [IsoXmlTag("TaxtnCtry")]
        public CountryCode? TaxationCountry { get; init; } 
        
        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_xflo6QhFEeSUPbC7DbLJpQ")]
        [DisplayName("Registration Country")]
        [IsoXmlTag("RegnCtry")]
        public CountryCode? RegistrationCountry { get; init; } 
        
        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_xflo6whFEeSUPbC7DbLJpQ")]
        [DisplayName("Registration Date")]
        [IsoXmlTag("RegnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? RegistrationDate { get; init; } 
        
        /// <summary>
        /// Tax identification information.
        /// </summary>
        [IsoId("_xflo7QhFEeSUPbC7DbLJpQ")]
        [DisplayName("Tax Identification")]
        [IsoXmlTag("TaxId")]
        public TaxIdentification2? TaxIdentification { get; init; } 
        
        /// <summary>
        /// Number assigned by a national registration authority to an entity.
        /// </summary>
        [IsoId("_xflo7whFEeSUPbC7DbLJpQ")]
        [DisplayName("National Registration Number")]
        [IsoXmlTag("NtlRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NationalRegistrationNumber { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_xflo8QhFEeSUPbC7DbLJpQ")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(5)]
        public ValueList<PostalAddress3> PostalAddress { get; init; } = new ValueList<PostalAddress3>(){};
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_xflo8whFEeSUPbC7DbLJpQ")]
        [DisplayName("Primary Communication Address")]
        [IsoXmlTag("PmryComAdr")]
        public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_xflo9QhFEeSUPbC7DbLJpQ")]
        [DisplayName("Secondary Communication Address")]
        [IsoXmlTag("ScndryComAdr")]
        public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
        
        /// <summary>
        /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_xflo9whFEeSUPbC7DbLJpQ")]
        [DisplayName("Additional Regulatory Information")]
        [IsoXmlTag("AddtlRgltryInf")]
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
