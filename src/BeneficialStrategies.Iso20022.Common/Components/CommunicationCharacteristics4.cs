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
[IsoId("_nWOPkezfEeiojesOXOKoug")]
[DisplayName("Communication Characteristics")]
public partial record CommunicationCharacteristics4
{
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_niOrQezfEeiojesOXOKoug")]
    [DisplayName("Communication Type")]
    [IsoXmlTag("ComTp")]
    public required POICommunicationType2Code CommunicationType { get; init; } 
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_niOrQ-zfEeiojesOXOKoug")]
    [DisplayName("Remote Party")]
    [IsoXmlTag("RmotPty")]
    public SimpleValueList<PartyType7Code> RemoteParty { get; init; } = [];
    // ID for the above is _niOrQ-zfEeiojesOXOKoug
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_niOrRezfEeiojesOXOKoug")]
    [DisplayName("Active")]
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Active { get; init; } 
    
    /// <summary>
    /// Network parameters of the communication link.
    /// </summary>
    [IsoId("_ufdjIezfEeiojesOXOKoug")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public NetworkParameters5? Parameters { get; init; } 
    
    /// <summary>
    /// Physical Interface used by the communication link.
    /// </summary>
    [IsoId("_5sFzoezfEeiojesOXOKoug")]
    [DisplayName("Physical Interface")]
    [IsoXmlTag("PhysIntrfc")]
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    
    
    #nullable disable
    
}
