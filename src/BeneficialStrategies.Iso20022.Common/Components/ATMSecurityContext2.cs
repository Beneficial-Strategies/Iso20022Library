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
/// Context of the ATM for the key download.
/// </summary>
[IsoId("__m9pwYtLEeSxlKlAGYErFg")]
[DisplayName("ATM Security Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityContext2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMSecurityContext2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMSecurityContext2( ATMSecurityScheme1Code reqCurrentSecurityScheme )
    {
        CurrentSecurityScheme = reqCurrentSecurityScheme;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Key exchange security scheme in activation on the ATM for the host manager.
    /// </summary>
    [IsoId("__y4l4YtLEeSxlKlAGYErFg")]
    [DisplayName("Current Security Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSctySchme")]
    #endif
    [IsoXmlTag("CurSctySchme")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMSecurityScheme1Code CurrentSecurityScheme { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMSecurityScheme1Code CurrentSecurityScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityScheme1Code CurrentSecurityScheme { get; init; } 
    #else
    public ATMSecurityScheme1Code CurrentSecurityScheme { get; set; } 
    #endif
    
    /// <summary>
    /// Hardware security module information, so called EPP for Encrypted PIN Pad.
    /// </summary>
    [IsoId("_rW7poItMEeSxlKlAGYErFg")]
    [DisplayName("Device Property")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcPrprty")]
    #endif
    [IsoXmlTag("DvcPrprty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMEquipment3? DeviceProperty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEquipment3? DeviceProperty { get; init; } 
    #else
    public ATMEquipment3? DeviceProperty { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters in use by the security device.
    /// </summary>
    [IsoId("_9vs7QItNEeSxlKlAGYErFg")]
    [DisplayName("Current Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurCfgtn")]
    #endif
    [IsoXmlTag("CurCfgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration1? CurrentConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration1? CurrentConfiguration { get; init; } 
    #else
    public ATMSecurityConfiguration1? CurrentConfiguration { get; set; } 
    #endif
    
    
    #nullable disable
    
}
