// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration of the encryption or digital envelope, if the security module is able to perform encryption.
/// </summary>
[IsoId("_nKkasYr7EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
public partial record ATMSecurityConfiguration3
{
    #nullable enable
    
    /// <summary>
    /// True if the security module is able to perform encryption with an asymmetric key.
    /// </summary>
    [IsoId("_3KR_sIr7EeSvuOJS0mmL0g")]
    [DisplayName("Asymmetric Encryption")]
    [IsoXmlTag("AsmmtrcNcrptn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AsymmetricEncryption { get; init; } 
    
    /// <summary>
    /// True if the security module is able to identify an asymmetric key with certificate issuer X.500 name and certificate serial number. False if a proprietary asymmetric key identifier is required.
    /// </summary>
    [IsoId("_9exckIr7EeSvuOJS0mmL0g")]
    [DisplayName("Asymmetric Key Standard Identification")]
    [IsoXmlTag("AsmmtrcKeyStdId")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AsymmetricKeyStandardIdentification { get; init; } 
    
    /// <summary>
    /// Asymmetric encryption algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_CXeQ4Ir8EeSvuOJS0mmL0g")]
    [DisplayName("Asymmetric Encryption Algorithm")]
    [IsoXmlTag("AsmmtrcNcrptnAlgo")]
    public Algorithm7Code? AsymmetricEncryptionAlgorithm { get; init; } 
    
    /// <summary>
    /// True if the security module is able to manage a symmetric transport session key to protect cryptographic keys and data. False if only a previously exchanged symmetric key must be used; a proprietary symmetric key identifier is then used.
    /// </summary>
    [IsoId("_GbL98Ir8EeSvuOJS0mmL0g")]
    [DisplayName("Symmetric Transport Key")]
    [IsoXmlTag("SmmtrcTrnsprtKey")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SymmetricTransportKey { get; init; } 
    
    /// <summary>
    /// Symmetric transport session key algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_LToTkIr8EeSvuOJS0mmL0g")]
    [DisplayName("Symmetric Transport Key Algorithm")]
    [IsoXmlTag("SmmtrcTrnsprtKeyAlgo")]
    public Algorithm13Code? SymmetricTransportKeyAlgorithm { get; init; } 
    
    /// <summary>
    /// Symmetric encryption algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_RIUPAIr8EeSvuOJS0mmL0g")]
    [DisplayName("Symmetric Encryption Algorithm")]
    [IsoXmlTag("SmmtrcNcrptnAlgo")]
    public Algorithm15Code? SymmetricEncryptionAlgorithm { get; init; } 
    
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_WZP9IIr8EeSvuOJS0mmL0g")]
    [DisplayName("Encryption Format")]
    [IsoXmlTag("NcrptnFrmt")]
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    
    
    #nullable disable
    
}
