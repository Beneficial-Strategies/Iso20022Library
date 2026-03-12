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
[IsoId("_xeuz0UeTEeODR7vDcYOqmg")]
[DisplayName("Network Parameters")]
public partial record NetworkParameters2
{
    #nullable enable
    
    /// <summary>
    /// IP address or hostname.
    /// </summary>
    [IsoId("_qiiBQEeUEeODR7vDcYOqmg")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Address { get; init; } 
    
    /// <summary>
    /// Port number of the server, if the default port number is not used.
    /// </summary>
    [IsoId("_c3emgEeUEeODR7vDcYOqmg")]
    [DisplayName("Port Number")]
    [IsoXmlTag("PortNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PortNumber { get; init; } 
    
    /// <summary>
    /// Delay between two contacts of the server.
    /// </summary>
    [IsoId("_QxlywEeUEeODR7vDcYOqmg")]
    [DisplayName("Delay")]
    [IsoXmlTag("Dely")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Delay { get; init; } 
    
    
    #nullable disable
    
}
