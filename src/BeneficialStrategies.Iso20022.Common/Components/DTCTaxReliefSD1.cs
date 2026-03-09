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
/// Provides information about tax relief categories.
/// </summary>
[IsoId("_1WDUpTL3EeKU9IrkkToqcw_1580095547")]
[DisplayName("DTC Tax Relief SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DTCTaxReliefSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DTCTaxReliefSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DTCTaxReliefSD1( System.String reqCategoryIdentification,System.String reqCategoryDescription )
    {
        CategoryIdentification = reqCategoryIdentification;
        CategoryDescription = reqCategoryDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// DTC System assigned identification for tax relief category.
    /// </summary>
    [IsoId("_1WDUpjL3EeKU9IrkkToqcw_-693454410")]
    [DisplayName("Category Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyId")]
    #endif
    [IsoXmlTag("CtgyId")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText CategoryIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CategoryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CategoryIdentification { get; init; } 
    #else
    public System.String CategoryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes tax relief category.
    /// </summary>
    [IsoId("_1WNFoDL3EeKU9IrkkToqcw_-661539457")]
    [DisplayName("Category Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtgyDesc")]
    #endif
    [IsoXmlTag("CtgyDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CategoryDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CategoryDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CategoryDescription { get; init; } 
    #else
    public System.String CategoryDescription { get; set; } 
    #endif
    
    
    #nullable disable
    
}
