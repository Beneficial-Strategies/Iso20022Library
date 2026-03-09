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
/// Hardware security module information, so called EPP for Encrypted PIN Pad.
/// </summary>
[IsoId("_jisRQYtMEeSxlKlAGYErFg")]
[DisplayName("ATM Equipment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMEquipment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// ATM Manufacturer.
    /// </summary>
    [IsoId("_jvD5UYtMEeSxlKlAGYErFg")]
    [DisplayName("Manufacturer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Manfctr")]
    #endif
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Manufacturer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Manufacturer { get; init; } 
    #else
    public System.String? Manufacturer { get; set; } 
    #endif
    
    /// <summary>
    /// Model of ATM.
    /// </summary>
    [IsoId("_jvD5U4tMEeSxlKlAGYErFg")]
    [DisplayName("Model")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdl")]
    #endif
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Model { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Model { get; init; } 
    #else
    public System.String? Model { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the device model.
    /// </summary>
    [IsoId("_jvD5VYtMEeSxlKlAGYErFg")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number of the ATM.
    /// </summary>
    [IsoId("_jvD5V4tMEeSxlKlAGYErFg")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerialNumber { get; init; } 
    #else
    public System.String? SerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Signature of the serial number of the device. The signature may contain the serial number with the signature.
    /// </summary>
    [IsoId("_XcPAUItNEeSxlKlAGYErFg")]
    [DisplayName("Signed Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgndSrlNb")]
    #endif
    [IsoXmlTag("SgndSrlNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType14? SignedSerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType14? SignedSerialNumber { get; init; } 
    #else
    public ContentInformationType14? SignedSerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Provider of the firmware.
    /// </summary>
    [IsoId("_jvD5WYtMEeSxlKlAGYErFg")]
    [DisplayName("Firmware Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmwrPrvdr")]
    #endif
    [IsoXmlTag("FrmwrPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FirmwareProvider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FirmwareProvider { get; init; } 
    #else
    public System.String? FirmwareProvider { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the firmware.
    /// </summary>
    [IsoId("_jvD5XYtMEeSxlKlAGYErFg")]
    [DisplayName("Firmware Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmwrId")]
    #endif
    [IsoXmlTag("FrmwrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FirmwareIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FirmwareIdentification { get; init; } 
    #else
    public System.String? FirmwareIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the firmware.
    /// </summary>
    [IsoId("_jvD5X4tMEeSxlKlAGYErFg")]
    [DisplayName("Firmware Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmwrVrsn")]
    #endif
    [IsoXmlTag("FrmwrVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FirmwareVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FirmwareVersion { get; init; } 
    #else
    public System.String? FirmwareVersion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
