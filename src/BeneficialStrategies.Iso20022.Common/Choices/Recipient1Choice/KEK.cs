// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient1Choice
{
    /// <summary>
    /// Encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_SxR5oAEcEeCQm6a_G2yO_w_-535669566")]
    [DisplayName("KEK")]
    public partial record KEK : Recipient1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_Sw--sQEcEeCQm6a_G2yO_w_618110987")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; } 
        
        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_Sw--sgEcEeCQm6a_G2yO_w_2081604118")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier1 KEKIdentification { get; init; } 
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_Sw--swEcEeCQm6a_G2yO_w_-799126556")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification1 KeyEncryptionAlgorithm { get; init; } 
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_Sw--tAEcEeCQm6a_G2yO_w_-1299735264")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public required IsoMax140Binary EncryptedKey { get; init; } 
        
        
        #nullable disable
        
    }
}
