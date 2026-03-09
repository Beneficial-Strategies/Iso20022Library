// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the terminal.
/// </summary>
[IsoId("_e3RowaH4EeuiuNcvKhXmNQ")]
[DisplayName("Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Capabilities2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capability of the terminal performing the transaction.
    /// </summary>
    [IsoId("_e88L4aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Card Reading Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdngCpblty")]
    #endif
    [IsoXmlTag("CardRdngCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardReadingCapabilities1? CardReadingCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardReadingCapabilities1? CardReadingCapability { get; init; } 
    #else
    public CardReadingCapabilities1? CardReadingCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Card writing or output capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_e88L5aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Card Writing Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardWrtgCpblty")]
    #endif
    [IsoXmlTag("CardWrtgCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardWritingCapabilities1? CardWritingCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardWritingCapabilities1? CardWritingCapability { get; init; } 
    #else
    public CardWritingCapabilities1? CardWritingCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits that the Point of Interaction is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_e88L6aH4EeuiuNcvKhXmNQ")]
    [DisplayName("PIN Length Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINLngthCpblty")]
    #endif
    [IsoXmlTag("PINLngthCpblty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PINLengthCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PINLengthCapability { get; init; } 
    #else
    public System.UInt64? PINLengthCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Security characteristic of the PIN Entry device solution.
    /// </summary>
    [IsoId("_zBxMIKH4EeuiuNcvKhXmNQ")]
    [DisplayName("PIN Entry Security Characteristic")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINNtrySctyChrtc")]
    #endif
    [IsoXmlTag("PINNtrySctyChrtc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PINEntrySecurityCharacteristic1Code? PINEntrySecurityCharacteristic { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PINEntrySecurityCharacteristic1Code? PINEntrySecurityCharacteristic { get; init; } 
    #else
    public PINEntrySecurityCharacteristic1Code? PINEntrySecurityCharacteristic { get; set; } 
    #endif
    
    /// <summary>
    /// Other privately or nationally assigned code.
    /// </summary>
    [IsoId("_OFWuQKH5EeuiuNcvKhXmNQ")]
    [DisplayName("Other PIN Entry Security Characteristic")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPINNtrySctyChrtc")]
    #endif
    [IsoXmlTag("OthrPINNtrySctyChrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherPINEntrySecurityCharacteristic { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherPINEntrySecurityCharacteristic { get; init; } 
    #else
    public System.String? OtherPINEntrySecurityCharacteristic { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of characters of the approval code that the acquirer is able to manage.
    /// </summary>
    [IsoId("_e88L66H4EeuiuNcvKhXmNQ")]
    [DisplayName("Approval Code Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlCdLngth")]
    #endif
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ApprovalCodeLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ApprovalCodeLength { get; init; } 
    #else
    public System.UInt64? ApprovalCodeLength { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_e88L7aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Max Script Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MxScrptLngth")]
    #endif
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaxScriptLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaxScriptLength { get; init; } 
    #else
    public System.UInt64? MaxScriptLength { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the terminal can capture cards or not.
    /// True: The terminal is able to capture cards
    /// False: The terminal is not able to capture cards.
    /// </summary>
    [IsoId("_e88L8aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Card Capture Capable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardCaptrCpbl")]
    #endif
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCaptureCapable { get; init; } 
    #else
    public System.String? CardCaptureCapable { get; set; } 
    #endif
    
    /// <summary>
    /// Capability of the terminal to go online.
    /// </summary>
    [IsoId("_e88L86H4EeuiuNcvKhXmNQ")]
    [DisplayName("On Line Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineCpblty")]
    #endif
    [IsoXmlTag("OnLineCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLineCapability2Code? OnLineCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLineCapability2Code? OnLineCapability { get; init; } 
    #else
    public OnLineCapability2Code? OnLineCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Capability of the terminal to display or print messages to the cardholder or the merchant.
    /// </summary>
    [IsoId("_e88L9aH4EeuiuNcvKhXmNQ")]
    [DisplayName("Message Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCpblty")]
    #endif
    [IsoXmlTag("MsgCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities6? MessageCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities6? MessageCapability { get; init; } 
    #else
    public DisplayCapabilities6? MessageCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// </summary>
    [IsoId("_e88L96H4EeuiuNcvKhXmNQ")]
    [DisplayName("Cardholder Verification Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrVrfctnCpblty")]
    #endif
    [IsoXmlTag("CrdhldrVrfctnCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; init; } 
    #else
    public CardholderVerificationCapabilities1? CardholderVerificationCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal is capable of temporary secure storage of the card details for reuse upon permission of the card issuer.
    /// Default meaning when not present: false.
    /// </summary>
    [IsoId("_US2J8KhJEeuOaMA1YOy5YQ")]
    [DisplayName("Temporary Secure Card Data Storage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempScrCardDataStorg")]
    #endif
    [IsoXmlTag("TempScrCardDataStorg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TemporarySecureCardDataStorage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TemporarySecureCardDataStorage { get; init; } 
    #else
    public System.String? TemporarySecureCardDataStorage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
