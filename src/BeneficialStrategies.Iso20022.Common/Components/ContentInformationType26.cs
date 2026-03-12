// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing protected data.
/// </summary>
[IsoId("_CTLtQS8lEeu125Ip9zFcsQ")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType26
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_Cfx-0S8lEeu125Ip9zFcsQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_Cfx-0y8lEeu125Ip9zFcsQ")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData8? EnvelopedData { get; init; } 
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_Cfx-1S8lEeu125Ip9zFcsQ")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData7? AuthenticatedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_Cfx-1y8lEeu125Ip9zFcsQ")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData6? SignedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_Cfx-2S8lEeu125Ip9zFcsQ")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData5? DigestedData { get; init; } 
    
    
    #nullable disable
    
}
