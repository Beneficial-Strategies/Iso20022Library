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
[IsoId("_9jkI4XDDEe2MCaKO5AtGsA")]
[DisplayName("Key Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record KeyTransport9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a KeyTransport9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public KeyTransport9( Recipient13Choice_ reqRecipientIdentification,AlgorithmIdentification19 reqKeyEncryptionAlgorithm,System.Byte[] reqEncryptedKey )
    {
        RecipientIdentification = reqRecipientIdentification;
        KeyEncryptionAlgorithm = reqKeyEncryptionAlgorithm;
        EncryptedKey = reqEncryptedKey;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_9qw9EXDDEe2MCaKO5AtGsA")]
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
    /// Identification of a cryptographic asymmetric key for the recipient.
    /// </summary>
    [IsoId("_9qw9E3DDEe2MCaKO5AtGsA")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Recipient13Choice_ RecipientIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Recipient13Choice_ RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Recipient13Choice_ RecipientIdentification { get; init; } 
    #else
    public Recipient13Choice_ RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_9qw9FXDDEe2MCaKO5AtGsA")]
    [DisplayName("Key Encryption Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcrptnAlgo")]
    #endif
    [IsoXmlTag("KeyNcrptnAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    #else
    public AlgorithmIdentification19 KeyEncryptionAlgorithm { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_9qyLMXDDEe2MCaKO5AtGsA")]
    [DisplayName("Encrypted Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NcrptdKey")]
    #endif
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax5000Binary EncryptedKey { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] EncryptedKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] EncryptedKey { get; init; } 
    #else
    public System.Byte[] EncryptedKey { get; set; } 
    #endif
    
    
    #nullable disable
    
}
