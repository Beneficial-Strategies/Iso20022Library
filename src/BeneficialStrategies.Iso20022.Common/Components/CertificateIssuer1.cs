// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate issuer name (see X.509).
/// </summary>
[IsoId("_Sw--vQEcEeCQm6a_G2yO_w_152932975")]
[DisplayName("Certificate Issuer")]
public partial record CertificateIssuer1
{
    #nullable enable
    
    /// <summary>
    /// Relative distinguished name inside a X.509 certificate.
    /// </summary>
    [IsoId("_SxIvsAEcEeCQm6a_G2yO_w_1329577257")]
    [DisplayName("Relative Distinguished Name")]
    [IsoXmlTag("RltvDstngshdNm")]
    public ValueList<RelativeDistinguishedName1> RelativeDistinguishedName { get; init; } = [];
    // ID for the above is _SxIvsAEcEeCQm6a_G2yO_w_1329577257
    
    
    #nullable disable
    
}
