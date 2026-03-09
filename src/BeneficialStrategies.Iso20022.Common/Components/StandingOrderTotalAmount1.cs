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
/// Provides details on the overall amount of &quot;not yet executed&quot; predefined liquidity transfer orders or &quot;defined&quot; by a system participant in its sphere of responsibility within the system.
/// </summary>
[IsoId("_73Rq5KMgEeCJ6YNENx4h-w_-307258227")]
[DisplayName("Standing Order Total Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StandingOrderTotalAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StandingOrderTotalAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StandingOrderTotalAmount1( TotalAmountAndCurrency1 reqSetPredefinedOrder,TotalAmountAndCurrency1 reqPendingPredefinedOrder,TotalAmountAndCurrency1 reqSetStandingOrder,TotalAmountAndCurrency1 reqPendingStandingOrder )
    {
        SetPredefinedOrder = reqSetPredefinedOrder;
        PendingPredefinedOrder = reqPendingPredefinedOrder;
        SetStandingOrder = reqSetStandingOrder;
        PendingStandingOrder = reqPendingStandingOrder;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total defined amount of predefined liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq5aMgEeCJ6YNENx4h-w_323473670")]
    [DisplayName("Set Predefined Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SetPrdfndOrdr")]
    #endif
    [IsoXmlTag("SetPrdfndOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TotalAmountAndCurrency1 SetPredefinedOrder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TotalAmountAndCurrency1 SetPredefinedOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalAmountAndCurrency1 SetPredefinedOrder { get; init; } 
    #else
    public TotalAmountAndCurrency1 SetPredefinedOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of not yet executed predefined liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq5qMgEeCJ6YNENx4h-w_922243288")]
    [DisplayName("Pending Predefined Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgPrdfndOrdr")]
    #endif
    [IsoXmlTag("PdgPrdfndOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TotalAmountAndCurrency1 PendingPredefinedOrder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TotalAmountAndCurrency1 PendingPredefinedOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalAmountAndCurrency1 PendingPredefinedOrder { get; init; } 
    #else
    public TotalAmountAndCurrency1 PendingPredefinedOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Total defined amount of standing liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq56MgEeCJ6YNENx4h-w_-394534474")]
    [DisplayName("Set Standing Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SetStgOrdr")]
    #endif
    [IsoXmlTag("SetStgOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TotalAmountAndCurrency1 SetStandingOrder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TotalAmountAndCurrency1 SetStandingOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalAmountAndCurrency1 SetStandingOrder { get; init; } 
    #else
    public TotalAmountAndCurrency1 SetStandingOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of not yet executed standing liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq6KMgEeCJ6YNENx4h-w_-369288428")]
    [DisplayName("Pending Standing Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgStgOrdr")]
    #endif
    [IsoXmlTag("PdgStgOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TotalAmountAndCurrency1 PendingStandingOrder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TotalAmountAndCurrency1 PendingStandingOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalAmountAndCurrency1 PendingStandingOrder { get; init; } 
    #else
    public TotalAmountAndCurrency1 PendingStandingOrder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
