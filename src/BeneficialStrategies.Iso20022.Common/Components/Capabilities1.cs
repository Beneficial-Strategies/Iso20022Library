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
[IsoId("_HjX5sEYZEeegp_DADCe7HQ")]
[DisplayName("Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Capabilities1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the terminal performing the transaction.
    /// ISO 8583:93 bit 22-2; ISO 8583:2003 bit 27-1
    /// </summary>
    [IsoId("_f4hfoEYZEeegp_DADCe7HQ")]
    [DisplayName("Card Reading Capability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdngCpblty")]
    #endif
    [IsoXmlTag("CardRdngCpblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading7Code? CardReadingCapability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading7Code? CardReadingCapability { get; init; } 
    #else
    public CardDataReading7Code? CardReadingCapability { get; set; } 
    #endif
    
    /// <summary>
    /// Other types of card reading capabilities.
    /// </summary>
    [IsoId("_oEHoEEYZEeegp_DADCe7HQ")]
    [DisplayName("Other Card Reading Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCardRdngCpblties")]
    #endif
    [IsoXmlTag("OthrCardRdngCpblties")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherCardReadingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherCardReadingCapabilities { get; init; } 
    #else
    public System.String? OtherCardReadingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Card writing or output capabilities of the terminal performing the transaction.
    /// ISO 8583:93 bit 22-10, ISO 8583:2003 bit 27-8_9.
    /// </summary>
    [IsoId("_5zlTcEYZEeegp_DADCe7HQ")]
    [DisplayName("Card Writing Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardWrtgCpblties")]
    #endif
    [IsoXmlTag("CardWrtgCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataWriting1Code? CardWritingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataWriting1Code? CardWritingCapabilities { get; init; } 
    #else
    public CardDataWriting1Code? CardWritingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Other card writing or output capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_FKeTMEYaEeegp_DADCe7HQ")]
    [DisplayName("Other Card Writing Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCardWrtgCpblties")]
    #endif
    [IsoXmlTag("OthrCardWrtgCpblties")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherCardWritingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherCardWritingCapabilities { get; init; } 
    #else
    public System.String? OtherCardWritingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits that the Point of Interaction is able to accept when the cardholder enters its PIN.
    /// ISO 8583:87 bit 26, ISO 8583:93 bit 22-12, ISO 8583:2003 bit 27-11.
    /// </summary>
    [IsoId("_R71s4EYaEeegp_DADCe7HQ")]
    [DisplayName("PIN Length Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINLngthCpblties")]
    #endif
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PINLengthCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PINLengthCapabilities { get; init; } 
    #else
    public System.UInt64? PINLengthCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of characters of the approval code that the acquirer is able to manage.
    /// ISO 8583:87 &amp; 93 bit 27,  ISO 8583:2003-1 bit 27-3
    /// </summary>
    [IsoId("_gyFvcEYaEeegp_DADCe7HQ")]
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
    /// ISO 8583:2003 bit 27-8
    /// </summary>
    [IsoId("_r_zlEEYaEeegp_DADCe7HQ")]
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
    /// PIN pad is inoperative.
    /// Default: False - PIN pad is operative or not applicable.
    /// True: PIN pas is inoperative.
    /// </summary>
    [IsoId("_fVl-wJo5Eee2tb5MXkS8WQ")]
    [DisplayName("PIN Pad Inoperative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINPadInprtv")]
    #endif
    [IsoXmlTag("PINPadInprtv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PINPadInoperative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PINPadInoperative { get; init; } 
    #else
    public System.String? PINPadInoperative { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the terminal can capture cards or not.
    /// True: The terminal is able to capture cards
    /// False: The terminal is not able to capture cards.
    /// ISO 8583:87 bit 25, ISO 8583:93 bit 22-3, ISO 8583:2003 bit 27-10.
    /// </summary>
    [IsoId("_9yTWUEYaEeegp_DADCe7HQ")]
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
    [IsoId("_GkEt8EYbEeegp_DADCe7HQ")]
    [DisplayName("On Line Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineCpblties")]
    #endif
    [IsoXmlTag("OnLineCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLineCapability2Code? OnLineCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLineCapability2Code? OnLineCapabilities { get; init; } 
    #else
    public OnLineCapability2Code? OnLineCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Capability of the terminal to display or print messages to the cardholder or the merchant.
    /// ISO 8583:93 bit 22-11, ISO 8583:2003-1 bit 27-4,5, 6, 7
    /// </summary>
    [IsoId("_Im3aMEYdEeegp_DADCe7HQ")]
    [DisplayName("Message Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCpblties")]
    #endif
    [IsoXmlTag("MsgCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities6? MessageCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities6? MessageCapabilities { get; init; } 
    #else
    public DisplayCapabilities6? MessageCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities performing the transaction at the point of service.
    /// ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-2
    /// </summary>
    [IsoId("_25q4kRqZEeqH1IQNpbVpEw")]
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
    
    
    #nullable disable
    
}
