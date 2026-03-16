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
[IsoId("_txTnMezgEeiojesOXOKoug")]
[DisplayName("Point Of Interaction Component Characteristics")]
public record PointOfInteractionComponentCharacteristics5
{
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_t7znAezgEeiojesOXOKoug")]
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public MemoryCharacteristics1? Memory { get; init; }

    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_t7znA-zgEeiojesOXOKoug")]
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public CommunicationCharacteristics4? Communication { get; init; }

    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_t7znBezgEeiojesOXOKoug")]
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SecurityAccessModules { get; init; }

    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_t7znB-zgEeiojesOXOKoug")]
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubscriberIdentityModules { get; init; }

    /// <summary>
    /// Security characteristics of the component.
    /// </summary>
    [IsoId("_t7znCezgEeiojesOXOKoug")]
    [DisplayName("Security Element")]
    [IsoXmlTag("SctyElmt")]
    public CryptographicKey13? SecurityElement { get; init; }
}
