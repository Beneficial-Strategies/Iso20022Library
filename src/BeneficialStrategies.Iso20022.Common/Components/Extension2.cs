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
/// Additional information that can not be captured in the structured fields and/or any other specific block.
/// </summary>
[IsoId("_QzJSNdp-Ed-ak6NoX_4Aeg_251191216")]
[DisplayName("Extension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Extension2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Extension2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Extension2( ExtensionEnvelope1 reqExtensionEnvelope )
    {
        ExtensionEnvelope = reqExtensionEnvelope;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name qualifying the information provided in the Text field, and place where this information should be inserted.
    /// </summary>
    [IsoId("_QzJSNtp-Ed-ak6NoX_4Aeg_-1852964930")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Technical element wrapping the extension.
    /// </summary>
    [IsoId("_QzJSN9p-Ed-ak6NoX_4Aeg_-277341268")]
    [DisplayName("Extension Envelope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtnsnEnvlp")]
    #endif
    [IsoXmlTag("XtnsnEnvlp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExtensionEnvelope1 ExtensionEnvelope { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExtensionEnvelope1 ExtensionEnvelope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtensionEnvelope1 ExtensionEnvelope { get; init; } 
    #else
    public ExtensionEnvelope1 ExtensionEnvelope { get; set; } 
    #endif
    
    
    #nullable disable
    
}
