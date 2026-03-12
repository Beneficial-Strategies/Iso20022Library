// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash dividend amount per equity before deductions or allowances have been made.
/// </summary>
[IsoId("_UPh5g9p-Ed-ak6NoX_4Aeg_1227561580")]
[DisplayName("Gross Dividend Rate")]
public partial record GrossDividendRate2
{
    #nullable enable
    
    /// <summary>
    /// Type of underlying securities to which the rate is related, eg, underlying security for which an interest is paid.
    /// </summary>
    [IsoId("_UPh5hNp-Ed-ak6NoX_4Aeg_1284818087")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required GrossDividendRateType1FormatChoice_ RateType { get; init; } 
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UPh5hdp-Ed-ak6NoX_4Aeg_1284818088")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
