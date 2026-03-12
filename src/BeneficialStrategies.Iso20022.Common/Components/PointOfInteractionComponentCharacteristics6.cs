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
[IsoId("_IZvIoQ1KEeqjM-rxn3HuXQ")]
[DisplayName("Point Of Interaction Component Characteristics")]
public partial record PointOfInteractionComponentCharacteristics6
{
    #nullable enable
    
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_ImUMEQ1KEeqjM-rxn3HuXQ")]
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public MemoryCharacteristics1? Memory { get; init; } 
    
    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_ImUzIQ1KEeqjM-rxn3HuXQ")]
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public CommunicationCharacteristics5? Communication { get; init; } 
    
    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_ImUzIw1KEeqjM-rxn3HuXQ")]
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SecurityAccessModules { get; init; } 
    
    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_ImUzJQ1KEeqjM-rxn3HuXQ")]
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubscriberIdentityModules { get; init; } 
    
    /// <summary>
    /// Security characteristics of the component.
    /// </summary>
    [IsoId("_ImUzJw1KEeqjM-rxn3HuXQ")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public CryptographicKey14? SecurityElement { get; init; } 
    
    
    #nullable disable
    
}
