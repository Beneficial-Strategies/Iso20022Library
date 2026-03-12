// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.KeyChoiceValue2
{
    /// <summary>
    /// Encrypted value of the cryptographic key.
    /// </summary>
    [IsoId("_FjgS0bTqEeeQy4o2AayYHg")]
    [DisplayName("Encrypted Key Value")]
    public partial record EncryptedKeyValue : KeyChoiceValue2_
    {
        #nullable enable
        
        /// <summary>
        /// Type of data protection.
        /// </summary>
        [IsoId("_Us-c0WizEeS87LmvcA55sg")]
        [DisplayName("Content Type")]
        [IsoXmlTag("CnttTp")]
        public required ContentType2Code ContentType { get; init; } 
        
        /// <summary>
        /// Data protection by encryption or by a digital envelope, with an encryption key.
        /// </summary>
        [IsoId("_Us-c02izEeS87LmvcA55sg")]
        [DisplayName("Enveloped Data")]
        [IsoXmlTag("EnvlpdData")]
        public required EnvelopedData4 EnvelopedData { get; init; } 
        
        
        #nullable disable
        
    }
}
