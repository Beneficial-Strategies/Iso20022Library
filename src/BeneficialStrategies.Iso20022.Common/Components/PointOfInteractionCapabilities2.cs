// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("_Lo4wkS9LEeOlZIh7PImd0A")]
[DisplayName("Point Of Interaction Capabilities")]
public record PointOfInteractionCapabilities2
{
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_L5jp0S9LEeOlZIh7PImd0A")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public SimpleValueList<CardDataReading1Code> CardReadingCapabilities { get; init; } = [];

    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_L5jp0y9LEeOlZIh7PImd0A")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public SimpleValueList<CardholderVerificationCapability1Code> CardholderVerificationCapabilities { get; init; } =
        [];

    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_L5jp1S9LEeOlZIh7PImd0A")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capabilities of the display components performing the transaction.
    /// </summary>
    [IsoId("_L5jp1y9LEeOlZIh7PImd0A")]
    [DisplayName("Display Capabilities")]
    [IsoXmlTag("DispCpblties")]
    public ValueList<DisplayCapabilities2> DisplayCapabilities { get; init; } = [];

    /// <summary>
    /// Number of columns of the printer component.
    /// </summary>
    [IsoId("_L5jp2S9LEeOlZIh7PImd0A")]
    [DisplayName("Print Line Width")]
    [IsoXmlTag("PrtLineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PrintLineWidth { get; init; }

    /// <summary>
    /// Available language in the display and printer interface.
    /// </summary>
    [IsoId("_Ek1CgC9MEeOlZIh7PImd0A")]
    [DisplayName("Available Language")]
    [IsoXmlTag("AvlblLang")]
    public SimpleValueList<ISO2ALanguageCode> AvailableLanguage { get; init; } = [];
}
