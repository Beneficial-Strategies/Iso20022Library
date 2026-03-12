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
[IsoId("_PwIbYWmPEeS7iYydEtv3Ug")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType12
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_P9PDQWmPEeS7iYydEtv3Ug")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_P9PDQ2mPEeS7iYydEtv3Ug")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData4? EnvelopedData { get; init; } 
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_P9PDRWmPEeS7iYydEtv3Ug")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData4? AuthenticatedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_P9PDR2mPEeS7iYydEtv3Ug")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData4? SignedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_P9PDSWmPEeS7iYydEtv3Ug")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData4? DigestedData { get; init; } 
    
    
    #nullable disable
    
}
