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
[IsoId("_Z6U5gdkHEeiojJsa6FYyew")]
[DisplayName("Point Of Interaction Capabilities")]
public record PointOfInteractionCapabilities8
{
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_aD4eIdkHEeiojJsa6FYyew")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public SimpleValueList<CardDataReading6Code> CardReadingCapabilities { get; init; } = [];

    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_aD5FMdkHEeiojJsa6FYyew")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public SimpleValueList<CardholderVerificationCapability4Code> CardholderVerificationCapabilities { get; init; } =
        [];

    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_aD5FM9kHEeiojJsa6FYyew")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? PINLengthCapabilities { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_aD5FNdkHEeiojJsa6FYyew")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_aD5FN9kHEeiojJsa6FYyew")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_aD5FOdkHEeiojJsa6FYyew")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_aD5FO9kHEeiojJsa6FYyew")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    [IsoId("_aD5FPdkHEeiojJsa6FYyew")]
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public ValueList<DisplayCapabilities4> MessageCapabilities { get; init; } = [];
}
