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
[IsoId("_HWMLUYKvEeu4svNQ5N-l6w")]
[DisplayName("Device")]
public partial record Device2
{
    #nullable enable
    
    /// <summary>
    /// Manufacturer of the device.
    /// </summary>
    [IsoId("_2JR5oJfGEeuBSOvOJYhcGw")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Manufacturer { get; init; } 
    
    /// <summary>
    /// Manufacturer&apos;s identification of the model.
    /// </summary>
    [IsoId("_GQ2aIJfHEeuBSOvOJYhcGw")]
    [DisplayName("Manufacturer Model Identification")]
    [IsoXmlTag("ManfctrMdlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ManufacturerModelIdentification { get; init; } 
    
    /// <summary>
    /// Type of customer device.
    /// </summary>
    [IsoId("_HcUogYKvEeu4svNQ5N-l6w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CustomerDeviceType2Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of customer device in free text.
    /// </summary>
    [IsoId("_HcUog4KvEeu4svNQ5N-l6w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Preferred language set on the device
    /// </summary>
    [IsoId("_HcUohYKvEeu4svNQ5N-l6w")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Phone number associated with the device.
    /// </summary>
    [IsoId("_HcUoh4KvEeu4svNQ5N-l6w")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    
    /// <summary>
    /// Geographical location of the device.
    /// </summary>
    [IsoId("_HcUoiYKvEeu4svNQ5N-l6w")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; } 
    
    /// <summary>
    /// Country of the location.
    /// </summary>
    [IsoId("_xfLaoJfJEeuqNYk2TG3bTg")]
    [DisplayName("Location Country Code")]
    [IsoXmlTag("LctnCtryCd")]
    public ISO3NumericCountryCode? LocationCountryCode { get; init; } 
    
    /// <summary>
    /// Internet Protocol address associated with the device.
    /// </summary>
    [IsoId("_HcUoi4KvEeu4svNQ5N-l6w")]
    [DisplayName("IP Address")]
    [IsoXmlTag("IPAdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? IPAddress { get; init; } 
    
    /// <summary>
    /// Electronic mail address associated with the device.
    /// </summary>
    [IsoId("_HcUojYKvEeu4svNQ5N-l6w")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    /// <summary>
    /// Customer&apos;s name of the device.
    /// </summary>
    [IsoId("_AyfzsJfKEeuqNYk2TG3bTg")]
    [DisplayName("Device Name")]
    [IsoXmlTag("DvcNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? DeviceName { get; init; } 
    
    /// <summary>
    /// Customer assigned device name, normalized.
    /// </summary>
    [IsoId("_158gUJfKEeuqNYk2TG3bTg")]
    [DisplayName("Device Name Normalized")]
    [IsoXmlTag("DvcNmNrmlzd")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? DeviceNameNormalized { get; init; } 
    
    
    #nullable disable
    
}
