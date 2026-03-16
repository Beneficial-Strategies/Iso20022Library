// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Individual Person44.
/// </summary>
[IsoId("_3atwVTEyEe6g-ffJsqGiSA")]
[DisplayName("Individual Person44")]
public partial record IndividualPerson44
{
    #nullable enable

    /// <summary>
    /// Birth Date.
    /// </summary>
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    public IsoISODate? BirthDate { get; init; } 

    /// <summary>
    /// Citizenship Information.
    /// </summary>
    [DisplayName("Citizenship Information")]
    [IsoXmlTag("CtznshInf")]
    public ValueList<CitizenshipInformation1> CitizenshipInformation { get; init; } = [];

    /// <summary>
    /// City Of Birth.
    /// </summary>
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    public IsoMax35Text? CityOfBirth { get; init; } 

    /// <summary>
    /// Country And Residential Status.
    /// </summary>
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 

    /// <summary>
    /// Country Of Birth.
    /// </summary>
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; } 

    /// <summary>
    /// Current Name.
    /// </summary>
    [DisplayName("Current Name")]
    [IsoXmlTag("CurNm")]
    public required IndividualPersonNameLong2 CurrentName { get; init; } 

    /// <summary>
    /// Gender.
    /// </summary>
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public Gender1Code? Gender { get; init; } 

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 

    /// <summary>
    /// Other Details.
    /// </summary>
    [DisplayName("Other Details")]
    [IsoXmlTag("OthrDtls")]
    public ValueList<TransferInstruction1> OtherDetails { get; init; } = [];

    /// <summary>
    /// Other Identification.
    /// </summary>
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public ValueList<GenericIdentification44> OtherIdentification { get; init; } = [];

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public ValueList<PostalAddress27> PostalAddress { get; init; } = [];

    /// <summary>
    /// Previous Name.
    /// </summary>
    [DisplayName("Previous Name")]
    [IsoXmlTag("PrvsNm")]
    public ValueList<IndividualPersonNameLong2> PreviousName { get; init; } = [];

    /// <summary>
    /// Primary Communication Address.
    /// </summary>
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 

    /// <summary>
    /// Province Of Birth.
    /// </summary>
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    public IsoMax35Text? ProvinceOfBirth { get; init; } 

    /// <summary>
    /// Secondary Communication Address.
    /// </summary>
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 

    /// <summary>
    /// Social Security Number.
    /// </summary>
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    public IsoMax35Text? SocialSecurityNumber { get; init; } 

    /// <summary>
    /// Taxation Country.
    /// </summary>
    [DisplayName("Taxation Country")]
    [IsoXmlTag("TaxtnCtry")]
    public CountryCode? TaxationCountry { get; init; } 

    
    #nullable disable
    
}
