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
[IsoId("_DgX_cY0SEeWRYffwL7E13A")]
[DisplayName("Display Capabilities")]
public record DisplayCapabilities4
{
    /// <summary>
    /// Destination of the message to present.
    /// </summary>
    [IsoId("_Dqzt0Y0SEeWRYffwL7E13A")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public SimpleValueList<UserInterface4Code> Destination { get; init; } = [];

    // ID for the above is _Dqzt0Y0SEeWRYffwL7E13A

    /// <summary>
    /// Available message format.
    /// </summary>
    [IsoId("_Dqzt040SEeWRYffwL7E13A")]
    [DisplayName("Available Format")]
    [IsoXmlTag("AvlblFrmt")]
    public SimpleValueList<OutputFormat1Code> AvailableFormat { get; init; } = [];

    /// <summary>
    /// Number of lines of the display.
    /// </summary>
    [IsoId("_Dqzt1Y0SEeWRYffwL7E13A")]
    [DisplayName("Number Of Lines")]
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfLines { get; init; }

    /// <summary>
    /// Number of columns of the display or printer.
    /// </summary>
    [IsoId("_Dqzt140SEeWRYffwL7E13A")]
    [DisplayName("Line Width")]
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LineWidth { get; init; }

    /// <summary>
    /// Available language for the message. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_Dqzt2Y0SEeWRYffwL7E13A")]
    [DisplayName("Available Language")]
    [IsoXmlTag("AvlblLang")]
    public SimpleValueList<LanguageCode> AvailableLanguage { get; init; } = [];
}
