// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the individual record of the file signature.
/// </summary>
[IsoId("_fhqo8KA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Signature Record")]
public partial record IsabelSignatureRecord1
{
    #nullable enable
    
    /// <summary>
    /// Type of the signature.
    /// </summary>
    [IsoId("_Uvx6EsnAEeWI4cSIO9foRA")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public required SignatureOriginType1Code SignatureType { get; init; } 
    
    /// <summary>
    /// Serial number of the certificate.
    /// </summary>
    [IsoId("_ut-UQKMaEeWZDvWHgGXs7Q")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max20AlphaNumericText)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    public required IsoMax20AlphaNumericText SerialNumber { get; init; } 
    
    /// <summary>
    /// Electronic document which uses a digital signature to bind together a public key with an identity.
    /// </summary>
    [IsoId("_OG7hUMnBEeWI4cSIO9foRA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max4kBinary)]
    public required IsoMax4kBinary Certificate { get; init; } 
    
    /// <summary>
    /// Mathematical scheme for demonstrating the authenticity of a digital message or document.
    /// </summary>
    [IsoId("_WHuH8MnBEeWI4cSIO9foRA")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max1kBinary)]
    public required IsoMax1kBinary Signature { get; init; } 
    
    /// <summary>
    /// Effective method for calculating the signature using a finite sequence of instructions.
    /// </summary>
    [IsoId("_pPYVUMnBEeWI4cSIO9foRA")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text Algorithm { get; init; } 
    
    /// <summary>
    /// Unique identification of the signer that issued the signature.
    /// </summary>
    [IsoId("_tcEYMMnBEeWI4cSIO9foRA")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    [IsoSimpleType(IsoSimpleType.Max13AlphaNumericText)]
    [StringLength(maximumLength: 13 ,MinimumLength = 1)]
    public required IsoMax13AlphaNumericText SignerIdentification { get; init; } 
    
    
    #nullable disable
    
}
