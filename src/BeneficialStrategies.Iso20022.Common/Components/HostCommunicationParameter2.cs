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
[IsoId("_dJ5eMQvdEeK9Xewg3qiFQA")]
[DisplayName("Host Communication Parameter")]
public partial record HostCommunicationParameter2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_dWGHIQvdEeK9Xewg3qiFQA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_dWGHJQvdEeK9Xewg3qiFQA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters1? Address { get; init; } 
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_dWGHKQvdEeK9Xewg3qiFQA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey3? Key { get; init; } 
    
    
    #nullable disable
    
}
