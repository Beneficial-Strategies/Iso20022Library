// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party23Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_Bkkfc2W8EeSHcOWXSsMhqw")]
    [DisplayName("Individual Person")]
    public record IndividualPerson : Party23Choice_
    {
        /// <summary>
        /// Term used to address a person.
        /// </summary>
        [IsoId("_En0lYwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Name Prefix")]
        [IsoXmlTag("NmPrfx")]
        public NamePrefix1Choice_? NamePrefix { get; init; }

        /// <summary>
        /// First name of a person.
        /// </summary>
        [IsoId("_En0lZQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Given Name")]
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text GivenName { get; init; }

        /// <summary>
        /// Second name of a person.
        /// </summary>
        [IsoId("_En0lZwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Middle Name")]
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MiddleName { get; init; }

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_En0laQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Name { get; init; }

        /// <summary>
        /// Additional information about a person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
        /// </summary>
        [IsoId("_En0lawhDEeSUPbC7DbLJpQ")]
        [DisplayName("Name Suffix")]
        [IsoXmlTag("NmSfx")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? NameSuffix { get; init; }

        /// <summary>
        /// Specifies the gender of the person.
        /// </summary>
        [IsoId("_En0lbQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Gender")]
        [IsoXmlTag("Gndr")]
        public GenderCode? Gender { get; init; }

        /// <summary>
        /// Language in which a person communicates.
        /// </summary>
        [IsoId("_En0lbwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Language")]
        [IsoXmlTag("Lang")]
        public LanguageCode? Language { get; init; }

        /// <summary>
        /// Date on which a person is born.
        /// </summary>
        [IsoId("_En0ldwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Birth Date")]
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate BirthDate { get; init; }

        /// <summary>
        /// Country where a person was born.
        /// </summary>
        [IsoId("_En0leQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Country Of Birth")]
        [IsoXmlTag("CtryOfBirth")]
        public CountryCode? CountryOfBirth { get; init; }

        /// <summary>
        /// Province where a person was born.
        /// </summary>
        [IsoId("_En0lgQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Province Of Birth")]
        [IsoXmlTag("PrvcOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProvinceOfBirth { get; init; }

        /// <summary>
        /// City where a person was born.
        /// </summary>
        [IsoId("_En0lgwhDEeSUPbC7DbLJpQ")]
        [DisplayName("City Of Birth")]
        [IsoXmlTag("CityOfBirth")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CityOfBirth { get; init; }

        /// <summary>
        /// Name of the occupation or job of a person.
        /// </summary>
        [IsoId("_En0lhQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Profession")]
        [IsoXmlTag("Prfssn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Profession { get; init; }

        /// <summary>
        /// Country of taxation of an individual person.
        /// </summary>
        [IsoId("_En0lhwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Taxation Country")]
        [IsoXmlTag("TaxtnCtry")]
        public CountryCode? TaxationCountry { get; init; }

        /// <summary>
        /// Country and residential status of an individual, for example, non-permanent resident.
        /// </summary>
        [IsoId("_En0liQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Country And Residential Status")]
        [IsoXmlTag("CtryAndResdtlSts")]
        public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_En0liwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        [MinLength(1)]
        [MaxLength(5)]
        public ValueList<PostalAddress3> PostalAddress { get; init; } = [];

        /// <summary>
        /// Nationality and legal status (minor or major) or rights that an individual may possess.
        /// </summary>
        [IsoId("_En0ljQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Citizenship")]
        [IsoXmlTag("Ctznsh")]
        [MinLength(1)]
        [MaxLength(3)]
        public ValueList<CitizenshipInformation> Citizenship { get; init; } = [];

        /// <summary>
        /// Organisation represented by a person, or for which a person works.
        /// </summary>
        [IsoId("_En0ljwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Employing Company")]
        [IsoXmlTag("EmplngCpny")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? EmployingCompany { get; init; }

        /// <summary>
        /// Title of the function.
        /// </summary>
        [IsoId("_En0lkQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Business Function")]
        [IsoXmlTag("BizFctn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? BusinessFunction { get; init; }

        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_En0lkwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Primary Communication Address")]
        [IsoXmlTag("PmryComAdr")]
        public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

        /// <summary>
        /// Communication device number or electronic address used for communication.
        /// </summary>
        [IsoId("_En0llQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Secondary Communication Address")]
        [IsoXmlTag("ScndryComAdr")]
        public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }

        /// <summary>
        /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
        /// </summary>
        [IsoId("_En0llwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Other Identification")]
        [IsoXmlTag("OthrId")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<GenericIdentification55> OtherIdentification { get; init; } = [];

        /// <summary>
        /// Additional regulatory information about the investor that is required in some markets to support anti-money laundering laws.
        /// </summary>
        [IsoId("_En0lmQhDEeSUPbC7DbLJpQ")]
        [DisplayName("Additional Regulatory Information")]
        [IsoXmlTag("AddtlRgltryInf")]
        public RegulatoryInformation1? AdditionalRegulatoryInformation { get; init; }

        /// <summary>
        /// Specifies if due diligence checks on the political exposure of the investor have been carried out and whether these checks are national or foreign. (A politically exposed person is someone who has been entrusted with a prominent public function, or an individual who is closely related to such a person.).
        /// </summary>
        [IsoId("_En0lmwhDEeSUPbC7DbLJpQ")]
        [DisplayName("Politically Exposed Person Type")]
        [IsoXmlTag("PltclyXpsdPrsnTp")]
        public PoliticalExposureType1Choice_? PoliticallyExposedPersonType { get; init; }
    }
}
