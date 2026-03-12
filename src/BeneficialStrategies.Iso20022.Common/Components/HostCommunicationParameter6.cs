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
[IsoId("_-yW3QQufEeqw5uEXxQ9H4g")]
[DisplayName("Host Communication Parameter")]
public partial record HostCommunicationParameter6
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_-9KZEQufEeqw5uEXxQ9H4g")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_-9KZEwufEeqw5uEXxQ9H4g")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_-9KZFQufEeqw5uEXxQ9H4g")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters7? Address { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_-9KZFwufEeqw5uEXxQ9H4g")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public KEKIdentifier5? Key { get; init; } 
    
    /// <summary>
    /// Access information to reach an intermediate network service provider.
    /// </summary>
    [IsoId("_-9KZGQufEeqw5uEXxQ9H4g")]
    [DisplayName("Network Service Provider")]
    [IsoXmlTag("NtwkSvcPrvdr")]
    public NetworkParameters7? NetworkServiceProvider { get; init; } 
    
    /// <summary>
    /// Physical Interface where the host is connected.
    /// </summary>
    [IsoId("_-9KZGwufEeqw5uEXxQ9H4g")]
    [DisplayName("Physical Interface")]
    [IsoXmlTag("PhysIntrfc")]
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    
    
    #nullable disable
    
}
