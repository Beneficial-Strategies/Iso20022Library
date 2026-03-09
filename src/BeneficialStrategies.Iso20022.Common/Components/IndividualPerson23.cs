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
[IsoId("_EMmpBQhDEeSUPbC7DbLJpQ")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson23( System.String reqGivenName,System.String reqName,System.DateOnly reqBirthDate )
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
    [IsoId("_En0lYwhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lZQhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lZwhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0laQhDEeSUPbC7DbLJpQ")]
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
    /// Additional information about a person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_En0lawhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lbQhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lbwhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0ldwhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0leQhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lgQhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lgwhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lhQhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lhwhDEeSUPbC7DbLJpQ")]
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
    /// Country and residential status of an individual, for example, non-permanent resident.
    /// </summary>
    [IsoId("_En0liQhDEeSUPbC7DbLJpQ")]
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
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_En0liwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<PostalAddress3> PostalAddress { get; init; } = new ValueList<PostalAddress3>(){};
    
    /// <summary>
    /// Nationality and legal status (minor or major) or rights that an individual may possess.
    /// </summary>
    [IsoId("_En0ljQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Citizenship")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctznsh")]
    #endif
    [IsoXmlTag("Ctznsh")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CitizenshipInformation> Citizenship { get; init; } = new ValueList<CitizenshipInformation>(){};
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_En0ljwhDEeSUPbC7DbLJpQ")]
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
    /// Title of the function.
    /// </summary>
    [IsoId("_En0lkQhDEeSUPbC7DbLJpQ")]
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
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_En0lkwhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0llQhDEeSUPbC7DbLJpQ")]
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
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_En0llwhDEeSUPbC7DbLJpQ")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<GenericIdentification55> OtherIdentification { get; init; } = new ValueList<GenericIdentification55>(){};
    
    /// <summary>
    /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
    /// </summary>
    [IsoId("_En0lmQhDEeSUPbC7DbLJpQ")]
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
    [IsoId("_En0lmwhDEeSUPbC7DbLJpQ")]
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
