// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_49vcsU_pEeaB8-OWTiMVrQ")]
[DisplayName("Individual Person")]
public record IndividualPerson33
{
    /// <summary>
    /// Term used to address the person.
    /// </summary>
    [IsoId("_5WvLg0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Choice_? NamePrefix { get; init; }

    /// <summary>
    /// First name of the person.
    /// </summary>
    [IsoId("_5WvLhU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Second name of the person.
    /// </summary>
    [IsoId("_5WvLh0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Name by which the party is known and which is usually used to identify that person.
    /// </summary>
    [IsoId("_5WvLiU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Additional information about the person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_5WvLi0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; }

    /// <summary>
    /// Gender of the person.
    /// </summary>
    [IsoId("_5WvLjU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public Gender1Code? Gender { get; init; }

    /// <summary>
    /// Date on which the person was born.
    /// </summary>
    [IsoId("_5WvLj0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country where the person was born.
    /// </summary>
    [IsoId("_5WvLkU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Province where the person was born.
    /// </summary>
    [IsoId("_5WvLlU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <summary>
    /// City where the person was born.
    /// </summary>
    [IsoId("_5WvLl0_pEeaB8-OWTiMVrQ")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; }

    /// <summary>
    /// Name of the occupation or job of the person.
    /// </summary>
    [IsoId("_5WvLmU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Profession")]
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Profession { get; init; }

    /// <summary>
    /// Information related to an address to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_5WvLm0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    public ValueList<ModificationScope34> ModifiedPostalAddress { get; init; } = [];

    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    [IsoId("_5WvLnU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Modified Citizenship")]
    [IsoXmlTag("ModfdCtznsh")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<ModificationScope39> ModifiedCitizenship { get; init; } = [];

    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_5WvLn0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Employing Company")]
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? EmployingCompany { get; init; }

    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_5WvLoU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Business Function")]
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BusinessFunction { get; init; }

    /// <summary>
    /// Specifies if due diligence checks on the political exposure of the investor or account servicer have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
    /// </summary>
    [IsoId("_5WvLo0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Politically Exposed Person Type")]
    [IsoXmlTag("PltclyXpsdPrsnTp")]
    public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; }

    /// <summary>
    /// Date of death.
    /// </summary>
    [IsoId("_5WvLpU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Death Date")]
    [IsoXmlTag("DthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeathDate { get; init; }

    /// <summary>
    /// Civil status of the individual person.
    /// </summary>
    [IsoId("_5WvLp0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Civil Status")]
    [IsoXmlTag("CvlSts")]
    public CivilStatus1Choice_? CivilStatus { get; init; }

    /// <summary>
    /// Highest level of education reached by the individual person.
    /// </summary>
    [IsoId("_5WvLqU_pEeaB8-OWTiMVrQ")]
    [DisplayName("Education Level")]
    [IsoXmlTag("EdctnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EducationLevel { get; init; }

    /// <summary>
    /// Information related to the person.
    /// </summary>
    [IsoId("_5WvLq0_pEeaB8-OWTiMVrQ")]
    [DisplayName("Family Information")]
    [IsoXmlTag("FmlyInf")]
    public PersonalInformation1? FamilyInformation { get; init; }
}
