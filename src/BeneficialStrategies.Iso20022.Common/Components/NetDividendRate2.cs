// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash dividend amount per equity after deductions or allowances have been made.
/// </summary>
[IsoId("_UPrqgNp-Ed-ak6NoX_4Aeg_2118430595")]
[DisplayName("Net Dividend Rate")]
public partial record NetDividendRate2
{
    #nullable enable
    
    /// <summary>
    /// Type of underlying securities to which the rate is related, eg, underlying security for which an interest is paid.
    /// </summary>
    [IsoId("_UPrqgdp-Ed-ak6NoX_4Aeg_-2120201442")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required NetDividendRateType1FormatChoice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UPrqgtp-Ed-ak6NoX_4Aeg_-2120201411")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
