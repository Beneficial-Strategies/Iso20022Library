// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical and logical characteristics of a POI component (Point of Interaction).
/// </summary>
[IsoId("_FYQfgbZzEfCUZfsQO4rYeA")]
[DisplayName("Point Of Interaction Component Characteristics11")]
public record PointOfInteractionComponentCharacteristics11
{
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_FaNnVbZzEfCUZfsQO4rYeA")]
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public ValueList<MemoryCharacteristics1> Memory { get; init; } = [];

    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_FaNnW7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public ValueList<CommunicationCharacteristics5> Communication { get; init; } = [];

    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_FaNnYbZzEfCUZfsQO4rYeA")]
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    public IsoNumber? SecurityAccessModules { get; init; }

    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_FaNnZ7ZzEfCUZfsQO4rYeA")]
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    public IsoNumber? SubscriberIdentityModules { get; init; }

    /// <summary>
    /// Security characteristics of the component.
    /// </summary>
    [IsoId("_FaNnbbZzEfCUZfsQO4rYeA")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public ValueList<CryptographicKey19> SecurityElement { get; init; } = [];
}
