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
[IsoId("_C4EK8bCZEeapjPTKZHuM2w")]
[DisplayName("Communication Characteristics")]
public partial record CommunicationCharacteristics3
{
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_DExKMbCZEeapjPTKZHuM2w")]
    [DisplayName("Communication Type")]
    [IsoXmlTag("ComTp")]
    public required POICommunicationType2Code CommunicationType { get; init; } 
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_DExKM7CZEeapjPTKZHuM2w")]
    [DisplayName("Remote Party")]
    [IsoXmlTag("RmotPty")]
    public SimpleValueList<PartyType7Code> RemoteParty { get; init; } = [];
    // ID for the above is _DExKM7CZEeapjPTKZHuM2w
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_DExKNbCZEeapjPTKZHuM2w")]
    [DisplayName("Active")]
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Active { get; init; } 
    
    
    #nullable disable
    
}
