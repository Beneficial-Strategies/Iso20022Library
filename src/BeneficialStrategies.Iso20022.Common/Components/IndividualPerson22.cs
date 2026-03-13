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
[IsoId("_AXXaARRlEeOKWo1NF21OVw")]
[DisplayName("Individual Person")]
public partial record IndividualPerson22
{
    #nullable enable
    
    /// <summary>
    /// Term used to address a person.
    /// </summary>
    [IsoId("_AulAIxRlEeOKWo1NF21OVw")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Choice_? NamePrefix { get; init; } 
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_AulAJRRlEeOKWo1NF21OVw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GivenName { get; init; } 
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_AulAJxRlEeOKWo1NF21OVw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_AulAKRRlEeOKWo1NF21OVw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, eg, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_AulAKxRlEeOKWo1NF21OVw")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_AulALRRlEeOKWo1NF21OVw")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public GenderCode? Gender { get; init; } 
    
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_AulALxRlEeOKWo1NF21OVw")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_AulANxRlEeOKWo1NF21OVw")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; } 
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_AulAORRlEeOKWo1NF21OVw")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; } 
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_AulAQRRlEeOKWo1NF21OVw")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_AulAQxRlEeOKWo1NF21OVw")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; } 
    
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    [IsoId("_AulARRRlEeOKWo1NF21OVw")]
    [DisplayName("Profession")]
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Profession { get; init; } 
    
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_AulARxRlEeOKWo1NF21OVw")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_AulASRRlEeOKWo1NF21OVw")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_AulASxRlEeOKWo1NF21OVw")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
    
    /// <summary>
    /// Nationality and legal status (minor or major) or rights that an individual may possess.
    /// </summary>
    [IsoId("_AulATRRlEeOKWo1NF21OVw")]
    [DisplayName("Citizenship")]
    [IsoXmlTag("Ctznsh")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CitizenshipInformation> Citizenship { get; init; } = [];
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_AulATxRlEeOKWo1NF21OVw")]
    [DisplayName("Employing Company")]
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? EmployingCompany { get; init; } 
    
    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_AulAURRlEeOKWo1NF21OVw")]
    [DisplayName("Business Function")]
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessFunction { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_AulAUxRlEeOKWo1NF21OVw")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_AulAVRRlEeOKWo1NF21OVw")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_AulAVxRlEeOKWo1NF21OVw")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<GenericIdentification44> OtherIdentification { get; init; } = [];
    
    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    [IsoId("_AulAWRRlEeOKWo1NF21OVw")]
    [DisplayName("Additional Regulatory Information")]
    [IsoXmlTag("AddtlRgltryInf")]
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    [IsoId("_2zwKMBRuEeOKWo1NF21OVw")]
    [DisplayName("Politically Exposed Person Type")]
    [IsoXmlTag("PltclyXpsdPrsnTp")]
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
    
    
    #nullable disable
    
}
