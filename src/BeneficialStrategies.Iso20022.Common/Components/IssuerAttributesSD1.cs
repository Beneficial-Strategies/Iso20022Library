// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the issuer, as required by ASX.
/// </summary>
[IsoId("_uvhcJ299EeKuY41pq1-dog")]
[DisplayName("Issuer Attributes SD")]
public partial record IssuerAttributesSD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. ||In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_uvhcL299EeKuY41pq1-dog")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_uvhcRW99EeKuY41pq1-dog")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax140Text Name { get; init; } 
    
    /// <summary>
    /// Registered number type of the entity.
    /// </summary>
    [IsoId("_uvhcKm99EeKuY41pq1-dog")]
    [DisplayName("Registered Number Type")]
    [IsoXmlTag("RegdNbTp")]
    public RegisteredNumberType1Code? RegisteredNumberType { get; init; } 
    
    /// <summary>
    /// Other type of Registered Number.
    /// </summary>
    [IsoId("_uvhcPm99EeKuY41pq1-dog")]
    [DisplayName("Other Registered Number Type")]
    [IsoXmlTag("OthrRegdNbTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherRegisteredNumberType { get; init; } 
    
    /// <summary>
    /// Equivalent, unique number of the entity for the Registered Number Type.
    /// </summary>
    [IsoId("_uvhcOW99EeKuY41pq1-dog")]
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text RegistrationNumber { get; init; } 
    
    /// <summary>
    /// ASX Issuer Code.
    /// </summary>
    [IsoId("_uvhcNG99EeKuY41pq1-dog")]
    [DisplayName("Issuer Identification")]
    [IsoXmlTag("IssrId")]
    [IsoSimpleType(IsoSimpleType.Exact3UpperCaseAlphaNumericText)]
    public required IsoExact3UpperCaseAlphaNumericText IssuerIdentification { get; init; } 
    
    
    #nullable disable
    
}
