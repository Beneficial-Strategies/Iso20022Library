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
[IsoId("_QCRO5tp-Ed-ak6NoX_4Aeg_440061392")]
[DisplayName("Individual Person")]
public partial record IndividualPerson11
{
    #nullable enable
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QCRO59p-Ed-ak6NoX_4Aeg_440061418")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; } 
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QCRO6Np-Ed-ak6NoX_4Aeg_440981441")]
    [DisplayName("Extended Name Prefix")]
    [IsoXmlTag("XtndedNmPrfx")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedNamePrefix { get; init; } 
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QCRO6dp-Ed-ak6NoX_4Aeg_440981458")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GivenName { get; init; } 
    
    /// <summary>
    /// Second name of a person.
    /// </summary>
    [IsoId("_QCRO6tp-Ed-ak6NoX_4Aeg_440981476")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QCRO69p-Ed-ak6NoX_4Aeg_440981518")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, eg, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_QCa_4Np-Ed-ak6NoX_4Aeg_440981536")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_QCa_4dp-Ed-ak6NoX_4Aeg_440981561")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public GenderCode? Gender { get; init; } 
    
    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_QCa_4tp-Ed-ak6NoX_4Aeg_440981596")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QCa_49p-Ed-ak6NoX_4Aeg_440981613")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; } 
    
    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_QCa_5Np-Ed-ak6NoX_4Aeg_440981631")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; } 
    
    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_QCa_5dp-Ed-ak6NoX_4Aeg_440981656")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; } 
    
    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_QCa_5tp-Ed-ak6NoX_4Aeg_440981691")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; } 
    
    /// <summary>
    /// Name of the occupation or job of a person.
    /// </summary>
    [IsoId("_QCa_59p-Ed-ak6NoX_4Aeg_440981716")]
    [DisplayName("Profession")]
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Profession { get; init; } 
    
    /// <summary>
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    [IsoId("_QCa_6Np-Ed-ak6NoX_4Aeg_440981733")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_QCa_6dp-Ed-ak6NoX_4Aeg_440981985")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    
    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_QCkJ0Np-Ed-ak6NoX_4Aeg_524099481")]
    [DisplayName("Business Function")]
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessFunction { get; init; } 
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QCkJ0dp-Ed-ak6NoX_4Aeg_524099583")]
    [DisplayName("Employing Company")]
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? EmployingCompany { get; init; } 
    
    /// <summary>
    /// Address information to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_QCkJ0tp-Ed-ak6NoX_4Aeg_440982433")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ModificationScope1> ModifiedPostalAddress { get; init; } = new ValueList<ModificationScope1>(){};
    
    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    [IsoId("_QCkJ09p-Ed-ak6NoX_4Aeg_440982415")]
    [DisplayName("Modified Citizenship")]
    [IsoXmlTag("ModfdCtznsh")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<ModificationScope3> ModifiedCitizenship { get; init; } = new ValueList<ModificationScope3>(){};
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QCkJ1Np-Ed-ak6NoX_4Aeg_440982047")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QCkJ1dp-Ed-ak6NoX_4Aeg_440982089")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Identification information to be either inserted or deleted.
    /// </summary>
    [IsoId("_QCkJ1tp-Ed-ak6NoX_4Aeg_440982124")]
    [DisplayName("Modified Other Identification")]
    [IsoXmlTag("ModfdOthrId")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<ModificationScope2> ModifiedOtherIdentification { get; init; } = new ValueList<ModificationScope2>(){};
    
    
    #nullable disable
    
}
