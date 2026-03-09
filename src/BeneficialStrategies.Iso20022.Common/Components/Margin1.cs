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
/// Defines the elements used to calculate the collateral margin call for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_UnOn1dp-Ed-ak6NoX_4Aeg_-1003583230")]
[DisplayName("Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Margin1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Margin1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Margin1( VariationMargin1 reqVariationMargin )
    {
        VariationMargin = reqVariationMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Elements used to calculate the collateral margin call for the variation margin.
    /// </summary>
    [IsoId("_UnOn1tp-Ed-ak6NoX_4Aeg_-1233189826")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VariationMargin1 VariationMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VariationMargin1 VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VariationMargin1 VariationMargin { get; init; } 
    #else
    public VariationMargin1 VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Elements used to calculate the collateral margin call for the segregated independent amount.
    /// </summary>
    [IsoId("_UnOn19p-Ed-ak6NoX_4Aeg_1199972462")]
    [DisplayName("Segregated Independent Amount Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmtMrgn")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmtMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SegregatedIndependentAmountMargin1? SegregatedIndependentAmountMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SegregatedIndependentAmountMargin1? SegregatedIndependentAmountMargin { get; init; } 
    #else
    public SegregatedIndependentAmountMargin1? SegregatedIndependentAmountMargin { get; set; } 
    #endif
    
    
    #nullable disable
    
}
