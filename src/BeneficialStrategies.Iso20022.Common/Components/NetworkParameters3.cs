// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters to communicate with a host.
/// </summary>
[IsoId("_-UB7YWpTEeSR-ZWLvO-1dg")]
[DisplayName("Network Parameters")]
public partial record NetworkParameters3
{
    #nullable enable
    
    /// <summary>
    /// Network addresses of the host.
    /// </summary>
    [IsoId("_hbhpkGpUEeSR-ZWLvO-1dg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public ValueList<NetworkParameters4> Address { get; init; } = [];
    // ID for the above is _hbhpkGpUEeSR-ZWLvO-1dg
    
    /// <summary>
    /// User name identifying the client.
    /// </summary>
    [IsoId("_-gseaWpTEeSR-ZWLvO-1dg")]
    [DisplayName("User Name")]
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? UserName { get; init; } 
    
    /// <summary>
    /// Password authenticating the client.
    /// </summary>
    [IsoId("_-gsea2pTEeSR-ZWLvO-1dg")]
    [DisplayName("Access Code")]
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AccessCode { get; init; } 
    
    /// <summary>
    /// X.509 Certificate required to authenticate the server.
    /// </summary>
    [IsoId("_H9hTQGpWEeSR-ZWLvO-1dg")]
    [DisplayName("Server Certificate")]
    [IsoXmlTag("SvrCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ServerCertificate { get; init; } 
    
    /// <summary>
    /// Identification of the X.509 Certificate required to authenticate the server, for instance a digest of the certificate.
    /// </summary>
    [IsoId("_PZZO8GpWEeSR-ZWLvO-1dg")]
    [DisplayName("Server Certificate Identifier")]
    [IsoXmlTag("SvrCertIdr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ServerCertificateIdentifier { get; init; } 
    
    
    #nullable disable
    
}
