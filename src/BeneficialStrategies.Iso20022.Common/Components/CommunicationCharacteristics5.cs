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
[IsoId("_FsXroQ0XEeqUVL7sB4m7NA")]
[DisplayName("Communication Characteristics")]
public partial record CommunicationCharacteristics5
{
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_F3D4sQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Communication Type")]
    [IsoXmlTag("ComTp")]
    public required POICommunicationType2Code CommunicationType { get; init; } 
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_F3D4sw0XEeqUVL7sB4m7NA")]
    [DisplayName("Remote Party")]
    [IsoXmlTag("RmotPty")]
    public SimpleValueList<PartyType7Code> RemoteParty { get; init; } = new SimpleValueList<PartyType7Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _F3D4sw0XEeqUVL7sB4m7NA
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_F3D4tQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Active")]
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Active { get; init; } 
    
    /// <summary>
    /// Network parameters of the communication link.
    /// </summary>
    [IsoId("_F3D4tw0XEeqUVL7sB4m7NA")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public NetworkParameters7? Parameters { get; init; } 
    
    /// <summary>
    /// Physical Interface used by the communication link.
    /// </summary>
    [IsoId("_F3D4uQ0XEeqUVL7sB4m7NA")]
    [DisplayName("Physical Interface")]
    [IsoXmlTag("PhysIntrfc")]
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    
    
    #nullable disable
    
}
