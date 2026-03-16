// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the terminal.
/// </summary>
[IsoId("_HjX5sEYZEeegp_DADCe7HQ")]
[DisplayName("Capabilities")]
public record Capabilities1
{
    /// <summary>
    /// Card reading capabilities of the terminal performing the transaction.
    /// ISO 8583:93 bit 22-2; ISO 8583:2003 bit 27-1
    /// </summary>
    [IsoId("_f4hfoEYZEeegp_DADCe7HQ")]
    [DisplayName("Card Reading Capability")]
    [IsoXmlTag("CardRdngCpblty")]
    public SimpleValueList<CardDataReading7Code> CardReadingCapability { get; init; } = [];

    /// <summary>
    /// Other types of card reading capabilities.
    /// </summary>
    [IsoId("_oEHoEEYZEeegp_DADCe7HQ")]
    [DisplayName("Other Card Reading Capabilities")]
    [IsoXmlTag("OthrCardRdngCpblties")]
    public SimpleValueList<IsoMax35Text> OtherCardReadingCapabilities { get; init; } = [];

    /// <summary>
    /// Card writing or output capabilities of the terminal performing the transaction.
    /// ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9.
    /// </summary>
    [IsoId("_5zlTcEYZEeegp_DADCe7HQ")]
    [DisplayName("Card Writing Capabilities")]
    [IsoXmlTag("CardWrtgCpblties")]
    public SimpleValueList<CardDataWriting1Code> CardWritingCapabilities { get; init; } = [];

    /// <summary>
    /// Other card writing or output capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_FKeTMEYaEeegp_DADCe7HQ")]
    [DisplayName("Other Card Writing Capabilities")]
    [IsoXmlTag("OthrCardWrtgCpblties")]
    public SimpleValueList<IsoMax35Text> OtherCardWritingCapabilities { get; init; } = [];

    /// <summary>
    /// Maximum number of digits that the Point of Interaction is able to accept when the cardholder enters its PIN.
    /// ISO 8583:87 bit 26, ISO 8583:93 bit 22-12, ISO 8583:2003 bit 27-11.
    /// </summary>
    [IsoId("_R71s4EYaEeegp_DADCe7HQ")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code that the acquirer is able to manage.
    /// ISO 8583:87 &amp; 93 bit 27,  ISO 8583:2003-1 bit 27-3
    /// </summary>
    [IsoId("_gyFvcEYaEeegp_DADCe7HQ")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// ISO 8583:2003 bit 27-8
    /// </summary>
    [IsoId("_r_zlEEYaEeegp_DADCe7HQ")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// PIN pad is inoperative.
    /// Default: False - PIN pad is operative or not applicable.
    /// True: PIN pas is inoperative.
    /// </summary>
    [IsoId("_fVl-wJo5Eee2tb5MXkS8WQ")]
    [DisplayName("PIN Pad Inoperative")]
    [IsoXmlTag("PINPadInprtv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PINPadInoperative { get; init; }

    /// <summary>
    /// Indicates whether the terminal can capture cards or not.
    /// True: The terminal is able to capture cards
    /// False: The terminal is not able to capture cards.
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-3, ISO 8583:2003 bit 27-10.
    /// </summary>
    [IsoId("_9yTWUEYaEeegp_DADCe7HQ")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// Capability of the terminal to go online.
    /// </summary>
    [IsoId("_GkEt8EYbEeegp_DADCe7HQ")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability2Code? OnLineCapabilities { get; init; }

    /// <summary>
    /// Capability of the terminal to display or print messages to the cardholder or the merchant.
    /// ISO 8583:93 bit 22-11, ISO 8583:2003-1 bit 27-4,5, 6, 7
    /// </summary>
    [IsoId("_Im3aMEYdEeegp_DADCe7HQ")]
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public ValueList<DisplayCapabilities6> MessageCapabilities { get; init; } = [];

    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-2
    /// </summary>
    [IsoId("_25q4kRqZEeqH1IQNpbVpEw")]
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public ValueList<CardholderVerificationCapabilities1> CardholderVerificationCapability { get; init; } =
        [];
}
