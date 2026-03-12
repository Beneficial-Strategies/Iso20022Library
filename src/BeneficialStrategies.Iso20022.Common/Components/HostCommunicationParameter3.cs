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
[IsoId("_fYHrwWpyEeSMqvBfBY1c9A")]
[DisplayName("Host Communication Parameter")]
public partial record HostCommunicationParameter3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_fk7YsWpyEeSMqvBfBY1c9A")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_fk7Ys2pyEeSMqvBfBY1c9A")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters3? Address { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_fk7YtWpyEeSMqvBfBY1c9A")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public KEKIdentifier2? Key { get; init; } 
    
    
    #nullable disable
    
}
