// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Recipient4Choice
{
    /// <summary>
    /// Key encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_N1aSo2i0EeS87LmvcA55sg")]
    [DisplayName("KEK")]
    public partial record KEK : Recipient4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_Hs9e8Wi6EeS87LmvcA55sg")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; } 
        
        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_Hs9e82i6EeS87LmvcA55sg")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier2 KEKIdentification { get; init; } 
        
        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_Hs9e9Wi6EeS87LmvcA55sg")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification13 KeyEncryptionAlgorithm { get; init; } 
        
        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_Hs9e92i6EeS87LmvcA55sg")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public required IsoMax500Binary EncryptedKey { get; init; } 
        
        
        #nullable disable
        
    }
}
