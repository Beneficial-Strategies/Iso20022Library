// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point Of Interaction Component Characteristics10.
/// </summary>
[IsoId("_xJcmMZEIEe6Un9Rms6YuCg")]
[DisplayName("Point Of Interaction Component Characteristics10")]
public partial record PointOfInteractionComponentCharacteristics10
{
    #nullable enable

    /// <summary>
    /// Communication.
    /// </summary>
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public ValueList<CommunicationCharacteristics5> Communication { get; init; } = [];

    /// <summary>
    /// Memory.
    /// </summary>
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public ValueList<MemoryCharacteristics1> Memory { get; init; } = [];

    /// <summary>
    /// Security Access Modules.
    /// </summary>
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    public IsoNumber? SecurityAccessModules { get; init; } 

    /// <summary>
    /// Security Element.
    /// </summary>
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public ValueList<CryptographicKey18> SecurityElement { get; init; } = [];

    /// <summary>
    /// Subscriber Identity Modules.
    /// </summary>
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    public IsoNumber? SubscriberIdentityModules { get; init; } 

    
    #nullable disable
    
}
