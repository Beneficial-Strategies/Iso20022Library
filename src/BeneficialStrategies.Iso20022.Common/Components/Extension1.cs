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
[IsoId("_Q6vvCNp-Ed-ak6NoX_4Aeg_1503007069")]
[DisplayName("Extension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Extension1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Extension1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Extension1( System.String reqPlaceAndName,System.String reqText )
    {
        PlaceAndName = reqPlaceAndName;
        Text = reqText;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name qualifying the information provided in the Text field, and place where this information should be inserted.
    /// </summary>
    [IsoId("_Q65gANp-Ed-ak6NoX_4Aeg_-1802982859")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Text of the extension.
    /// </summary>
    [IsoId("_Q65gAdp-Ed-ak6NoX_4Aeg_-1661684876")]
    [DisplayName("Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Txt")]
    #endif
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Text { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Text { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Text { get; init; } 
    #else
    public System.String Text { get; set; } 
    #endif
    
    
    #nullable disable
    
}
