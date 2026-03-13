// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party14Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_dVFRDRdCEeK5g-3oYI0_9Q")]
    [DisplayName("Individual Person")]
    public partial record IndividualPerson : Party14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Term used to address a person.
        /// </summary>
        [IsoId("_jv5UVSiFEeKVDZ5HKjI6bg")]
        [DisplayName("Name Prefix")]
        [IsoXmlTag("NmPrfx")]
        public NamePrefix1Choice_? NamePrefix { get; init; } 
        
        /// <summary>
        /// First name of a person.
        /// </summary>
        [IsoId("_cRcJdSb-EeK33eWt3gq4Fg")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text GivenName { get; init; } 
        
        /// <summary>
        /// Second name of a person.
        /// </summary>
        [IsoId("_cRcJeSb-EeK33eWt3gq4Fg")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; } 
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_cRcJfSb-EeK33eWt3gq4Fg")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; } 
        
        /// <summary>
        /// Additional information about a person that follows a person&apos;s name, eg, qualification such as Doctor of Philosophy (PhD).
        /// </summary>
        [IsoId("_cRcJgSb-EeK33eWt3gq4Fg")]
        [DisplayName("Name Suffix")]
        [IsoXmlTag("NmSfx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NameSuffix { get; init; } 
        
        /// <summary>
        /// Specifies the gender of the person.
        /// </summary>
        [IsoId("_cRcJhSb-EeK33eWt3gq4Fg")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public GenderCode? Gender { get; init; } 
        
        /// <summary>
        /// Language in which a person communicates.
        /// </summary>
        [IsoId("_cRcJiSb-EeK33eWt3gq4Fg")]
        [DisplayName("Language")]
        [IsoXmlTag("Lang")]
        public LanguageCode? Language { get; init; } 
        
        /// <summary>
        /// Date on which a person is born.
        /// </summary>
        [IsoId("_cRcJkyb-EeK33eWt3gq4Fg")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate BirthDate { get; init; } 
        
        /// <summary>
        /// Country where a person was born.
        /// </summary>
        [IsoId("_cRcJlyb-EeK33eWt3gq4Fg")]
        [DisplayName("Country Of Birth")]
        [IsoXmlTag("CtryOfBirth")]
        public CountryCode? CountryOfBirth { get; init; } 
        
        /// <summary>
        /// Province where a person was born.
        /// </summary>
        [IsoId("_cRcJoSb-EeK33eWt3gq4Fg")]
        [DisplayName("Province Of Birth")]
        [IsoXmlTag("PrvcOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ProvinceOfBirth { get; init; } 
        
        /// <summary>
        /// City where a person was born.
        /// </summary>
        [IsoId("_cRcJpSb-EeK33eWt3gq4Fg")]
        [DisplayName("City Of Birth")]
        [IsoXmlTag("CityOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CityOfBirth { get; init; } 
        
        /// <summary>
        /// Name of the occupation or job of a person.
        /// </summary>
        [IsoId("_cRcJqSb-EeK33eWt3gq4Fg")]
        [DisplayName("Profession")]
        [IsoXmlTag("Prfssn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Profession { get; init; } 
        
        /// <summary>
        /// Country of taxation of an individual person.
        /// </summary>
        [IsoId("_cRcJrSb-EeK33eWt3gq4Fg")]
        [DisplayName("Taxation Country")]
        [IsoXmlTag("TaxtnCtry")]
        public CountryCode? TaxationCountry { get; init; } 
        
        /// <summary>
        /// Country and residential status of an individual, for example, non-pernament resident.
        /// </summary>
        [IsoId("_cRcJsSb-EeK33eWt3gq4Fg")]
        [DisplayName("Country And Residential Status")]
        [IsoXmlTag("CtryAndResdtlSts")]
        public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_cRcJtSb-EeK33eWt3gq4Fg")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(5)]
        public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
        
        /// <summary>
        /// Nationality and legal status (minor or major) or rights that an individual may possess.
        /// </summary>
        [IsoId("_cRcJuSb-EeK33eWt3gq4Fg")]
        [DisplayName("Citizenship")]
        [IsoXmlTag("Ctznsh")]
        [MinLength(1)]
        [MaxLength(3)]
        public ValueList<CitizenshipInformation> Citizenship { get; init; } = [];
        
        /// <summary>
        /// Organisation represented by a person, or for which a person works.
        /// </summary>
        [IsoId("_cRcJvSb-EeK33eWt3gq4Fg")]
        [DisplayName("Employing Company")]
        [IsoXmlTag("EmplngCpny")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? EmployingCompany { get; init; } 
        
        /// <summary>
        /// Title of the function.
        /// </summary>
        [IsoId("_cRcJwSb-EeK33eWt3gq4Fg")]
        [DisplayName("Business Function")]
        [IsoXmlTag("BizFctn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? BusinessFunction { get; init; } 
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_cRcJxSb-EeK33eWt3gq4Fg")]
        [DisplayName("Primary Communication Address")]
        [IsoXmlTag("PmryComAdr")]
        public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
        
        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_cRcJySb-EeK33eWt3gq4Fg")]
        [DisplayName("Secondary Communication Address")]
        [IsoXmlTag("ScndryComAdr")]
        public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
        
        /// <summary>
        /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
        /// </summary>
        [IsoId("_cRcJzSb-EeK33eWt3gq4Fg")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<GenericIdentification44> OtherIdentification { get; init; } = [];
        
        /// <summary>
        /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_jRPNFSb-EeK33eWt3gq4Fg")]
        [DisplayName("Additional Regulatory Information")]
        [IsoXmlTag("AddtlRgltryInf")]
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
