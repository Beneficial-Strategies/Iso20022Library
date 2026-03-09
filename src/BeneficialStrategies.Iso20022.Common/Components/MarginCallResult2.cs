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
/// Provides the summation of the call amounts for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_UlvaFtp-Ed-ak6NoX_4Aeg_-1833234715")]
[DisplayName("Margin Call Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCallResult2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginCallResult2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCallResult2( Result1 reqVariationMarginResult )
    {
        VariationMarginResult = reqVariationMarginResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin amount only.
    /// </summary>
    [IsoId("_UlvaF9p-Ed-ak6NoX_4Aeg_-1196189794")]
    [DisplayName("Variation Margin Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRslt")]
    #endif
    [IsoXmlTag("VartnMrgnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Result1 VariationMarginResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Result1 VariationMarginResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Result1 VariationMarginResult { get; init; } 
    #else
    public Result1 VariationMarginResult { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the summation of the call amounts for the segregated independent amount.
    /// </summary>
    [IsoId("_UlvaGNp-Ed-ak6NoX_4Aeg_872246105")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Result1? SegregatedIndependentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Result1? SegregatedIndependentAmount { get; init; } 
    #else
    public Result1? SegregatedIndependentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
