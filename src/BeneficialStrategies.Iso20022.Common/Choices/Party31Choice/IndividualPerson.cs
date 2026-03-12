// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Party31Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_Hr4NsyCBEeWhHbfCMWc1cw")]
    [DisplayName("Individual Person")]
    public partial record IndividualPerson : Party31Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Term used to address the person.
        /// </summary>
        [IsoId("_I96dUyCBEeWhHbfCMWc1cw")]
        [DisplayName("Name Prefix")]
        [IsoXmlTag("NmPrfx")]
        public NamePrefix1Choice_? NamePrefix { get; init; } 
        
        /// <summary>
        /// First name of the person.
        /// </summary>
        [IsoId("_I96dVSCBEeWhHbfCMWc1cw")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? GivenName { get; init; } 
        
        /// <summary>
        /// Second name of the person.
        /// </summary>
        [IsoId("_I96dVyCBEeWhHbfCMWc1cw")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; } 
        
        /// <summary>
        /// Name by which the party is known and which is usually used to identify that person.
        /// </summary>
        [IsoId("_I96dWSCBEeWhHbfCMWc1cw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; } 
        
        /// <summary>
        /// Additional information about the person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
        /// </summary>
        [IsoId("_I96dWyCBEeWhHbfCMWc1cw")]
        [DisplayName("Name Suffix")]
        [IsoXmlTag("NmSfx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? NameSuffix { get; init; } 
        
        /// <summary>
        /// Gender of the person.
        /// </summary>
        [IsoId("_I96dXSCBEeWhHbfCMWc1cw")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public GenderCode? Gender { get; init; } 
        
        /// <summary>
        /// Date on which the person was born.
        /// </summary>
        [IsoId("_I96dYyCBEeWhHbfCMWc1cw")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? BirthDate { get; init; } 
        
        /// <summary>
        /// Country where the person was born.
        /// </summary>
        [IsoId("_I96dZSCBEeWhHbfCMWc1cw")]
        [DisplayName("Country Of Birth")]
        [IsoXmlTag("CtryOfBirth")]
        public CountryCode? CountryOfBirth { get; init; } 
        
        /// <summary>
        /// Province where the person was born.
        /// </summary>
        [IsoId("_I97EYSCBEeWhHbfCMWc1cw")]
        [DisplayName("Province Of Birth")]
        [IsoXmlTag("PrvcOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ProvinceOfBirth { get; init; } 
        
        /// <summary>
        /// City where the person was born.
        /// </summary>
        [IsoId("_I97EYyCBEeWhHbfCMWc1cw")]
        [DisplayName("City Of Birth")]
        [IsoXmlTag("CityOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CityOfBirth { get; init; } 
        
        /// <summary>
        /// Name of the occupation or job of the person.
        /// </summary>
        [IsoId("_I97EZSCBEeWhHbfCMWc1cw")]
        [DisplayName("Profession")]
        [IsoXmlTag("Prfssn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Profession { get; init; } 
        
        /// <summary>
        /// Address of the person.
        /// </summary>
        [IsoId("_I97EayCBEeWhHbfCMWc1cw")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(10)]
        public ValueList<PostalAddress21> PostalAddress { get; init; } = new ValueList<PostalAddress21>(){};
        
        /// <summary>
        /// Nationality and legal status (minor or major) or rights that an individual may possess.
        /// </summary>
        [IsoId("_I97EbSCBEeWhHbfCMWc1cw")]
        [DisplayName("Citizenship")]
        [IsoXmlTag("Ctznsh")]
        [MinLength(0)]
        [MaxLength(3)]
        public ValueList<CitizenshipInformation> Citizenship { get; init; } = new ValueList<CitizenshipInformation>(){};
        
        /// <summary>
        /// Organisation represented by a person, or for which a person works.
        /// </summary>
        [IsoId("_I97EbyCBEeWhHbfCMWc1cw")]
        [DisplayName("Employing Company")]
        [IsoXmlTag("EmplngCpny")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoMax140Text? EmployingCompany { get; init; } 
        
        /// <summary>
        /// Title of the function.
        /// </summary>
        [IsoId("_I97EcSCBEeWhHbfCMWc1cw")]
        [DisplayName("Business Function")]
        [IsoXmlTag("BizFctn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? BusinessFunction { get; init; } 
        
        /// <summary>
        /// Specifies if due diligence checks on the political exposure of the investor or account servicer have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
        /// </summary>
        [IsoId("_I97EeyCBEeWhHbfCMWc1cw")]
        [DisplayName("Politically Exposed Person Type")]
        [IsoXmlTag("PltclyXpsdPrsnTp")]
        public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
        
        /// <summary>
        /// Date of death.
        /// </summary>
        [IsoId("_pPbr0CCgEeWJd9HF2tO7BA")]
        [DisplayName("Death Date")]
        [IsoXmlTag("DthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DeathDate { get; init; } 
        
        /// <summary>
        /// Civil status of the individual person.
        /// </summary>
        [IsoId("_rQHxMCCgEeWJd9HF2tO7BA")]
        [DisplayName("Civil Status")]
        [IsoXmlTag("CvlSts")]
        public CivilStatus1Choice_? CivilStatus { get; init; } 
        
        /// <summary>
        /// Highest level of education reached by the individual person.
        /// </summary>
        [IsoId("_sa0CsCCgEeWJd9HF2tO7BA")]
        [DisplayName("Education Level")]
        [IsoXmlTag("EdctnLvl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? EducationLevel { get; init; } 
        
        /// <summary>
        /// Information related to the person.
        /// </summary>
        [IsoId("_9CUlcDnkEeW7UoCHqpiMaQ")]
        [DisplayName("Family Information")]
        [IsoXmlTag("FmlyInf")]
        public PersonalInformation1? FamilyInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
