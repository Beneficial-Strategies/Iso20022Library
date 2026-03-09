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
/// Capabilities of the display components performing the transaction.
/// </summary>
[IsoId("_mYI9YUeYEee9r7QjOdsbFw")]
[DisplayName("Display Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisplayCapabilities6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DisplayCapabilities6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DisplayCapabilities6( UserInterface1Code reqDestination )
    {
        Destination = reqDestination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the message to present.
    /// </summary>
    [IsoId("_mjKhoUeYEee9r7QjOdsbFw")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface1Code Destination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UserInterface1Code Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface1Code Destination { get; init; } 
    #else
    public UserInterface1Code Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Available message format.
    /// </summary>
    [IsoId("_mjKho0eYEee9r7QjOdsbFw")]
    [DisplayName("Available Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlblFrmt")]
    #endif
    [IsoXmlTag("AvlblFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat1Code? AvailableFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat1Code? AvailableFormat { get; init; } 
    #else
    public OutputFormat1Code? AvailableFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Number of lines of the display.
    /// </summary>
    [IsoId("_mjKhpUeYEee9r7QjOdsbFw")]
    [DisplayName("Number Of Lines")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfLines")]
    #endif
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfLines { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfLines { get; init; } 
    #else
    public System.UInt64? NumberOfLines { get; set; } 
    #endif
    
    /// <summary>
    /// Number of columns of the display or printer.
    /// </summary>
    [IsoId("_mjKhp0eYEee9r7QjOdsbFw")]
    [DisplayName("Line Width")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineWidth")]
    #endif
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? LineWidth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LineWidth { get; init; } 
    #else
    public System.UInt64? LineWidth { get; set; } 
    #endif
    
    /// <summary>
    /// Available language for the message. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_mjKhqUeYEee9r7QjOdsbFw")]
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
