// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured postal address.
/// </summary>
[IsoId("_OBCckEB6Eeepk8PtnyIgsg")]
[DisplayName("Address")]
public partial record Address1
{
    #nullable enable
    
    /// <summary>
    /// First line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_fzOr0EB6Eeepk8PtnyIgsg")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine1")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AddressLine1 { get; init; } 
    
    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_O71_gRqXEeqH1IQNpbVpEw")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine2")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AddressLine2 { get; init; } 
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_mpO6UEB6Eeepk8PtnyIgsg")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_usxS8EB6Eeepk8PtnyIgsg")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_7SSpAEB6Eeepk8PtnyIgsg")]
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? PostalCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_FJpIoEB7Eeepk8PtnyIgsg")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; } 
    
    /// <summary>
    /// Identifies a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_QsL-wEB7Eeepk8PtnyIgsg")]
    [DisplayName("Country Sub Division Minor")]
    [IsoXmlTag("CtrySubDvsnMnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivisionMinor { get; init; } 
    
    /// <summary>
    /// Identifies a major subdivision of a country, for instance state, province.
    /// </summary>
    [IsoId("_Y0FFYRqWEeqH1IQNpbVpEw")]
    [DisplayName("Country Sub Division Major")]
    [IsoXmlTag("CtrySubDvsnMjr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivisionMajor { get; init; } 
    
    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// </summary>
    [IsoId("_b4h7YEB7Eeepk8PtnyIgsg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; } 
    
    
    #nullable disable
    
}
