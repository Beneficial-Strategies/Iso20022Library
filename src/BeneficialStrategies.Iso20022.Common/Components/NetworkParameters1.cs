// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a host.
/// </summary>
[IsoId("_K86DOH1DEeCF8NjrBemJWQ_-1777383124")]
[DisplayName("Network Parameters")]
public partial record NetworkParameters1
{
    #nullable enable
    
    /// <summary>
    /// IP address or host name of the primary host.
    /// </summary>
    [IsoId("_K9D0MH1DEeCF8NjrBemJWQ_1112033591")]
    [DisplayName("Primary Address")]
    [IsoXmlTag("PmryAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PrimaryAddress { get; init; } 
    
    /// <summary>
    /// Port number of the primary host.
    /// </summary>
    [IsoId("_K9D0MX1DEeCF8NjrBemJWQ_1665134773")]
    [DisplayName("Primary Port Number")]
    [IsoXmlTag("PmryPortNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber PrimaryPortNumber { get; init; } 
    
    /// <summary>
    /// IP address or host name of the secondary host.
    /// </summary>
    [IsoId("_K9D0Mn1DEeCF8NjrBemJWQ_386383236")]
    [DisplayName("Secondary Address")]
    [IsoXmlTag("ScndryAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecondaryAddress { get; init; } 
    
    /// <summary>
    /// Port number of the secondary host.
    /// </summary>
    [IsoId("_K9D0M31DEeCF8NjrBemJWQ_-776733232")]
    [DisplayName("Secondary Port Number")]
    [IsoXmlTag("ScndryPortNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SecondaryPortNumber { get; init; } 
    
    /// <summary>
    /// User name identifying the client.
    /// </summary>
    [IsoId("_K9D0NH1DEeCF8NjrBemJWQ_434071500")]
    [DisplayName("User Name")]
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? UserName { get; init; } 
    
    /// <summary>
    /// Password authenticating the client.
    /// </summary>
    [IsoId("_K9D0NX1DEeCF8NjrBemJWQ_73749005")]
    [DisplayName("Access Code")]
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccessCode { get; init; } 
    
    /// <summary>
    /// Client certificate chain.
    /// </summary>
    [IsoId("_K9D0Nn1DEeCF8NjrBemJWQ_69300385")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ClientCertificate { get; init; } 
    
    
    #nullable disable
    
}
