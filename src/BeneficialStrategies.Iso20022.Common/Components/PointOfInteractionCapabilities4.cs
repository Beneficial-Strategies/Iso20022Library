// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the terminal performing the transaction.
/// </summary>
[IsoId("_YSjIwXrwEeSz_of_1TY14A")]
[DisplayName("Point Of Interaction Capabilities")]
public partial record PointOfInteractionCapabilities4
{
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the terminal performing the transaction. 
    /// It correspond to the ISO 8583 field number 22-2 for the version 93, and field number 27-1 for the version 2003.
    /// </summary>
    [IsoId("_Ye6w0XrwEeSz_of_1TY14A")]
    [DisplayName("Card Reading Capabilities")]
    [IsoXmlTag("CardRdngCpblties")]
    public SimpleValueList<CardDataReading2Code> CardReadingCapabilities { get; init; } = [];
    // ID for the above is _Ye6w0XrwEeSz_of_1TY14A
    
    /// <summary>
    /// Card writting capabilities of the terminal performing the transaction. 
    /// It correspond to the ISO 8583 field number 22-10 for the version 93, and field number 27-8_9 for the version 2003.
    /// </summary>
    [IsoId("_DjhbUHr4EeSZrs_hiwNOWA")]
    [DisplayName("Card Writting Capabilities")]
    [IsoXmlTag("CardWrttgCpblties")]
    public CardDataReading3Code? CardWrittingCapabilities { get; init; } 
    
    /// <summary>
    /// Cardholder verification capabilities by the terminal. 
    /// It correspond to the ISO 8583 field number 22-2 for the versions 87 and 93, and field number 27-2 for the version 2003.
    /// </summary>
    [IsoId("_Ye6w03rwEeSz_of_1TY14A")]
    [DisplayName("Cardholder Verification Capabilities")]
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    public CardholderVerificationCapability2Code? CardholderVerificationCapabilities { get; init; } 
    
    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN. 
    /// It correspond to the ISO 8583, field number 25 for the version 87, 22-12 for the version 93, and field number 27-11 for the version 2003.
    /// </summary>
    [IsoId("_Ye6w1XrwEeSz_of_1TY14A")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; } 
    
    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_Ye6w13rwEeSz_of_1TY14A")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ApprovalCodeLength { get; init; } 
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_c2yfUC7yEeWc7f-D6ByqMg")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaxScriptLength { get; init; } 
    
    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_Ye6w2XrwEeSz_of_1TY14A")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    
    /// <summary>
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Ye6w23rwEeSz_of_1TY14A")]
    [DisplayName("On Line Capabilities")]
    [IsoXmlTag("OnLineCpblties")]
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    
    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant. 
    /// It correspond to the ISO 8583 field number 22-11 for the version 93, and field number 27-6 for the version 2003.
    /// </summary>
    [IsoId("_YUO_QHr6EeSZrs_hiwNOWA")]
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public DisplayCapabilities3? MessageCapabilities { get; init; } 
    
    
    #nullable disable
    
}
