// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Recipient7Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("__MbdwaRbEeeWXKXf3KjtmQ")]
    [DisplayName("Key Transport")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record KeyTransport : Recipient7Choice_
    #else
    public partial class KeyTransport : Recipient7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a KeyTransport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public KeyTransport( Recipient5Choice_ reqRecipientIdentification,AlgorithmIdentification27 reqKeyEncryptionAlgorithm,System.Byte[] reqEncryptedKey )
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
        [IsoId("_K1i9UaRZEeeWXKXf3KjtmQ")]
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
        [IsoId("_K1i9U6RZEeeWXKXf3KjtmQ")]
        [DisplayName("Recipient Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcptId")]
        #endif
        [IsoXmlTag("RcptId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Recipient5Choice_ RecipientIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Recipient5Choice_ RecipientIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Recipient5Choice_ RecipientIdentification { get; init; } 
        #else
        public Recipient5Choice_ RecipientIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_K1i9VaRZEeeWXKXf3KjtmQ")]
        [DisplayName("Key Encryption Algorithm")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="KeyNcrptnAlgo")]
        #endif
        [IsoXmlTag("KeyNcrptnAlgo")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AlgorithmIdentification27 KeyEncryptionAlgorithm { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AlgorithmIdentification27 KeyEncryptionAlgorithm { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AlgorithmIdentification27 KeyEncryptionAlgorithm { get; init; } 
        #else
        public AlgorithmIdentification27 KeyEncryptionAlgorithm { get; set; } 
        #endif
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_K1i9V6RZEeeWXKXf3KjtmQ")]
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
}
