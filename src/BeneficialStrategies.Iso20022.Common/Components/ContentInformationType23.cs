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
[IsoId("_uLdwoQ0XEeqUVL7sB4m7NA")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType23
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_uWcRkQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_uWcRkw0XEeqUVL7sB4m7NA")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData7? EnvelopedData { get; init; } 
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_uWcRlQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData6? AuthenticatedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_uWcRlw0XEeqUVL7sB4m7NA")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData5? SignedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_uWcRmQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData5? DigestedData { get; init; } 
    
    
    #nullable disable
    
}
