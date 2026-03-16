// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party30Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_u1elk0KSEeWuG5hmkcJWSQ")]
    [DisplayName("Individual Person")]
    public record IndividualPerson : Party30Choice_
    {
        /// <summary>
        /// Term used to address the person.
        /// </summary>
        [IsoId("_Nk4cs0KUEeWuG5hmkcJWSQ")]
        [DisplayName("Name Prefix")]
        [IsoXmlTag("NmPrfx")]
        public NamePrefix1Choice_? NamePrefix { get; init; }

        /// <summary>
        /// First name of the person.
        /// </summary>
        [IsoId("_Nk4ctUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? GivenName { get; init; }

        /// <summary>
        /// Second name of the person.
        /// </summary>
        [IsoId("_Nk4ct0KUEeWuG5hmkcJWSQ")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; }

        /// <summary>
        /// Name by which the party is known and which is usually used to identify that person.
        /// </summary>
        [IsoId("_Nk4cuUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Additional information about the person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
        /// </summary>
        [IsoId("_Nk4cu0KUEeWuG5hmkcJWSQ")]
        [DisplayName("Name Suffix")]
        [IsoXmlTag("NmSfx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NameSuffix { get; init; }

        /// <summary>
        /// Gender of the person.
        /// </summary>
        [IsoId("_Nk4cvUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public GenderCode? Gender { get; init; }

        /// <summary>
        /// Date on which the person was born.
        /// </summary>
        [IsoId("_Nk4cv0KUEeWuG5hmkcJWSQ")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? BirthDate { get; init; }

        /// <summary>
        /// Country where the person was born.
        /// </summary>
        [IsoId("_Nk4cwUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Country Of Birth")]
        [IsoXmlTag("CtryOfBirth")]
        public CountryCode? CountryOfBirth { get; init; }

        /// <summary>
        /// Province where the person was born.
        /// </summary>
        [IsoId("_Nk4cxUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Province Of Birth")]
        [IsoXmlTag("PrvcOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProvinceOfBirth { get; init; }

        /// <summary>
        /// City where the person was born.
        /// </summary>
        [IsoId("_Nk4cx0KUEeWuG5hmkcJWSQ")]
        [DisplayName("City Of Birth")]
        [IsoXmlTag("CityOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CityOfBirth { get; init; }

        /// <summary>
        /// Name of the occupation or job of the person.
        /// </summary>
        [IsoId("_Nk4cyUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Profession")]
        [IsoXmlTag("Prfssn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Profession { get; init; }

        /// <summary>
        /// Information related to an address to be inserted, updated or deleted.
        /// </summary>
        [IsoId("_P04wcUKUEeWuG5hmkcJWSQ")]
        [DisplayName("Modified Postal Address")]
        [IsoXmlTag("ModfdPstlAdr")]
        [MinLength(0)]
        [MaxLength(5)]
        public ValueList<ModificationScope34> ModifiedPostalAddress { get; init; } = [];

        /// <summary>
        /// Citizenship information to be inserted or deleted.
        /// </summary>
        [IsoId("_Gyue0XcKEeW68sPeY5XtQw")]
        [DisplayName("Modified Citizenship")]
        [IsoXmlTag("ModfdCtznsh")]
        [MinLength(0)]
        [MaxLength(3)]
        public ValueList<ModificationScope3> ModifiedCitizenship { get; init; } = [];

        /// <summary>
        /// Organisation represented by a person, or for which a person works.
        /// </summary>
        [IsoId("_Nk4cz0KUEeWuG5hmkcJWSQ")]
        [DisplayName("Employing Company")]
        [IsoXmlTag("EmplngCpny")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? EmployingCompany { get; init; }

        /// <summary>
        /// Title of the function.
        /// </summary>
        [IsoId("_Nk4c0UKUEeWuG5hmkcJWSQ")]
        [DisplayName("Business Function")]
        [IsoXmlTag("BizFctn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? BusinessFunction { get; init; }

        /// <summary>
        /// Specifies if due diligence checks on the political exposure of the investor or account servicer have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
        /// </summary>
        [IsoId("_Nk4c2UKUEeWuG5hmkcJWSQ")]
        [DisplayName("Politically Exposed Person Type")]
        [IsoXmlTag("PltclyXpsdPrsnTp")]
        public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [IsoId("_Nk4c20KUEeWuG5hmkcJWSQ")]
        [DisplayName("Death Date")]
        [IsoXmlTag("DthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DeathDate { get; init; }

        /// <summary>
        /// Civil status of the individual person.
        /// </summary>
        [IsoId("_Nk4c3UKUEeWuG5hmkcJWSQ")]
        [DisplayName("Civil Status")]
        [IsoXmlTag("CvlSts")]
        public CivilStatus1Choice_? CivilStatus { get; init; }

        /// <summary>
        /// Highest level of education reached by the individual person.
        /// </summary>
        [IsoId("_Nk4c30KUEeWuG5hmkcJWSQ")]
        [DisplayName("Education Level")]
        [IsoXmlTag("EdctnLvl")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? EducationLevel { get; init; }

        /// <summary>
        /// Information related to the person.
        /// </summary>
        [IsoId("_Nk4c4UKUEeWuG5hmkcJWSQ")]
        [DisplayName("Family Information")]
        [IsoXmlTag("FmlyInf")]
        public PersonalInformation1? FamilyInformation { get; init; }
    }
}
