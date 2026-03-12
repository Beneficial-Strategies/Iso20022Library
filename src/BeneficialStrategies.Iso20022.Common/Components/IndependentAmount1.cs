// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the independent amount and how it was applied in the calculation.
/// </summary>
[IsoId("_UlI9KNp-Ed-ak6NoX_4Aeg_1173631516")]
[DisplayName("Independent Amount")]
public partial record IndependentAmount1
{
    #nullable enable
    
    /// <summary>
    /// Provides the independant amount.
    /// </summary>
    [IsoId("_UlSuINp-Ed-ak6NoX_4Aeg_-2028501598")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Determines how the independent amount was applied in the calculation. 
    /// It is either:
    /// - before threshold, effectively acting as an add on to exposure, 
    /// - after threshold where the amount is an add on to the credit support amount and forms part of the variation margin requirement,
    /// - segregated where it is treated independently of variation margin for segregation purposes.
    /// </summary>
    [IsoId("_UlSuIdp-Ed-ak6NoX_4Aeg_1427405925")]
    [DisplayName("Convention")]
    [IsoXmlTag("Cnvntn")]
    public required IndependentAmountConventionType1Code Convention { get; init; } 
    
    
    #nullable disable
    
}
