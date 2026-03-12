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
[IsoId("_gkSEMQuhEeqw5uEXxQ9H4g")]
[DisplayName("Content Information Type")]
public partial record ContentInformationType21
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_gvWEsQuhEeqw5uEXxQ9H4g")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_gvWEswuhEeqw5uEXxQ9H4g")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData6? AuthenticatedData { get; init; } 
    
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_gvWEtQuhEeqw5uEXxQ9H4g")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData5? SignedData { get; init; } 
    
    
    #nullable disable
    
}
