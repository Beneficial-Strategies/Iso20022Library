// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the customer device.
/// </summary>
[IsoId("_HWMLUYKvEeu4svNQ5N-l6w")]
[DisplayName("Device")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Device2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Manufacturer of the device.
    /// </summary>
    [IsoId("_2JR5oJfGEeuBSOvOJYhcGw")]
    [DisplayName("Manufacturer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Manfctr")]
    #endif
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Manufacturer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Manufacturer { get; init; } 
    #else
    public System.String? Manufacturer { get; set; } 
    #endif
    
    /// <summary>
    /// Manufacturer&apos;s identification of the model.
    /// </summary>
    [IsoId("_GQ2aIJfHEeuBSOvOJYhcGw")]
    [DisplayName("Manufacturer Model Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ManfctrMdlId")]
    #endif
    [IsoXmlTag("ManfctrMdlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ManufacturerModelIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ManufacturerModelIdentification { get; init; } 
    #else
    public System.String? ManufacturerModelIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of customer device.
    /// </summary>
    [IsoId("_HcUogYKvEeu4svNQ5N-l6w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerDeviceType2Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerDeviceType2Code? Type { get; init; } 
    #else
    public CustomerDeviceType2Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of customer device in free text.
    /// </summary>
    [IsoId("_HcUog4KvEeu4svNQ5N-l6w")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Preferred language set on the device
    /// </summary>
    [IsoId("_HcUohYKvEeu4svNQ5N-l6w")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Language { get; init; } 
    #else
    public string? Language { get; set; } 
    #endif
    
    /// <summary>
    /// Phone number associated with the device.
    /// </summary>
    [IsoId("_HcUoh4KvEeu4svNQ5N-l6w")]
    [DisplayName("Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhneNb")]
    #endif
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhoneNumber { get; init; } 
    #else
    public System.String? PhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Geographical location of the device.
    /// </summary>
    [IsoId("_HcUoiYKvEeu4svNQ5N-l6w")]
    [DisplayName("Geographic Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GeogcLctn")]
    #endif
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GeographicLocation { get; init; } 
    #else
    public System.String? GeographicLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the location.
    /// </summary>
    [IsoId("_xfLaoJfJEeuqNYk2TG3bTg")]
    [DisplayName("Location Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnCtryCd")]
    #endif
    [IsoXmlTag("LctnCtryCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCountryCode? LocationCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LocationCountryCode { get; init; } 
    #else
    public string? LocationCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Internet Protocol address associated with the device.
    /// </summary>
    [IsoId("_HcUoi4KvEeu4svNQ5N-l6w")]
    [DisplayName("IP Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IPAdr")]
    #endif
    [IsoXmlTag("IPAdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? IPAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IPAddress { get; init; } 
    #else
    public System.String? IPAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic mail address associated with the device.
    /// </summary>
    [IsoId("_HcUojYKvEeu4svNQ5N-l6w")]
    [DisplayName("Email")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Email")]
    #endif
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Email { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Email { get; init; } 
    #else
    public System.String? Email { get; set; } 
    #endif
    
    /// <summary>
    /// Customer&apos;s name of the device.
    /// </summary>
    [IsoId("_AyfzsJfKEeuqNYk2TG3bTg")]
    [DisplayName("Device Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcNm")]
    #endif
    [IsoXmlTag("DvcNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? DeviceName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeviceName { get; init; } 
    #else
    public System.String? DeviceName { get; set; } 
    #endif
    
    /// <summary>
    /// Customer assigned device name, normalized.
    /// </summary>
    [IsoId("_158gUJfKEeuqNYk2TG3bTg")]
    [DisplayName("Device Name Normalized")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcNmNrmlzd")]
    #endif
    [IsoXmlTag("DvcNmNrmlzd")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? DeviceNameNormalized { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeviceNameNormalized { get; init; } 
    #else
    public System.String? DeviceNameNormalized { get; set; } 
    #endif
    
    
    #nullable disable
    
}
