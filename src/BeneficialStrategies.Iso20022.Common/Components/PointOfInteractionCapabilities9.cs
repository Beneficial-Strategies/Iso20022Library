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
/// Capabilities of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("_n5BG4Q0yEeqUVL7sB4m7NA")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Card reading capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_oEy5EQ0yEeqUVL7sB4m7NA")]
    [DisplayName("Card Reading Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdngCpblties")]
    #endif
    [IsoXmlTag("CardRdngCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading8Code? CardReadingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading8Code? CardReadingCapabilities { get; init; } 
    #else
    public CardDataReading8Code? CardReadingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_oEy5Ew0yEeqUVL7sB4m7NA")]
    [DisplayName("Cardholder Verification Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrVrfctnCpblties")]
    #endif
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; init; } 
    #else
    public CardholderVerificationCapability4Code? CardholderVerificationCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_oEy5FQ0yEeqUVL7sB4m7NA")]
    [DisplayName("PIN Length Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINLngthCpblties")]
    #endif
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? PINLengthCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PINLengthCapabilities { get; init; } 
    #else
    public System.UInt64? PINLengthCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of characters of the approval code the POI is able to manage.
    /// </summary>
    [IsoId("_oEy5Fw0yEeqUVL7sB4m7NA")]
    [DisplayName("Approval Code Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlCdLngth")]
    #endif
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? ApprovalCodeLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ApprovalCodeLength { get; init; } 
    #else
    public System.UInt64? ApprovalCodeLength { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_oEy5GQ0yEeqUVL7sB4m7NA")]
    [DisplayName("Max Script Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MxScrptLngth")]
    #endif
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? MaxScriptLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaxScriptLength { get; init; } 
    #else
    public System.UInt64? MaxScriptLength { get; set; } 
    #endif
    
    /// <summary>
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_oEy5Gw0yEeqUVL7sB4m7NA")]
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
    [IsoId("_oEy5HQ0yEeqUVL7sB4m7NA")]
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
    /// </summary>
    [IsoId("_oEy5Hw0yEeqUVL7sB4m7NA")]
    [DisplayName("Message Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCpblties")]
    #endif
    [IsoXmlTag("MsgCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities4? MessageCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities4? MessageCapabilities { get; init; } 
    #else
    public DisplayCapabilities4? MessageCapabilities { get; set; } 
    #endif
    
    
    #nullable disable
    
}
