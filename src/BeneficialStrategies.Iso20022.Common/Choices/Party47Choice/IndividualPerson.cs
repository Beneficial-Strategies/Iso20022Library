// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party47Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_mDHs05Q_EemqYPWMBuVawg")]
    [DisplayName("Individual Person")]
    public record IndividualPerson : Party47Choice_
    {
        /// <summary>
        /// Term used to address the person.
        /// </summary>
        [IsoId("_yphp45TSEemC09f0MxYkRg")]
        [DisplayName("Name Prefix")]
        [IsoXmlTag("NmPrfx")]
        public NamePrefix1Choice_? NamePrefix { get; init; }

        /// <summary>
        /// First name of the person.
        /// </summary>
        [IsoId("_yphp5ZTSEemC09f0MxYkRg")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? GivenName { get; init; }

        /// <summary>
        /// Second name of the person.
        /// </summary>
        [IsoId("_yphp55TSEemC09f0MxYkRg")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; }

        /// <summary>
        /// Name by which the party is known and which is usually used to identify that person.
        /// </summary>
        [IsoId("_yphp6ZTSEemC09f0MxYkRg")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Additional information about the person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
        /// </summary>
        [IsoId("_yphp65TSEemC09f0MxYkRg")]
        [DisplayName("Name Suffix")]
        [IsoXmlTag("NmSfx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NameSuffix { get; init; }

        /// <summary>
        /// Gender of the person.
        /// </summary>
        [IsoId("_yphp7ZTSEemC09f0MxYkRg")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public Gender1Code? Gender { get; init; }

        /// <summary>
        /// Date on which the person was born.
        /// </summary>
        [IsoId("_yphp75TSEemC09f0MxYkRg")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? BirthDate { get; init; }

        /// <summary>
        /// Country where the person was born.
        /// </summary>
        [IsoId("_yphp8ZTSEemC09f0MxYkRg")]
        [DisplayName("Country Of Birth")]
        [IsoXmlTag("CtryOfBirth")]
        public CountryCode? CountryOfBirth { get; init; }

        /// <summary>
        /// Province where the person was born.
        /// </summary>
        [IsoId("_yphp9ZTSEemC09f0MxYkRg")]
        [DisplayName("Province Of Birth")]
        [IsoXmlTag("PrvcOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProvinceOfBirth { get; init; }

        /// <summary>
        /// City where the person was born.
        /// </summary>
        [IsoId("_yphp95TSEemC09f0MxYkRg")]
        [DisplayName("City Of Birth")]
        [IsoXmlTag("CityOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CityOfBirth { get; init; }

        /// <summary>
        /// Name of the occupation or job of the person.
        /// </summary>
        [IsoId("_yphp-ZTSEemC09f0MxYkRg")]
        [DisplayName("Profession")]
        [IsoXmlTag("Prfssn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Profession { get; init; }

        /// <summary>
        /// Address of the person.
        /// </summary>
        [IsoId("_yphp-5TSEemC09f0MxYkRg")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(10)]
        public ValueList<PostalAddress21> PostalAddress { get; init; } = [];

        /// <summary>
        /// Nationality and legal status (minor or major).
        /// </summary>
        [IsoId("_yphp_ZTSEemC09f0MxYkRg")]
        [DisplayName("Citizenship")]
        [IsoXmlTag("Ctznsh")]
        [MinLength(0)]
        [MaxLength(3)]
        public ValueList<CitizenshipInformation2> Citizenship { get; init; } = [];

        /// <summary>
        /// Organisation represented by a person, or for which a person works.
        /// </summary>
        [IsoId("_yphp_5TSEemC09f0MxYkRg")]
        [DisplayName("Employing Company")]
        [IsoXmlTag("EmplngCpny")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? EmployingCompany { get; init; }

        /// <summary>
        /// Title of the function.
        /// </summary>
        [IsoId("_yphqAZTSEemC09f0MxYkRg")]
        [DisplayName("Business Function")]
        [IsoXmlTag("BizFctn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? BusinessFunction { get; init; }

        /// <summary>
        /// Politically exposed person checks.
        /// </summary>
        [IsoId("_hFq4AKeeEemSUcvu_mDC7w")]
        [DisplayName("Politically Exposed Person")]
        [IsoXmlTag("PltclyXpsdPrsn")]
        public PoliticallyExposedPerson1? PoliticallyExposedPerson { get; init; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [IsoId("_yphqBZTSEemC09f0MxYkRg")]
        [DisplayName("Death Date")]
        [IsoXmlTag("DthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DeathDate { get; init; }

        /// <summary>
        /// Civil status of the individual person.
        /// </summary>
        [IsoId("_yphqB5TSEemC09f0MxYkRg")]
        [DisplayName("Civil Status")]
        [IsoXmlTag("CvlSts")]
        public CivilStatus1Choice_? CivilStatus { get; init; }

        /// <summary>
        /// Highest level of education reached by the individual person.
        /// </summary>
        [IsoId("_yphqCZTSEemC09f0MxYkRg")]
        [DisplayName("Education Level")]
        [IsoXmlTag("EdctnLvl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? EducationLevel { get; init; }

        /// <summary>
        /// Information related to the person.
        /// </summary>
        [IsoId("_yphqC5TSEemC09f0MxYkRg")]
        [DisplayName("Family Information")]
        [IsoXmlTag("FmlyInf")]
        public PersonalInformation1? FamilyInformation { get; init; }

        /// <summary>
        /// Information about the individual&apos;s consent to use personal data under the General Protection Regulation (GDPR) 2016/679 regulation.
        /// </summary>
        [IsoId("_3EpKUJTSEemC09f0MxYkRg")]
        [DisplayName("GDPR Data")]
        [IsoXmlTag("GDPRData")]
        public GDPRData1? GDPRData { get; init; }
    }
}
