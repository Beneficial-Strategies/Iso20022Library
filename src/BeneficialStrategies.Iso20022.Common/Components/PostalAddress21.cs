// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_E4FW4SFyEeW9XJWqfgXIIA")]
[DisplayName("Postal Address")]
public partial record PostalAddress21
{
    #nullable enable
    
    /// <summary>
    /// Type of address.
    /// </summary>
    [IsoId("_FUWcIyFyEeW9XJWqfgXIIA")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType2Choice_? AddressType { get; init; } 
    
    /// <summary>
    /// Indicates whether mail should be sent to the address.
    /// </summary>
    [IsoId("_FUWcJSFyEeW9XJWqfgXIIA")]
    [DisplayName("Mailing Indicator")]
    [IsoXmlTag("MlngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MailingIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the address is the official address of the party.
    /// </summary>
    [IsoId("_FUWcJyFyEeW9XJWqfgXIIA")]
    [DisplayName("Registration Address Indicator")]
    [IsoXmlTag("RegnAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RegistrationAddressIndicator { get; init; } 
    
    /// <summary>
    /// When the individual resides at another person’s address, the name of the other person.
    /// </summary>
    [IsoId("_4dKfkDnhEeW7UoCHqpiMaQ")]
    [DisplayName("Care Of")]
    [IsoXmlTag("CareOf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CareOf { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_vkmOWDnfEeWSyLR5Z9BEKA")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AddressLine { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Name of the street or thoroughfare.
    /// </summary>
    [IsoId("_vkmOWTnfEeWSyLR5Z9BEKA")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of the building on a street.
    /// </summary>
    [IsoId("_vkmOWjnfEeWSyLR5Z9BEKA")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Name of the building or house.
    /// </summary>
    [IsoId("_AzwB8TngEeWSyLR5Z9BEKA")]
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BuildingName { get; init; } 
    
    /// <summary>
    /// Post box number of the addressee within the residential or company building.
    /// </summary>
    [IsoId("_FeMX0DngEeWSyLR5Z9BEKA")]
    [DisplayName("Post Box")]
    [IsoXmlTag("PstBx")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? PostBox { get; init; } 
    
    /// <summary>
    /// Side or wing of the building, for example, ‘wing A’.
    /// </summary>
    [IsoId("_HSPIUDngEeWSyLR5Z9BEKA")]
    [DisplayName("Side In Building")]
    [IsoXmlTag("SdInBldg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SideInBuilding { get; init; } 
    
    /// <summary>
    /// Floor or storey within the building.
    /// </summary>
    [IsoId("_LcrvgTngEeWSyLR5Z9BEKA")]
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Floor { get; init; } 
    
    /// <summary>
    /// Identification of the suite or apartment.
    /// </summary>
    [IsoId("_R48BQDngEeWSyLR5Z9BEKA")]
    [DisplayName("Suite Identification")]
    [IsoXmlTag("SuiteId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    public IsoMax10Text? SuiteIdentification { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_vkmOWznfEeWSyLR5Z9BEKA")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; } 
    
    /// <summary>
    /// Name of a district, that is, a part of the town or region.
    /// </summary>
    [IsoId("_vkmOXDnfEeWSyLR5Z9BEKA")]
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DistrictName { get; init; } 
    
    /// <summary>
    /// Name of the village.
    /// </summary>
    [IsoId("_S0S2QDngEeWSyLR5Z9BEKA")]
    [DisplayName("Village")]
    [IsoXmlTag("Vllg")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Village { get; init; } 
    
    /// <summary>
    /// Name of the town or city.
    /// </summary>
    [IsoId("_vkmOXTnfEeWSyLR5Z9BEKA")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; } 
    
    /// <summary>
    /// Name of the state, county or country sub-division.
    /// </summary>
    [IsoId("_calbEDngEeWSyLR5Z9BEKA")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? State { get; init; } 
    
    /// <summary>
    /// Country of the address.
    /// </summary>
    [IsoId("_vkmOXznfEeWSyLR5Z9BEKA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    
    #nullable disable
    
}
