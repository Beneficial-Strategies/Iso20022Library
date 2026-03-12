// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing data. protected by a MAC or a digital signature.
/// </summary>
[IsoId("_kWoPYS8jEeu125Ip9zFcsQ")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType25
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_kjb8US8jEeu125Ip9zFcsQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_kjb8Uy8jEeu125Ip9zFcsQ")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData7? AuthenticatedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_kjb8VS8jEeu125Ip9zFcsQ")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData6? SignedData { get; init; } 
    
    
    #nullable disable
    
}
