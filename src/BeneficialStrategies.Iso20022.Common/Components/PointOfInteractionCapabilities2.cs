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
[IsoId("_Lo4wkS9LEeOlZIh7PImd0A")]
[DisplayName("Point Of Interaction Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionCapabilities2
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
    [IsoId("_L5jp0S9LEeOlZIh7PImd0A")]
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
    [IsoId("_L5jp0y9LEeOlZIh7PImd0A")]
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
    /// On-line and off-line capabilities of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_L5jp1S9LEeOlZIh7PImd0A")]
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
    [IsoId("_L5jp1y9LEeOlZIh7PImd0A")]
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
    [IsoId("_L5jp2S9LEeOlZIh7PImd0A")]
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
    /// </summary>
    [IsoId("_Ek1CgC9MEeOlZIh7PImd0A")]
    [DisplayName("Available Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblLang")]
    #endif
    [IsoXmlTag("AvlblLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO2ALanguageCode? AvailableLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AvailableLanguage { get; init; } 
    #else
    public string? AvailableLanguage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
