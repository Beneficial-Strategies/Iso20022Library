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
/// Provides the collateral proposal response for the variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_xPxG_StIEeyOa655cLd-DQ")]
[DisplayName("Collateral Proposal Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralProposalResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralProposalResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralProposalResponse4( CollateralProposalResponseType4 reqVariationMargin )
    {
        VariationMargin = reqVariationMargin;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the collateral proposal response for the variation margin.
    /// </summary>
    [IsoId("_xophAStIEeyOa655cLd-DQ")]
    [DisplayName("Variation Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgn")]
    #endif
    [IsoXmlTag("VartnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposalResponseType4 VariationMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralProposalResponseType4 VariationMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponseType4 VariationMargin { get; init; } 
    #else
    public CollateralProposalResponseType4 VariationMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount.
    /// </summary>
    [IsoId("_xophAytIEeyOa655cLd-DQ")]
    [DisplayName("Segregated Independent Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralProposalResponseType4? SegregatedIndependentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponseType4? SegregatedIndependentAmount { get; init; } 
    #else
    public CollateralProposalResponseType4? SegregatedIndependentAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
