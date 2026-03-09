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
/// Configuration of the encryption or digital envelope, if the security module is able to perform encryption.
/// </summary>
[IsoId("_nKkasYr7EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityConfiguration3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// True if the security module is able to perform encryption with an asymmetric key.
    /// </summary>
    [IsoId("_3KR_sIr7EeSvuOJS0mmL0g")]
    [DisplayName("Asymmetric Encryption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsmmtrcNcrptn")]
    #endif
    [IsoXmlTag("AsmmtrcNcrptn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AsymmetricEncryption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AsymmetricEncryption { get; init; } 
    #else
    public System.String? AsymmetricEncryption { get; set; } 
    #endif
    
    /// <summary>
    /// True if the security module is able to identify an asymmetric key with certificate issuer X.500 name and certificate serial number. False if a proprietary asymmetric key identifier is required.
    /// </summary>
    [IsoId("_9exckIr7EeSvuOJS0mmL0g")]
    [DisplayName("Asymmetric Key Standard Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsmmtrcKeyStdId")]
    #endif
    [IsoXmlTag("AsmmtrcKeyStdId")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AsymmetricKeyStandardIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AsymmetricKeyStandardIdentification { get; init; } 
    #else
    public System.String? AsymmetricKeyStandardIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Asymmetric encryption algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_CXeQ4Ir8EeSvuOJS0mmL0g")]
    [DisplayName("Asymmetric Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsmmtrcNcrptnAlgo")]
    #endif
    [IsoXmlTag("AsmmtrcNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm7Code? AsymmetricEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm7Code? AsymmetricEncryptionAlgorithm { get; init; } 
    #else
    public Algorithm7Code? AsymmetricEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// True if the security module is able to manage a symmetric transport session key to protect cryptographic keys and data. False if only a previously exchanged symmetric key must be used; a proprietary symmetric key identifier is then used.
    /// </summary>
    [IsoId("_GbL98Ir8EeSvuOJS0mmL0g")]
    [DisplayName("Symmetric Transport Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SmmtrcTrnsprtKey")]
    #endif
    [IsoXmlTag("SmmtrcTrnsprtKey")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SymmetricTransportKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SymmetricTransportKey { get; init; } 
    #else
    public System.String? SymmetricTransportKey { get; set; } 
    #endif
    
    /// <summary>
    /// Symmetric transport session key algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_LToTkIr8EeSvuOJS0mmL0g")]
    [DisplayName("Symmetric Transport Key Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SmmtrcTrnsprtKeyAlgo")]
    #endif
    [IsoXmlTag("SmmtrcTrnsprtKeyAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm13Code? SymmetricTransportKeyAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm13Code? SymmetricTransportKeyAlgorithm { get; init; } 
    #else
    public Algorithm13Code? SymmetricTransportKeyAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Symmetric encryption algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_RIUPAIr8EeSvuOJS0mmL0g")]
    [DisplayName("Symmetric Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SmmtrcNcrptnAlgo")]
    #endif
    [IsoXmlTag("SmmtrcNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm15Code? SymmetricEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm15Code? SymmetricEncryptionAlgorithm { get; init; } 
    #else
    public Algorithm15Code? SymmetricEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_WZP9IIr8EeSvuOJS0mmL0g")]
    [DisplayName("Encryption Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptnFrmt")]
    #endif
    [IsoXmlTag("NcrptnFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    #else
    public EncryptionFormat1Code? EncryptionFormat { get; set; } 
    #endif
    
    
    #nullable disable
    
}
