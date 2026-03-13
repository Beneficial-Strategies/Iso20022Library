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
[IsoId("_QCkJ2tp-Ed-ak6NoX_4Aeg_-1430709668")]
[DisplayName("Individual Person")]
public partial record IndividualPerson10
{
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QCt60Np-Ed-ak6NoX_4Aeg_-1430709573")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; } 
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QCt60dp-Ed-ak6NoX_4Aeg_-1430709538")]
    [DisplayName("Extended Name Prefix")]
    [IsoXmlTag("XtndedNmPrfx")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedNamePrefix { get; init; } 
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QCt60tp-Ed-ak6NoX_4Aeg_-1430709496")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GivenName { get; init; } 
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_QCt609p-Ed-ak6NoX_4Aeg_-1430709184")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QCt61Np-Ed-ak6NoX_4Aeg_-1430709124")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, eg, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_QCt61dp-Ed-ak6NoX_4Aeg_-1430709089")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_QCt61tp-Ed-ak6NoX_4Aeg_-1430708781")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public GenderCode? Gender { get; init; } 
    
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_QCt619p-Ed-ak6NoX_4Aeg_-1430708738")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QCt62Np-Ed-ak6NoX_4Aeg_-1430708608")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; } 
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_QCt62dp-Ed-ak6NoX_4Aeg_-1430708548")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; } 
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_QC3r0Np-Ed-ak6NoX_4Aeg_-1430708296")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_QC3r0dp-Ed-ak6NoX_4Aeg_-1430708254")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; } 
    
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    [IsoId("_QC3r0tp-Ed-ak6NoX_4Aeg_-1430708211")]
    [DisplayName("Profession")]
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Profession { get; init; } 
    
    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_QC3r09p-Ed-ak6NoX_4Aeg_-1430708176")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_QC3r1Np-Ed-ak6NoX_4Aeg_-1430707867")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QC3r1dp-Ed-ak6NoX_4Aeg_-1430707168")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<PostalAddress3> PostalAddress { get; init; } = [];
    
    /// <summary>
    /// Nationality and legal status (minor or major) or rights that an individual may possess.
    /// </summary>
    [IsoId("_QC3r1tp-Ed-ak6NoX_4Aeg_-1430707574")]
    [DisplayName("Citizenship")]
    [IsoXmlTag("Ctznsh")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CitizenshipInformation> Citizenship { get; init; } = [];
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QC3r19p-Ed-ak6NoX_4Aeg_-583245358")]
    [DisplayName("Employing Company")]
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? EmployingCompany { get; init; } 
    
    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_QC3r2Np-Ed-ak6NoX_4Aeg_-628495412")]
    [DisplayName("Business Function")]
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessFunction { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QC3r2dp-Ed-ak6NoX_4Aeg_-1429786223")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QDA1wNp-Ed-ak6NoX_4Aeg_-1430706333")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_QDA1wdp-Ed-ak6NoX_4Aeg_-1430706764")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<GenericIdentification9> OtherIdentification { get; init; } = [];
    
    
    #nullable disable
    
}
