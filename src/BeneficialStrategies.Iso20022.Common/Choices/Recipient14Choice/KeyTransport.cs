// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient14Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("_4SHA4XDEEe2MCaKO5AtGsA")]
    [DisplayName("Key Transport")]
    public partial record KeyTransport : Recipient14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_9qw9EXDDEe2MCaKO5AtGsA")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; } 
        
        /// <summary>
        /// Identification of a cryptographic asymmetric key for the recipient.
        /// </summary>
        [IsoId("_9qw9E3DDEe2MCaKO5AtGsA")]
        [DisplayName("Recipient Identification")]
        [IsoXmlTag("RcptId")]
        public required Recipient13Choice_ RecipientIdentification { get; init; } 
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_9qw9FXDDEe2MCaKO5AtGsA")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_9qyLMXDDEe2MCaKO5AtGsA")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        public required IsoMax5000Binary EncryptedKey { get; init; } 
        
        
        #nullable disable
        
    }
}
