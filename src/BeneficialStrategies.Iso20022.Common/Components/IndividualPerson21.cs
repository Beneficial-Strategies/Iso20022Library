// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_oPl40RRQEeOKWo1NF21OVw")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson21( System.String reqGivenName,System.String reqName,System.DateOnly reqBirthDate )
    {
        GivenName = reqGivenName;
        Name = reqName;
        BirthDate = reqBirthDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Term used to address a person.
    /// </summary>
    [IsoId("_om17MxRQEeOKWo1NF21OVw")]
    [DisplayName("Name Prefix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmPrfx")]
    #endif
    [IsoXmlTag("NmPrfx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NamePrefix1Choice_? NamePrefix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NamePrefix1Choice_? NamePrefix { get; init; } 
    #else
    public NamePrefix1Choice_? NamePrefix { get; set; } 
    #endif
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_om17NRRQEeOKWo1NF21OVw")]
    [DisplayName("Given Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvnNm")]
    #endif
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text GivenName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GivenName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GivenName { get; init; } 
    #else
    public System.String GivenName { get; set; } 
    #endif
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_om17NxRQEeOKWo1NF21OVw")]
    [DisplayName("Middle Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MddlNm")]
    #endif
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MiddleName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MiddleName { get; init; } 
    #else
    public System.String? MiddleName { get; set; } 
    #endif
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_om17ORRQEeOKWo1NF21OVw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, eg, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_om17OxRQEeOKWo1NF21OVw")]
    [DisplayName("Name Suffix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmSfx")]
    #endif
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NameSuffix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameSuffix { get; init; } 
    #else
    public System.String? NameSuffix { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_om17PRRQEeOKWo1NF21OVw")]
    [DisplayName("Gender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Gndr")]
    #endif
    [IsoXmlTag("Gndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenderCode? Gender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenderCode? Gender { get; init; } 
    #else
    public GenderCode? Gender { get; set; } 
    #endif
    
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_om17PxRQEeOKWo1NF21OVw")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_om17RxRQEeOKWo1NF21OVw")]
    [DisplayName("Birth Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BirthDt")]
    #endif
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate BirthDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly BirthDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly BirthDate { get; init; } 
    #else
    public System.DateOnly BirthDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_om17SRRQEeOKWo1NF21OVw")]
    [DisplayName("Country Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfBirth")]
    #endif
    [IsoXmlTag("CtryOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfBirth { get; init; } 
    #else
    public string? CountryOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_om17URRQEeOKWo1NF21OVw")]
    [DisplayName("Province Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvcOfBirth")]
    #endif
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProvinceOfBirth { get; init; } 
    #else
    public System.String? ProvinceOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_om17UxRQEeOKWo1NF21OVw")]
    [DisplayName("City Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CityOfBirth")]
    #endif
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CityOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CityOfBirth { get; init; } 
    #else
    public System.String? CityOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    [IsoId("_om17VRRQEeOKWo1NF21OVw")]
    [DisplayName("Profession")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prfssn")]
    #endif
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Profession { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Profession { get; init; } 
    #else
    public System.String? Profession { get; set; } 
    #endif
    
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_om17VxRQEeOKWo1NF21OVw")]
    [DisplayName("Taxation Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnCtry")]
    #endif
    [IsoXmlTag("TaxtnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? TaxationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TaxationCountry { get; init; } 
    #else
    public string? TaxationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_om17WRRQEeOKWo1NF21OVw")]
    [DisplayName("Country And Residential Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryAndResdtlSts")]
    #endif
    [IsoXmlTag("CtryAndResdtlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    #else
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_P3W68xRWEeOKWo1NF21OVw")]
    [DisplayName("Business Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizFctn")]
    #endif
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BusinessFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessFunction { get; init; } 
    #else
    public System.String? BusinessFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_P3W68hRWEeOKWo1NF21OVw")]
    [DisplayName("Employing Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmplngCpny")]
    #endif
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? EmployingCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmployingCompany { get; init; } 
    #else
    public System.String? EmployingCompany { get; set; } 
    #endif
    
    /// <summary>
    /// Address information to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_om17WxRQEeOKWo1NF21OVw")]
    [DisplayName("Modified Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdPstlAdr")]
    #endif
    [IsoXmlTag("ModfdPstlAdr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ModificationScope1> ModifiedPostalAddress { get; init; } = new ValueList<ModificationScope1>(){};
    
    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    [IsoId("_om17XRRQEeOKWo1NF21OVw")]
    [DisplayName("Modified Citizenship")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdCtznsh")]
    #endif
    [IsoXmlTag("ModfdCtznsh")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<ModificationScope3> ModifiedCitizenship { get; init; } = new ValueList<ModificationScope3>(){};
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_om17YxRQEeOKWo1NF21OVw")]
    [DisplayName("Primary Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryComAdr")]
    #endif
    [IsoXmlTag("PmryComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? PrimaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_om17ZRRQEeOKWo1NF21OVw")]
    [DisplayName("Secondary Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryComAdr")]
    #endif
    [IsoXmlTag("ScndryComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? SecondaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Identification information to be either inserted or deleted.
    /// </summary>
    [IsoId("_om17ZxRQEeOKWo1NF21OVw")]
    [DisplayName("Modified Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModfdOthrId")]
    #endif
    [IsoXmlTag("ModfdOthrId")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope17> ModifiedOtherIdentification { get; init; } = new ValueList<ModificationScope17>(){};
    
    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    [IsoId("_om17aRRQEeOKWo1NF21OVw")]
    [DisplayName("Additional Regulatory Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRgltryInf")]
    #endif
    [IsoXmlTag("AddtlRgltryInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; } 
    #else
    public RegulatoryInformation1? AdditionalRegulatoryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    [IsoId("_FZ_lYRRwEeOKWo1NF21OVw")]
    [DisplayName("Politically Exposed Person Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PltclyXpsdPrsnTp")]
    #endif
    [IsoXmlTag("PltclyXpsdPrsnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; } 
    #else
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
