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
[IsoId("_yUspYZTSEemC09f0MxYkRg")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson37
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson37 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson37( System.String reqName )
    {
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Term used to address the person.
    /// </summary>
    [IsoId("_yphp45TSEemC09f0MxYkRg")]
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
    /// First name of the person.
    /// </summary>
    [IsoId("_yphp5ZTSEemC09f0MxYkRg")]
    [DisplayName("Given Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvnNm")]
    #endif
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GivenName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GivenName { get; init; } 
    #else
    public System.String? GivenName { get; set; } 
    #endif
    
    /// <summary>
    /// Second name of the person.
    /// </summary>
    [IsoId("_yphp55TSEemC09f0MxYkRg")]
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
    /// Name by which the party is known and which is usually used to identify that person.
    /// </summary>
    [IsoId("_yphp6ZTSEemC09f0MxYkRg")]
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
    /// Additional information about the person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_yphp65TSEemC09f0MxYkRg")]
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
    /// Gender of the person.
    /// </summary>
    [IsoId("_yphp7ZTSEemC09f0MxYkRg")]
    [DisplayName("Gender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Gndr")]
    #endif
    [IsoXmlTag("Gndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Gender1Code? Gender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Gender1Code? Gender { get; init; } 
    #else
    public Gender1Code? Gender { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the person was born.
    /// </summary>
    [IsoId("_yphp75TSEemC09f0MxYkRg")]
    [DisplayName("Birth Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BirthDt")]
    #endif
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BirthDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BirthDate { get; init; } 
    #else
    public System.DateOnly? BirthDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the person was born.
    /// </summary>
    [IsoId("_yphp8ZTSEemC09f0MxYkRg")]
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
    /// Province where the person was born.
    /// </summary>
    [IsoId("_yphp9ZTSEemC09f0MxYkRg")]
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
    /// City where the person was born.
    /// </summary>
    [IsoId("_yphp95TSEemC09f0MxYkRg")]
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
    /// Name of the occupation or job of the person.
    /// </summary>
    [IsoId("_yphp-ZTSEemC09f0MxYkRg")]
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
    /// Address of the person.
    /// </summary>
    [IsoId("_yphp-5TSEemC09f0MxYkRg")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<PostalAddress21> PostalAddress { get; init; } = new ValueList<PostalAddress21>(){};
    
    /// <summary>
    /// Nationality and legal status (minor or major).
    /// </summary>
    [IsoId("_yphp_ZTSEemC09f0MxYkRg")]
    [DisplayName("Citizenship")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctznsh")]
    #endif
    [IsoXmlTag("Ctznsh")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<CitizenshipInformation2> Citizenship { get; init; } = new ValueList<CitizenshipInformation2>(){};
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_yphp_5TSEemC09f0MxYkRg")]
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
    [IsoId("_yphqAZTSEemC09f0MxYkRg")]
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
    /// Politically exposed person checks.
    /// </summary>
    [IsoId("_hFq4AKeeEemSUcvu_mDC7w")]
    [DisplayName("Politically Exposed Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PltclyXpsdPrsn")]
    #endif
    [IsoXmlTag("PltclyXpsdPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PoliticallyExposedPerson1? PoliticallyExposedPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PoliticallyExposedPerson1? PoliticallyExposedPerson { get; init; } 
    #else
    public PoliticallyExposedPerson1? PoliticallyExposedPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Date of death.
    /// </summary>
    [IsoId("_yphqBZTSEemC09f0MxYkRg")]
    [DisplayName("Death Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DthDt")]
    #endif
    [IsoXmlTag("DthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DeathDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DeathDate { get; init; } 
    #else
    public System.DateOnly? DeathDate { get; set; } 
    #endif
    
    /// <summary>
    /// Civil status of the individual person.
    /// </summary>
    [IsoId("_yphqB5TSEemC09f0MxYkRg")]
    [DisplayName("Civil Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CvlSts")]
    #endif
    [IsoXmlTag("CvlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CivilStatus1Choice_? CivilStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CivilStatus1Choice_? CivilStatus { get; init; } 
    #else
    public CivilStatus1Choice_? CivilStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Highest level of education reached by the individual person.
    /// </summary>
    [IsoId("_yphqCZTSEemC09f0MxYkRg")]
    [DisplayName("Education Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EdctnLvl")]
    #endif
    [IsoXmlTag("EdctnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EducationLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EducationLevel { get; init; } 
    #else
    public System.String? EducationLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the person.
    /// </summary>
    [IsoId("_yphqC5TSEemC09f0MxYkRg")]
    [DisplayName("Family Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FmlyInf")]
    #endif
    [IsoXmlTag("FmlyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonalInformation1? FamilyInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonalInformation1? FamilyInformation { get; init; } 
    #else
    public PersonalInformation1? FamilyInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the individual&apos;s consent to use personal data under the General Protection Regulation (GDPR) 2016/679 regulation.
    /// </summary>
    [IsoId("_3EpKUJTSEemC09f0MxYkRg")]
    [DisplayName("GDPR Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GDPRData")]
    #endif
    [IsoXmlTag("GDPRData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GDPRData1? GDPRData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GDPRData1? GDPRData { get; init; } 
    #else
    public GDPRData1? GDPRData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
