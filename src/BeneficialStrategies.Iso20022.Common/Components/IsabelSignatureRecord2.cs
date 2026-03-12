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
[IsoId("_l1lLp8_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel Signature Record")]
public partial record IsabelSignatureRecord2
{
    #nullable enable
    
    /// <summary>
    /// Type of the signature.
    /// </summary>
    [IsoId("_mDtuQc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public required SignatureOriginType1Code SignatureType { get; init; } 
    
    /// <summary>
    /// Serial number of the certificate.
    /// </summary>
    [IsoId("_mDtuQ8_aEeWjSMe6YTKHlQ")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max20AlphaNumericText)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    public required IsoMax20AlphaNumericText SerialNumber { get; init; } 
    
    /// <summary>
    /// Electronic document which uses a digital signature to bind together a public key with an identity.
    /// </summary>
    [IsoId("_mDtuRc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max4kBinary)]
    public required IsoMax4kBinary Certificate { get; init; } 
    
    /// <summary>
    /// Mathematical scheme for demonstrating the authenticity of a digital message or document.
    /// </summary>
    [IsoId("_mDtuR8_aEeWjSMe6YTKHlQ")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max1kBinary)]
    public required IsoMax1kBinary Signature { get; init; } 
    
    /// <summary>
    /// Effective method for calculating the signature using a finite sequence of instructions.
    /// </summary>
    [IsoId("_mDtuSc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text Algorithm { get; init; } 
    
    /// <summary>
    /// Unique identification of the signer that issued the signature.
    /// </summary>
    [IsoId("_mDtuS8_aEeWjSMe6YTKHlQ")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    [IsoSimpleType(IsoSimpleType.Max13AlphaNumericText)]
    [StringLength(maximumLength: 13 ,MinimumLength = 1)]
    public required IsoMax13AlphaNumericText SignerIdentification { get; init; } 
    
    /// <summary>
    /// Block of signature related data in case the LRCI protocol is used during the signature process of a set of payment files.
    /// </summary>
    [IsoId("_n35osM_aEeWjSMe6YTKHlQ")]
    [DisplayName("LRCI Extension")]
    [IsoXmlTag("LRCIXtnsn")]
    public IsabelLRCIExtension1? LRCIExtension { get; init; } 
    
    
    #nullable disable
    
}
