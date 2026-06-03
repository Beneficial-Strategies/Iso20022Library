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
[IsoId("_1kawEc-cEfCTVKnQ8NFKFg")]
[DisplayName("Point Of Interaction Capabilities11")]
public record PointOfInteractionCapabilities11
{
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_1lJv5c-cEfCTVKnQ8NFKFg")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public SimpleValueList<CardDataReading8Code> CardReadingCapabilities { get; init; } = [];

    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_1lJv68-cEfCTVKnQ8NFKFg")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public SimpleValueList<CardholderVerificationCapability4Code> CardholderVerificationCapabilities { get; init; } = [];

    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_1lJv8c-cEfCTVKnQ8NFKFg")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    public IsoPositiveNumber? PINLengthCapabilities { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_1lJv98-cEfCTVKnQ8NFKFg")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    public IsoPositiveNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_1lJv_c-cEfCTVKnQ8NFKFg")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    public IsoPositiveNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_1lJwA8-cEfCTVKnQ8NFKFg")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_1lJwCc-cEfCTVKnQ8NFKFg")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    [IsoId("_1lJwD8-cEfCTVKnQ8NFKFg")]
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public ValueList<DisplayCapabilities7> MessageCapabilities { get; init; } = [];
}
