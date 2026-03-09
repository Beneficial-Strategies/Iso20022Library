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
/// Provides details about the margin requirements for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_Ul4kA9p-Ed-ak6NoX_4Aeg_1931035123")]
[DisplayName("Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Requirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Requirement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Requirement1( MarginRequirement1 reqVariationMarginRequirement )
    {
        VariationMarginRequirement = reqVariationMarginRequirement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the margin requirements for the variation margin.
    /// </summary>
    [IsoId("_Ul4kBNp-Ed-ak6NoX_4Aeg_-362986859")]
    [DisplayName("Variation Margin Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRqrmnt")]
    #endif
    [IsoXmlTag("VartnMrgnRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarginRequirement1 VariationMarginRequirement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarginRequirement1 VariationMarginRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginRequirement1 VariationMarginRequirement { get; init; } 
    #else
    public MarginRequirement1 VariationMarginRequirement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin requirements for the segregated independent amount.
    /// </summary>
    [IsoId("_Ul4kBdp-Ed-ak6NoX_4Aeg_-1666534406")]
    [DisplayName("Segregated Independent Amount Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmtRqrmnt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmtRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginRequirement1? SegregatedIndependentAmountRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginRequirement1? SegregatedIndependentAmountRequirement { get; init; } 
    #else
    public MarginRequirement1? SegregatedIndependentAmountRequirement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
