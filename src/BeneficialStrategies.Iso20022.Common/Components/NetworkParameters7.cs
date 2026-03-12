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
[IsoId("_ghX0oQ0WEeqUVL7sB4m7NA")]
[DisplayName("Network Parameters")]
public partial record NetworkParameters7
{
    #nullable enable
    
    /// <summary>
    /// Network addresses of the host.
    /// </summary>
    [IsoId("_gsopcQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public ValueList<NetworkParameters9> Address { get; init; } = new ValueList<NetworkParameters9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _gsopcQ0WEeqUVL7sB4m7NA
    
    /// <summary>
    /// User name identifying the client.
    /// </summary>
    [IsoId("_gsopcw0WEeqUVL7sB4m7NA")]
    [DisplayName("User Name")]
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? UserName { get; init; } 
    
    /// <summary>
    /// Password authenticating the client.
    /// </summary>
    [IsoId("_gsopdQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Access Code")]
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AccessCode { get; init; } 
    
    /// <summary>
    /// X.509 Certificate required to authenticate the server.
    /// </summary>
    [IsoId("_gsopdw0WEeqUVL7sB4m7NA")]
    [DisplayName("Server Certificate")]
    [IsoXmlTag("SvrCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ServerCertificate { get; init; } 
    
    /// <summary>
    /// Identification of the X.509 Certificates required to authenticate the server, for instance a digest of the certificate.
    /// </summary>
    [IsoId("_gsopeQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Server Certificate Identifier")]
    [IsoXmlTag("SvrCertIdr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? ServerCertificateIdentifier { get; init; } 
    
    /// <summary>
    /// X.509 Certificate required to authenticate the client.
    /// </summary>
    [IsoId("_gspQgQ0WEeqUVL7sB4m7NA")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ClientCertificate { get; init; } 
    
    /// <summary>
    /// Identification of the set of security elements to access the host.
    /// </summary>
    [IsoId("_gspQgw0WEeqUVL7sB4m7NA")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; } 
    
    
    #nullable disable
    
}
