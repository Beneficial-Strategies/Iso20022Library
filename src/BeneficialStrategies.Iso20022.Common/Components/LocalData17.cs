// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Data17.
/// </summary>
[IsoId("_9Y3joZkPEe6Qpd-x8YgzaA")]
[DisplayName("Local Data17")]
public record LocalData17
{
    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Encoding Format.
    /// </summary>
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public Max35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Text Message.
    /// </summary>
    [DisplayName("Text Message")]
    [IsoXmlTag("TxtMsg")]
    public required Max40KText TextMessage { get; init; }
}
