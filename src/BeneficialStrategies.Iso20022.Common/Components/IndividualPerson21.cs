// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_oPl40RRQEeOKWo1NF21OVw")]
[DisplayName("Individual Person")]
public partial record IndividualPerson21
{
    #nullable enable
    
    /// <summary>
    /// Term used to address a person.
    /// </summary>
    [IsoId("_om17MxRQEeOKWo1NF21OVw")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Choice_? NamePrefix { get; init; } 
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_om17NRRQEeOKWo1NF21OVw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GivenName { get; init; } 
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_om17NxRQEeOKWo1NF21OVw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_om17ORRQEeOKWo1NF21OVw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, eg, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_om17OxRQEeOKWo1NF21OVw")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_om17PRRQEeOKWo1NF21OVw")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public GenderCode? Gender { get; init; } 
    
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_om17PxRQEeOKWo1NF21OVw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_om17RxRQEeOKWo1NF21OVw")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; } 
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_om17SRRQEeOKWo1NF21OVw")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; } 
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_om17URRQEeOKWo1NF21OVw")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_om17UxRQEeOKWo1NF21OVw")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; } 
    
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    [IsoId("_om17VRRQEeOKWo1NF21OVw")]
    [DisplayName("Profession")]
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Profession { get; init; } 
    
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_om17VxRQEeOKWo1NF21OVw")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_om17WRRQEeOKWo1NF21OVw")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    
    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_P3W68xRWEeOKWo1NF21OVw")]
    [DisplayName("Business Function")]
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessFunction { get; init; } 
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_P3W68hRWEeOKWo1NF21OVw")]
    [DisplayName("Employing Company")]
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? EmployingCompany { get; init; } 
    
    /// <summary>
    /// Address information to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_om17WxRQEeOKWo1NF21OVw")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ModificationScope1> ModifiedPostalAddress { get; init; } = [];
    
    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    [IsoId("_om17XRRQEeOKWo1NF21OVw")]
    [DisplayName("Modified Citizenship")]
    [IsoXmlTag("ModfdCtznsh")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<ModificationScope3> ModifiedCitizenship { get; init; } = [];
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_om17YxRQEeOKWo1NF21OVw")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_om17ZRRQEeOKWo1NF21OVw")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Identification information to be either inserted or deleted.
    /// </summary>
    [IsoId("_om17ZxRQEeOKWo1NF21OVw")]
    [DisplayName("Modified Other Identification")]
    [IsoXmlTag("ModfdOthrId")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope17> ModifiedOtherIdentification { get; init; } = [];
    
    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    [IsoId("_om17aRRQEeOKWo1NF21OVw")]
    [DisplayName("Additional Regulatory Information")]
    [IsoXmlTag("AddtlRgltryInf")]
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    [IsoId("_FZ_lYRRwEeOKWo1NF21OVw")]
    [DisplayName("Politically Exposed Person Type")]
    [IsoXmlTag("PltclyXpsdPrsnTp")]
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
    
    
    #nullable disable
    
}
