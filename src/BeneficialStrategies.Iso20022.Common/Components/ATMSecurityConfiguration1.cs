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
/// Configuration parameters in use by the security device.
/// </summary>
[IsoId("_4FKwEIr6EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityConfiguration1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Configuration of the cryptographic keys.
    /// </summary>
    [IsoId("_LT8SEIr7EeSvuOJS0mmL0g")]
    [DisplayName("Keys")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Keys")]
    #endif
    [IsoXmlTag("Keys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration2? Keys { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration2? Keys { get; init; } 
    #else
    public ATMSecurityConfiguration2? Keys { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the encryption or digital envelope, if the security module is able to perform encryption.
    /// </summary>
    [IsoId("_vEEGgIr7EeSvuOJS0mmL0g")]
    [DisplayName("Encryption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ncrptn")]
    #endif
    [IsoXmlTag("Ncrptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration3? Encryption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration3? Encryption { get; init; } 
    #else
    public ATMSecurityConfiguration3? Encryption { get; set; } 
    #endif
    
    /// <summary>
    /// MAC (Message Authentication Code) algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_gRAscIr8EeSvuOJS0mmL0g")]
    [DisplayName("MAC Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MACAlgo")]
    #endif
    [IsoXmlTag("MACAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm12Code? MACAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm12Code? MACAlgorithm { get; init; } 
    #else
    public Algorithm12Code? MACAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Digest algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_kEKN8Ir8EeSvuOJS0mmL0g")]
    [DisplayName("Digest Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgstAlgo")]
    #endif
    [IsoXmlTag("DgstAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm11Code? DigestAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm11Code? DigestAlgorithm { get; init; } 
    #else
    public Algorithm11Code? DigestAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the digital signatures if the security module is able to perform digital signatures with an asymmetric key.
    /// </summary>
    [IsoId("_2MDAYIr8EeSvuOJS0mmL0g")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration4? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration4? DigitalSignature { get; init; } 
    #else
    public ATMSecurityConfiguration4? DigitalSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the PIN online verification.
    /// </summary>
    [IsoId("_fAcnAIr9EeSvuOJS0mmL0g")]
    [DisplayName("PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PIN")]
    #endif
    [IsoXmlTag("PIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration5? PIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration5? PIN { get; init; } 
    #else
    public ATMSecurityConfiguration5? PIN { get; set; } 
    #endif
    
    /// <summary>
    /// Mechanism used to protect the message of the ATM protocol.
    /// </summary>
    [IsoId("_KGeSAIr-EeSvuOJS0mmL0g")]
    [DisplayName("Message Protection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPrtcn")]
    #endif
    [IsoXmlTag("MsgPrtcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageProtection1Code? MessageProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageProtection1Code? MessageProtection { get; init; } 
    #else
    public MessageProtection1Code? MessageProtection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
