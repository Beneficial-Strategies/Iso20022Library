// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key encryption key (KEK), encrypted with a previously distributed asymmetric public key.
/// </summary>
[IsoId("_vGGAUS9cEeOlZIh7PImd0A")]
[DisplayName("Key Transport")]
public partial record KeyTransport3
{
    #nullable enable
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_vWnIkS9cEeOlZIh7PImd0A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [IsoId("_vWnIky9cEeOlZIh7PImd0A")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public required CertificateIdentifier1 RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_vWnIlS9cEeOlZIh7PImd0A")]
    [DisplayName("Key Encryption Algorithm")]
    [IsoXmlTag("KeyNcrptnAlgo")]
    public required AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; } 
    
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_vWnIly9cEeOlZIh7PImd0A")]
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public required IsoMax3000Binary EncryptedKey { get; init; } 
    
    
    #nullable disable
    
}
