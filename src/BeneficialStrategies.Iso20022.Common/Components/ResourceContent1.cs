// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Features of a media resource.
/// </summary>
[IsoId("_wkqgEC8DEeu125Ip9zFcsQ")]
[DisplayName("Resource Content")]
public record ResourceContent1
{
    /// <summary>
    /// Type of media resource.
    /// </summary>
    [IsoId("_RZ53wC8EEeu125Ip9zFcsQ")]
    [DisplayName("Resource Type")]
    [IsoXmlTag("RsrcTp")]
    public required ResourceType1Code ResourceType { get; init; }

    /// <summary>
    /// Format of the media resource;
    /// </summary>
    [IsoId("_X5H98C8EEeu125Ip9zFcsQ")]
    [DisplayName("Resource Format")]
    [IsoXmlTag("RsrcFrmt")]
    public SoundFormat1Code? ResourceFormat { get; init; }

    /// <summary>
    /// Language of the media resource.
    /// </summary>
    [IsoId("_fjS0UC8EEeu125Ip9zFcsQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; }

    /// <summary>
    /// Reference of a media resource.
    /// </summary>
    [IsoId("_bzU3wS8GEeu125Ip9zFcsQ")]
    [DisplayName("Resource Reference")]
    [IsoXmlTag("RsrcRef")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ResourceReference { get; init; }
}
