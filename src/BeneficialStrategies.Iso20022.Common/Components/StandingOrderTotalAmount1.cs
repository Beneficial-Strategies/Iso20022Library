// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the overall amount of &quot;not yet executed&quot; predefined liquidity transfer orders or &quot;defined&quot; by a system participant in its sphere of responsibility within the system.
/// </summary>
[IsoId("_73Rq5KMgEeCJ6YNENx4h-w_-307258227")]
[DisplayName("Standing Order Total Amount")]
public partial record StandingOrderTotalAmount1
{
    #nullable enable
    
    /// <summary>
    /// Total defined amount of predefined liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq5aMgEeCJ6YNENx4h-w_323473670")]
    [DisplayName("Set Predefined Order")]
    [IsoXmlTag("SetPrdfndOrdr")]
    public required TotalAmountAndCurrency1 SetPredefinedOrder { get; init; } 
    
    /// <summary>
    /// Total amount of not yet executed predefined liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq5qMgEeCJ6YNENx4h-w_922243288")]
    [DisplayName("Pending Predefined Order")]
    [IsoXmlTag("PdgPrdfndOrdr")]
    public required TotalAmountAndCurrency1 PendingPredefinedOrder { get; init; } 
    
    /// <summary>
    /// Total defined amount of standing liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq56MgEeCJ6YNENx4h-w_-394534474")]
    [DisplayName("Set Standing Order")]
    [IsoXmlTag("SetStgOrdr")]
    public required TotalAmountAndCurrency1 SetStandingOrder { get; init; } 
    
    /// <summary>
    /// Total amount of not yet executed standing liquidity transfer orders.
    /// </summary>
    [IsoId("_73Rq6KMgEeCJ6YNENx4h-w_-369288428")]
    [DisplayName("Pending Standing Order")]
    [IsoXmlTag("PdgStgOrdr")]
    public required TotalAmountAndCurrency1 PendingStandingOrder { get; init; } 
    
    
    #nullable disable
    
}
