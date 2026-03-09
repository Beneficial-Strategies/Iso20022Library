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
/// Technical component that contains the validated extension information. This technical envelope allows to segregate the extension information from any other information.
/// </summary>
[IsoId("_QzJSM9p-Ed-ak6NoX_4Aeg_-1719963560")]
[DisplayName("Extension Envelope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtensionEnvelope1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExtensionEnvelope1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtensionEnvelope1( ExtensionContents1 reqExtensionContents )
    {
        ExtensionContents = reqExtensionContents;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Technical element that specifies the extension.
    /// </summary>
    [IsoId("_QzJSNNp-Ed-ak6NoX_4Aeg_-2120876746")]
    [DisplayName("Extension Contents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtnsnCnts")]
    #endif
    [IsoXmlTag("XtnsnCnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExtensionContents1 ExtensionContents { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExtensionContents1 ExtensionContents { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtensionContents1 ExtensionContents { get; init; } 
    #else
    public ExtensionContents1 ExtensionContents { get; set; } 
    #endif
    
    
    #nullable disable
    
}
