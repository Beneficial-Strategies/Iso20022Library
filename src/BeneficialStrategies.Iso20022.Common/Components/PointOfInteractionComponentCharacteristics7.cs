// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical and logical characteristics of a POI component (Point of Interaction).
/// </summary>
[IsoId("_S6Jm4S8iEeu125Ip9zFcsQ")]
[DisplayName("Point Of Interaction Component Characteristics")]
public partial record PointOfInteractionComponentCharacteristics7
{
    #nullable enable
    
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_TIqkAS8iEeu125Ip9zFcsQ")]
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public MemoryCharacteristics1? Memory { get; init; } 
    
    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_TIqkAy8iEeu125Ip9zFcsQ")]
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public CommunicationCharacteristics5? Communication { get; init; } 
    
    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_TIqkBS8iEeu125Ip9zFcsQ")]
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SecurityAccessModules { get; init; } 
    
    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_TIqkBy8iEeu125Ip9zFcsQ")]
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubscriberIdentityModules { get; init; } 
    
    /// <summary>
    /// Security characteristics of the component.
    /// </summary>
    [IsoId("_TIqkCS8iEeu125Ip9zFcsQ")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public CryptographicKey15? SecurityElement { get; init; } 
    
    
    #nullable disable
    
}
