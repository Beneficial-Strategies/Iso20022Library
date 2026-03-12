// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies ranged amounts, for a specific currency and type of amount.
/// </summary>
[IsoId("_dqmJYKHfEeagRbKvRt3LnA")]
[DisplayName("Amount Type")]
public partial record AmountType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of amount.
    /// </summary>
    [IsoId("_vw3LMKHfEeagRbKvRt3LnA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount9Code Type { get; init; } 
    
    /// <summary>
    /// Specifies the currency code of the ranged amount.
    /// </summary>
    [IsoId("_CPG9QKHiEeagRbKvRt3LnA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Specifies the lowest amount value.
    /// </summary>
    [IsoId("_IYpuYKHiEeagRbKvRt3LnA")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public required ImpliedCurrencyAndAmount FromAmount { get; init; } 
    
    /// <summary>
    /// Specifies the highest amount value.
    /// </summary>
    [IsoId("_Xyci4KHiEeagRbKvRt3LnA")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public required ImpliedCurrencyAndAmount ToAmount { get; init; } 
    
    
    #nullable disable
    
}
