// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certification request PKCS#10 (Public Key Certificate Standard 10) for creation or renewal of an X.509 certificate.
/// </summary>
[IsoId("_ruEwkI4REeW6h7rGyYlyTg")]
[DisplayName("Certification Request")]
public partial record CertificationRequest1
{
    #nullable enable
    
    /// <summary>
    /// Information of the certificate to create.
    /// </summary>
    [IsoId("_VYZSkI4SEeW6h7rGyYlyTg")]
    [DisplayName("Certificate Request Information")]
    [IsoXmlTag("CertReqInf")]
    public required CertificationRequest2 CertificateRequestInformation { get; init; } 
    
    /// <summary>
    /// Identification of the key.
    /// </summary>
    [IsoId("_6_1qcI4REeW6h7rGyYlyTg")]
    [DisplayName("Key Identification")]
    [IsoXmlTag("KeyId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? KeyIdentification { get; init; } 
    
    /// <summary>
    /// Version of the key.
    /// </summary>
    [IsoId("_dWxMcI4UEeW6h7rGyYlyTg")]
    [DisplayName("Key Version")]
    [IsoXmlTag("KeyVrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? KeyVersion { get; init; } 
    
    
    #nullable disable
    
}
