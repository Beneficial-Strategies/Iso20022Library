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
[IsoId("_UHySzNp-Ed-ak6NoX_4Aeg_1510604861")]
[DisplayName("Amount And Quantity Ratio")]
public partial record AmountAndQuantityRatio2
{
    #nullable enable
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_UHySzdp-Ed-ak6NoX_4Aeg_1510604904")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    [IsoId("_UHySztp-Ed-ak6NoX_4Aeg_1510604921")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Quantity { get; init; } 
    
    
    #nullable disable
    
}
