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
[IsoId("_HRfssdqcEeearpaEPXv9UA")]
[DisplayName("Host Communication Parameter")]
public partial record HostCommunicationParameter5
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_HaScUdqcEeearpaEPXv9UA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_HaTDYdqcEeearpaEPXv9UA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_HaTDY9qcEeearpaEPXv9UA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters5? Address { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_HaTDZdqcEeearpaEPXv9UA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public KEKIdentifier5? Key { get; init; } 
    
    /// <summary>
    /// Access information to reach an intermediate network service provider.
    /// </summary>
    [IsoId("_HaTDZ9qcEeearpaEPXv9UA")]
    [DisplayName("Network Service Provider")]
    [IsoXmlTag("NtwkSvcPrvdr")]
    public NetworkParameters5? NetworkServiceProvider { get; init; } 
    
    /// <summary>
    /// Physical Interface where the host is connected.
    /// </summary>
    [IsoId("_-FxKsNqgEeearpaEPXv9UA")]
    [DisplayName("Physical Interface")]
    [IsoXmlTag("PhysIntrfc")]
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    
    
    #nullable disable
    
}
