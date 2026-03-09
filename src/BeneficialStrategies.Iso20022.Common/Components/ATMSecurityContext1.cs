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
/// Information related to security commands.
/// </summary>
[IsoId("_lCc_AIr4EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityContext1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMSecurityContext1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMSecurityContext1( ATMSecurityScheme1Code reqCurrentSecurityScheme,ATMSecurityDevice1 reqSecurityDevice )
    {
        CurrentSecurityScheme = reqCurrentSecurityScheme;
        SecurityDevice = reqSecurityDevice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Key exchange security scheme in activation on the ATM for the host manager.
    /// </summary>
    [IsoId("_dul6YIr5EeSvuOJS0mmL0g")]
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
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_ydPTsIr5EeSvuOJS0mmL0g")]
    [DisplayName("Security Scheme Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctySchmeCpblties")]
    #endif
    [IsoXmlTag("SctySchmeCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityScheme2Code? SecuritySchemeCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityScheme2Code? SecuritySchemeCapabilities { get; init; } 
    #else
    public ATMSecurityScheme2Code? SecuritySchemeCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Hardware security module of the ATM.
    /// </summary>
    [IsoId("_Ay-DIIr6EeSvuOJS0mmL0g")]
    [DisplayName("Security Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDvc")]
    #endif
    [IsoXmlTag("SctyDvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMSecurityDevice1 SecurityDevice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMSecurityDevice1 SecurityDevice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityDevice1 SecurityDevice { get; init; } 
    #else
    public ATMSecurityDevice1 SecurityDevice { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic keys stored in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_AYkRYItCEeSxlKlAGYErFg")]
    [DisplayName("Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Key")]
    #endif
    [IsoXmlTag("Key")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey7? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey7? Key { get; init; } 
    #else
    public CryptographicKey7? Key { get; set; } 
    #endif
    
    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_D54KEItEEeSxlKlAGYErFg")]
    [DisplayName("Host Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstChllng")]
    #endif
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? HostChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? HostChallenge { get; init; } 
    #else
    public System.Byte[]? HostChallenge { get; set; } 
    #endif
    
    
    #nullable disable
    
}
