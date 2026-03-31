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
[IsoId("_EGMoQaevEemSUcvu_mDC7w")]
[DisplayName("Individual Person")]
public record IndividualPerson38
{
    /// <summary>
    /// Term used to address the person.
    /// </summary>
    [IsoId("_EZ_G86evEemSUcvu_mDC7w")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Choice_? NamePrefix { get; init; }

    /// <summary>
    /// First name of the person.
    /// </summary>
    [IsoId("_EZ_G9aevEemSUcvu_mDC7w")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Second name of the person.
    /// </summary>
    [IsoId("_EZ_G96evEemSUcvu_mDC7w")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Name by which the party is known and which is usually used to identify that person.
    /// </summary>
    [IsoId("_EZ_G-aevEemSUcvu_mDC7w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Additional information about the person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_EZ_G-6evEemSUcvu_mDC7w")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; }

    /// <summary>
    /// Gender of the person.
    /// </summary>
    [IsoId("_EZ_G_aevEemSUcvu_mDC7w")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public Gender1Code? Gender { get; init; }

    /// <summary>
    /// Date on which the person was born.
    /// </summary>
    [IsoId("_EZ_G_6evEemSUcvu_mDC7w")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country where the person was born.
    /// </summary>
    [IsoId("_EZ_HAaevEemSUcvu_mDC7w")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Province where the person was born.
    /// </summary>
    [IsoId("_EZ_HBaevEemSUcvu_mDC7w")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <summary>
    /// City where the person was born.
    /// </summary>
    [IsoId("_EZ_HB6evEemSUcvu_mDC7w")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; }

    /// <summary>
    /// Name of the occupation or job of the person.
    /// </summary>
    [IsoId("_EZ_HCaevEemSUcvu_mDC7w")]
    [DisplayName("Profession")]
    [IsoXmlTag("Prfssn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Profession { get; init; }

    /// <summary>
    /// Information related to an address to be inserted, updated or deleted.
    /// </summary>
    [IsoId("_EZ_HC6evEemSUcvu_mDC7w")]
    [DisplayName("Modified Postal Address")]
    [IsoXmlTag("ModfdPstlAdr")]
    public ValueList<ModificationScope34> ModifiedPostalAddress { get; init; } = [];

    /// <summary>
    /// Citizenship information to be inserted or deleted.
    /// </summary>
    [IsoId("_EZ_HDaevEemSUcvu_mDC7w")]
    [DisplayName("Modified Citizenship")]
    [IsoXmlTag("ModfdCtznsh")]
    [MinLength(0)]
    [MaxLength(3)]
    public ValueList<ModificationScope39> ModifiedCitizenship { get; init; } = [];

    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_EZ_HD6evEemSUcvu_mDC7w")]
    [DisplayName("Employing Company")]
    [IsoXmlTag("EmplngCpny")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? EmployingCompany { get; init; }

    /// <summary>
    /// Title of the function.
    /// </summary>
    [IsoId("_EZ_HEaevEemSUcvu_mDC7w")]
    [DisplayName("Business Function")]
    [IsoXmlTag("BizFctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BusinessFunction { get; init; }

    /// <summary>
    /// Politically exposed person checks.
    /// </summary>
    [IsoId("_OFeU0aevEemSUcvu_mDC7w")]
    [DisplayName("Politically Exposed Person")]
    [IsoXmlTag("PltclyXpsdPrsn")]
    public PoliticallyExposedPerson1? PoliticallyExposedPerson { get; init; }

    /// <summary>
    /// Date of death.
    /// </summary>
    [IsoId("_EZ_HFaevEemSUcvu_mDC7w")]
    [DisplayName("Death Date")]
    [IsoXmlTag("DthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DeathDate { get; init; }

    /// <summary>
    /// Civil status of the individual person.
    /// </summary>
    [IsoId("_EaI38aevEemSUcvu_mDC7w")]
    [DisplayName("Civil Status")]
    [IsoXmlTag("CvlSts")]
    public CivilStatus1Choice_? CivilStatus { get; init; }

    /// <summary>
    /// Highest level of education reached by the individual person.
    /// </summary>
    [IsoId("_EaI386evEemSUcvu_mDC7w")]
    [DisplayName("Education Level")]
    [IsoXmlTag("EdctnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EducationLevel { get; init; }

    /// <summary>
    /// Information related to the person.
    /// </summary>
    [IsoId("_EaI39aevEemSUcvu_mDC7w")]
    [DisplayName("Family Information")]
    [IsoXmlTag("FmlyInf")]
    public PersonalInformation1? FamilyInformation { get; init; }

    /// <summary>
    /// Information about the individual&apos;s consent to use personal data under the General Protection Regulation (GDPR) 2016/679 regulation.
    /// </summary>
    [IsoId("_QKVIgaevEemSUcvu_mDC7w")]
    [DisplayName("GDPR Data")]
    [IsoXmlTag("GDPRData")]
    public ValueList<GDPRData1> GDPRData { get; init; } = [];
}
