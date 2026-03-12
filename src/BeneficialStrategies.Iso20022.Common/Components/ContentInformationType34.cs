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
[IsoId("_smMyYXDPEe2MCaKO5AtGsA")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType34
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_suRwUXDPEe2MCaKO5AtGsA")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_suRwU3DPEe2MCaKO5AtGsA")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData10? EnvelopedData { get; init; } 
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_suRwVXDPEe2MCaKO5AtGsA")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData9? AuthenticatedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_suRwV3DPEe2MCaKO5AtGsA")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData8? SignedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_suRwWXDPEe2MCaKO5AtGsA")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData5? DigestedData { get; init; } 
    
    
    #nullable disable
    
}
