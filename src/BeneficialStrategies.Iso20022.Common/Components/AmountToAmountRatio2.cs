// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of amounts.
/// </summary>
[IsoId("_UHohydp-Ed-ak6NoX_4Aeg_-722645114")]
[DisplayName("Amount To Amount Ratio")]
public partial record AmountToAmountRatio2
{
    #nullable enable
    
    /// <summary>
    /// Numerator of the quotient of amounts.
    /// </summary>
    [IsoId("_UHohytp-Ed-ak6NoX_4Aeg_1560297783")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt1")]
    public required ActiveCurrencyAnd13DecimalAmount Amount1 { get; init; } 
    
    /// <summary>
    /// Denominator of the quotient of amounts.
    /// </summary>
    [IsoId("_UHohy9p-Ed-ak6NoX_4Aeg_1248536401")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt2")]
    public required ActiveCurrencyAnd13DecimalAmount Amount2 { get; init; } 
    
    
    #nullable disable
    
}
