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
/// Provides details about the proposal for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_rpS7BYpIEeaNTaanBSMWmg")]
[DisplayName("Collateral Proposal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralProposal6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralProposal6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralProposal6( CollateralMovement10 reqVariationMargin )
    {
        VariationMargin = reqVariationMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the proposal for the variation margin.
    /// </summary>
    [IsoId("_r4UOcYpIEeaNTaanBSMWmg")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralMovement10 VariationMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralMovement10 VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralMovement10 VariationMargin { get; init; } 
    #else
    public CollateralMovement10 VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_r4UOc4pIEeaNTaanBSMWmg")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralMovement10? SegregatedIndependentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralMovement10? SegregatedIndependentAmount { get; init; } 
    #else
    public CollateralMovement10? SegregatedIndependentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
