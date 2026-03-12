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
[IsoId("_kmpXEe5NEeCisYr99QEiWA_-1757199613")]
[DisplayName("Postal Address")]
public partial record PostalAddress10
{
    #nullable enable
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_kmpXEu5NEeCisYr99QEiWA_646870815")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_kmpXE-5NEeCisYr99QEiWA_1586016919")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_kmpXFO5NEeCisYr99QEiWA_-1668916082")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text PostCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.|.
    /// </summary>
    [IsoId("_kmyhAO5NEeCisYr99QEiWA_1997034647")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TownName { get; init; } 
    
    /// <summary>
    /// Identifies a subdivision of a country such as the state, region or county.
    /// </summary>
    [IsoId("_kmyhAe5NEeCisYr99QEiWA_-1453787147")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; } 
    
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_kmyhAu5NEeCisYr99QEiWA_2048444232")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Starting date from which the address is valid.
    /// </summary>
    [IsoId("_kmyhA-5NEeCisYr99QEiWA_-567861040")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidFrom { get; init; } 
    
    
    #nullable disable
    
}
