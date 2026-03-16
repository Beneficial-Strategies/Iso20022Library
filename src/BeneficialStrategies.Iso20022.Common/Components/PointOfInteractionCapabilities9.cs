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
[IsoId("_n5BG4Q0yEeqUVL7sB4m7NA")]
[DisplayName("Point Of Interaction Capabilities")]
public record PointOfInteractionCapabilities9
{
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_oEy5EQ0yEeqUVL7sB4m7NA")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public CardDataReading8Code? CardReadingCapabilities { get; init; }

    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_oEy5Ew0yEeqUVL7sB4m7NA")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; init; }

    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_oEy5FQ0yEeqUVL7sB4m7NA")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? PINLengthCapabilities { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_oEy5Fw0yEeqUVL7sB4m7NA")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_oEy5GQ0yEeqUVL7sB4m7NA")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_oEy5Gw0yEeqUVL7sB4m7NA")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_oEy5HQ0yEeqUVL7sB4m7NA")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    [IsoId("_oEy5Hw0yEeqUVL7sB4m7NA")]
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public DisplayCapabilities4? MessageCapabilities { get; init; }
}
