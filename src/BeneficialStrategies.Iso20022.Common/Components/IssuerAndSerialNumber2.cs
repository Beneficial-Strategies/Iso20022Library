// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate issuer name and serial number (see X.509).
/// </summary>
[IsoId("_-vM7ES8iEeu125Ip9zFcsQ")]
[DisplayName("Issuer And Serial Number")]
public partial record IssuerAndSerialNumber2
{
    #nullable enable
    
    /// <summary>
    /// Certificate issuer name (see X.509).
    /// </summary>
    [IsoId("_-8B2IS8iEeu125Ip9zFcsQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required CertificateIssuer1 Issuer { get; init; } 
    
    /// <summary>
    /// Certificate serial number (see X.509).
    /// </summary>
    [IsoId("_-8B2Iy8iEeu125Ip9zFcsQ")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public required IsoMax500Binary SerialNumber { get; init; } 
    
    
    #nullable disable
    
}
