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
/// Details of the customer device.
/// </summary>
[IsoId("_Uy_usYKvEeu4svNQ5N-l6w")]
[DisplayName("Customer Device")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerDevice4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information about the customer device.
    /// </summary>
    [IsoId("_U4M-0YKvEeu4svNQ5N-l6w")]
    [DisplayName("Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dvc")]
    #endif
    [IsoXmlTag("Dvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Device2? Device { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Device2? Device { get; init; } 
    #else
    public Device2? Device { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the device.
    /// </summary>
    [IsoId("_Rs2CsJfPEeuqNYk2TG3bTg")]
    [DisplayName("Device Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcId")]
    #endif
    [IsoXmlTag("DvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceIdentification1? DeviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceIdentification1? DeviceIdentification { get; init; } 
    #else
    public DeviceIdentification1? DeviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Device operating system information.
    /// </summary>
    [IsoId("_mZABUJfSEeuqNYk2TG3bTg")]
    [DisplayName("Operating System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprgSys")]
    #endif
    [IsoXmlTag("OprgSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceOperatingSystem1? OperatingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceOperatingSystem1? OperatingSystem { get; init; } 
    #else
    public DeviceOperatingSystem1? OperatingSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Provider of the customer device.
    /// </summary>
    [IsoId("_U4M-1YKvEeu4svNQ5N-l6w")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Provider { get; init; } 
    #else
    public System.String? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Additional customer device data.
    /// </summary>
    [IsoId("_w89vUJfSEeuqNYk2TG3bTg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
