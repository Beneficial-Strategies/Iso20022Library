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
[IsoId("_JtjHEAyJEeKa_56Jbsi1RQ")]
[DisplayName("Point Of Interaction Component Characteristics")]
public record PointOfInteractionComponentCharacteristics1
{
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_Y0FoYAyJEeKa_56Jbsi1RQ")]
    [DisplayName("Memory")]
    [IsoXmlTag("Mmry")]
    public MemoryCharacteristics1? Memory { get; init; }

    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_jlU9YAyJEeKa_56Jbsi1RQ")]
    [DisplayName("Communication")]
    [IsoXmlTag("Com")]
    public CommunicationCharacteristics1? Communication { get; init; }

    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_vo4O0AyJEeKa_56Jbsi1RQ")]
    [DisplayName("Security Access Modules")]
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SecurityAccessModules { get; init; }

    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_6Y6C4AyJEeKa_56Jbsi1RQ")]
    [DisplayName("Subscriber Identity Modules")]
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SubscriberIdentityModules { get; init; }

    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_Av72YAyKEeKa_56Jbsi1RQ")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; }
}
