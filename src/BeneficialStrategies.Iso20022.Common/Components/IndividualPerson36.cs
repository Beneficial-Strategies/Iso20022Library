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
[IsoId("_-rUYBW4-EeiU9cctagi5ow")]
[DisplayName("Individual Person")]
public record IndividualPerson36
{
    /// <summary>
    /// Current name used.
    /// </summary>
    [IsoId("_-2MLQW4-EeiU9cctagi5ow")]
    [DisplayName("Current Name")]
    [IsoXmlTag("CurNm")]
    public required IndividualPersonNameLong2 CurrentName { get; init; }

    /// <summary>
    /// Previous name used.
    /// </summary>
    [IsoId("_-2MLQ24-EeiU9cctagi5ow")]
    [DisplayName("Previous Name")]
    [IsoXmlTag("PrvsNm")]
    public IndividualPersonNameLong2? PreviousName { get; init; }

    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_-2MLRW4-EeiU9cctagi5ow")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public Gender1Code? Gender { get; init; }

    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_-2MLR24-EeiU9cctagi5ow")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_-2MLSW4-EeiU9cctagi5ow")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_-2MLS24-EeiU9cctagi5ow")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_-2MLTW4-EeiU9cctagi5ow")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_-2MLT24-EeiU9cctagi5ow")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; }

    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_-2MLUW4-EeiU9cctagi5ow")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country and residential status of an individual, for example, non-permanent resident.
    /// </summary>
    [IsoId("_-2MLU24-EeiU9cctagi5ow")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; }

    /// <summary>
    /// Government identification for its citizens.
    /// </summary>
    [IsoId("_-2MLVW4-EeiU9cctagi5ow")]
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SocialSecurityNumber { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_-2MLV24-EeiU9cctagi5ow")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }

    /// <summary>
    /// Information about a citizen.
    /// </summary>
    [IsoId("_-2MLWW4-EeiU9cctagi5ow")]
    [DisplayName("Citizenship Information")]
    [IsoXmlTag("CtznshInf")]
    public CitizenshipInformation1? CitizenshipInformation { get; init; }

    /// <summary>
    /// Address for the primary contact.
    /// </summary>
    [IsoId("_-2MLW24-EeiU9cctagi5ow")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication to an alternate address.
    /// </summary>
    [IsoId("_-2MLXW4-EeiU9cctagi5ow")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }

    /// <summary>
    /// Other type of identification.
    /// </summary>
    [IsoId("_-2MLX24-EeiU9cctagi5ow")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public GenericIdentification44? OtherIdentification { get; init; }

    /// <summary>
    /// Additional information required for the account switch.
    /// </summary>
    [IsoId("_-2MLYW4-EeiU9cctagi5ow")]
    [DisplayName("Other Details")]
    [IsoXmlTag("OthrDtls")]
    public TransferInstruction1? OtherDetails { get; init; }
}
