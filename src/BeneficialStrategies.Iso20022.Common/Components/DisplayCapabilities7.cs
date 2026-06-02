// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the display components performing the transaction.
/// </summary>
[IsoId("_1lJwFc-cEfCTVKnQ8NFKFg")]
[DisplayName("Display Capabilities7")]
public record DisplayCapabilities7
{
    /// <summary>
    /// Destination of the message to present.
    /// </summary>
    [IsoId("_1l4Ioc-cEfCTVKnQ8NFKFg")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    [MinLength(1)]
    public SimpleValueList<UserInterface9Code> Destination { get; init; } = [];

    /// <summary>
    /// Available message format.
    /// </summary>
    [IsoId("_1l4Ip8-cEfCTVKnQ8NFKFg")]
    [DisplayName("Available Format")]
    [IsoXmlTag("AvlblFrmt")]
    public SimpleValueList<OutputFormat1Code> AvailableFormat { get; init; } = [];

    /// <summary>
    /// Number of lines of the display.
    /// </summary>
    [IsoId("_1l4Irc-cEfCTVKnQ8NFKFg")]
    [DisplayName("Number Of Lines")]
    [IsoXmlTag("NbOfLines")]
    public IsoNumber? NumberOfLines { get; init; }

    /// <summary>
    /// Number of columns of the display or printer.
    /// </summary>
    [IsoId("_1l4Is8-cEfCTVKnQ8NFKFg")]
    [DisplayName("Line Width")]
    [IsoXmlTag("LineWidth")]
    public IsoNumber? LineWidth { get; init; }

    /// <summary>
    /// Available language for the message. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_1l4Iuc-cEfCTVKnQ8NFKFg")]
    [DisplayName("Available Language")]
    [IsoXmlTag("AvlblLang")]
    public SimpleValueList<LanguageCode> AvailableLanguage { get; init; } = [];
}
