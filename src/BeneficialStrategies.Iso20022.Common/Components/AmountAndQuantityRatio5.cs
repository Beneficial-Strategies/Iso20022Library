// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as amount per quantity.
/// </summary>
[IsoId("_ckCYkpKQEeWHWpTQn1FFVg")]
[DisplayName("Amount And Quantity Ratio")]
public partial record AmountAndQuantityRatio5
{
    #nullable enable
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_ckCYlJKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    [IsoId("_ckCYnJKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
    
    
    #nullable disable
    
}
