// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the customer device.
/// </summary>
[IsoId("_zOiXAEamEeeIjf8aP9KbJA")]
[DisplayName("Device")]
public partial record Device1
{
    #nullable enable
    
    /// <summary>
    /// Type of customer device.
    /// </summary>
    [IsoId("_AdH4MEanEeeIjf8aP9KbJA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CustomerDeviceType1Code Type { get; init; } 
    
    /// <summary>
    /// Other type of customer device in free text.
    /// </summary>
    [IsoId("_GtylAEanEeeIjf8aP9KbJA")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Preferred language set on the device
    /// </summary>
    [IsoId("_w8sUkOCTEeeWtMJGJyksMA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Phone number associated with the device.
    /// </summary>
    [IsoId("_9rh-sOCTEeeWtMJGJyksMA")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    
    /// <summary>
    /// Geographical location of the device.
    /// </summary>
    [IsoId("_IcpX4OCUEeeWtMJGJyksMA")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public GeographicCoordinates1? Location { get; init; } 
    
    /// <summary>
    /// Internet Protocol address associated with the device.
    /// </summary>
    [IsoId("_qMsK8OCUEeeWtMJGJyksMA")]
    [DisplayName("IP Address")]
    [IsoXmlTag("IPAdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? IPAddress { get; init; } 
    
    /// <summary>
    /// Electronic mail address associated with the device.
    /// </summary>
    [IsoId("_IxWnIOCVEeeWtMJGJyksMA")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    
    #nullable disable
    
}
