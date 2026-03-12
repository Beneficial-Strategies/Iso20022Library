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
[IsoId("_VHsEkAyIEeKa_56Jbsi1RQ")]
[DisplayName("Communication Characteristics")]
public partial record CommunicationCharacteristics1
{
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_qkpVYAyIEeKa_56Jbsi1RQ")]
    [DisplayName("Communication Type")]
    [IsoXmlTag("ComTp")]
    public required POICommunicationType1Code CommunicationType { get; init; } 
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_v3PQYAyIEeKa_56Jbsi1RQ")]
    [DisplayName("Remote Party")]
    [IsoXmlTag("RmotPty")]
    public required PartyType7Code RemoteParty { get; init; } 
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_3TAeYAyIEeKa_56Jbsi1RQ")]
    [DisplayName("Active")]
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Active { get; init; } 
    
    
    #nullable disable
    
}
