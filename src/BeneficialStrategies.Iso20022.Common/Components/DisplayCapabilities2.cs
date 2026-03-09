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
/// The capabilities of the display components performing the transaction.
/// </summary>
[IsoId("_OdbxQS9KEeOlZIh7PImd0A")]
[DisplayName("Display Capabilities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisplayCapabilities2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DisplayCapabilities2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DisplayCapabilities2( UserInterface2Code reqDisplayType,System.UInt64 reqNumberOfLines,System.UInt64 reqLineWidth )
    {
        DisplayType = reqDisplayType;
        NumberOfLines = reqNumberOfLines;
        LineWidth = reqLineWidth;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of display (for example merchant or cardholder).
    /// </summary>
    [IsoId("_Ot8ScS9KEeOlZIh7PImd0A")]
    [DisplayName("Display Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispTp")]
    #endif
    [IsoXmlTag("DispTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface2Code DisplayType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UserInterface2Code DisplayType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface2Code DisplayType { get; init; } 
    #else
    public UserInterface2Code DisplayType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of lines of the display component.
    /// </summary>
    [IsoId("_Ot8Scy9KEeOlZIh7PImd0A")]
    [DisplayName("Number Of Lines")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfLines")]
    #endif
    [IsoXmlTag("NbOfLines")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfLines { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfLines { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfLines { get; init; } 
    #else
    public System.UInt64 NumberOfLines { get; set; } 
    #endif
    
    /// <summary>
    /// Number of columns of the display component.
    /// </summary>
    [IsoId("_Ot8SdS9KEeOlZIh7PImd0A")]
    [DisplayName("Line Width")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineWidth")]
    #endif
    [IsoXmlTag("LineWidth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber LineWidth { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 LineWidth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 LineWidth { get; init; } 
    #else
    public System.UInt64 LineWidth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
