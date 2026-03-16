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
[IsoId("_mYI9YUeYEee9r7QjOdsbFw")]
[DisplayName("Display Capabilities")]
public record DisplayCapabilities6
{
    /// <summary>
    /// Destination of the message to present.
    /// </summary>
    [IsoId("_mjKhoUeYEee9r7QjOdsbFw")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public required UserInterface1Code Destination { get; init; }

    /// <summary>
    /// Available message format.
    /// </summary>
    [IsoId("_mjKho0eYEee9r7QjOdsbFw")]
    [DisplayName("Available Format")]
    [IsoXmlTag("AvlblFrmt")]
    public OutputFormat1Code? AvailableFormat { get; init; }

    /// <summary>
    /// Number of lines of the display.
    /// </summary>
    [IsoId("_mjKhpUeYEee9r7QjOdsbFw")]
    [DisplayName("Number Of Lines")]
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfLines { get; init; }

    /// <summary>
    /// Number of columns of the display or printer.
    /// </summary>
    [IsoId("_mjKhp0eYEee9r7QjOdsbFw")]
    [DisplayName("Line Width")]
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LineWidth { get; init; }

    /// <summary>
    /// Available language for the message. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_mjKhqUeYEee9r7QjOdsbFw")]
    [DisplayName("Available Language")]
    [IsoXmlTag("AvlblLang")]
    public LanguageCode? AvailableLanguage { get; init; }
}
