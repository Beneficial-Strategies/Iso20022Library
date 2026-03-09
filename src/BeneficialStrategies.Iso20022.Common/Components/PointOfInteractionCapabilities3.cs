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
[IsoId("_L_T7YWiuEeS87LmvcA55sg")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities3
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
    [IsoId("_MMNH4WiuEeS87LmvcA55sg")]
    [DisplayName("Card Reading Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRdngCpblties")]
    #endif
    [IsoXmlTag("CardRdngCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading1Code? CardReadingCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading1Code? CardReadingCapabilities { get; init; } 
    #else
    public CardDataReading1Code? CardReadingCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder verification capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_MMNH42iuEeS87LmvcA55sg")]
    [DisplayName("Cardholder Verification Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrVrfctnCpblties")]
    #endif
    [IsoXmlTag("CrdhldrVrfctnCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; init; } 
    #else
    public CardholderVerificationCapability1Code? CardholderVerificationCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of digits the POI is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_l3yVQGiuEeS87LmvcA55sg")]
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
    [IsoId("_CvY9QGiwEeS87LmvcA55sg")]
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
    /// True if the POI is able to capture card.
    /// </summary>
    [IsoId("_KuVJwGiwEeS87LmvcA55sg")]
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
    [IsoId("_MMNH5WiuEeS87LmvcA55sg")]
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
    /// Capabilities of the display components performing the transaction.
    /// </summary>
    [IsoId("_MMNH52iuEeS87LmvcA55sg")]
    [DisplayName("Display Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispCpblties")]
    #endif
    [IsoXmlTag("DispCpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisplayCapabilities2? DisplayCapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisplayCapabilities2? DisplayCapabilities { get; init; } 
    #else
    public DisplayCapabilities2? DisplayCapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Number of columns of the printer component.
    /// </summary>
    [IsoId("_MMNH6WiuEeS87LmvcA55sg")]
    [DisplayName("Print Line Width")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtLineWidth")]
    #endif
    [IsoXmlTag("PrtLineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PrintLineWidth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PrintLineWidth { get; init; } 
    #else
    public System.UInt64? PrintLineWidth { get; set; } 
    #endif
    
    /// <summary>
    /// Available language in the display and printer interface.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_MMNH62iuEeS87LmvcA55sg")]
    [DisplayName("Available Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblLang")]
    #endif
    [IsoXmlTag("AvlblLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? AvailableLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AvailableLanguage { get; init; } 
    #else
    public string? AvailableLanguage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
