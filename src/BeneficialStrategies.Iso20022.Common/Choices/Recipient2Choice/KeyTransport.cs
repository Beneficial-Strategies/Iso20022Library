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
namespace BeneficialStrategies.Iso20022.Choices.Recipient2Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("_E8e4BQioEeKn9O5oyej_zw")]
    [DisplayName("Key Transport")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record KeyTransport : Recipient2Choice_
    #else
    public partial class KeyTransport : Recipient2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a KeyTransport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public KeyTransport( System.UInt64 reqVersion,CertificateIdentifier1 reqRecipientIdentification,AlgorithmIdentification7 reqKeyEncryptionAlgorithm,System.Byte[] reqEncryptedKey )
        {
            Version = reqVersion;
            RecipientIdentification = reqRecipientIdentification;
            KeyEncryptionAlgorithm = reqKeyEncryptionAlgorithm;
            EncryptedKey = reqEncryptedKey;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_NevTEQvAEeK6BpGAixa3eA")]
        [DisplayName("Version")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Vrsn")]
        #endif
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNumber Version { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Version { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Version { get; init; } 
        #else
        public System.UInt64 Version { get; set; } 
        #endif
        
        /// <summary>
        /// Transport key or key encryption key (KEK) for the recipient.
        /// </summary>
        [IsoId("_NevTFQvAEeK6BpGAixa3eA")]
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
        [IsoId("_NevTGQvAEeK6BpGAixa3eA")]
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
        [IsoId("_NevTHQvAEeK6BpGAixa3eA")]
        [DisplayName("Encrypted Key")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NcrptdKey")]
        #endif
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Binary EncryptedKey { get; init; } 
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
