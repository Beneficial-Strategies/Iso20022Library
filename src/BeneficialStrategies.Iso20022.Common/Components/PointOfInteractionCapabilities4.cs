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
/// Capabilities of the terminal performing the transaction.
/// </summary>
[IsoId("_YSjIwXrwEeSz_of_1TY14A")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the terminal performing the transaction. 
    /// It correspond to the ISO 8583 field number 22-2 for the version 93, and field number 27-1 for the version 2003.
    /// </summary>
    [IsoId("_Ye6w0XrwEeSz_of_1TY14A")]
    [DisplayName("Card Reading Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdngCpblties")]
    #endif
    [IsoXmlTag("CardRdngCpblties")]
    public SimpleValueList<CardDataReading2Code> CardReadingCapabilities { get; init; } = new SimpleValueList<CardDataReading2Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Ye6w0XrwEeSz_of_1TY14A
    
    /// <summary>
    /// Card writting capabilities of the terminal performing the transaction. 
    /// It correspond to the ISO 8583 field number 22-10 for the version 93, and field number 27-8_9 for the version 2003.
    /// </summary>
    [IsoId("_DjhbUHr4EeSZrs_hiwNOWA")]
    [DisplayName("Card Writting Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardWrttgCpblties")]
    #endif
    [IsoXmlTag("CardWrttgCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading3Code? CardWrittingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading3Code? CardWrittingCapabilities { get; init; } 
    #else
    public CardDataReading3Code? CardWrittingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities by the terminal. 
    /// It correspond to the ISO 8583 field number 22-2 for the versions 87 and 93, and field number 27-2 for the version 2003.
    /// </summary>
    [IsoId("_Ye6w03rwEeSz_of_1TY14A")]
    [DisplayName("Cardholder Verification Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrVrfctnCpblties")]
    #endif
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapability2Code? CardholderVerificationCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapability2Code? CardholderVerificationCapabilities { get; init; } 
    #else
    public CardholderVerificationCapability2Code? CardholderVerificationCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN. 
    /// It correspond to the ISO 8583, field number 25 for the version 87, 22-12 for the version 93, and field number 27-11 for the version 2003.
    /// </summary>
    [IsoId("_Ye6w1XrwEeSz_of_1TY14A")]
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
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_Ye6w13rwEeSz_of_1TY14A")]
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
    [IsoId("_c2yfUC7yEeWc7f-D6ByqMg")]
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
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_Ye6w2XrwEeSz_of_1TY14A")]
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
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Ye6w23rwEeSz_of_1TY14A")]
    [DisplayName("On Line Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnLineCpblties")]
    #endif
    [IsoXmlTag("OnLineCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLineCapability1Code? OnLineCapabilities { get; init; } 
    #else
    public OnLineCapability1Code? OnLineCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant. 
    /// It correspond to the ISO 8583 field number 22-11 for the version 93, and field number 27-6 for the version 2003.
    /// </summary>
    [IsoId("_YUO_QHr6EeSZrs_hiwNOWA")]
    [DisplayName("Message Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCpblties")]
    #endif
    [IsoXmlTag("MsgCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities3? MessageCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities3? MessageCapabilities { get; init; } 
    #else
    public DisplayCapabilities3? MessageCapabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
