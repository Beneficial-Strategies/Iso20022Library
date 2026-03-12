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
[IsoId("_pt6_8Y0PEeWRYffwL7E13A")]
[DisplayName("Network Parameters")]
public partial record NetworkParameters5
{
    #nullable enable
    
    /// <summary>
    /// Network addresses of the host.
    /// </summary>
    [IsoId("_p5GVMY0PEeWRYffwL7E13A")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public ValueList<NetworkParameters4> Address { get; init; } = new ValueList<NetworkParameters4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _p5GVMY0PEeWRYffwL7E13A
    
    /// <summary>
    /// User name identifying the client.
    /// </summary>
    [IsoId("_p5GVM40PEeWRYffwL7E13A")]
    [DisplayName("User Name")]
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? UserName { get; init; } 
    
    /// <summary>
    /// Password authenticating the client.
    /// </summary>
    [IsoId("_p5GVNY0PEeWRYffwL7E13A")]
    [DisplayName("Access Code")]
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AccessCode { get; init; } 
    
    /// <summary>
    /// X.509 Certificate required to authenticate the server.
    /// </summary>
    [IsoId("_p5GVN40PEeWRYffwL7E13A")]
    [DisplayName("Server Certificate")]
    [IsoXmlTag("SvrCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ServerCertificate { get; init; } 
    
    /// <summary>
    /// Identification of the X.509 Certificates required to authenticate the server, for instance a digest of the certificate.
    /// </summary>
    [IsoId("_p5GVOY0PEeWRYffwL7E13A")]
    [DisplayName("Server Certificate Identifier")]
    [IsoXmlTag("SvrCertIdr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ServerCertificateIdentifier { get; init; } 
    
    /// <summary>
    /// X.509 Certificate required to authenticate the client.
    /// </summary>
    [IsoId("_-lXv8I0PEeWRYffwL7E13A")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ClientCertificate { get; init; } 
    
    /// <summary>
    /// Identification of the set of security elements to access the host.
    /// </summary>
    [IsoId("_GXoLUI0QEeWRYffwL7E13A")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; } 
    
    
    #nullable disable
    
}
