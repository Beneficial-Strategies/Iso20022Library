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
/// Provides details about the collateral against variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_UoRJqtp-Ed-ak6NoX_4Aeg_1673012479")]
[DisplayName("Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Collateral1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Collateral1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Collateral1( MarginCollateral1 reqVariationMargin )
    {
        VariationMargin = reqVariationMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the variation margin.
    /// </summary>
    [IsoId("_Uoa6oNp-Ed-ak6NoX_4Aeg_117230825")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginCollateral1 VariationMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginCollateral1 VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCollateral1 VariationMargin { get; init; } 
    #else
    public MarginCollateral1 VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the segregated independent amount.
    /// </summary>
    [IsoId("_Uoa6odp-Ed-ak6NoX_4Aeg_-2144467240")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCollateral1? SegregatedIndependentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCollateral1? SegregatedIndependentAmount { get; init; } 
    #else
    public MarginCollateral1? SegregatedIndependentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
