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
/// Subbalances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
[IsoId("_uLgAh_fVEeiNZp_PtLohLw")]
[DisplayName("Additional Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalBalanceInformation19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalBalanceInformation19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalBalanceInformation19( SubBalanceType14Choice_ reqSubBalanceType,Balance13 reqQuantity )
    {
        SubBalanceType = reqSubBalanceType;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_uLgAjffVEeiNZp_PtLohLw")]
    [DisplayName("Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalTp")]
    #endif
    [IsoXmlTag("SubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubBalanceType14Choice_ SubBalanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubBalanceType14Choice_ SubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceType14Choice_ SubBalanceType { get; init; } 
    #else
    public SubBalanceType14Choice_ SubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_uLgAlffVEeiNZp_PtLohLw")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Balance13 Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Balance13 Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance13 Quantity { get; init; } 
    #else
    public Balance13 Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional sub-balance information.
    /// </summary>
    [IsoId("_uLgAnffVEeiNZp_PtLohLw")]
    [DisplayName("Sub Balance Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalAddtlDtls")]
    #endif
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubBalanceAdditionalDetails { get; init; } 
    #else
    public System.String? SubBalanceAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_uLgApffVEeiNZp_PtLohLw")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown56? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown56? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown56? QuantityBreakdown { get; set; } 
    #endif
    
    
    #nullable disable
    
}
