// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient2Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("_E8e4BQioEeKn9O5oyej_zw")]
    [DisplayName("Key Transport")]
    public partial record KeyTransport : Recipient2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_NevTEQvAEeK6BpGAixa3eA")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Version { get; init; } 
        
        /// <summary>
        /// Transport key or key encryption key (KEK) for the recipient.
        /// </summary>
        [IsoId("_NevTFQvAEeK6BpGAixa3eA")]
        [DisplayName("Recipient Identification")]
        [IsoXmlTag("RcptId")]
        public required CertificateIdentifier1 RecipientIdentification { get; init; } 
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_NevTGQvAEeK6BpGAixa3eA")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; } 
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_NevTHQvAEeK6BpGAixa3eA")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public required IsoMax140Binary EncryptedKey { get; init; } 
        
        
        #nullable disable
        
    }
}
