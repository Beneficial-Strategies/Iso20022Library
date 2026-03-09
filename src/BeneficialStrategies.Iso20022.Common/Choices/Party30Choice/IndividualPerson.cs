// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Party30Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_u1elk0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Individual Person")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IndividualPerson : Party30Choice_
    #else
    public partial class IndividualPerson : Party30Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IndividualPerson instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IndividualPerson( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Term used to address the person.
        /// </summary>
        [IsoId("_Nk4cs0KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4ctUKUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4ct0KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cuUKUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cu0KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cvUKUEeWuG5hmkcJWSQ")]
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
        /// Date on which the person was born.
        /// </summary>
        [IsoId("_Nk4cv0KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cwUKUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cxUKUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cx0KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4cyUKUEeWuG5hmkcJWSQ")]
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
        /// Information related to an address to be inserted, updated or deleted.
        /// </summary>
        [IsoId("_P04wcUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Modified Postal Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ModfdPstlAdr")]
        #endif
        [IsoXmlTag("ModfdPstlAdr")]
        [MinLength(0)]
        [MaxLength(5)]
        public ValueList<ModificationScope34> ModifiedPostalAddress { get; init; } = new ValueList<ModificationScope34>(){};
        
        /// <summary>
        /// Citizenship information to be inserted or deleted.
        /// </summary>
        [IsoId("_Gyue0XcKEeW68sPeY5XtQw")]
        [DisplayName("Modified Citizenship")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ModfdCtznsh")]
        #endif
        [IsoXmlTag("ModfdCtznsh")]
        [MinLength(0)]
        [MaxLength(3)]
        public ValueList<ModificationScope3> ModifiedCitizenship { get; init; } = new ValueList<ModificationScope3>(){};
        
        /// <summary>
        /// Organisation represented by a person, or for which a person works.
        /// </summary>
        [IsoId("_Nk4cz0KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4c0UKUEeWuG5hmkcJWSQ")]
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
        /// Specifies if due diligence checks on the political exposure of the investor or account servicer have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
        /// </summary>
        [IsoId("_Nk4c2UKUEeWuG5hmkcJWSQ")]
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
        
        /// <summary>
        /// Date of death.
        /// </summary>
        [IsoId("_Nk4c20KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4c3UKUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4c30KUEeWuG5hmkcJWSQ")]
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
        [IsoId("_Nk4c4UKUEeWuG5hmkcJWSQ")]
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
        
        
        #nullable disable
        
    }
}
