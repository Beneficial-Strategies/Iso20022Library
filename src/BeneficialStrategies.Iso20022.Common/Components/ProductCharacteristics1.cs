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
/// Identifies the characteristic of a product.
/// </summary>
[IsoId("_T5L2FNp-Ed-ak6NoX_4Aeg_1219351972")]
[DisplayName("Product Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProductCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProductCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProductCharacteristics1( ProductCharacteristics1Code reqType,System.String reqCharacteristics )
    {
        Type = reqType;
        Characteristics = reqCharacteristics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of product characteristic by means of a code.
    /// </summary>
    [IsoId("_T5L2Fdp-Ed-ak6NoX_4Aeg_1279381373")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProductCharacteristics1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProductCharacteristics1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCharacteristics1Code Type { get; init; } 
    #else
    public ProductCharacteristics1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the characteristic of a product.
    /// </summary>
    [IsoId("_T5L2Ftp-Ed-ak6NoX_4Aeg_1319095231")]
    [DisplayName("Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrtcs")]
    #endif
    [IsoXmlTag("Chrtcs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Characteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Characteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Characteristics { get; init; } 
    #else
    public System.String Characteristics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
