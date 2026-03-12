// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty amount to apply to an Loyalty account.
/// </summary>
[IsoId("_GG5KQNuDEeiXqq0XHEoNUA")]
[DisplayName("Loyalty Amount")]
public partial record LoyaltyAmount1
{
    #nullable enable
    
    /// <summary>
    /// Unit type for the amount.
    /// </summary>
    [IsoId("_RLs7gNuDEeiXqq0XHEoNUA")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public AmountUnit1Code? Unit { get; init; } 
    
    /// <summary>
    /// Currency of the amount is Unit is Monetary.
    /// </summary>
    [IsoId("_WBnhkNuDEeiXqq0XHEoNUA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_ZvzqkNuDEeiXqq0XHEoNUA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
