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
/// Specifies the individual record of the file signature.
/// </summary>
[IsoId("_fhqo8KA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Signature Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelSignatureRecord1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelSignatureRecord1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelSignatureRecord1( SignatureOriginType1Code reqSignatureType,System.String reqSerialNumber,System.Byte[] reqCertificate,System.Byte[] reqSignature,System.String reqAlgorithm,System.String reqSignerIdentification )
    {
        SignatureType = reqSignatureType;
        SerialNumber = reqSerialNumber;
        Certificate = reqCertificate;
        Signature = reqSignature;
        Algorithm = reqAlgorithm;
        SignerIdentification = reqSignerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the signature.
    /// </summary>
    [IsoId("_Uvx6EsnAEeWI4cSIO9foRA")]
    [DisplayName("Signature Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrTp")]
    #endif
    [IsoXmlTag("SgntrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignatureOriginType1Code SignatureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SignatureOriginType1Code SignatureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignatureOriginType1Code SignatureType { get; init; } 
    #else
    public SignatureOriginType1Code SignatureType { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number of the certificate.
    /// </summary>
    [IsoId("_ut-UQKMaEeWZDvWHgGXs7Q")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max20AlphaNumericText)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20AlphaNumericText SerialNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SerialNumber { get; init; } 
    #else
    public System.String SerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic document which uses a digital signature to bind together a public key with an identity.
    /// </summary>
    [IsoId("_OG7hUMnBEeWI4cSIO9foRA")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max4kBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4kBinary Certificate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Certificate { get; init; } 
    #else
    public System.Byte[] Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Mathematical scheme for demonstrating the authenticity of a digital message or document.
    /// </summary>
    [IsoId("_WHuH8MnBEeWI4cSIO9foRA")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max1kBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax1kBinary Signature { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] Signature { get; init; } 
    #else
    public System.Byte[] Signature { get; set; } 
    #endif
    
    /// <summary>
    /// Effective method for calculating the signature using a finite sequence of instructions.
    /// </summary>
    [IsoId("_pPYVUMnBEeWI4cSIO9foRA")]
    [DisplayName("Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Algo")]
    #endif
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax105Text Algorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Algorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Algorithm { get; init; } 
    #else
    public System.String Algorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the signer that issued the signature.
    /// </summary>
    [IsoId("_tcEYMMnBEeWI4cSIO9foRA")]
    [DisplayName("Signer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgnrId")]
    #endif
    [IsoXmlTag("SgnrId")]
    [IsoSimpleType(IsoSimpleType.Max13AlphaNumericText)]
    [StringLength(maximumLength: 13 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax13AlphaNumericText SignerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SignerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SignerIdentification { get; init; } 
    #else
    public System.String SignerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
