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
/// Key encryption key (KEK), encrypted with a previously distributed asymmetric public key.
/// </summary>
[IsoId("_vGGAUS9cEeOlZIh7PImd0A")]
[DisplayName("Key Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KeyTransport3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a KeyTransport3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public KeyTransport3( CertificateIdentifier1 reqRecipientIdentification,AlgorithmIdentification7 reqKeyEncryptionAlgorithm,System.Byte[] reqEncryptedKey )
    {
        RecipientIdentification = reqRecipientIdentification;
        KeyEncryptionAlgorithm = reqKeyEncryptionAlgorithm;
        EncryptedKey = reqEncryptedKey;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_vWnIkS9cEeOlZIh7PImd0A")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [IsoId("_vWnIky9cEeOlZIh7PImd0A")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificateIdentifier1 RecipientIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificateIdentifier1 RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateIdentifier1 RecipientIdentification { get; init; } 
    #else
    public CertificateIdentifier1 RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_vWnIlS9cEeOlZIh7PImd0A")]
    [DisplayName("Key Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcrptnAlgo")]
    #endif
    [IsoXmlTag("KeyNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification7 KeyEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_vWnIly9cEeOlZIh7PImd0A")]
    [DisplayName("Encrypted Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdKey")]
    #endif
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3000Binary EncryptedKey { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] EncryptedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] EncryptedKey { get; init; } 
    #else
    public System.Byte[] EncryptedKey { get; set; } 
    #endif
    
    
    #nullable disable
    
}
