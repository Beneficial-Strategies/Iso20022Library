// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Low level communication of the hardware or software component toward another component or an external entity.
/// </summary>
[IsoId("_gvNNkS9MEeOlZIh7PImd0A")]
[DisplayName("Communication Characteristics")]
public partial record CommunicationCharacteristics2
{
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_g_4G0S9MEeOlZIh7PImd0A")]
    [DisplayName("Communication Type")]
    [IsoXmlTag("ComTp")]
    public required POICommunicationType1Code CommunicationType { get; init; } 
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_g_4G0y9MEeOlZIh7PImd0A")]
    [DisplayName("Remote Party")]
    [IsoXmlTag("RmotPty")]
    public SimpleValueList<PartyType7Code> RemoteParty { get; init; } = [];
    // ID for the above is _g_4G0y9MEeOlZIh7PImd0A
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_g_4G1S9MEeOlZIh7PImd0A")]
    [DisplayName("Active")]
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Active { get; init; } 
    
    
    #nullable disable
    
}
