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
/// Provides the dispute notification details for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_UllpFNp-Ed-ak6NoX_4Aeg_203292187")]
[DisplayName("Dispute Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisputeNotification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DisputeNotification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DisputeNotification1( VariationMarginDispute1 reqVariationMarginDispute )
    {
        VariationMarginDispute = reqVariationMarginDispute;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the dispute notification details for the variation margin.
    /// </summary>
    [IsoId("_UllpFdp-Ed-ak6NoX_4Aeg_-641718307")]
    [DisplayName("Variation Margin Dispute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnDspt")]
    #endif
    [IsoXmlTag("VartnMrgnDspt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VariationMarginDispute1 VariationMarginDispute { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VariationMarginDispute1 VariationMarginDispute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VariationMarginDispute1 VariationMarginDispute { get; init; } 
    #else
    public VariationMarginDispute1 VariationMarginDispute { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the dispute notification details for the segregated independent amount.
    /// </summary>
    [IsoId("_UllpFtp-Ed-ak6NoX_4Aeg_1091176533")]
    [DisplayName("Segregated Independent Amount Dispute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgrtdIndpdntAmtDspt")]
    #endif
    [IsoXmlTag("SgrtdIndpdntAmtDspt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SegregatedIndependentAmountDispute1? SegregatedIndependentAmountDispute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SegregatedIndependentAmountDispute1? SegregatedIndependentAmountDispute { get; init; } 
    #else
    public SegregatedIndependentAmountDispute1? SegregatedIndependentAmountDispute { get; set; } 
    #endif
    
    
    #nullable disable
    
}
