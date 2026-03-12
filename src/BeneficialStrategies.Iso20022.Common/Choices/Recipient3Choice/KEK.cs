// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient3Choice
{
    /// <summary>
    /// Encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_lPQMIy9eEeOlZIh7PImd0A")]
    [DisplayName("KEK")]
    public partial record KEK : Recipient3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_Th7gsS9cEeOlZIh7PImd0A")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; } 
        
        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_Th7gsy9cEeOlZIh7PImd0A")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier1 KEKIdentification { get; init; } 
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_Th7gtS9cEeOlZIh7PImd0A")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification9 KeyEncryptionAlgorithm { get; init; } 
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_Th7gty9cEeOlZIh7PImd0A")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public required IsoMax140Binary EncryptedKey { get; init; } 
        
        
        #nullable disable
        
    }
}
