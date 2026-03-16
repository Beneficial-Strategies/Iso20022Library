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
[IsoId("_L_T7YWiuEeS87LmvcA55sg")]
[DisplayName("Point Of Interaction Capabilities")]
public record PointOfInteractionCapabilities3
{
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_MMNH4WiuEeS87LmvcA55sg")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public CardDataReading1Code? CardReadingCapabilities { get; init; }

    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_MMNH42iuEeS87LmvcA55sg")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; init; }

    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_l3yVQGiuEeS87LmvcA55sg")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_CvY9QGiwEeS87LmvcA55sg")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_KuVJwGiwEeS87LmvcA55sg")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_MMNH5WiuEeS87LmvcA55sg")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capabilities of the display components performing the transaction.
    /// </summary>
    [IsoId("_MMNH52iuEeS87LmvcA55sg")]
    [DisplayName("Display Capabilities")]
    [IsoXmlTag("DispCpblties")]
    public DisplayCapabilities2? DisplayCapabilities { get; init; }

    /// <summary>
    /// Number of columns of the printer component.
    /// </summary>
    [IsoId("_MMNH6WiuEeS87LmvcA55sg")]
    [DisplayName("Print Line Width")]
    [IsoXmlTag("PrtLineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PrintLineWidth { get; init; }

    /// <summary>
    /// Available language in the display and printer interface.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_MMNH62iuEeS87LmvcA55sg")]
    [DisplayName("Available Language")]
    [IsoXmlTag("AvlblLang")]
    public LanguageCode? AvailableLanguage { get; init; }
}
