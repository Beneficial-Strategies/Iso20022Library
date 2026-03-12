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
[IsoId("_lpCy4WpUEeSR-ZWLvO-1dg")]
[DisplayName("Network Parameters")]
public partial record NetworkParameters4
{
    #nullable enable
    
    /// <summary>
    /// Type of communication network.
    /// </summary>
    [IsoId("_9_FJoGpUEeSR-ZWLvO-1dg")]
    [DisplayName("Network Type")]
    [IsoXmlTag("NtwkTp")]
    public required NetworkType1Code NetworkType { get; init; } 
    
    /// <summary>
    /// Value of the address. The value of an internet protocol address contains the IP address or the DNS (Domain Name Server) address, followed by the character &apos;: &apos; and the port number if the default port is not used. The value of a public telephone address contains the phone number with possible prefix and extensions.
    /// </summary>
    [IsoId("_BalAIGpVEeSR-ZWLvO-1dg")]
    [DisplayName("Address Value")]
    [IsoXmlTag("AdrVal")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text AddressValue { get; init; } 
    
    
    #nullable disable
    
}
