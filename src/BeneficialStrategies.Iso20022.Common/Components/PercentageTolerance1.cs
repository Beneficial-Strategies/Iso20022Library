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
/// Variance allowed on a quantity or on a price.
/// </summary>
[IsoId("_SsvRF9p-Ed-ak6NoX_4Aeg_964334524")]
[DisplayName("Percentage Tolerance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PercentageTolerance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PercentageTolerance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PercentageTolerance1( System.Decimal reqPlusPercent,System.Decimal reqMinusPercent )
    {
        PlusPercent = reqPlusPercent;
        MinusPercent = reqMinusPercent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Variance in percentage allowed over the agreed dimension. For example, plus 10 percent.
    /// </summary>
    [IsoId("_SsvRGNp-Ed-ak6NoX_4Aeg_981883394")]
    [DisplayName("Plus Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlusPct")]
    #endif
    [IsoXmlTag("PlusPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate PlusPercent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal PlusPercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal PlusPercent { get; init; } 
    #else
    public System.Decimal PlusPercent { get; set; } 
    #endif
    
    /// <summary>
    /// Variance in percentage allowed below the agreed dimension. For example, minus 10 percent.
    /// </summary>
    [IsoId("_SsvRGdp-Ed-ak6NoX_4Aeg_1021595225")]
    [DisplayName("Minus Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnsPct")]
    #endif
    [IsoXmlTag("MnsPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate MinusPercent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal MinusPercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal MinusPercent { get; init; } 
    #else
    public System.Decimal MinusPercent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
