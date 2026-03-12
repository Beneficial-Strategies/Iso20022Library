// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the terminal.
/// </summary>
[IsoId("_e3RowaH4EeuiuNcvKhXmNQ")]
[DisplayName("Capabilities")]
public partial record Capabilities2
{
    #nullable enable
    
    /// <summary>
    /// Card reading capability of the terminal performing the transaction.
    /// </summary>
    [IsoId("_e88L4aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Card Reading Capability")]
    [IsoXmlTag("CardRdngCpblty")]
    public CardReadingCapabilities1? CardReadingCapability { get; init; } 
    
    /// <summary>
    /// Card writing or output capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_e88L5aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Card Writing Capability")]
    [IsoXmlTag("CardWrtgCpblty")]
    public CardWritingCapabilities1? CardWritingCapability { get; init; } 
    
    /// <summary>
    /// Maximum number of digits that the Point of Interaction is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_e88L6aH4EeuiuNcvKhXmNQ")]
    [DisplayName("PIN Length Capability")]
    [IsoXmlTag("PINLngthCpblty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapability { get; init; } 
    
    /// <summary>
    /// Security characteristic of the PIN Entry device solution.
    /// </summary>
    [IsoId("_zBxMIKH4EeuiuNcvKhXmNQ")]
    [DisplayName("PIN Entry Security Characteristic")]
    [IsoXmlTag("PINNtrySctyChrtc")]
    public PINEntrySecurityCharacteristic1Code? PINEntrySecurityCharacteristic { get; init; } 
    
    /// <summary>
    /// Other privately or nationally assigned code.
    /// </summary>
    [IsoId("_OFWuQKH5EeuiuNcvKhXmNQ")]
    [DisplayName("Other PIN Entry Security Characteristic")]
    [IsoXmlTag("OthrPINNtrySctyChrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherPINEntrySecurityCharacteristic { get; init; } 
    
    /// <summary>
    /// Maximum number of characters of the approval code that the acquirer is able to manage.
    /// </summary>
    [IsoId("_e88L66H4EeuiuNcvKhXmNQ")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ApprovalCodeLength { get; init; } 
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_e88L7aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaxScriptLength { get; init; } 
    
    /// <summary>
    /// Indicates whether the terminal can capture cards or not.
    /// True: The terminal is able to capture cards
    /// False: The terminal is not able to capture cards.
    /// </summary>
    [IsoId("_e88L8aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    
    /// <summary>
    /// Capability of the terminal to go online.
    /// </summary>
    [IsoId("_e88L86H4EeuiuNcvKhXmNQ")]
    [DisplayName("On Line Capability")]
    [IsoXmlTag("OnLineCpblty")]
    public OnLineCapability2Code? OnLineCapability { get; init; } 
    
    /// <summary>
    /// Capability of the terminal to display or print messages to the cardholder or the merchant.
    /// </summary>
    [IsoId("_e88L9aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Message Capability")]
    [IsoXmlTag("MsgCpblty")]
    public DisplayCapabilities6? MessageCapability { get; init; } 
    
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// </summary>
    [IsoId("_e88L96H4EeuiuNcvKhXmNQ")]
    [DisplayName("Cardholder Verification Capability")]
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    
    /// <summary>
    /// Terminal is capable of temporary secure storage of the card details for reuse upon permission of the card issuer.
    /// Default meaning when not present: false.
    /// </summary>
    [IsoId("_US2J8KhJEeuOaMA1YOy5YQ")]
    [DisplayName("Temporary Secure Card Data Storage")]
    [IsoXmlTag("TempScrCardDataStorg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TemporarySecureCardDataStorage { get; init; } 
    
    
    #nullable disable
    
}
