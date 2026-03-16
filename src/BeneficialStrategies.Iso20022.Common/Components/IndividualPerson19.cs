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
[IsoId("_Q5lmoQ2hEeSNWNtJlXOAhg")]
[DisplayName("Individual Person")]
public record IndividualPerson19
{
    /// <summary>
    /// Current name used.
    /// </summary>
    [IsoId("_VymukA2iEeSNWNtJlXOAhg")]
    [DisplayName("Current Name")]
    [IsoXmlTag("CurNm")]
    public required IndividualPersonNameLong1 CurrentName { get; init; }

    /// <summary>
    /// Previous name used.
    /// </summary>
    [IsoId("_YcDdEA2iEeSNWNtJlXOAhg")]
    [DisplayName("Previous Name")]
    [IsoXmlTag("PrvsNm")]
    public IndividualPersonNameLong1? PreviousName { get; init; }

    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_7GGPsA2hEeSNWNtJlXOAhg")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public Gender1Code? Gender { get; init; }

    /// <summary>
    /// Language in which a person communicates.
    /// </summary>
    [IsoId("_33wEYA2hEeSNWNtJlXOAhg")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_YFl6UA2hEeSNWNtJlXOAhg")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_egpSMA2hEeSNWNtJlXOAhg")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_0zEycA2hEeSNWNtJlXOAhg")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_xeCJQA2hEeSNWNtJlXOAhg")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; }

    /// <summary>
    /// Country of taxation of an individual person.
    /// </summary>
    [IsoId("_uMHskA2hEeSNWNtJlXOAhg")]
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; }

    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_bUYxkA2hEeSNWNtJlXOAhg")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; }

    /// <summary>
    /// Government identification for its citizens.
    /// </summary>
    [IsoId("__URgUA2hEeSNWNtJlXOAhg")]
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SocialSecurityNumber { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_iY9AgA2hEeSNWNtJlXOAhg")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <summary>
    /// Information about a citizen.
    /// </summary>
    [IsoId("_nKO-MA2hEeSNWNtJlXOAhg")]
    [DisplayName("Citizenship Information")]
    [IsoXmlTag("CtznshInf")]
    public CitizenshipInformation1? CitizenshipInformation { get; init; }

    /// <summary>
    /// Address for the primary contact.
    /// </summary>
    [IsoId("_Lp9DkA2iEeSNWNtJlXOAhg")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication to an alternate address.
    /// </summary>
    [IsoId("_DnWfEA2iEeSNWNtJlXOAhg")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }

    /// <summary>
    /// Other type of identification.
    /// </summary>
    [IsoId("_IQcxIA2iEeSNWNtJlXOAhg")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public GenericIdentification44? OtherIdentification { get; init; }

    /// <summary>
    /// Additonal information required for the account switch.
    /// </summary>
    [IsoId("_qrxLQA2hEeSNWNtJlXOAhg")]
    [DisplayName("Other Details")]
    [IsoXmlTag("OthrDtls")]
    public TransferInstruction1? OtherDetails { get; init; }
}
