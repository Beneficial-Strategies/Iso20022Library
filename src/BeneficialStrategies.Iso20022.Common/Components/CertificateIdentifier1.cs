// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transport key or key encryption key (KEK) identification for the recipient.
/// </summary>
[IsoId("_SxIvtAEcEeCQm6a_G2yO_w_1837772326")]
[DisplayName("Certificate Identifier")]
public partial record CertificateIdentifier1
{
    #nullable enable
    
    /// <summary>
    /// Certificate issuer name and serial number (see X.509).
    /// </summary>
    [IsoId("_SxIvtQEcEeCQm6a_G2yO_w_942906832")]
    [DisplayName("Issuer And Serial Number")]
    [IsoXmlTag("IssrAndSrlNb")]
    public required IssuerAndSerialNumber1 IssuerAndSerialNumber { get; init; } 
    
    
    #nullable disable
    
}
