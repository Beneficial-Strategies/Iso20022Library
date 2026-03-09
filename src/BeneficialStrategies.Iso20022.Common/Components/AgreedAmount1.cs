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
/// Provides details about the agreed amount for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_UmCVAtp-Ed-ak6NoX_4Aeg_-442441347")]
[DisplayName("Agreed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgreedAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgreedAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgreedAmount1( Amount1 reqVariationMarginAmount )
    {
        VariationMarginAmount = reqVariationMarginAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the agreed amount for the variation margin.
    /// </summary>
    [IsoId("_UmCVA9p-Ed-ak6NoX_4Aeg_-885757742")]
    [DisplayName("Variation Margin Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnAmt")]
    #endif
    [IsoXmlTag("VartnMrgnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount1 VariationMarginAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount1 VariationMarginAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount1 VariationMarginAmount { get; init; } 
    #else
    public Amount1 VariationMarginAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the agreed amount for the segregated independent amount.
    /// </summary>
    [IsoId("_UmCVBNp-Ed-ak6NoX_4Aeg_-223051895")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount1? SegregatedIndependentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount1? SegregatedIndependentAmount { get; init; } 
    #else
    public Amount1? SegregatedIndependentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
