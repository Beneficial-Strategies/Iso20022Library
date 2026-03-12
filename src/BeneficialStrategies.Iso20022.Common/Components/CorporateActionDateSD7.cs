// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action options date details.
/// </summary>
[IsoId("_SgmSUJEZEeajS_7NioJdVA")]
[DisplayName("Corporate Action Date SD")]
public partial record CorporateActionDateSD7
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_u-KQYZEfEeajS_7NioJdVA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Actual early expiration time as set by the issuer/offer/agent.
    /// </summary>
    [IsoId("_VZJagJEeEeajS_7NioJdVA")]
    [DisplayName("Actual Early Expiration Date")]
    [IsoXmlTag("ActlEarlyXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActualEarlyExpirationDate { get; init; } 
    
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_O0TKQJEaEeajS_7NioJdVA")]
    [DisplayName("Actual Protect Expiration Date")]
    [IsoXmlTag("ActlPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActualProtectExpirationDate { get; init; } 
    
    /// <summary>
    /// Last day protect instructions can be submitted to the issuer / agent for the early expiration.
    /// </summary>
    [IsoId("_dvld0JEaEeajS_7NioJdVA")]
    [DisplayName("Actual Early Protect Expiration Date")]
    [IsoXmlTag("ActlEarlyPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActualEarlyProtectExpirationDate { get; init; } 
    
    /// <summary>
    /// Last day protect instructions can be submitted to DTC for the early expiration.
    /// </summary>
    [IsoId("_qBkz4JEaEeajS_7NioJdVA")]
    [DisplayName("DTC Early Protect Expiration Date")]
    [IsoXmlTag("DTCEarlyPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DTCEarlyProtectExpirationDate { get; init; } 
    
    /// <summary>
    /// Last day cover early protect instructions can be submitted to the issuer / agent.
    /// </summary>
    [IsoId("_er8i8JEbEeajS_7NioJdVA")]
    [DisplayName("Actual Early Cover Protect Expiration Date")]
    [IsoXmlTag("ActlEarlyCoverPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActualEarlyCoverProtectExpirationDate { get; init; } 
    
    /// <summary>
    /// Last day cover early protect instructions can be submitted to DTC.
    /// </summary>
    [IsoId("_qt21oJEbEeajS_7NioJdVA")]
    [DisplayName("DTC Early Cover Protect Expiration Date")]
    [IsoXmlTag("DTCEarlyCoverPrtctXprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DTCEarlyCoverProtectExpirationDate { get; init; } 
    
    
    #nullable disable
    
}
